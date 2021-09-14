
namespace Timer
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.buttonOK = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBoxMute = new System.Windows.Forms.CheckBox();
            this.numericUpDownVolume = new System.Windows.Forms.NumericUpDown();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.dateTimePickerCountdown = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBoxTime = new System.Windows.Forms.GroupBox();
            this.groupBoxTimer = new System.Windows.Forms.GroupBox();
            this.radioButtonCountdown = new System.Windows.Forms.RadioButton();
            this.radioButtonCountup = new System.Windows.Forms.RadioButton();
            this.groupBoxVolume = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.groupBoxTime.SuspendLayout();
            this.groupBoxTimer.SuspendLayout();
            this.groupBoxVolume.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonOK.Location = new System.Drawing.Point(120, 370);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(31, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(80, 19);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(31, 112);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(80, 19);
            this.dateTimePicker2.TabIndex = 4;
            this.dateTimePicker2.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker3.Location = new System.Drawing.Point(31, 184);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowUpDown = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(80, 19);
            this.dateTimePicker3.TabIndex = 7;
            this.dateTimePicker3.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(6, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 19);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(6, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 19);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(6, 184);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(19, 19);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.PictureBox_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 18);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(40, 16);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "1st";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 90);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(42, 16);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "2nd";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 162);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(40, 16);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "3rd";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBoxMute
            // 
            this.checkBoxMute.AutoSize = true;
            this.checkBoxMute.Location = new System.Drawing.Point(6, 318);
            this.checkBoxMute.Name = "checkBoxMute";
            this.checkBoxMute.Size = new System.Drawing.Size(48, 16);
            this.checkBoxMute.TabIndex = 2;
            this.checkBoxMute.Text = "消音";
            this.checkBoxMute.UseVisualStyleBackColor = true;
            this.checkBoxMute.CheckedChanged += new System.EventHandler(this.CheckBoxMute_CheckedChanged);
            // 
            // numericUpDownVolume
            // 
            this.numericUpDownVolume.Location = new System.Drawing.Point(6, 293);
            this.numericUpDownVolume.Name = "numericUpDownVolume";
            this.numericUpDownVolume.Size = new System.Drawing.Size(48, 19);
            this.numericUpDownVolume.TabIndex = 1;
            this.numericUpDownVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownVolume.ValueChanged += new System.EventHandler(this.NumericUpDownVolume_ValueChanged);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(9, 18);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarVolume.Size = new System.Drawing.Size(45, 269);
            this.trackBarVolume.TabIndex = 0;
            this.trackBarVolume.Scroll += new System.EventHandler(this.TrackBarVolume_Scroll);
            // 
            // dateTimePickerCountdown
            // 
            this.dateTimePickerCountdown.Enabled = false;
            this.dateTimePickerCountdown.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerCountdown.Location = new System.Drawing.Point(31, 62);
            this.dateTimePickerCountdown.Name = "dateTimePickerCountdown";
            this.dateTimePickerCountdown.ShowUpDown = true;
            this.dateTimePickerCountdown.Size = new System.Drawing.Size(80, 19);
            this.dateTimePickerCountdown.TabIndex = 2;
            this.dateTimePickerCountdown.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 19);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(105, 19);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 209);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(105, 19);
            this.textBox3.TabIndex = 8;
            // 
            // groupBoxTime
            // 
            this.groupBoxTime.AutoSize = true;
            this.groupBoxTime.Controls.Add(this.checkBox1);
            this.groupBoxTime.Controls.Add(this.textBox3);
            this.groupBoxTime.Controls.Add(this.dateTimePicker1);
            this.groupBoxTime.Controls.Add(this.textBox2);
            this.groupBoxTime.Controls.Add(this.dateTimePicker2);
            this.groupBoxTime.Controls.Add(this.textBox1);
            this.groupBoxTime.Controls.Add(this.dateTimePicker3);
            this.groupBoxTime.Controls.Add(this.pictureBox1);
            this.groupBoxTime.Controls.Add(this.pictureBox2);
            this.groupBoxTime.Controls.Add(this.pictureBox3);
            this.groupBoxTime.Controls.Add(this.checkBox2);
            this.groupBoxTime.Controls.Add(this.checkBox3);
            this.groupBoxTime.Location = new System.Drawing.Point(12, 118);
            this.groupBoxTime.Name = "groupBoxTime";
            this.groupBoxTime.Size = new System.Drawing.Size(117, 246);
            this.groupBoxTime.TabIndex = 1;
            this.groupBoxTime.TabStop = false;
            this.groupBoxTime.Text = "背景色/時間";
            // 
            // groupBoxTimer
            // 
            this.groupBoxTimer.AutoSize = true;
            this.groupBoxTimer.Controls.Add(this.radioButtonCountdown);
            this.groupBoxTimer.Controls.Add(this.radioButtonCountup);
            this.groupBoxTimer.Controls.Add(this.dateTimePickerCountdown);
            this.groupBoxTimer.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTimer.Name = "groupBoxTimer";
            this.groupBoxTimer.Size = new System.Drawing.Size(117, 100);
            this.groupBoxTimer.TabIndex = 0;
            this.groupBoxTimer.TabStop = false;
            this.groupBoxTimer.Text = "機能";
            // 
            // radioButtonCountdown
            // 
            this.radioButtonCountdown.AutoSize = true;
            this.radioButtonCountdown.Location = new System.Drawing.Point(6, 40);
            this.radioButtonCountdown.Name = "radioButtonCountdown";
            this.radioButtonCountdown.Size = new System.Drawing.Size(85, 16);
            this.radioButtonCountdown.TabIndex = 1;
            this.radioButtonCountdown.Text = "カウントダウン";
            this.radioButtonCountdown.UseVisualStyleBackColor = true;
            this.radioButtonCountdown.CheckedChanged += new System.EventHandler(this.RadioButtonCountdown_CheckedChanged);
            // 
            // radioButtonCountup
            // 
            this.radioButtonCountup.AutoSize = true;
            this.radioButtonCountup.Checked = true;
            this.radioButtonCountup.Location = new System.Drawing.Point(6, 18);
            this.radioButtonCountup.Name = "radioButtonCountup";
            this.radioButtonCountup.Size = new System.Drawing.Size(83, 16);
            this.radioButtonCountup.TabIndex = 0;
            this.radioButtonCountup.TabStop = true;
            this.radioButtonCountup.Text = "カウントアップ";
            this.radioButtonCountup.UseVisualStyleBackColor = true;
            // 
            // groupBoxVolume
            // 
            this.groupBoxVolume.AutoSize = true;
            this.groupBoxVolume.Controls.Add(this.checkBoxMute);
            this.groupBoxVolume.Controls.Add(this.trackBarVolume);
            this.groupBoxVolume.Controls.Add(this.numericUpDownVolume);
            this.groupBoxVolume.Location = new System.Drawing.Point(135, 12);
            this.groupBoxVolume.Name = "groupBoxVolume";
            this.groupBoxVolume.Size = new System.Drawing.Size(60, 352);
            this.groupBoxVolume.TabIndex = 2;
            this.groupBoxVolume.TabStop = false;
            this.groupBoxVolume.Text = "音量";
            // 
            // Setting
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonOK;
            this.ClientSize = new System.Drawing.Size(207, 405);
            this.Controls.Add(this.groupBoxVolume);
            this.Controls.Add(this.groupBoxTimer);
            this.Controls.Add(this.groupBoxTime);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Setting";
            this.Text = "設定";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.groupBoxTime.ResumeLayout(false);
            this.groupBoxTime.PerformLayout();
            this.groupBoxTimer.ResumeLayout(false);
            this.groupBoxTimer.PerformLayout();
            this.groupBoxVolume.ResumeLayout(false);
            this.groupBoxVolume.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBoxMute;
        private System.Windows.Forms.NumericUpDown numericUpDownVolume;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.DateTimePicker dateTimePickerCountdown;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBoxTime;
        private System.Windows.Forms.GroupBox groupBoxTimer;
        private System.Windows.Forms.GroupBox groupBoxVolume;
        private System.Windows.Forms.RadioButton radioButtonCountdown;
        private System.Windows.Forms.RadioButton radioButtonCountup;
    }
}