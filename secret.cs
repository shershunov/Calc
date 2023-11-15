using LibVLCSharp.Shared;
using System.Windows.Forms;

namespace Calc
{
    public partial class secret : Form
    {
        private LibVLC _libVLC;
        private MediaPlayer _mediaPlayer;
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_mediaPlayer != null)
            {
                if (_mediaPlayer.IsPlaying)
                {
                    _mediaPlayer.Stop();
                }
                _mediaPlayer.Dispose();
            }

            if (_libVLC != null)
            {
                _libVLC.Dispose();
            }
        }

        public secret()
        {
            InitializeComponent();
            Core.Initialize();

            _libVLC = new LibVLC();
            _mediaPlayer = new MediaPlayer(_libVLC);
            videoView.MediaPlayer = _mediaPlayer;
            var media = new Media(_libVLC, @"c:\video.mp4", FromType.FromPath);
            videoView.Dock = DockStyle.Fill;
            _mediaPlayer.Scale = 0;
            _mediaPlayer.Play(media);
            this.FormClosing += MainForm_FormClosing;
        }
    }
}
