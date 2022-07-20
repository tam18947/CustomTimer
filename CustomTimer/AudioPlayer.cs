using System.IO;
using NAudio.Wave;

namespace CustomTimer
{
    internal class AudioPlayer
    {
        internal AudioPlayer(string audioPath, int volume = 100)
        {
            if (Path.GetExtension(audioPath) != ".mp3" &&
                Path.GetExtension(audioPath) != ".wav")
            {
                return;
            }

            audioReader = new AudioFileReader(audioPath);
            if (audioReader != null)
            {
                waveOut = new WaveOut();
                waveOut.Init(audioReader);
                audioReader.Volume = volume * 0.01f;
            }
        }

        private readonly WaveOut waveOut = null;
        private readonly AudioFileReader audioReader = null;

        public void Play()
        {
            if (null == audioReader)
            {
                return;
            }

            if (waveOut.PlaybackState != PlaybackState.Playing)
            {
                waveOut.Play();
            }
        }
        public void Stop()
        {
            if (null == audioReader)
            {
                return;
            }

            if (waveOut.PlaybackState != PlaybackState.Stopped)
            {
                waveOut.Stop();
                audioReader.Dispose();
                waveOut.Dispose();
            }
        }
    }
}
