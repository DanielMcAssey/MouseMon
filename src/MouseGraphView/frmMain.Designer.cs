namespace MouseGraphView
{
	partial class frmMain
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
			this.dgvMouseData = new System.Windows.Forms.DataGridView();
			this.dgvColMouseTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvColMouseX = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvColMouseY = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.txtUpdatesPerSecond = new System.Windows.Forms.TextBox();
			this.lblUpdatePerSec = new System.Windows.Forms.Label();
			this.txtDataLife = new System.Windows.Forms.TextBox();
			this.lblMaxSeconds = new System.Windows.Forms.Label();
			this.btnGenerateGraph = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvMouseData)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvMouseData
			// 
			this.dgvMouseData.AllowUserToAddRows = false;
			this.dgvMouseData.AllowUserToDeleteRows = false;
			this.dgvMouseData.AllowUserToResizeColumns = false;
			this.dgvMouseData.AllowUserToResizeRows = false;
			this.dgvMouseData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvMouseData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvMouseData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMouseData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColMouseTime,
            this.dgvColMouseX,
            this.dgvColMouseY});
			this.dgvMouseData.Location = new System.Drawing.Point(12, 66);
			this.dgvMouseData.MultiSelect = false;
			this.dgvMouseData.Name = "dgvMouseData";
			this.dgvMouseData.RowHeadersVisible = false;
			this.dgvMouseData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvMouseData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvMouseData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMouseData.Size = new System.Drawing.Size(418, 349);
			this.dgvMouseData.TabIndex = 0;
			// 
			// dgvColMouseTime
			// 
			this.dgvColMouseTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgvColMouseTime.HeaderText = "Recorded Time";
			this.dgvColMouseTime.Name = "dgvColMouseTime";
			this.dgvColMouseTime.ReadOnly = true;
			// 
			// dgvColMouseX
			// 
			this.dgvColMouseX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dgvColMouseX.HeaderText = "X";
			this.dgvColMouseX.Name = "dgvColMouseX";
			this.dgvColMouseX.ReadOnly = true;
			this.dgvColMouseX.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvColMouseX.Width = 39;
			// 
			// dgvColMouseY
			// 
			this.dgvColMouseY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dgvColMouseY.HeaderText = "Y";
			this.dgvColMouseY.Name = "dgvColMouseY";
			this.dgvColMouseY.ReadOnly = true;
			this.dgvColMouseY.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvColMouseY.Width = 39;
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(12, 12);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 1;
			this.btnStart.Text = "START";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnStop
			// 
			this.btnStop.Enabled = false;
			this.btnStop.Location = new System.Drawing.Point(12, 38);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(75, 23);
			this.btnStop.TabIndex = 2;
			this.btnStop.Text = "STOP";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// txtUpdatesPerSecond
			// 
			this.txtUpdatesPerSecond.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtUpdatesPerSecond.Location = new System.Drawing.Point(226, 14);
			this.txtUpdatesPerSecond.Name = "txtUpdatesPerSecond";
			this.txtUpdatesPerSecond.Size = new System.Drawing.Size(204, 20);
			this.txtUpdatesPerSecond.TabIndex = 3;
			// 
			// lblUpdatePerSec
			// 
			this.lblUpdatePerSec.AutoSize = true;
			this.lblUpdatePerSec.Location = new System.Drawing.Point(93, 17);
			this.lblUpdatePerSec.Name = "lblUpdatePerSec";
			this.lblUpdatePerSec.Size = new System.Drawing.Size(106, 13);
			this.lblUpdatePerSec.TabIndex = 4;
			this.lblUpdatePerSec.Text = "Updates per second:";
			// 
			// txtDataLife
			// 
			this.txtDataLife.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDataLife.Location = new System.Drawing.Point(226, 40);
			this.txtDataLife.Name = "txtDataLife";
			this.txtDataLife.Size = new System.Drawing.Size(204, 20);
			this.txtDataLife.TabIndex = 5;
			// 
			// lblMaxSeconds
			// 
			this.lblMaxSeconds.AutoSize = true;
			this.lblMaxSeconds.Location = new System.Drawing.Point(93, 43);
			this.lblMaxSeconds.Name = "lblMaxSeconds";
			this.lblMaxSeconds.Size = new System.Drawing.Size(127, 13);
			this.lblMaxSeconds.TabIndex = 6;
			this.lblMaxSeconds.Text = "Max Seconds (Data Life):";
			// 
			// btnGenerateGraph
			// 
			this.btnGenerateGraph.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGenerateGraph.Location = new System.Drawing.Point(12, 421);
			this.btnGenerateGraph.Name = "btnGenerateGraph";
			this.btnGenerateGraph.Size = new System.Drawing.Size(418, 23);
			this.btnGenerateGraph.TabIndex = 7;
			this.btnGenerateGraph.Text = "Generate Graph with Current Data";
			this.btnGenerateGraph.UseVisualStyleBackColor = true;
			this.btnGenerateGraph.Click += new System.EventHandler(this.btnGenerateGraph_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(442, 456);
			this.Controls.Add(this.btnGenerateGraph);
			this.Controls.Add(this.lblMaxSeconds);
			this.Controls.Add(this.txtDataLife);
			this.Controls.Add(this.lblUpdatePerSec);
			this.Controls.Add(this.txtUpdatesPerSecond);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.dgvMouseData);
			this.Name = "frmMain";
			this.Text = "Mouse Data Log";
			this.Load += new System.EventHandler(this.frmMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvMouseData)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvMouseData;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvColMouseTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvColMouseX;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvColMouseY;
		private System.Windows.Forms.TextBox txtUpdatesPerSecond;
		private System.Windows.Forms.Label lblUpdatePerSec;
		private System.Windows.Forms.TextBox txtDataLife;
		private System.Windows.Forms.Label lblMaxSeconds;
		private System.Windows.Forms.Button btnGenerateGraph;
	}
}

