using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

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
            ReadConfiguration();

            isHiddenCursor = false;
            previousPoint = Cursor.Position;
            isStandBy = true;

            // カーソルを隠すためのタイマーのインターバル
            cursorTimer.Interval = HIDE_CURSOR_TIME;

            Margin = new Padding(9);
            TimerReset();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            ControlSizeChange(labelTime);
        }

        #region メニュー操作，設定のイベント処理
        /// <summary>
        /// コンテキストメニューが開くときはカーソルを表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ShowCursor();
        }

        /// <summary>
        /// フォームを閉じる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 終了時に設定ファイルをjsonで保存する
            WriteConfiguration();
            Close();
        }

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
            configuration.IsCountdown = !configuration.IsCountdown;
            countdownToolStripMenuItem.Text = String_ChangeToCountUpOrCountDown(configuration.IsCountdown);
            // 未計測なら表示を初期化
            if (!mainTimer.Enabled)
            { TimerReset(); }
        }

        /// <summary>
        /// 詳細設定メニュークリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting setting = new(configuration);
            if (setting.ShowDialog() == DialogResult.OK)
            {
                // 時間
                time1ToolStripMenuItem.Text = "[1]  " + TimeSpanToString(configuration.TimeSpan1);
                time2ToolStripMenuItem.Text = "[2]  " + TimeSpanToString(configuration.TimeSpan2);
                time3ToolStripMenuItem.Text = "[3]  " + TimeSpanToString(configuration.TimeSpan3);
                time1ToolStripMenuItem.Checked = configuration.Enable1;
                time2ToolStripMenuItem.Checked = configuration.Enable2;
                time3ToolStripMenuItem.Checked = configuration.Enable3;
                // 背景色
                time1ToolStripMenuItem.BackColor = configuration.BackColor1;
                time2ToolStripMenuItem.BackColor = configuration.BackColor2;
                time3ToolStripMenuItem.BackColor = configuration.BackColor3;
                // 音量
                volumeToolStripMenuItem.Text = "音量 " + (configuration.Mute ? "0%" : configuration.Volume + "%");
                volumeToolStripMenuItem.Checked = !configuration.Mute;
                // 機能
                countdownToolStripMenuItem.Text = String_ChangeToCountUpOrCountDown(configuration.IsCountdown);
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

        private void Time1ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (!time1ToolStripMenuItem.Checked)
            {
                time2ToolStripMenuItem.Checked = false;
                time3ToolStripMenuItem.Checked = false;
            }
            configuration.Enable1 = time1ToolStripMenuItem.Checked;
        }

        private void Time2ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (!time2ToolStripMenuItem.Checked)
            {
                time3ToolStripMenuItem.Checked = false;
            }
            else
            {
                time1ToolStripMenuItem.Checked = true;
            }
            configuration.Enable2 = time2ToolStripMenuItem.Checked;
        }

        private void Time3ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (time3ToolStripMenuItem.Checked)
            {
                time1ToolStripMenuItem.Checked = true;
                time2ToolStripMenuItem.Checked = true;
            }
            configuration.Enable3 = time3ToolStripMenuItem.Checked;
        }

        private void VolumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            volumeToolStripMenuItem.Checked = !volumeToolStripMenuItem.Checked;
            volumeToolStripMenuItem.Text = volumeToolStripMenuItem.Checked ? "音量 " + configuration.Volume + "%" : "音量 0%";
            configuration.Mute = !volumeToolStripMenuItem.Checked;
        }

        private void TopMostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = configuration.TopMost
                = topMostToolStripMenuItem.Checked
                = !topMostToolStripMenuItem.Checked;
        }

        private void MaximizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maximizeToolStripMenuItem.Checked = !maximizeToolStripMenuItem.Checked;
            configuration.Maximize = MaximizeBox = maximizeToolStripMenuItem.Checked;
            WindowState = MaximizeBox ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void Msec10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msec10ToolStripMenuItem.Checked = !msec10ToolStripMenuItem.Checked;
            mainTimer.Interval = msec10ToolStripMenuItem.Checked ? 10 : 100;
            configuration.Microsec = msec10ToolStripMenuItem.Checked;
            if (isStandBy)
            {
                TimerReset();
            }
            else
            {
                LabelTime_TextChange();
            }
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

                configuration.ForeColor = fontDialog1.Color;
                configuration.Font.FontFamily = fontDialog1.Font.FontFamily.Name;
                configuration.Font.Size = fontDialog1.Font.Size;
                configuration.Font.Bold = fontDialog1.Font.Bold;
                configuration.Font.Italic = fontDialog1.Font.Italic;
                configuration.Font.Strikeout = fontDialog1.Font.Strikeout;
                configuration.Font.Underline = fontDialog1.Font.Underline;
            }
        }

        private void InitBackColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                configuration.InitColor = colorDialog1.Color;
                if (isStandBy)
                { BackColor = colorDialog1.Color; }
            }
        }

        private void AutoSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autoSaveToolStripMenuItem.Checked = !autoSaveToolStripMenuItem.Checked;
        }

        /// <summary>
        /// バージョン情報
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CustomTimer v1.0.3\n" + "https://github.com/tam18947/CustomTimer",
                "バージョン情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region タイマーイベント処理
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

            if (configuration.TimeSpan1 <= sw.Elapsed && timeCnt == 0)
            {
                Backcolor_Playsound(time1ToolStripMenuItem.Checked, configuration.BackColor1, configuration.WaveFile1);
            }
            else if (configuration.TimeSpan2 <= sw.Elapsed && timeCnt == 1)
            {
                Backcolor_Playsound(time2ToolStripMenuItem.Checked, configuration.BackColor2, configuration.WaveFile2);
            }
            else if (configuration.TimeSpan3 <= sw.Elapsed && timeCnt == 2)
            {
                Backcolor_Playsound(time3ToolStripMenuItem.Checked, configuration.BackColor3, configuration.WaveFile3);
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
        #endregion

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
                Size gap = new(16, 16);

                // 移動先のフォーム位置
                Rectangle newPosition = new(
                    Left + x - mousePoint.X,
                    Top + y - mousePoint.Y,
                    Width,
                    Height);

                // 作業領域の取得（この作業領域の内側に吸着する）
                Size area = new(
                    Screen.FromControl((Control)sender).WorkingArea.Width,
                    Screen.FromControl((Control)sender).WorkingArea.Height);

                // 作業領域の左上隅の座標の取得
                Point wp = Screen.FromControl((Control)sender).WorkingArea.Location;

                // 画面端の判定用（画面の端の位置に、吸着するサイズ分のRECTを定義する）
                Rectangle rectLeft = new(
                                            wp.X - 8,
                                            wp.Y,
                                            gap.Width,
                                            area.Height);
                Rectangle rectTop = new(
                                            wp.X,
                                            wp.Y - 8,
                                            area.Width,
                                            gap.Height);
                Rectangle rectRight = new(
                                            area.Width - gap.Width + wp.X + 8,
                                            wp.Y,
                                            gap.Width,
                                            area.Height);
                Rectangle rectBottom = new(
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
                        newPosition.X = area.Width - Width + wp.X + 8;
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
                        newPosition.Y = area.Height - Height + wp.Y + 8;
                    }
                }

                // 実際に移動させる
                Left = newPosition.Left;
                Top = newPosition.Top;
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
        private AudioPlayer audioPlayer = null;

        // 音声ファイルを再生する
        private void PlaySound(string audioFile, int volume)
        {
            try
            {
                if (audioPlayer != null)
                { audioPlayer.Stop(); }

                audioPlayer = new AudioPlayer(audioFile, volume);
                audioPlayer.Play();
            }
            catch (Exception)
            {
                MessageBox.Show("Unplayable File");
            }
        }
        #endregion

        #region シリアライズ関係
        private const string configName = "CustomTimer.config.json";

        /// <summary>
        /// 設定ファイルを読み込んでコントロールに反映させる
        /// </summary>
        private void ReadConfiguration()
        {
            // 設定ファイルを読み込む
            var config = DeSerialize<Configuration>(configName);
            configuration = config is not null ? config : new Configuration();

            ClientSize = configuration.ClientSize;
            FontStyle fontStyle = (FontStyle)(configuration.Font.Bold ? 1 : 0)
                | (FontStyle)(configuration.Font.Italic ? 2 : 0)
                | (FontStyle)(configuration.Font.Strikeout ? 8 : 0)
                | (FontStyle)(configuration.Font.Underline ? 4 : 0);
            labelTime.Font = new Font(configuration.Font.FontFamily, configuration.Font.Size, fontStyle);
            labelTime.ForeColor = configuration.ForeColor;
            BackColor = configuration.InitColor;
            time1ToolStripMenuItem.ForeColor = configuration.ForeColor;
            time2ToolStripMenuItem.ForeColor = configuration.ForeColor;
            time3ToolStripMenuItem.ForeColor = configuration.ForeColor;
            time1ToolStripMenuItem.Checked = configuration.Enable1;
            time2ToolStripMenuItem.Checked = configuration.Enable2;
            time3ToolStripMenuItem.Checked = configuration.Enable3;
            time1ToolStripMenuItem.Text = "[1]  " + TimeSpanToString(configuration.TimeSpan1);
            time2ToolStripMenuItem.Text = "[2]  " + TimeSpanToString(configuration.TimeSpan2);
            time3ToolStripMenuItem.Text = "[3]  " + TimeSpanToString(configuration.TimeSpan3);
            time1ToolStripMenuItem.BackColor = configuration.BackColor1;
            time2ToolStripMenuItem.BackColor = configuration.BackColor2;
            time3ToolStripMenuItem.BackColor = configuration.BackColor3;
            volumeToolStripMenuItem.Text = "音量 " + configuration.Volume + "%";
            volumeToolStripMenuItem.Checked = !configuration.Mute;
            countdownToolStripMenuItem.Text = String_ChangeToCountUpOrCountDown(configuration.IsCountdown);

            TopMost = topMostToolStripMenuItem.Checked = configuration.TopMost;
            msec10ToolStripMenuItem.Checked = configuration.Microsec;
            MaximizeBox = maximizeToolStripMenuItem.Checked = configuration.Maximize;
            WindowState = configuration.Maximize ? FormWindowState.Maximized : FormWindowState.Normal;

            // 設定ファイルを読み込んだら自動保存をONにする
            autoSaveToolStripMenuItem.Checked = config is not null;
        }

        /// <summary>
        /// 設定ファイルを書き込む
        /// </summary>
        private void WriteConfiguration()
        {
            if (autoSaveToolStripMenuItem.Checked)
            {
                configuration.ClientSize = ClientSize;
                // 設定ファイルが存在していなければ保存する
                // 設定が読み込んだものと異なっていたら保存する
                Configuration defConfig = DeSerialize<Configuration>(configName);
                if (defConfig == null || (
                    defConfig != null && (
                    configuration.ClientSize != defConfig.ClientSize ||
                    configuration.BackColor1 != defConfig.BackColor1 ||
                    configuration.BackColor2 != defConfig.BackColor2 ||
                    configuration.BackColor3 != defConfig.BackColor3 ||
                    configuration.Enable1 != defConfig.Enable1 ||
                    configuration.Enable2 != defConfig.Enable2 ||
                    configuration.Enable3 != defConfig.Enable3 ||
                    configuration.Font.Bold != defConfig.Font.Bold ||
                    configuration.Font.FontFamily != defConfig.Font.FontFamily ||
                    configuration.Font.Italic != defConfig.Font.Italic ||
                    configuration.Font.Size != defConfig.Font.Size ||
                    configuration.Font.Strikeout != defConfig.Font.Strikeout ||
                    configuration.Font.Underline != defConfig.Font.Underline ||
                    configuration.ForeColor != defConfig.ForeColor ||
                    configuration.InitColor != defConfig.InitColor ||
                    configuration.IsCountdown != defConfig.IsCountdown ||
                    configuration.Maximize != defConfig.Maximize ||
                    configuration.Microsec != defConfig.Microsec ||
                    configuration.Mute != defConfig.Mute ||
                    configuration.TimeCountdown != defConfig.TimeCountdown ||
                    configuration.TimeSpan1 != defConfig.TimeSpan1 ||
                    configuration.TimeSpan2 != defConfig.TimeSpan2 ||
                    configuration.TimeSpan3 != defConfig.TimeSpan3 ||
                    configuration.TopMost != defConfig.TopMost ||
                    configuration.Volume != defConfig.Volume ||
                    configuration.WaveFile1 != defConfig.WaveFile1 ||
                    configuration.WaveFile2 != defConfig.WaveFile2 ||
                    configuration.WaveFile3 != defConfig.WaveFile3)))
                {
                    Serialize(configuration, configName);
                }
            }
            else
            {
                if (File.Exists(configName))
                {
                    File.Delete(configName);
                }
            }
        }

        /// <summary>
        /// json書き込み用シリアライズ
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="jsonfile"></param>
        private static void Serialize<T>(T data, string jsonfile)
        {
            using var fs = new FileStream(jsonfile, FileMode.Create);
            using var writer = JsonReaderWriterFactory.CreateJsonWriter(fs, Encoding.UTF8, true, true, "  ");
            var serializer = new DataContractJsonSerializer(typeof(T));
            serializer.WriteObject(writer, data);
        }

        /// <summary>
        /// json読み込み用デシリアライズ
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonfile"></param>
        /// <returns></returns>
        private static T DeSerialize<T>(string jsonfile)
        {
            try
            {
                using var ms = new FileStream(jsonfile, FileMode.Open);
                var serializer = new DataContractJsonSerializer(typeof(T));
                return (T)serializer.ReadObject(ms);
            }
            catch
            {
                return default;
            }
        }
        #endregion

        /// <summary>
        /// Stopwatchオブジェクトを作成する
        /// </summary>
        private readonly Stopwatch sw = new();

        private int clickInterval = 0;
        private int clickCnt = 0;
        private bool isFirstClick = true;
        private int timeCnt = 0;

        private Configuration configuration;
        private bool isStandBy;

        private const int HIDE_CURSOR_TIME = 2000; // カーソルを隠すミリ秒数
        private bool isHiddenCursor; // カーソルが隠れているか
        private Point previousPoint; // 前回のカーソル位置

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

        /// <summary>
        /// 表示時間の書き換え，リサイズ
        /// </summary>
        private void LabelTime_TextChange()
        {
            // カウントダウン表示の場合
            if (configuration.IsCountdown)
            {
                TimeSpan ts = configuration.TimeCountdown;
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
#if true // 文字色に背景色の補色を使用する場合はTRUE
                labelTime.ForeColor = GetComplementaryColor(bc);
#endif 
                if (volumeToolStripMenuItem.Checked && File.Exists(waveFile))
                {
                    PlaySound(waveFile, configuration.Volume);
                }
            }
        }
        /// <summary>
        /// 引数の補色を取得する
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        private static Color GetComplementaryColor(Color color)
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
            labelTime.Text = configuration.IsCountdown ? TimeSpanToString(configuration.TimeCountdown) : TimeSpanToString(new TimeSpan());
            startStopToolStripMenuItem.Text = "開始（ダブルクリック）";
            ControlSizeChange(labelTime);
            BackColor = configuration.InitColor;
            isStandBy = true;
            timeCnt = 0;
        }

        /// <summary>
        /// TimeSpanのString型への変換形式の指定。
        /// 1時間未満なら分単位から表示する。
        /// 必要に応じて1/100秒単位を表示する。
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        private string TimeSpanToString(TimeSpan ts)
        {
            string str = ts.Hours == 0 ? @"mm\:ss" : @"h\:mm\:ss";
            if (configuration.Microsec) { str += @"\.ff"; }

            return ts.ToString(str);
        }
        /// <summary>
        /// True -> CountUp, False -> CountDown をStringで出力
        /// </summary>
        /// <param name="isCountdown"></param>
        /// <returns></returns>
        private static string String_ChangeToCountUpOrCountDown(bool isCountdown) => "カウント" + (isCountdown ? "アップ" : "ダウン") + "に変更";
    }
}
