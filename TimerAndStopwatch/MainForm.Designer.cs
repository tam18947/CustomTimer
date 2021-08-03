﻿namespace TimerAndStopwatch
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelTime = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startStopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetRestartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.topMostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.time1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.time2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.time3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.volumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volumeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initBackColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerSW = new System.Windows.Forms.Timer(this.components);
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timerClick = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.ContextMenuStrip = this.contextMenuStrip1;
            this.labelTime.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(20, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(80, 24);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "0:00:00";
            this.labelTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.labelTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startStopToolStripMenuItem,
            this.resetRestartToolStripMenuItem,
            this.toolStripSeparator1,
            this.topMostToolStripMenuItem,
            this.timeSettingToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.initBackColorToolStripMenuItem,
            this.toolStripSeparator2,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(202, 170);
            // 
            // startStopToolStripMenuItem
            // 
            this.startStopToolStripMenuItem.Name = "startStopToolStripMenuItem";
            this.startStopToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.startStopToolStripMenuItem.Text = "開始（ダブルクリック）";
            this.startStopToolStripMenuItem.Click += new System.EventHandler(this.StartStopToolStripMenuItem_Click);
            // 
            // resetRestartToolStripMenuItem
            // 
            this.resetRestartToolStripMenuItem.Name = "resetRestartToolStripMenuItem";
            this.resetRestartToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.resetRestartToolStripMenuItem.Text = "リセット（トリプルクリック）";
            this.resetRestartToolStripMenuItem.Click += new System.EventHandler(this.ResetRestartToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(198, 6);
            // 
            // topMostToolStripMenuItem
            // 
            this.topMostToolStripMenuItem.Checked = true;
            this.topMostToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.topMostToolStripMenuItem.Name = "topMostToolStripMenuItem";
            this.topMostToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.topMostToolStripMenuItem.Text = "最前面";
            this.topMostToolStripMenuItem.Click += new System.EventHandler(this.TopMostToolStripMenuItem_Click);
            // 
            // timeSettingToolStripMenuItem
            // 
            this.timeSettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countdownToolStripMenuItem,
            this.toolStripSeparator3,
            this.time1ToolStripMenuItem,
            this.time2ToolStripMenuItem,
            this.time3ToolStripMenuItem,
            this.toolStripSeparator4,
            this.volumeToolStripMenuItem,
            this.volumeTestToolStripMenuItem});
            this.timeSettingToolStripMenuItem.Name = "timeSettingToolStripMenuItem";
            this.timeSettingToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.timeSettingToolStripMenuItem.Text = "設定...";
            this.timeSettingToolStripMenuItem.Click += new System.EventHandler(this.TimeSettingToolStripMenuItem_Click);
            // 
            // countdownToolStripMenuItem
            // 
            this.countdownToolStripMenuItem.Name = "countdownToolStripMenuItem";
            this.countdownToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.countdownToolStripMenuItem.Text = "カウントダウン 0:00:00";
            this.countdownToolStripMenuItem.Click += new System.EventHandler(this.CountdownToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(172, 6);
            // 
            // time1ToolStripMenuItem
            // 
            this.time1ToolStripMenuItem.Checked = true;
            this.time1ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.time1ToolStripMenuItem.Name = "time1ToolStripMenuItem";
            this.time1ToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.time1ToolStripMenuItem.Text = "0:00:00";
            this.time1ToolStripMenuItem.Click += new System.EventHandler(this.Time1ToolStripMenuItem_Click);
            // 
            // time2ToolStripMenuItem
            // 
            this.time2ToolStripMenuItem.Checked = true;
            this.time2ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.time2ToolStripMenuItem.Name = "time2ToolStripMenuItem";
            this.time2ToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.time2ToolStripMenuItem.Text = "0:00:00";
            this.time2ToolStripMenuItem.Click += new System.EventHandler(this.Time2ToolStripMenuItem_Click);
            // 
            // time3ToolStripMenuItem
            // 
            this.time3ToolStripMenuItem.Checked = true;
            this.time3ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.time3ToolStripMenuItem.Name = "time3ToolStripMenuItem";
            this.time3ToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.time3ToolStripMenuItem.Text = "0:00:00";
            this.time3ToolStripMenuItem.Click += new System.EventHandler(this.Time3ToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(172, 6);
            // 
            // volumeToolStripMenuItem
            // 
            this.volumeToolStripMenuItem.Checked = true;
            this.volumeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.volumeToolStripMenuItem.Name = "volumeToolStripMenuItem";
            this.volumeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.volumeToolStripMenuItem.Text = "音量 0%";
            this.volumeToolStripMenuItem.Click += new System.EventHandler(this.VolumeToolStripMenuItem_Click);
            // 
            // volumeTestToolStripMenuItem
            // 
            this.volumeTestToolStripMenuItem.Name = "volumeTestToolStripMenuItem";
            this.volumeTestToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.volumeTestToolStripMenuItem.Text = "音量テスト";
            this.volumeTestToolStripMenuItem.Click += new System.EventHandler(this.VolumeTestToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.fontToolStripMenuItem.Text = "フォント...";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItem_Click);
            // 
            // initBackColorToolStripMenuItem
            // 
            this.initBackColorToolStripMenuItem.Name = "initBackColorToolStripMenuItem";
            this.initBackColorToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.initBackColorToolStripMenuItem.Text = "初期背景色...";
            this.initBackColorToolStripMenuItem.Click += new System.EventHandler(this.InitBackColorToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(198, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.closeToolStripMenuItem.Text = "終了";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // timerSW
            // 
            this.timerSW.Tick += new System.EventHandler(this.TimerSW_Tick);
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowColor = true;
            // 
            // timerClick
            // 
            this.timerClick.Tick += new System.EventHandler(this.TimerClick_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(120, 43);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.ControlBox = false;
            this.Controls.Add(this.labelTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(136, 59);
            this.Name = "MainForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topMostToolStripMenuItem;
        private System.Windows.Forms.Timer timerSW;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem initBackColorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem startStopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetRestartToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem timeSettingToolStripMenuItem;
        private System.Windows.Forms.Timer timerClick;
        private System.Windows.Forms.ToolStripMenuItem time1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem time2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem time3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volumeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}
