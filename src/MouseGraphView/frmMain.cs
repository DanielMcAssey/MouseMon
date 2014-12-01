using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using MouseMon;

namespace MouseGraphView
{

	public partial class frmMain : Form
	{
		BackgroundWorker UpdateListWorker = new BackgroundWorker();
		MouseMonitor MouseMonitor = new MouseMonitor();

		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			btnGenerateGraph.Enabled = false;
			txtUpdatesPerSecond.Text = MouseMonitor.UpdatesPerSecond.ToString();
			txtDataLife.Text = MouseMonitor.MaxSecondsToRecord.ToString();
			UpdateListWorker.WorkerReportsProgress = true;
			UpdateListWorker.WorkerSupportsCancellation = true;
			UpdateListWorker.ProgressChanged += UpdateListWorkerProgressChanged;
			UpdateListWorker.DoWork += UpdateListWorkerDoWork;
		}

		private void AddData(MouseData newData)
		{
			if(newData.MouseRecordedTime != null)
				dgvMouseData.Rows.Add(newData.MouseRecordedTime.ToString(), newData.MouseX.ToString(), newData.MouseY.ToString());

			dgvMouseData.FirstDisplayedScrollingRowIndex = dgvMouseData.RowCount - 1;
		}

		private void UpdateListWorkerDoWork(object sender, DoWorkEventArgs e)
		{
			BackgroundWorker currentWorker = (BackgroundWorker)sender;
			while (!currentWorker.CancellationPending)
			{
				if (this.MouseMonitor.FMouseRecorded)
				{
					if (this.MouseMonitor.FMouseNewData) //Only new data
					{
						currentWorker.ReportProgress(0, this.MouseMonitor.GetLastData());
					}
				}
				else
					MessageBox.Show("ERROR: No Data, probably no initial data, if this only appears once, ignore it.");
			}
		}

		private void UpdateListWorkerProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			MouseData newData = (MouseData)e.UserState;
			AddData(newData);
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			//Prep
			dgvMouseData.Rows.Clear();
			btnGenerateGraph.Enabled = true;
			btnStop.Enabled = true;
			btnStart.Enabled = false;

			//Reset mouse monitor
			this.MouseMonitor.Clear();

			int updatesPerSecond;
			bool isNumeric = int.TryParse(txtUpdatesPerSecond.Text, out updatesPerSecond);
			if (isNumeric && updatesPerSecond > 0)
				MouseMonitor.UpdatesPerSecond = updatesPerSecond;
			else
				MessageBox.Show("ERROR: Updates per second must be in a numerical form and greater than '0'");

			int dataLife;
			isNumeric = int.TryParse(txtDataLife.Text, out dataLife);
			if (isNumeric && dataLife > 0)
				MouseMonitor.MaxSecondsToRecord = dataLife;
			else
				MessageBox.Show("ERROR: Max data life must be in a numerical form and greater than '0'");

			//Run
			MouseMonitor.StartTracking();
			UpdateListWorker.RunWorkerAsync();
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			btnStart.Enabled = true;
			btnStop.Enabled = false;
			MouseMonitor.StopTracking();
			UpdateListWorker.CancelAsync();
		}

		private void btnGenerateGraph_Click(object sender, EventArgs e)
		{
			frmGraph graphWindow = new frmGraph(this.MouseMonitor.GetFullDataset());
			graphWindow.FormClosed += frmGraphClose;
			graphWindow.Show();
			btnGenerateGraph.Enabled = false;

		}

		private void frmGraphClose(object sender, EventArgs e)
		{
			btnGenerateGraph.Enabled = true;
		}
	}
}
