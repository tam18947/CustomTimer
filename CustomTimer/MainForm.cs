using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Media;

namespace CustomTimer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Margin = new Padding(9);
            ControlSizeChange(labelTime);

            initColor = BackColor;
            time1ToolStripMenuItem.BackColor = bc1 = Color.DarkGreen;
            time2ToolStripMenuItem.BackColor = bc2 = Color.DarkOrange;
            time3ToolStripMenuItem.BackColor = bc3 = Color.DarkRed;
            time1ToolStripMenuItem.ForeColor = labelTime.ForeColor;
            time2ToolStripMenuItem.ForeColor = labelTime.ForeColor;
            time3ToolStripMenuItem.ForeColor = labelTime.ForeColor;
            tsCountdown = new TimeSpan(0, 3, 0);
            isCountdown = false;
            countdownToolStripMenuItem.Text = String_ChangeToCountUpOrCountDown(isCountdown);
            ts1 = new TimeSpan(0, 1, 0);
            ts2 = new TimeSpan(0, 2, 0);
            ts3 = new TimeSpan(0, 3, 0);
            time1ToolStripMenuItem.Text = TimeSpanToString(ts1);
            time2ToolStripMenuItem.Text = TimeSpanToString(ts2);
            time3ToolStripMenuItem.Text = TimeSpanToString(ts3);
            volume = 1;
            volumeToolStripMenuItem.Text = "音量 " + volume + "%";
            waveFile1 = @"wav\chime1.wav";
            waveFile2 = @"wav\chime2.wav";
            waveFile3 = @"wav\chime3.wav";
            isStandBy = true;

            isHiddenCursor = false;
            previousPoint = Cursor.Position;

            // カーソルを隠すためのタイマー生成
            cursorTimer.Interval = HIDE_CURSOR_TIME;
            cursorTimer.Start();
        }

        /// <summary>
        /// Stopwatchオブジェクトを作成する
        /// </summary>
        private readonly Stopwatch sw = new Stopwatch();

        private int clickInterval = 0;
        private int clickCnt = 0;
        private bool isFirstClick = true;
        private int timeCnt = 0;

        private Color initColor;
        private Color bc1, bc2, bc3;
        private TimeSpan ts1, ts2, ts3;
        private TimeSpan tsCountdown;
        private bool isCountdown;
        private int volume;
        private string waveFile1, waveFile2, waveFile3;
        private bool isStandBy;

        //private readonly Timer cursorTimer; // カーソルを隠すためのタイマー
        private const int HIDE_CURSOR_TIME = 2000; // カーソルを隠すミリ秒数
        private bool isHiddenCursor; // カーソルが隠れているか
        private Point previousPoint; // 前回のカーソル位置

        private void MainForm_Resize(object sender, EventArgs e)
        {
            ControlSizeChange(labelTime);
        }

        private void ControlSizeChange(Control control)
        {
            int val = 0;
            Point p = GetControlLocation(control);
            while (control.Font.Size - 1 > 0 && (p.X != 0 || p.Y != 0))
            {
                if (p.X < 0 || p.Y < 0)
                {
                    // 文字を小さくする
                    p = ResizeFont(control, -1f);
                    if (val == 1)
                    {
                        break;
                    }
                    val = -1;
                }
                else
                {
                    // 文字を大きくする
                    p = ResizeFont(control, 1f);
                    if (val == -1)
                    {
                        // 文字を小さくする
                        p = ResizeFont(control, -1f);
                        break;
                    }
                    val = 1;
                }
            }
            control.Location = p + new Size(Margin.Left, Margin.Top);
        }
        private Point ResizeFont(Control control, float emSize)
        {
            control.Font = new Font(control.Font.FontFamily, (float)(control.Font.Size + emSize), control.Font.Style);
            return GetControlLocation(control);
        }
        private Point GetControlLocation(Control control)
        {
            Size s = ClientSize - control.ClientSize;
            return new Point(
                (s.Width - Margin.Left - Margin.Right) / 2,
                (s.Height - Margin.Top - Margin.Bottom) / 2);
        }

        #region メニュー操作，設定のイベント処理
        /// <summary>
        /// メニューから開始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartStopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartStop();
        }
        /// <summary>
        /// メニューから停止，リセット
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetRestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimerReset();
        }

        private void CountdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isCountdown = !isCountdown;
            countdownToolStripMenuItem.Text = String_ChangeToCountUpOrCountDown(isCountdown);
            // 未計測なら表示を初期化
            if (!mainTimer.Enabled)
            { TimerReset(); }
        }

        private void AdvSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting
            {
                Owner = this,
                // 時間
                TimeSpan1 = ts1,
                TimeSpan2 = ts2,
                TimeSpan3 = ts3,
                TimeEnabled1 = time1ToolStripMenuItem.Checked,
                TimeEnabled2 = time2ToolStripMenuItem.Checked,
                TimeEnabled3 = time3ToolStripMenuItem.Checked,
                // 背景色
                BackColor1 = bc1,
                BackColor2 = bc2,
                BackColor3 = bc3,
                // 音量
                Volume = volume,
                Mute = volume == 0 || !volumeToolStripMenuItem.Checked,
                // waveファイル
                WaveFile1 = waveFile1,
                WaveFile2 = waveFile2,
                WaveFile3 = waveFile3,
                // 機能
                TimeSpanCountdown = tsCountdown,
                IsCountdown = isCountdown,
            };
            setting.ShowDialog();
            {
                // 時間
                ts1 = setting.TimeSpan1;
                ts2 = setting.TimeSpan2;
                ts3 = setting.TimeSpan3;
                time1ToolStripMenuItem.Text = TimeSpanToString(ts1);
                time2ToolStripMenuItem.Text = TimeSpanToString(ts2);
                time3ToolStripMenuItem.Text = TimeSpanToString(ts3);
                time1ToolStripMenuItem.Checked = setting.TimeEnabled1;
                time2ToolStripMenuItem.Checked = setting.TimeEnabled2;
                time3ToolStripMenuItem.Checked = setting.TimeEnabled3;
                // 背景色
                time1ToolStripMenuItem.BackColor = bc1 = setting.BackColor1;
                time2ToolStripMenuItem.BackColor = bc2 = setting.BackColor2;
                time3ToolStripMenuItem.BackColor = bc3 = setting.BackColor3;
                // 音量
                volume = setting.Volume;
                bool isMute = setting.Mute || setting.Volume == 0;
                volumeToolStripMenuItem.Text = "音量 " + (isMute ? "0%" : setting.Volume + "%");
                volumeToolStripMenuItem.Checked = !isMute;
                // waveファイル
                waveFile1 = setting.WaveFile1;
                waveFile2 = setting.WaveFile2;
                waveFile3 = setting.WaveFile3;
                // 機能
                tsCountdown = setting.TimeSpanCountdown;
                isCountdown = setting.IsCountdown;
                countdownToolStripMenuItem.Text = String_ChangeToCountUpOrCountDown(isCountdown);
                if (!mainTimer.Enabled)
                { TimerReset(); }
            }
        }

        private void Time1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            time1ToolStripMenuItem.Checked = !time1ToolStripMenuItem.Checked;
        }

        private void Time2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            time2ToolStripMenuItem.Checked = !time2ToolStripMenuItem.Checked;
        }

        private void Time3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            time3ToolStripMenuItem.Checked = !time3ToolStripMenuItem.Checked;
        }

        private void VolumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            volumeToolStripMenuItem.Checked = !volumeToolStripMenuItem.Checked;
            volumeToolStripMenuItem.Text = volumeToolStripMenuItem.Checked ? "音量 " + volume + "%" : "音量 0%";
        }

        private void VolumeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(waveFile1))
            {
                PlaySound(waveFile1);
            }
        }

        private void TopMostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = topMostToolStripMenuItem.Checked = !topMostToolStripMenuItem.Checked;
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = labelTime.Font;
            fontDialog1.Color = labelTime.ForeColor;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                labelTime.ForeColor = fontDialog1.Color;
                labelTime.Font = fontDialog1.Font;
                time1ToolStripMenuItem.ForeColor = fontDialog1.Color;
                time2ToolStripMenuItem.ForeColor = fontDialog1.Color;
                time3ToolStripMenuItem.ForeColor = fontDialog1.Color;
                FormSizeChange(labelTime);
            }
        }

        private void InitBackColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                initColor = colorDialog1.Color;
                if (isStandBy)
                { BackColor = colorDialog1.Color; }
            }
        }

        private void MaximizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!maximizeToolStripMenuItem.Checked)
            {
                maximizeToolStripMenuItem.Checked = true;
                MaximizeBox = true;
                //自分自身のフォームを最大化
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                maximizeToolStripMenuItem.Checked = false;
                MaximizeBox = false;
                //自分自身のフォームをウィンドウサイズ
                WindowState = FormWindowState.Normal;
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Msec10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (msec10ToolStripMenuItem.Checked)
            {
                msec10ToolStripMenuItem.Checked = false;
                mainTimer.Interval = 100;
            }
            else
            {
                msec10ToolStripMenuItem.Checked = true;
                mainTimer.Interval = 10;
            }
            LabelTime_TextChange();
        }
        #endregion

        /// <summary>
        /// クリック間隔の時間の計測
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickIntervalTimer_Tick(object sender, EventArgs e)
        {
            // 時間計測
            clickInterval += clickIntervalTimer.Interval;
            // ダブルクリック間隔の時間を超えたらリセット
            if (SystemInformation.DoubleClickTime < clickInterval)
            {
                clickIntervalTimer.Stop();
                clickInterval = 0;
                isFirstClick = true;
                clickCnt = 0;
            }
        }

        /// <summary>
        /// タイマー計測時の時間表示の更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainTimer_Tick(object sender, EventArgs e)
        {
            LabelTime_TextChange();

            if (ts1 <= sw.Elapsed && timeCnt == 0)
            {
                Backcolor_Playsound(time1ToolStripMenuItem.Checked, bc1, waveFile1);
            }
            else if (ts2 <= sw.Elapsed && timeCnt == 1)
            {
                Backcolor_Playsound(time2ToolStripMenuItem.Checked, bc2, waveFile2);
            }
            else if (ts3 <= sw.Elapsed && timeCnt == 2)
            {
                Backcolor_Playsound(time3ToolStripMenuItem.Checked, bc3, waveFile3);
            }
        }

        /// <summary>
        /// マウスカーソルを隠すときのタイマー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CursorTimer_Tick(object sender, EventArgs e)
        {
            cursorTimer.Stop();

            if (!isHiddenCursor && ActiveForm == this)
            {
                // カーソルが隠れていない時のみ、カーソルを隠す
                Cursor.Hide();
                isHiddenCursor = true;
            }
        }

        /// <summary>
        /// 表示時間の書き換え，リサイズ
        /// </summary>
        private void LabelTime_TextChange()
        {
            // カウントダウン表示の場合
            if (isCountdown)
            {
                TimeSpan ts = tsCountdown;
                string s;
                ts -= sw.Elapsed;
                if (ts > TimeSpan.Zero)
                {
                    ts += TimeSpan.FromSeconds(1);
                    s = TimeSpanToString(ts);
                }
                else
                {
                    s = TimeSpanToString(ts);
                    if (s != TimeSpanToString(new TimeSpan()))
                    {
                        s = "-" + s;
                    }
                }
                labelTime.Text = s;
            }
            else
            {
                labelTime.Text = TimeSpanToString(sw.Elapsed);
            }

            ControlSizeChange(labelTime);
        }

        /// <summary>
        /// 背景色の変更，音声の再生
        /// </summary>
        /// <param name="check"></param>
        /// <param name="bc"></param>
        /// <param name="waveFile"></param>
        private void Backcolor_Playsound(bool check, Color bc, string waveFile)
        {
            timeCnt++;
            if (check)
            {
                BackColor = bc;
                //labelTime.ForeColor = GetComplementaryColor(bc);
                if (volumeToolStripMenuItem.Checked && File.Exists(waveFile))
                {
                    PlaySound(waveFile);
                }
            }
        }
        /// <summary>
        /// 引数の補色を取得する
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        private Color GetComplementaryColor(Color color)
        {
            //byte r = (byte)~color.R;
            //byte g = (byte)~color.G;
            //byte b = (byte)~color.B;
            byte max = Math.Max(Math.Max(color.R, color.G), color.B);
            byte min = Math.Min(Math.Min(color.R, color.G), color.B);
            int val = max + min;
            byte r = (byte)(val - color.R);
            byte g = (byte)(val - color.G);
            byte b = (byte)(val - color.B);

            return Color.FromArgb(r, g, b);
        }

        /// <summary>
        /// フォントを変更したときにフォントに合わせてフォームサイズを変更する
        /// </summary>
        /// <param name="control"></param>
        private void FormSizeChange(Control control)
        {
            Size += control.ClientSize - ClientSize
               + new Size(Margin.Left + Margin.Right, Margin.Top + Margin.Bottom);
        }

        /// <summary>
        /// ストップウォッチ開始，停止操作
        /// </summary>
        private void StartStop()
        {
            isStandBy = false;
            if (mainTimer.Enabled)
            {
                // タイマーを停止する
                mainTimer.Stop();
                // ストップウォッチを止める
                sw.Stop();
                startStopToolStripMenuItem.Text = "再開（ダブルクリック）";
            }
            else
            {
                // タイマーを開始する
                mainTimer.Start();
                // ストップウォッチを開始する
                sw.Start();
                startStopToolStripMenuItem.Text = "一時停止（ダブルクリック）";
            }
        }

        /// <summary>
        /// タイマーリセット時の初期化
        /// </summary>
        private void TimerReset()
        {
            mainTimer.Stop();
            sw.Reset();
            labelTime.Text = isCountdown ? TimeSpanToString(tsCountdown) : TimeSpanToString(new TimeSpan());
            startStopToolStripMenuItem.Text = "開始（ダブルクリック）";
            ControlSizeChange(labelTime);
            BackColor = initColor;
            isStandBy = true;
            timeCnt = 0;
        }

        /// <summary>
        /// TimeSpanのString型への変換形式の指定
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
#if false
        private string TimeSpanToString(TimeSpan ts) => ts.ToString(@"h\:mm\:ss");
#elif false
        private string TimeSpanToString(TimeSpan ts) => ts.ToString((ts.Hours != 0 ? @"h\:" : "") + @"mm\:ss");
#else
        private string TimeSpanToString(TimeSpan ts)
        {
            string str = ts.Hours == 0 ? @"mm\:ss" : @"h\:mm\:ss";
            if (msec10ToolStripMenuItem.Checked) { str += @"\.ff"; }

            return ts.ToString(str);
        }
#endif
        /// <summary>
        /// True -> CountUp, False -> CountDown をStringで出力
        /// </summary>
        /// <param name="isCountdown"></param>
        /// <returns></returns>
        private string String_ChangeToCountUpOrCountDown(bool isCountdown) => "カウント" + (isCountdown ? "アップ" : "ダウン") + "に変更";

#region マウス操作
        /// <summary>
        /// マウスのクリック位置を記憶
        /// </summary>
        private Point mousePoint;

        /// <summary>
        /// MouseDownイベントハンドラ
        /// マウスがフォームから離れたとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_MouseLeave(object sender, EventArgs e)
        {
            cursorTimer.Stop();
        }

        /// <summary>
        /// MouseDownイベントハンドラ
        /// マウスのボタンが押されたとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            // 左クリック
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                int x = e.X, y = e.Y;
                if (sender is Label label)
                {
                    x += label.Location.X;
                    y += label.Location.Y;
                }

                //位置を記憶する
                mousePoint = new Point(x, y);

                // クリック数カウント
                clickCnt++;

                // ダブルクリックだったらトリプルクリックの計測開始
                if (isFirstClick)
                {
                    isFirstClick = false;
                    clickIntervalTimer.Start();
                }

                // ダブルクリック間隔の時間を超えるまで処理
                if (clickInterval < SystemInformation.DoubleClickTime)
                {
                    if (clickCnt == 2)
                    {
                        StartStop();
                    }
                    else if (clickCnt == 3)
                    {
                        TimerReset();
                    }
                }
            }
            // それ以外
            else
            {
                ShowCursor();
            }
        }

        private void ShowCursor()
        {
            cursorTimer.Stop();
            if (isHiddenCursor)
            {
                // カーソルが隠れている時のみ、カーソルを表示する
                Cursor.Show();
                isHiddenCursor = false;
            }
        }

        /// <summary>
        /// MouseMoveイベントハンドラ
        /// マウスが動いたとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                int x = e.X, y = e.Y;
                if (sender is Label label)
                {
                    x += label.Location.X;
                    y += label.Location.Y;
                }

                // 吸着するサイズ
                Size gap = new Size(16, 16);

                // 移動先のフォーム位置
                Rectangle newPosition = new Rectangle(
                    this.Left + x - mousePoint.X,
                    this.Top + y - mousePoint.Y,
                    this.Width,
                    this.Height);

                // 作業領域の取得（この作業領域の内側に吸着する）
                Size area = new Size(
                    Screen.FromControl((Control)sender).WorkingArea.Width,
                    Screen.FromControl((Control)sender).WorkingArea.Height);

                // 作業領域の左上隅の座標の取得
                Point wp = Screen.FromControl((Control)sender).WorkingArea.Location;

                // 画面端の判定用（画面の端の位置に、吸着するサイズ分のRECTを定義する）
                Rectangle rectLeft = new Rectangle(
                                            wp.X - 8,
                                            wp.Y,
                                            gap.Width,
                                            area.Height);
                Rectangle rectTop = new Rectangle(
                                            wp.X,
                                            wp.Y - 8,
                                            area.Width,
                                            gap.Height);
                Rectangle rectRight = new Rectangle(
                                            area.Width - gap.Width + wp.X + 8,
                                            wp.Y,
                                            gap.Width,
                                            area.Height);
                Rectangle rectBottom = new Rectangle(
                                            wp.X,
                                            area.Height - gap.Height + wp.Y + 8,
                                            area.Width,
                                            gap.Height);

                // 衝突判定
                // 判定用のRECTを自分のウィンドウの隅に重ねるように移動し、
                // 画面端の判定用のRECTと衝突しているかチェックする。
                // 衝突していた場合は、吸着させるように移動する

                // 左端衝突判定
                {
                    // 判定用のRECT
                    Rectangle newRect = newPosition;
                    newRect.Width = gap.Width;

                    if (newRect.IntersectsWith(rectLeft))
                    {
                        // 左端に吸着させる
                        newPosition.X = wp.X - 8;
                    }
                }
                // 右端衝突判定
                {
                    // 判定用のRECT
                    Rectangle newRect = newPosition;
                    newRect.X = newPosition.Right - gap.Width;  // ウィンドウの右隅
                    newRect.Width = gap.Width;

                    if (newRect.IntersectsWith(rectRight))
                    {
                        // 右端に吸着させる
                        newPosition.X = area.Width - this.Width + wp.X + 8;
                    }
                }
                // 上端衝突判定
                {
                    // 判定用のRECT
                    Rectangle newRect = newPosition;
                    newRect.Height = gap.Height;

                    if (newRect.IntersectsWith(rectTop))
                    {
                        // 上端に吸着させる
                        newPosition.Y = wp.Y - 8;
                    }
                }
                // 下端衝突判定
                {
                    // 判定用のRECT
                    Rectangle newRect = newPosition;
                    newRect.Y = newPosition.Bottom - gap.Height; // ウィンドウの下端
                    newRect.Height = gap.Height;

                    if (newRect.IntersectsWith(rectBottom))
                    {
                        // 下端に吸着させる
                        newPosition.Y = area.Height - this.Height + wp.Y + 8;
                    }
                }

                // 実際に移動させる
                this.Left = newPosition.Left;
                this.Top = newPosition.Top;
            }

            if (previousPoint == Cursor.Position)
            {
                // 前回と今回のカーソル位置が同じ場合は何もしない
                return;
            }
            previousPoint = Cursor.Position;

            ShowCursor();
            cursorTimer.Start();
        }
#endregion

#region ベルの再生
        private SoundPlayer player = null;

        //WAVEファイルを再生する
        private void PlaySound(string waveFile)
        {
            //再生されているときは止める
            if (player != null)
                StopSound();

            //読み込む
            var stream = new WaveStream(File.OpenRead(waveFile))
            {
                Volume = volume,
            };
            player = new SoundPlayer(stream);
            //非同期再生する
            player.Play();

            //次のようにすると、ループ再生される
            //player.PlayLooping();

            //次のようにすると、最後まで再生し終えるまで待機する
            //player.PlaySync();
        }

        //再生されている音を止める
        private void StopSound()
        {
            if (player != null)
            {
                player.Stop();
                player.Dispose();
                player = null;
            }
        }
#endregion

    }
}
