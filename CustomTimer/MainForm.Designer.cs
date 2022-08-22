namespace CustomTimer
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
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.time1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.time2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.time3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topMostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msec10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initBackColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.autoSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.clickIntervalTimer = new System.Windows.Forms.Timer(this.components);
            this.cursorTimer = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.ContextMenuStrip = this.contextMenuStrip1;
            this.labelTime.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(12, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(34, 15);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "00:00";
            this.labelTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.labelTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startStopToolStripMenuItem,
            this.resetRestartToolStripMenuItem,
            this.toolStripSeparator1,
            this.settingToolStripMenuItem,
            this.topMostToolStripMenuItem,
            this.maximizeToolStripMenuItem,
            this.msec10ToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.initBackColorToolStripMenuItem,
            this.toolStripSeparator2,
            this.autoSaveToolStripMenuItem,
            this.versionToolStripMenuItem,
            this.toolStripSeparator3,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(201, 264);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1_Opening);
            // 
            // startStopToolStripMenuItem
            // 
            this.startStopToolStripMenuItem.Name = "startStopToolStripMenuItem";
            this.startStopToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.startStopToolStripMenuItem.Text = "開始（ダブルクリック）";
            this.startStopToolStripMenuItem.Click += new System.EventHandler(this.StartStopToolStripMenuItem_Click);
            // 
            // resetRestartToolStripMenuItem
            // 
            this.resetRestartToolStripMenuItem.Name = "resetRestartToolStripMenuItem";
            this.resetRestartToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.resetRestartToolStripMenuItem.Text = "リセット（トリプルクリック）";
            this.resetRestartToolStripMenuItem.Click += new System.EventHandler(this.ResetRestartToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countdownToolStripMenuItem,
            this.volumeToolStripMenuItem,
            this.toolStripSeparator4,
            this.time1ToolStripMenuItem,
            this.time2ToolStripMenuItem,
            this.time3ToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.settingToolStripMenuItem.Text = "設定...";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.SettingToolStripMenuItem_Click);
            // 
            // countdownToolStripMenuItem
            // 
            this.countdownToolStripMenuItem.Name = "countdownToolStripMenuItem";
            this.countdownToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.countdownToolStripMenuItem.Text = "カウントダウンに変更";
            this.countdownToolStripMenuItem.Click += new System.EventHandler(this.CountdownToolStripMenuItem_Click);
            // 
            // volumeToolStripMenuItem
            // 
            this.volumeToolStripMenuItem.Checked = true;
            this.volumeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.volumeToolStripMenuItem.Name = "volumeToolStripMenuItem";
            this.volumeToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.volumeToolStripMenuItem.Text = "音量 0%";
            this.volumeToolStripMenuItem.Click += new System.EventHandler(this.VolumeToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(166, 6);
            // 
            // time1ToolStripMenuItem
            // 
            this.time1ToolStripMenuItem.Checked = true;
            this.time1ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.time1ToolStripMenuItem.Name = "time1ToolStripMenuItem";
            this.time1ToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.time1ToolStripMenuItem.Text = "0:00:00";
            this.time1ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.Time1ToolStripMenuItem_CheckedChanged);
            this.time1ToolStripMenuItem.Click += new System.EventHandler(this.Time1ToolStripMenuItem_Click);
            // 
            // time2ToolStripMenuItem
            // 
            this.time2ToolStripMenuItem.Checked = true;
            this.time2ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.time2ToolStripMenuItem.Name = "time2ToolStripMenuItem";
            this.time2ToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.time2ToolStripMenuItem.Text = "0:00:00";
            this.time2ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.Time2ToolStripMenuItem_CheckedChanged);
            this.time2ToolStripMenuItem.Click += new System.EventHandler(this.Time2ToolStripMenuItem_Click);
            // 
            // time3ToolStripMenuItem
            // 
            this.time3ToolStripMenuItem.Checked = true;
            this.time3ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.time3ToolStripMenuItem.Name = "time3ToolStripMenuItem";
            this.time3ToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.time3ToolStripMenuItem.Text = "0:00:00";
            this.time3ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.Time3ToolStripMenuItem_CheckedChanged);
            this.time3ToolStripMenuItem.Click += new System.EventHandler(this.Time3ToolStripMenuItem_Click);
            // 
            // topMostToolStripMenuItem
            // 
            this.topMostToolStripMenuItem.Checked = true;
            this.topMostToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.topMostToolStripMenuItem.Name = "topMostToolStripMenuItem";
            this.topMostToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.topMostToolStripMenuItem.Text = "最前面";
            this.topMostToolStripMenuItem.Click += new System.EventHandler(this.TopMostToolStripMenuItem_Click);
            // 
            // maximizeToolStripMenuItem
            // 
            this.maximizeToolStripMenuItem.Name = "maximizeToolStripMenuItem";
            this.maximizeToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.maximizeToolStripMenuItem.Text = "最大化";
            this.maximizeToolStripMenuItem.Click += new System.EventHandler(this.MaximizeToolStripMenuItem_Click);
            // 
            // msec10ToolStripMenuItem
            // 
            this.msec10ToolStripMenuItem.Name = "msec10ToolStripMenuItem";
            this.msec10ToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.msec10ToolStripMenuItem.Text = "100分の1秒を表示";
            this.msec10ToolStripMenuItem.Click += new System.EventHandler(this.Msec10ToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.fontToolStripMenuItem.Text = "フォント...";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItem_Click);
            // 
            // initBackColorToolStripMenuItem
            // 
            this.initBackColorToolStripMenuItem.Name = "initBackColorToolStripMenuItem";
            this.initBackColorToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.initBackColorToolStripMenuItem.Text = "初期背景色...";
            this.initBackColorToolStripMenuItem.Click += new System.EventHandler(this.InitBackColorToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(197, 6);
            // 
            // autoSaveToolStripMenuItem
            // 
            this.autoSaveToolStripMenuItem.Name = "autoSaveToolStripMenuItem";
            this.autoSaveToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.autoSaveToolStripMenuItem.Text = "設定の自動保存";
            this.autoSaveToolStripMenuItem.Click += new System.EventHandler(this.AutoSaveToolStripMenuItem_Click);
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.versionToolStripMenuItem.Text = "バージョン情報...";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.VersionToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(197, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.closeToolStripMenuItem.Text = "終了";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // mainTimer
            // 
            this.mainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowColor = true;
            // 
            // clickIntervalTimer
            // 
            this.clickIntervalTimer.Tick += new System.EventHandler(this.ClickIntervalTimer_Tick);
            // 
            // cursorTimer
            // 
            this.cursorTimer.Tick += new System.EventHandler(this.CursorTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(134, 54);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.ControlBox = false;
            this.Controls.Add(this.labelTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(150, 70);
            this.Name = "MainForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseLeave += new System.EventHandler(this.MainForm_MouseLeave);
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
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem startStopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetRestartToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.Timer clickIntervalTimer;
        private System.Windows.Forms.ToolStripMenuItem time1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem time2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem time3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem topMostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maximizeToolStripMenuItem;
        private System.Windows.Forms.Timer cursorTimer;
        private System.Windows.Forms.ToolStripMenuItem msec10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initBackColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem autoSaveToolStripMenuItem;
    }
}

