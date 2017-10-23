namespace Timer
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
            this.components = new System.ComponentModel.Container();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.btnBegin = new System.Windows.Forms.Button();
            this.updTime = new System.Windows.Forms.NumericUpDown();
            this.lblTime = new System.Windows.Forms.Label();
            this.pgbTimeRemaining = new System.Windows.Forms.ProgressBar();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.updTime)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrMain
            // 
            this.tmrMain.Interval = 1000;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // btnBegin
            // 
            this.btnBegin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBegin.Location = new System.Drawing.Point(282, 93);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(75, 23);
            this.btnBegin.TabIndex = 0;
            this.btnBegin.Text = "&Begin";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // updTime
            // 
            this.updTime.Location = new System.Drawing.Point(12, 25);
            this.updTime.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.updTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updTime.Name = "updTime";
            this.updTime.Size = new System.Drawing.Size(120, 20);
            this.updTime.TabIndex = 1;
            this.updTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(12, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(87, 13);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time in seconds:";
            // 
            // pgbTimeRemaining
            // 
            this.pgbTimeRemaining.Location = new System.Drawing.Point(12, 64);
            this.pgbTimeRemaining.Name = "pgbTimeRemaining";
            this.pgbTimeRemaining.Size = new System.Drawing.Size(345, 23);
            this.pgbTimeRemaining.TabIndex = 3;
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Location = new System.Drawing.Point(12, 48);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(86, 13);
            this.lblTimeLeft.TabIndex = 4;
            this.lblTimeLeft.Text = "Time Remaining:";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(201, 93);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "&Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 140);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.pgbTimeRemaining);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.updTime);
            this.Controls.Add(this.btnBegin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Timer";
            ((System.ComponentModel.ISupportInitialize)(this.updTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.NumericUpDown updTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ProgressBar pgbTimeRemaining;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Button btnStop;
    }
}

