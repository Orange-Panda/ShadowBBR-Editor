using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace ShadowBBR_Editor
{
	public partial class Editor : Form
	{
		private bool toolbarSelected = false;
		private Point toolbarSelectOffset;
		private bool playbackActive = false;
		private SoundPlayer playback = new SoundPlayer();

		public Editor()
		{
			InitializeComponent();
		}

		private void Toolbar_MouseDown(object sender, MouseEventArgs e)
		{
			toolbarSelected = true;
			toolbarSelectOffset = new Point(e.X, e.Y);
		}

		private void Toolbar_MouseMove(object sender, MouseEventArgs e)
		{
			if (toolbarSelected)
			{
				Location = new Point(Location.X + (e.X - toolbarSelectOffset.X), Location.Y + (e.Y - toolbarSelectOffset.Y));
			}
		}

		private void Toolbar_MouseUp(object sender, MouseEventArgs e)
		{
			toolbarSelected = false;
		}

		private void ToolbarExit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void playButton_Click(object sender, System.EventArgs e)
		{
			if (playbackActive)
			{
				playback.Stop();
				playbackActive = false;
				playButton.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\icons\Media-Play-128.png");
			}
			else
			{
				playback = new SoundPlayer(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\audio\test.wav");
				playback.PlayLooping();
				playbackActive = true;
				playButton.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\icons\Media-Pause-128.png");
			}
		}
	}
}
