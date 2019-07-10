using System.Drawing;
using System.Windows.Forms;

namespace ShadowBBR_Editor
{
	public partial class Editor : Form
	{
		private bool toolbarSelected = false;
		private Point toolbarSelectOffset;

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
	}
}
