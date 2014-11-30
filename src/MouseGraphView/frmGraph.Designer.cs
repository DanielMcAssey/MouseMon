namespace MouseGraphView
{
	partial class frmGraph
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chrtMousePos = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.btnPlay = new System.Windows.Forms.Button();
			this.tbPlot = new System.Windows.Forms.TrackBar();
			this.btnShowBoth = new System.Windows.Forms.Button();
			this.btnShowRecent = new System.Windows.Forms.Button();
			this.btnShowAllButRecent = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.chrtMousePos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbPlot)).BeginInit();
			this.SuspendLayout();
			// 
			// chrtMousePos
			// 
			this.chrtMousePos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea1.AxisX.Minimum = 0D;
			chartArea1.AxisX.Title = "X Position";
			chartArea1.AxisY.Minimum = 0D;
			chartArea1.AxisY.Title = "Y Position";
			chartArea1.Name = "ChartArea1";
			this.chrtMousePos.ChartAreas.Add(chartArea1);
			legend1.Alignment = System.Drawing.StringAlignment.Center;
			legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend1.Name = "Main Legend";
			this.chrtMousePos.Legends.Add(legend1);
			this.chrtMousePos.Location = new System.Drawing.Point(12, 12);
			this.chrtMousePos.Name = "chrtMousePos";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.Legend = "Main Legend";
			series1.Name = "Position";
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series2.Legend = "Main Legend";
			series2.Name = "Last 5 seconds";
			this.chrtMousePos.Series.Add(series1);
			this.chrtMousePos.Series.Add(series2);
			this.chrtMousePos.Size = new System.Drawing.Size(595, 427);
			this.chrtMousePos.TabIndex = 0;
			this.chrtMousePos.Text = "chart1";
			// 
			// btnPlay
			// 
			this.btnPlay.Location = new System.Drawing.Point(12, 496);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(75, 23);
			this.btnPlay.TabIndex = 1;
			this.btnPlay.Text = "Play";
			this.btnPlay.UseVisualStyleBackColor = true;
			// 
			// tbPlot
			// 
			this.tbPlot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbPlot.Location = new System.Drawing.Point(12, 445);
			this.tbPlot.Name = "tbPlot";
			this.tbPlot.Size = new System.Drawing.Size(595, 45);
			this.tbPlot.TabIndex = 2;
			// 
			// btnShowBoth
			// 
			this.btnShowBoth.Location = new System.Drawing.Point(276, 496);
			this.btnShowBoth.Name = "btnShowBoth";
			this.btnShowBoth.Size = new System.Drawing.Size(75, 23);
			this.btnShowBoth.TabIndex = 3;
			this.btnShowBoth.Text = "Show Both";
			this.btnShowBoth.UseVisualStyleBackColor = true;
			this.btnShowBoth.Click += new System.EventHandler(this.btnShowBoth_Click);
			// 
			// btnShowRecent
			// 
			this.btnShowRecent.Location = new System.Drawing.Point(357, 496);
			this.btnShowRecent.Name = "btnShowRecent";
			this.btnShowRecent.Size = new System.Drawing.Size(100, 23);
			this.btnShowRecent.TabIndex = 4;
			this.btnShowRecent.Text = "Show Recent";
			this.btnShowRecent.UseVisualStyleBackColor = true;
			this.btnShowRecent.Click += new System.EventHandler(this.btnShowRecent_Click);
			// 
			// btnShowAllButRecent
			// 
			this.btnShowAllButRecent.Location = new System.Drawing.Point(463, 496);
			this.btnShowAllButRecent.Name = "btnShowAllButRecent";
			this.btnShowAllButRecent.Size = new System.Drawing.Size(144, 23);
			this.btnShowAllButRecent.TabIndex = 5;
			this.btnShowAllButRecent.Text = "Show All Except Recent";
			this.btnShowAllButRecent.UseVisualStyleBackColor = true;
			this.btnShowAllButRecent.Click += new System.EventHandler(this.btnShowAllButRecent_Click);
			// 
			// frmGraph
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(619, 531);
			this.Controls.Add(this.btnShowAllButRecent);
			this.Controls.Add(this.btnShowRecent);
			this.Controls.Add(this.btnShowBoth);
			this.Controls.Add(this.tbPlot);
			this.Controls.Add(this.btnPlay);
			this.Controls.Add(this.chrtMousePos);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "frmGraph";
			this.Text = "Graph Data";
			this.Load += new System.EventHandler(this.frmGraph_Load);
			((System.ComponentModel.ISupportInitialize)(this.chrtMousePos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbPlot)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chrtMousePos;
		private System.Windows.Forms.Button btnPlay;
		private System.Windows.Forms.TrackBar tbPlot;
		private System.Windows.Forms.Button btnShowBoth;
		private System.Windows.Forms.Button btnShowRecent;
		private System.Windows.Forms.Button btnShowAllButRecent;
	}
}