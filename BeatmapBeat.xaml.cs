using System;
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
		private static BeatmapBeat hovered;

		public int TargetBeat
		{
			get
			{
				return targetBeat;
			}
			set
			{
				targetBeat = value;
				canvas.ToolTip = value.ToString();
				RefreshPosition();
			}
		}

		public BeatmapBeat(BeatmapTimeline timeline, int height, int targetBeat)
		{
			InitializeComponent();

			this.targetBeat = targetBeat;
			this.timeline = timeline;
			outerRectangle.Height = height;
			innerRectangle.Height = height;
			canvas.ToolTip = targetBeat.ToString();

			MouseEnter += BeatmapBeat_MouseEnter;
			MouseLeave += BeatmapBeat_MouseLeave;
			MouseLeftButtonDown += BeatmapBeat_MouseLeftButtonDown;
		}

		internal void RefreshPosition()
		{
			Canvas.SetLeft(this, (timeline.BeatPixelDistance * TargetBeat) - 2);
			Canvas.SetTop(this, timeline.elementTop);
		}

		/// <summary>
		/// Sets the selection state of the beat.
		/// </summary>
		/// <param name="state">State to set the beat as</param>
		private void SetBeatState(BeatState state)
		{
			switch (state)
			{
				case BeatState.None:
					hovered = hovered == this ? null : hovered;
					outerRectangle.Opacity = 0.3;
					break;
				case BeatState.Hovering:
					hovered = this;
					outerRectangle.Opacity = 0.5;
					break;
				case BeatState.Grab:
					outerRectangle.Opacity = 0.6;
					break;
			}
		}

		#region Events
		private void BeatmapBeat_MouseEnter(object sender, MouseEventArgs e)
		{
			SetBeatState(BeatState.Hovering);
		}

		private void BeatmapBeat_MouseLeave(object sender, MouseEventArgs e)
		{
			SetBeatState(BeatState.None);
		}

		private void BeatmapBeat_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			if (hovered == this)
			{
				SetBeatState(BeatState.Grab);

				canvasLeft = Canvas.GetLeft(this);
				mouseXInitial = Mouse.GetPosition(timeline).X;
				ToolTip = "";

				timeline.MouseMove += Parent_MouseMove;
				timeline.MouseLeftButtonUp += Parent_MouseLeftButtonUp;
			}
		}

		private void Parent_MouseMove(object sender, MouseEventArgs e)
		{
			Canvas.SetLeft(this, canvasLeft - (mouseXInitial - Mouse.GetPosition(timeline).X));

			//Clamp the position to the edges of the canvas
			if (Canvas.GetLeft(this) > timeline.canvasPixelDistance - 2)
				Canvas.SetLeft(this, timeline.canvasPixelDistance - 2);
			if (Canvas.GetLeft(this) < -2)
				Canvas.SetLeft(this, -2);
		}

		private void Parent_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			timeline.MouseMove -= Parent_MouseMove;
			timeline.MouseLeftButtonUp -= Parent_MouseLeftButtonUp;

			SetBeatState(BeatState.None);
			TargetBeat = (int)Math.Round((Canvas.GetLeft(this) + 2) / timeline.BeatPixelDistance);
		}
		#endregion

		private enum BeatState { None, Hovering, Grab }
	}
}
