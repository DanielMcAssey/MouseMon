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
		private bool IsPlaying = false;
		private List<MouseData> PlotData;
		private List<MouseData> Last5Seconds;
		private List<MouseData> EverythingElse;

		private int MaxPoints = 0;
		private int CurrentPoint = 0;
		private const int GraphFPS = 30;

		private void UpdateCount(int currentPoint)
		{
			this.CurrentPoint = currentPoint;
			this.tbPlot.Value = currentPoint;
			this.lblPointsCount.Text = this.CurrentPoint.ToString() + "/" + this.MaxPoints.ToString();
		}

		private void tmrAnimateGraph_Tick(object sender, EventArgs e)
		{
			this.UpdateChart();
		}

		private void UpdateChart()
		{
			this.CurrentPoint = this.tbPlot.Value + 1;
			if (this.CurrentPoint <= this.tbPlot.Maximum)
			{
				this.UpdateCount(this.CurrentPoint);
				this.ShowPointTo(0, this.CurrentPoint);
				this.tbPlot.Value = this.CurrentPoint;
			}
			else
			{
				this.StopChartAnimation();
				this.UpdateCount(this.tbPlot.Maximum);
				this.tbPlot.Value = this.tbPlot.Maximum;
			}
		}

		private void ResetGraph()
		{
			Rectangle primaryResolution = Screen.PrimaryScreen.Bounds;
			chrtMousePos.ChartAreas[0].Axes[0].Maximum = primaryResolution.Width;
			chrtMousePos.ChartAreas[0].Axes[1].Maximum = primaryResolution.Height;

			DateTime lastTimeRecorded = PlotData[PlotData.Count - 1].MouseRecordedTime;
			this.Last5Seconds = PlotData.Where(s => s.MouseRecordedTime >= lastTimeRecorded.AddSeconds(-5)).ToList<MouseData>();
			this.EverythingElse = PlotData.Where(s => s.MouseRecordedTime <= lastTimeRecorded.AddSeconds(-5)).ToList<MouseData>();

			chrtMousePos.Series[0].Points.Clear();
			for (int i = 0; i < EverythingElse.Count; i++)
				chrtMousePos.Series[0].Points.AddXY(EverythingElse[i].MouseX, EverythingElse[i].MouseY);

			chrtMousePos.Series[1].Points.Clear();
			for (int i = 0; i < Last5Seconds.Count; i++)
				chrtMousePos.Series[1].Points.AddXY(Last5Seconds[i].MouseX, Last5Seconds[i].MouseY);

			for (int i = 0; i < PlotData.Count; i++)
			{
				//TODO: Add Mouse Button States
			}

			this.MaxPoints = (EverythingElse.Count + Last5Seconds.Count);
			tbPlot.Maximum = this.MaxPoints;
			this.UpdateCount(0);
			this.numSpeedMultiplier.Value = 1.0M;
		}

		private void ShowPointTo(int FromPoint, int MaxPoint)
		{
			//Temporary workaround, need to find more efficient method of removing points smoothly
			//TODO: Fix this
			chrtMousePos.Series[0].Points.Clear();
			chrtMousePos.Series[1].Points.Clear();

			if (MaxPoint > this.EverythingElse.Count)
			{
				//Show last 5 seconds points
				for (int i = FromPoint; i < MaxPoint; i++)
				{
					if(i > (this.EverythingElse.Count - 1))
					{
						//Add to last 5 seconds series
						chrtMousePos.Series[1].Points.AddXY(Last5Seconds[i - this.EverythingElse.Count].MouseX, Last5Seconds[i - this.EverythingElse.Count].MouseY);
					}
					else
					{
						//Add to everything else series
						chrtMousePos.Series[0].Points.AddXY(EverythingElse[i].MouseX, EverythingElse[i].MouseY);
					}
				}
			}
			else
			{
				//Show everything else points
				for (int i = FromPoint; i < MaxPoint; i++)
				{
					chrtMousePos.Series[0].Points.AddXY(EverythingElse[i].MouseX, EverythingElse[i].MouseY);
				}
			}
		}

		private void tbPlot_Scroll(object sender, EventArgs e)
		{
			this.UpdateChart();
		}

		public frmGraph(List<MouseData> _plotData)
		{
			InitializeComponent();
			PlotData = _plotData;
		}

		private void frmGraph_Load(object sender, EventArgs e)
		{
			btnShowBoth.Enabled = false;

			this.ResetGraph();
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

		private void btnPlay_Click(object sender, EventArgs e)
		{
			if (IsPlaying)
				StopChartAnimation();
			else
				PlayChartAnimation();
		}

		private void btnResetPoints_Click(object sender, EventArgs e)
		{
			this.ResetGraph();
		}

		private void PlayChartAnimation()
		{
			IsPlaying = true;
			btnPlay.Text = "Stop";
			this.numSpeedMultiplier.Enabled = false;

			if (this.CurrentPoint >= this.tbPlot.Maximum)
				this.UpdateCount(0);

			tmrAnimateGraph.Interval = (int)(((1 / (double)(GraphFPS * this.numSpeedMultiplier.Value)) * 1000));
			tmrAnimateGraph.Start();
		}

		private void StopChartAnimation()
		{
			IsPlaying = false;
			btnPlay.Text = "Play";
			this.numSpeedMultiplier.Enabled = true;

			tmrAnimateGraph.Stop();
		}
	}
}
