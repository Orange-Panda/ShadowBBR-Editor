using System.Windows.Controls;
using System.Windows.Input;

namespace ShadowBBR_Editor
{
	/// <summary>
	/// Interaction logic for BeatmapBeat.xaml
	/// </summary>
	public partial class BeatmapBeat : UserControl
	{
		private BeatmapTimeline timeline;
		private int targetBeat;
		private double canvasLeft;
		private double mouseXInitial;
		private bool primed = false;

		public BeatmapBeat(BeatmapTimeline timeline, int height, int targetBeat)
		{
			InitializeComponent();

			this.targetBeat = targetBeat;
			this.timeline = timeline;
			outerRectangle.Height = height;
			innerRectangle.Height = height;

			SetupTooltip();

			MouseEnter += BeatmapBeat_MouseEnter;
			MouseLeave += BeatmapBeat_MouseLeave;
			MouseLeftButtonDown += BeatmapBeat_MouseLeftButtonDown;
		}

		public void SetupTooltip()
		{
			canvas.ToolTip = targetBeat.ToString();
		}

		public void SetBeat(int targetBeat)
		{
			this.targetBeat = targetBeat;
			SetupTooltip();
		}

		private void BeatmapBeat_MouseEnter(object sender, MouseEventArgs e)
		{
			outerRectangle.Opacity = 0.5;
			primed = true;
		}

		private void BeatmapBeat_MouseLeave(object sender, MouseEventArgs e)
		{
			outerRectangle.Opacity = 0.3;
			primed = false;
		}

		private void BeatmapBeat_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			if (primed)
			{
				outerRectangle.Opacity = 0.6;
				canvasLeft = Canvas.GetLeft(this);
				mouseXInitial = Mouse.GetPosition(timeline).X;
				timeline.MouseMove += Parent_MouseMove;
				timeline.MouseLeftButtonUp += Parent_MouseLeftButtonUp;
				ToolTip = "";
			}
		}

		private void Parent_MouseMove(object sender, MouseEventArgs e)
		{
			Canvas.SetLeft(this, canvasLeft - (mouseXInitial - Mouse.GetPosition(timeline).X));
			if (Canvas.GetLeft(this) > timeline.pixelDistance - 2)
				Canvas.SetLeft(this, timeline.pixelDistance - 2);
			if (Canvas.GetLeft(this) < -2)
				Canvas.SetLeft(this, -2);
		}

		private void Parent_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			outerRectangle.Opacity = 0.3;
			primed = false;
			timeline.MouseMove -= Parent_MouseMove;
			timeline.MouseLeftButtonUp -= Parent_MouseLeftButtonUp;
			timeline.RefreshBeat(this);
		}
	}
}
