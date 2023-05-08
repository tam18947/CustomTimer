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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            labelTime = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            startStopToolStripMenuItem = new ToolStripMenuItem();
            resetRestartToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            settingToolStripMenuItem = new ToolStripMenuItem();
            countdownToolStripMenuItem = new ToolStripMenuItem();
            volumeToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            time1ToolStripMenuItem = new ToolStripMenuItem();
            time2ToolStripMenuItem = new ToolStripMenuItem();
            time3ToolStripMenuItem = new ToolStripMenuItem();
            topMostToolStripMenuItem = new ToolStripMenuItem();
            maximizeToolStripMenuItem = new ToolStripMenuItem();
            msec10ToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            initBackColorToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            autoSaveToolStripMenuItem = new ToolStripMenuItem();
            versionToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            closeToolStripMenuItem = new ToolStripMenuItem();
            mainTimer = new System.Windows.Forms.Timer(components);
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            cursorTimer = new System.Windows.Forms.Timer(components);
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.BackColor = Color.Transparent;
            labelTime.ContextMenuStrip = contextMenuStrip1;
            labelTime.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelTime.ForeColor = Color.White;
            labelTime.Location = new Point(12, 9);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(34, 15);
            labelTime.TabIndex = 0;
            labelTime.Text = "00:00";
            labelTime.MouseDown += MainForm_MouseDown;
            labelTime.MouseMove += MainForm_MouseMove;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { startStopToolStripMenuItem, resetRestartToolStripMenuItem, toolStripSeparator1, settingToolStripMenuItem, topMostToolStripMenuItem, maximizeToolStripMenuItem, msec10ToolStripMenuItem, fontToolStripMenuItem, initBackColorToolStripMenuItem, toolStripSeparator2, autoSaveToolStripMenuItem, versionToolStripMenuItem, toolStripSeparator3, closeToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(201, 264);
            contextMenuStrip1.Opening += ContextMenuStrip1_Opening;
            // 
            // startStopToolStripMenuItem
            // 
            startStopToolStripMenuItem.Name = "startStopToolStripMenuItem";
            startStopToolStripMenuItem.Size = new Size(200, 22);
            startStopToolStripMenuItem.Text = "開始（ダブルクリック）";
            startStopToolStripMenuItem.Click += StartStopToolStripMenuItem_Click;
            // 
            // resetRestartToolStripMenuItem
            // 
            resetRestartToolStripMenuItem.Name = "resetRestartToolStripMenuItem";
            resetRestartToolStripMenuItem.Size = new Size(200, 22);
            resetRestartToolStripMenuItem.Text = "リセット（トリプルクリック）";
            resetRestartToolStripMenuItem.Click += ResetRestartToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(197, 6);
            // 
            // settingToolStripMenuItem
            // 
            settingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { countdownToolStripMenuItem, volumeToolStripMenuItem, toolStripSeparator4, time1ToolStripMenuItem, time2ToolStripMenuItem, time3ToolStripMenuItem });
            settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            settingToolStripMenuItem.Size = new Size(200, 22);
            settingToolStripMenuItem.Text = "設定...";
            settingToolStripMenuItem.Click += SettingToolStripMenuItem_Click;
            // 
            // countdownToolStripMenuItem
            // 
            countdownToolStripMenuItem.Name = "countdownToolStripMenuItem";
            countdownToolStripMenuItem.Size = new Size(169, 22);
            countdownToolStripMenuItem.Text = "カウントダウンに変更";
            countdownToolStripMenuItem.Click += CountdownToolStripMenuItem_Click;
            // 
            // volumeToolStripMenuItem
            // 
            volumeToolStripMenuItem.Checked = true;
            volumeToolStripMenuItem.CheckState = CheckState.Checked;
            volumeToolStripMenuItem.Name = "volumeToolStripMenuItem";
            volumeToolStripMenuItem.Size = new Size(169, 22);
            volumeToolStripMenuItem.Text = "音量 0%";
            volumeToolStripMenuItem.Click += VolumeToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(166, 6);
            // 
            // time1ToolStripMenuItem
            // 
            time1ToolStripMenuItem.Checked = true;
            time1ToolStripMenuItem.CheckState = CheckState.Checked;
            time1ToolStripMenuItem.Name = "time1ToolStripMenuItem";
            time1ToolStripMenuItem.Size = new Size(169, 22);
            time1ToolStripMenuItem.Text = "0:00:00";
            time1ToolStripMenuItem.CheckedChanged += Time1ToolStripMenuItem_CheckedChanged;
            time1ToolStripMenuItem.Click += Time1ToolStripMenuItem_Click;
            // 
            // time2ToolStripMenuItem
            // 
            time2ToolStripMenuItem.Checked = true;
            time2ToolStripMenuItem.CheckState = CheckState.Checked;
            time2ToolStripMenuItem.Name = "time2ToolStripMenuItem";
            time2ToolStripMenuItem.Size = new Size(169, 22);
            time2ToolStripMenuItem.Text = "0:00:00";
            time2ToolStripMenuItem.CheckedChanged += Time2ToolStripMenuItem_CheckedChanged;
            time2ToolStripMenuItem.Click += Time2ToolStripMenuItem_Click;
            // 
            // time3ToolStripMenuItem
            // 
            time3ToolStripMenuItem.Checked = true;
            time3ToolStripMenuItem.CheckState = CheckState.Checked;
            time3ToolStripMenuItem.Name = "time3ToolStripMenuItem";
            time3ToolStripMenuItem.Size = new Size(169, 22);
            time3ToolStripMenuItem.Text = "0:00:00";
            time3ToolStripMenuItem.CheckedChanged += Time3ToolStripMenuItem_CheckedChanged;
            time3ToolStripMenuItem.Click += Time3ToolStripMenuItem_Click;
            // 
            // topMostToolStripMenuItem
            // 
            topMostToolStripMenuItem.Checked = true;
            topMostToolStripMenuItem.CheckState = CheckState.Checked;
            topMostToolStripMenuItem.Name = "topMostToolStripMenuItem";
            topMostToolStripMenuItem.Size = new Size(200, 22);
            topMostToolStripMenuItem.Text = "最前面";
            topMostToolStripMenuItem.Click += TopMostToolStripMenuItem_Click;
            // 
            // maximizeToolStripMenuItem
            // 
            maximizeToolStripMenuItem.Name = "maximizeToolStripMenuItem";
            maximizeToolStripMenuItem.Size = new Size(200, 22);
            maximizeToolStripMenuItem.Text = "最大化";
            maximizeToolStripMenuItem.Click += MaximizeToolStripMenuItem_Click;
            // 
            // msec10ToolStripMenuItem
            // 
            msec10ToolStripMenuItem.Name = "msec10ToolStripMenuItem";
            msec10ToolStripMenuItem.Size = new Size(200, 22);
            msec10ToolStripMenuItem.Text = "100分の1秒を表示";
            msec10ToolStripMenuItem.Click += Msec10ToolStripMenuItem_Click;
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(200, 22);
            fontToolStripMenuItem.Text = "フォント...";
            fontToolStripMenuItem.Click += FontToolStripMenuItem_Click;
            // 
            // initBackColorToolStripMenuItem
            // 
            initBackColorToolStripMenuItem.Name = "initBackColorToolStripMenuItem";
            initBackColorToolStripMenuItem.Size = new Size(200, 22);
            initBackColorToolStripMenuItem.Text = "初期背景色...";
            initBackColorToolStripMenuItem.Click += InitBackColorToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(197, 6);
            // 
            // autoSaveToolStripMenuItem
            // 
            autoSaveToolStripMenuItem.Name = "autoSaveToolStripMenuItem";
            autoSaveToolStripMenuItem.Size = new Size(200, 22);
            autoSaveToolStripMenuItem.Text = "設定の自動保存";
            autoSaveToolStripMenuItem.Click += AutoSaveToolStripMenuItem_Click;
            // 
            // versionToolStripMenuItem
            // 
            versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            versionToolStripMenuItem.Size = new Size(200, 22);
            versionToolStripMenuItem.Text = "バージョン情報...";
            versionToolStripMenuItem.Click += VersionToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(197, 6);
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(200, 22);
            closeToolStripMenuItem.Text = "終了";
            closeToolStripMenuItem.Click += CloseToolStripMenuItem_Click;
            // 
            // mainTimer
            // 
            mainTimer.Tick += MainTimer_Tick;
            // 
            // fontDialog1
            // 
            fontDialog1.ShowColor = true;
            // 
            // cursorTimer
            // 
            cursorTimer.Tick += CursorTimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(134, 54);
            ContextMenuStrip = contextMenuStrip1;
            ControlBox = false;
            Controls.Add(labelTime);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(150, 70);
            Name = "MainForm";
            TopMost = true;
            Load += MainForm_Load;
            MouseDown += MainForm_MouseDown;
            MouseLeave += MainForm_MouseLeave;
            MouseMove += MainForm_MouseMove;
            Resize += MainForm_Resize;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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

