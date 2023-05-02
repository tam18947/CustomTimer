using System;
using System.Windows.Forms;

namespace CustomTimer
{
    public partial class Setting : Form
    {
        public Setting(Configuration conf)
        {
            InitializeComponent();
            configuration = conf;
        }

        private readonly DateTime baseDate = new(2000, 1, 1, 0, 0, 0);
        private readonly Configuration configuration;

        private void Setting_Load(object sender, EventArgs e)
        {
            // 機能
            radioButtonCountdown.Checked = configuration.IsCountdown;
            dateTimePickerCountdown.Value = baseDate + configuration.TimeCountdown;
            // 音量
            checkBoxMute.Checked = configuration.Mute;
            numericUpDownVolume.Value = configuration.Volume;
            // 背景色・時間
            checkBox1.Checked = configuration.Enable1;
            checkBox2.Checked = configuration.Enable2;
            checkBox3.Checked = configuration.Enable3;
            pictureBox1.BackColor = configuration.BackColor1;
            pictureBox2.BackColor = configuration.BackColor2;
            pictureBox3.BackColor = configuration.BackColor3;
            dateTimePicker1.Value = baseDate + configuration.TimeSpan1;
            dateTimePicker2.Value = baseDate + configuration.TimeSpan2;
            dateTimePicker3.Value = baseDate + configuration.TimeSpan3;
            // ベル
            textBox1.Text = configuration.WaveFile1;
            textBox2.Text = configuration.WaveFile2;
            textBox3.Text = configuration.WaveFile3;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            // 機能
            configuration.IsCountdown = radioButtonCountdown.Checked;
            configuration.TimeCountdown = dateTimePickerCountdown.Value - baseDate;
            // 音量
            configuration.Volume = trackBarVolume.Value;
            configuration.Mute = checkBoxMute.Checked;
            // 背景色・時間
            configuration.BackColor1 = pictureBox1.BackColor;
            configuration.BackColor2 = pictureBox2.BackColor;
            configuration.BackColor3 = pictureBox3.BackColor;
            configuration.Enable1 = checkBox1.Checked;
            configuration.Enable2 = checkBox2.Checked;
            configuration.Enable3 = checkBox3.Checked;
            configuration.TimeSpan1 = dateTimePicker1.Value - baseDate;
            configuration.TimeSpan2 = dateTimePicker2.Value - baseDate;
            configuration.TimeSpan3 = dateTimePicker3.Value - baseDate;
            // ベル
            configuration.WaveFile1 = textBox1.Text;
            configuration.WaveFile2 = textBox2.Text;
            configuration.WaveFile3 = textBox3.Text;
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

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            panel1.Enabled = checkBox1.Checked;
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
            panel2.Enabled = checkBox2.Checked;
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox1.Checked = true;
                checkBox2.Checked = true;
            }
            panel3.Enabled = checkBox3.Checked;
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
            else if (dateTimePicker2.Value < dateTimePicker1.Value)
            {
                dateTimePicker1.Value = dateTimePicker2.Value;
            }
        }

        private void DateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker3.Value < dateTimePicker2.Value)
            {
                dateTimePicker2.Value = dateTimePicker3.Value;
            }
        }

        private AudioPlayer audioPlayer = null;
        private void ButtonVolumeTest_Click(object sender, EventArgs e)
        {
            try
            {
                audioPlayer?.Stop();
                audioPlayer = new AudioPlayer(textBox1.Text, trackBarVolume.Value);
                audioPlayer.Play();
            }
            catch (Exception)
            {
                MessageBox.Show("Unplayable File");
            }
        }
    }
}
