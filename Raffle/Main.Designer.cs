﻿namespace Text_Raffle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gbSource = new System.Windows.Forms.GroupBox();
            this.llView = new System.Windows.Forms.LinkLabel();
            this.lblNumEntries = new System.Windows.Forms.Label();
            this.lblEntries = new System.Windows.Forms.Label();
            this.btnSource = new System.Windows.Forms.Button();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.lblWinner = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.tmMain = new System.Windows.Forms.Timer(this.components);
            this.tmCtrl = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.gbSource.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSource
            // 
            this.gbSource.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gbSource.Controls.Add(this.llView);
            this.gbSource.Controls.Add(this.lblNumEntries);
            this.gbSource.Controls.Add(this.lblEntries);
            this.gbSource.Controls.Add(this.txtSource);
            this.gbSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSource.Location = new System.Drawing.Point(373, 454);
            this.gbSource.Name = "gbSource";
            this.gbSource.Size = new System.Drawing.Size(441, 85);
            this.gbSource.TabIndex = 0;
            this.gbSource.TabStop = false;
            this.gbSource.Text = "Source";
            this.gbSource.Paint += new System.Windows.Forms.PaintEventHandler(this.gbSource_Paint);
            // 
            // llView
            // 
            this.llView.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.llView.AutoSize = true;
            this.llView.LinkColor = System.Drawing.Color.Silver;
            this.llView.Location = new System.Drawing.Point(159, 61);
            this.llView.Name = "llView";
            this.llView.Size = new System.Drawing.Size(111, 21);
            this.llView.TabIndex = 4;
            this.llView.TabStop = true;
            this.llView.Text = "View Winners";
            this.llView.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.llView.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llView_LinkClicked);
            // 
            // lblNumEntries
            // 
            this.lblNumEntries.AutoSize = true;
            this.lblNumEntries.Location = new System.Drawing.Point(68, 59);
            this.lblNumEntries.Name = "lblNumEntries";
            this.lblNumEntries.Size = new System.Drawing.Size(16, 21);
            this.lblNumEntries.TabIndex = 3;
            this.lblNumEntries.Text = "-";
            // 
            // lblEntries
            // 
            this.lblEntries.AutoSize = true;
            this.lblEntries.Location = new System.Drawing.Point(13, 59);
            this.lblEntries.Name = "lblEntries";
            this.lblEntries.Size = new System.Drawing.Size(68, 21);
            this.lblEntries.TabIndex = 2;
            this.lblEntries.Text = "Entries:";
            // 
            // btnSource
            // 
            this.btnSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSource.Enabled = false;
            this.btnSource.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSource.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSource.Location = new System.Drawing.Point(906, 454);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(41, 23);
            this.btnSource.TabIndex = 1;
            this.btnSource.Text = "...";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Visible = false;
            // 
            // txtSource
            // 
            this.txtSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSource.Enabled = false;
            this.txtSource.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSource.Location = new System.Drawing.Point(17, 30);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(418, 27);
            this.txtSource.TabIndex = 0;
            // 
            // lblWinner
            // 
            this.lblWinner.AutoEllipsis = true;
            this.lblWinner.BackColor = System.Drawing.Color.White;
            this.lblWinner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWinner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWinner.Font = new System.Drawing.Font("Consolas", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Image = ((System.Drawing.Image)(resources.GetObject("lblWinner.Image")));
            this.lblWinner.Location = new System.Drawing.Point(0, 0);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(1162, 578);
            this.lblWinner.TabIndex = 3;
            this.lblWinner.Text = "Are you ready?";
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmMain
            // 
            this.tmMain.Interval = 10;
            this.tmMain.Tick += new System.EventHandler(this.tmMain_Tick);
            // 
            // tmCtrl
            // 
            this.tmCtrl.Interval = 500;
            this.tmCtrl.Tick += new System.EventHandler(this.tmCtrl_Tick);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.Enabled = false;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::Text_Raffle.Properties.Resources.exit_03;
            this.btnExit.Location = new System.Drawing.Point(820, 454);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 85);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Image = global::Text_Raffle.Properties.Resources.start_032;
            this.btnStart.Location = new System.Drawing.Point(287, 454);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 85);
            this.btnStart.TabIndex = 2;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.Paint += new System.Windows.Forms.PaintEventHandler(this.btnStart_Paint);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1162, 578);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gbSource);
            this.Controls.Add(this.btnSource);
            this.Controls.Add(this.lblWinner);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Year End Raffle 2018";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbSource.ResumeLayout(false);
            this.gbSource.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSource;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.Label lblNumEntries;
        private System.Windows.Forms.Label lblEntries;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.LinkLabel llView;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Timer tmMain;
        private System.Windows.Forms.Timer tmCtrl;
    }
}

