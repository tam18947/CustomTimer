namespace CustomTimer
{
    public class Configuration
    {
        /// <summary>
        /// ウィンドウサイズ
        /// </summary>
        public Size ClientSize { get; set; } = new Size(150, 70);
        /// <summary>
        /// 最前面
        /// </summary>
        public bool TopMost { get; set; } = true;
        /// <summary>
        /// 100分の1秒を表示するか
        /// </summary>
        public bool Microsec { get; set; } = false;
        /// <summary>
        /// 最大化
        /// </summary>
        public bool Maximize { get; set; } = false;
        /// <summary>
        /// フォント
        /// </summary>
        public FontClass Font { get; set; } = new FontClass();
        /// <summary>
        /// 文字色
        /// </summary>
        public Color ForeColor { get; set; } = Color.White;
        /// <summary>
        /// 初期背景色
        /// </summary>
        public Color InitColor { get; set; } = Color.Black;
        /// <summary>
        /// 背景色1
        /// </summary>
        public Color BackColor1 { get; set; } = Color.DarkGreen;
        /// <summary>
        /// 背景色2
        /// </summary>
        public Color BackColor2 { get; set; } = Color.DarkOrange;
        /// <summary>
        /// 背景色3
        /// </summary>
        public Color BackColor3 { get; set; } = Color.DarkRed;
        /// <summary>
        /// 実行するかをチェック1
        /// </summary>
        public bool Enable1 { get; set; } = true;
        /// <summary>
        /// 実行するかをチェック2
        /// </summary>
        public bool Enable2 { get; set; } = true;
        /// <summary>
        /// 実行するかをチェック3
        /// </summary>
        public bool Enable3 { get; set; } = true;
        /// <summary>
        /// カウントダウンさせる？
        /// </summary>
        public bool IsCountdown { get; set; } = false;
        /// <summary>
        /// カウントダウンの時間
        /// </summary>
        public TimeSpan TimeCountdown { get; set; } = new TimeSpan(0, 3, 0);
        /// <summary>
        /// タイムスパン1
        /// </summary>
        public TimeSpan TimeSpan1 { get; set; } = new TimeSpan(0, 1, 0);
        /// <summary>
        /// タイムスパン2
        /// </summary>
        public TimeSpan TimeSpan2 { get; set; } = new TimeSpan(0, 2, 0);
        /// <summary>
        /// タイムスパン3
        /// </summary>
        public TimeSpan TimeSpan3 { get; set; } = new TimeSpan(0, 3, 0);
        /// <summary>
        /// 音量
        /// </summary>
        public int Volume { get; set; } = 1;
        /// <summary>
        /// ミュート
        /// </summary>
        public bool Mute { get; set; } = false;
        /// <summary>
        /// 音声ファイル1
        /// </summary>
        public string WaveFile1 { get; set; } = @"wav\chime1.wav";
        /// <summary>
        /// 音声ファイル2
        /// </summary>
        public string WaveFile2 { get; set; } = @"wav\chime2.wav";
        /// <summary>
        /// 音声ファイル3
        /// </summary>
        public string WaveFile3 { get; set; } = @"wav\chime3.wav";
        /// <summary>
        /// 文字のフォント
        /// </summary>
        public class FontClass
        {
            public string FontFamily { get; set; } = "Yu Gothic UI";
            public float Size { get; set; } = 20;
            public bool Bold { get; set; } = false;
            public bool Italic { get; set; } = false;
            public bool Strikeout { get; set; } = false;
            public bool Underline { get; set; } = false;
        }
    }
}
