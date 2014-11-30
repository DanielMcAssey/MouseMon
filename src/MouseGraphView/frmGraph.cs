using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MouseMon;

namespace MouseGraphView
{
	public partial class frmGraph : Form
	{
		private List<MouseData> PlotData;

		public frmGraph(List<MouseData> _plotData)
		{
			InitializeComponent();
			PlotData = _plotData;
		}

		private void frmGraph_Load(object sender, EventArgs e)
		{
			btnShowBoth.Enabled = false;
			
			DateTime lastTimeRecorded = PlotData[PlotData.Count-1].MouseRecordedTime;
			List<MouseData> Last5Seconds = PlotData.Where(s => s.MouseRecordedTime >= lastTimeRecorded.AddSeconds(-5)).ToList<MouseData>();
			List<MouseData> EverythingElse = PlotData.Where(s => s.MouseRecordedTime < lastTimeRecorded.AddSeconds(-5)).ToList<MouseData>();
			
			for (int i = 0; i < EverythingElse.Count; i++)
			{
				chrtMousePos.Series[0].Points.AddXY(EverythingElse[i].MouseX, EverythingElse[i].MouseY);
			}

			for (int i = 0; i < Last5Seconds.Count; i++)
			{
				chrtMousePos.Series[1].Points.AddXY(Last5Seconds[i].MouseX, Last5Seconds[i].MouseY);
			}
			
		}

		private void btnShowBoth_Click(object sender, EventArgs e)
		{
			btnShowBoth.Enabled = false;
			btnShowAllButRecent.Enabled = true;
			btnShowRecent.Enabled = true;
			chrtMousePos.Series[0].Enabled = true;
			chrtMousePos.Series[1].Enabled = true;
		}

		private void btnShowRecent_Click(object sender, EventArgs e)
		{
			btnShowBoth.Enabled = true;
			btnShowRecent.Enabled = false;
			btnShowAllButRecent.Enabled = true;
			chrtMousePos.Series[0].Enabled = false;
			chrtMousePos.Series[1].Enabled = true;
		}

		private void btnShowAllButRecent_Click(object sender, EventArgs e)
		{
			btnShowBoth.Enabled = true;
			btnShowRecent.Enabled = true;
			btnShowAllButRecent.Enabled = false;
			chrtMousePos.Series[0].Enabled = true;
			chrtMousePos.Series[1].Enabled = false;
		}
	}
}
