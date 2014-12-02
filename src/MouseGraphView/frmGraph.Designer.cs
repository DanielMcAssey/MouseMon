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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chrtMousePos = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.btnPlay = new System.Windows.Forms.Button();
			this.tbPlot = new System.Windows.Forms.TrackBar();
			this.btnShowBoth = new System.Windows.Forms.Button();
			this.btnShowRecent = new System.Windows.Forms.Button();
			this.btnShowAllButRecent = new System.Windows.Forms.Button();
			this.lblPointsText = new System.Windows.Forms.Label();
			this.lblPointsCount = new System.Windows.Forms.Label();
			this.lblSpeedMultiplier = new System.Windows.Forms.Label();
			this.numSpeedMultiplier = new System.Windows.Forms.NumericUpDown();
			this.tmrAnimateGraph = new System.Windows.Forms.Timer(this.components);
			this.btnResetPoints = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.chrtMousePos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbPlot)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numSpeedMultiplier)).BeginInit();
			this.SuspendLayout();
			// 
			// chrtMousePos
			// 
			this.chrtMousePos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea3.AxisX.Minimum = 0D;
			chartArea3.AxisX.Title = "X Position";
			chartArea3.AxisY.IsReversed = true;
			chartArea3.AxisY.Minimum = 0D;
			chartArea3.AxisY.Title = "Y Position";
			chartArea3.Name = "ChartArea1";
			this.chrtMousePos.ChartAreas.Add(chartArea3);
			legend3.Alignment = System.Drawing.StringAlignment.Center;
			legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend3.Name = "Main Legend";
			this.chrtMousePos.Legends.Add(legend3);
			this.chrtMousePos.Location = new System.Drawing.Point(12, 12);
			this.chrtMousePos.Name = "chrtMousePos";
			series5.ChartArea = "ChartArea1";
			series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series5.Legend = "Main Legend";
			series5.Name = "Position";
			series6.ChartArea = "ChartArea1";
			series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series6.Legend = "Main Legend";
			series6.Name = "Last 5 seconds";
			this.chrtMousePos.Series.Add(series5);
			this.chrtMousePos.Series.Add(series6);
			this.chrtMousePos.Size = new System.Drawing.Size(949, 420);
			this.chrtMousePos.TabIndex = 0;
			this.chrtMousePos.Text = "Mouse Position Chart";
			// 
			// btnPlay
			// 
			this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnPlay.Location = new System.Drawing.Point(12, 489);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(75, 23);
			this.btnPlay.TabIndex = 1;
			this.btnPlay.Text = "Play";
			this.btnPlay.UseVisualStyleBackColor = true;
			this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
			// 
			// tbPlot
			// 
			this.tbPlot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbPlot.Location = new System.Drawing.Point(12, 438);
			this.tbPlot.Name = "tbPlot";
			this.tbPlot.Size = new System.Drawing.Size(949, 45);
			this.tbPlot.TabIndex = 2;
			this.tbPlot.Scroll += new System.EventHandler(this.tbPlot_Scroll);
			// 
			// btnShowBoth
			// 
			this.btnShowBoth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnShowBoth.Location = new System.Drawing.Point(630, 489);
			this.btnShowBoth.Name = "btnShowBoth";
			this.btnShowBoth.Size = new System.Drawing.Size(75, 23);
			this.btnShowBoth.TabIndex = 3;
			this.btnShowBoth.Text = "Show Both";
			this.btnShowBoth.UseVisualStyleBackColor = true;
			this.btnShowBoth.Click += new System.EventHandler(this.btnShowBoth_Click);
			// 
			// btnShowRecent
			// 
			this.btnShowRecent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnShowRecent.Location = new System.Drawing.Point(711, 489);
			this.btnShowRecent.Name = "btnShowRecent";
			this.btnShowRecent.Size = new System.Drawing.Size(100, 23);
			this.btnShowRecent.TabIndex = 4;
			this.btnShowRecent.Text = "Show Recent";
			this.btnShowRecent.UseVisualStyleBackColor = true;
			this.btnShowRecent.Click += new System.EventHandler(this.btnShowRecent_Click);
			// 
			// btnShowAllButRecent
			// 
			this.btnShowAllButRecent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnShowAllButRecent.Location = new System.Drawing.Point(817, 489);
			this.btnShowAllButRecent.Name = "btnShowAllButRecent";
			this.btnShowAllButRecent.Size = new System.Drawing.Size(144, 23);
			this.btnShowAllButRecent.TabIndex = 5;
			this.btnShowAllButRecent.Text = "Show All Except Recent";
			this.btnShowAllButRecent.UseVisualStyleBackColor = true;
			this.btnShowAllButRecent.Click += new System.EventHandler(this.btnShowAllButRecent_Click);
			// 
			// lblPointsText
			// 
			this.lblPointsText.AutoSize = true;
			this.lblPointsText.Location = new System.Drawing.Point(165, 494);
			this.lblPointsText.Name = "lblPointsText";
			this.lblPointsText.Size = new System.Drawing.Size(98, 13);
			this.lblPointsText.TabIndex = 6;
			this.lblPointsText.Text = "Captured Positions:";
			// 
			// lblPointsCount
			// 
			this.lblPointsCount.AutoSize = true;
			this.lblPointsCount.Location = new System.Drawing.Point(269, 494);
			this.lblPointsCount.Name = "lblPointsCount";
			this.lblPointsCount.Size = new System.Drawing.Size(24, 13);
			this.lblPointsCount.TabIndex = 7;
			this.lblPointsCount.Text = "0/0";
			// 
			// lblSpeedMultiplier
			// 
			this.lblSpeedMultiplier.AutoSize = true;
			this.lblSpeedMultiplier.Location = new System.Drawing.Point(93, 494);
			this.lblSpeedMultiplier.Name = "lblSpeedMultiplier";
			this.lblSpeedMultiplier.Size = new System.Drawing.Size(12, 13);
			this.lblSpeedMultiplier.TabIndex = 8;
			this.lblSpeedMultiplier.Text = "x";
			// 
			// numSpeedMultiplier
			// 
			this.numSpeedMultiplier.DecimalPlaces = 1;
			this.numSpeedMultiplier.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.numSpeedMultiplier.Location = new System.Drawing.Point(111, 492);
			this.numSpeedMultiplier.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numSpeedMultiplier.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.numSpeedMultiplier.Name = "numSpeedMultiplier";
			this.numSpeedMultiplier.Size = new System.Drawing.Size(48, 20);
			this.numSpeedMultiplier.TabIndex = 9;
			this.numSpeedMultiplier.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			// 
			// tmrAnimateGraph
			// 
			this.tmrAnimateGraph.Tick += new System.EventHandler(this.tmrAnimateGraph_Tick);
			// 
			// btnResetPoints
			// 
			this.btnResetPoints.Location = new System.Drawing.Point(549, 489);
			this.btnResetPoints.Name = "btnResetPoints";
			this.btnResetPoints.Size = new System.Drawing.Size(75, 23);
			this.btnResetPoints.TabIndex = 10;
			this.btnResetPoints.Text = "Reset Points";
			this.btnResetPoints.UseVisualStyleBackColor = true;
			this.btnResetPoints.Click += new System.EventHandler(this.btnResetPoints_Click);
			// 
			// frmGraph
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(973, 524);
			this.Controls.Add(this.btnResetPoints);
			this.Controls.Add(this.numSpeedMultiplier);
			this.Controls.Add(this.lblSpeedMultiplier);
			this.Controls.Add(this.lblPointsCount);
			this.Controls.Add(this.lblPointsText);
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
			((System.ComponentModel.ISupportInitialize)(this.numSpeedMultiplier)).EndInit();
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
		private System.Windows.Forms.Label lblPointsText;
		private System.Windows.Forms.Label lblPointsCount;
		private System.Windows.Forms.Label lblSpeedMultiplier;
		private System.Windows.Forms.NumericUpDown numSpeedMultiplier;
		private System.Windows.Forms.Timer tmrAnimateGraph;
		private System.Windows.Forms.Button btnResetPoints;
	}
}