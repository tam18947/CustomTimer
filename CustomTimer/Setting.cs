using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomTimer
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private readonly DateTime baseDate = new DateTime(2000, 1, 1);

        private void Setting_Load(object sender, EventArgs e)
        {
            numericUpDownVolume.Value = trackBarVolume.Value;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pictureBox1.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pictureBox2.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.BackColor = colorDialog1.Color;
            }
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pictureBox3.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.BackColor = colorDialog1.Color;
            }
        }

        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void TrackBarVolume_Scroll(object sender, EventArgs e)
        {
            numericUpDownVolume.Value = trackBarVolume.Value;
        }

        private void NumericUpDownVolume_ValueChanged(object sender, EventArgs e)
        {
            trackBarVolume.Value = (int)numericUpDownVolume.Value;
        }

        private void CheckBoxMute_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownVolume.Enabled = !checkBoxMute.Checked;
            trackBarVolume.Enabled = !checkBoxMute.Checked;
        }

        private void RadioButtonCountdown_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerCountdown.Enabled = radioButtonCountdown.Checked;
        }

        /// <summary>
        /// 時間1を設定または取得します。
        /// </summary>
        public TimeSpan TimeSpan1
        {
            get => dateTimePicker1.Value - baseDate;
            set => dateTimePicker1.Value = baseDate + value;
        }
        /// <summary>
        /// 時間2を設定または取得します。
        /// </summary>
        public TimeSpan TimeSpan2
        {
            get => dateTimePicker2.Value - baseDate;
            set => dateTimePicker2.Value = baseDate + value;
        }
        /// <summary>
        /// 時間3を設定または取得します。
        /// </summary>
        public TimeSpan TimeSpan3
        {
            get => dateTimePicker3.Value - baseDate;
            set => dateTimePicker3.Value = baseDate + value;
        }
        /// <summary>
        /// 背景色1を設定または取得します。
        /// </summary>
        public Color BackColor1
        {
            get => pictureBox1.BackColor;
            set => pictureBox1.BackColor = value;
        }
        /// <summary>
        /// 背景色2を設定または取得します。
        /// </summary>
        public Color BackColor2
        {
            get => pictureBox2.BackColor;
            set => pictureBox2.BackColor = value;
        }
        /// <summary>
        /// 背景色3を設定または取得します。
        /// </summary>
        public Color BackColor3
        {
            get => pictureBox3.BackColor;
            set => pictureBox3.BackColor = value;
        }
        /// <summary>
        /// 時間有効1を設定または取得します。
        /// </summary>
        public bool TimeEnabled1 { get => checkBox1.Checked; set => checkBox1.Checked = value; }
        /// <summary>
        /// 時間有効2を設定または取得します。
        /// </summary>
        public bool TimeEnabled2 { get => checkBox2.Checked; set => checkBox2.Checked = value; }
        /// <summary>
        /// 時間有効3を設定または取得します。
        /// </summary>
        public bool TimeEnabled3 { get => checkBox3.Checked; set => checkBox3.Checked = value; }
        /// <summary>
        /// 音量を設定または取得します。
        /// </summary>
        public int Volume
        {
            get => trackBarVolume.Value;
            set => trackBarVolume.Value = value;
        }
        /// <summary>
        /// 消音を設定または取得します。
        /// </summary>
        public bool Mute { get => checkBoxMute.Checked; set => checkBoxMute.Checked = value; }
        /// <summary>
        /// Bell sound file 1を設定または取得します。
        /// </summary>
        public string WaveFile1 { get => textBox1.Text; set => textBox1.Text = value; }
        /// <summary>
        /// Bell sound file 2を設定または取得します。
        /// </summary>
        public string WaveFile2 { get => textBox2.Text; set => textBox2.Text = value; }
        /// <summary>
        /// Bell sound file 3を設定または取得します。
        /// </summary>
        public string WaveFile3 { get => textBox3.Text; set => textBox3.Text = value; }
        /// <summary>
        /// カウントダウンの場合の時間を設定または取得します。
        /// </summary>
        public TimeSpan TimeSpanCountdown
        {
            get => dateTimePickerCountdown.Value - baseDate;
            set => dateTimePickerCountdown.Value = baseDate + value;
        }
        /// <summary>
        /// カウントダウン表示するかどうかを設定または取得します。
        /// </summary>
        public bool IsCountdown { get => radioButtonCountdown.Checked; set => radioButtonCountdown.Checked = value; }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox2.Checked)
            {
                checkBox3.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox1.Checked = true;
                checkBox2.Checked = true;
            }
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                dateTimePicker2.Value = dateTimePicker1.Value;
            }
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value > dateTimePicker3.Value)
            {
                dateTimePicker3.Value = dateTimePicker2.Value;
            }
        }
    }
}
