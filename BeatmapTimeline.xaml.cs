using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media;

namespace ShadowBBR_Editor
{
	/// <summary>
	/// Interaction logic for BeatmapTimeline.xaml
	/// </summary>
	public partial class BeatmapTimeline : UserControl
	{
		List<BeatmapBeat> beats = new List<BeatmapBeat>();
		List<BeatmapLabel> labels = new List<BeatmapLabel>();
		int width, height, innerHeight, elementTop, beatAmount;
		internal int pixelDistance;

		public BeatmapTimeline(int width, int height)
		{
			InitializeComponent();

			this.width = width;
			this.height = height;
			border.Width = width;
			border.Height = height;
		}

		/// <summary>
		/// Add a beat to the timeline.
		/// </summary>
		/// <param name="beatNum">The beat number to place it at.</param>
		public void AddBeat(int beatNum)
		{
			BeatmapBeat beat = new BeatmapBeat(this, innerHeight, beatNum);
			beats.Add(beat);
			canvas.Children.Add(beat);
			Canvas.SetTop(beat, elementTop);
			Canvas.SetLeft(beat, elementTop);
		}

		public void RefreshBeat(BeatmapBeat beat)
		{
			beat.SetBeat((int)(Canvas.GetLeft(beat) + 2 * beatAmount / pixelDistance));
		}

		public void Setup(int beatAmount, int spacing, int labelFrequency = 4)
		{
			this.beatAmount = beatAmount;

			BeatmapLabel start = new BeatmapLabel(0);
			labels.Add(start);
			canvas.Children.Add(start);

			int intervalCount = (beatAmount / labelFrequency);
			for (int i = 1; i <= intervalCount - 1; i++)
			{
				BeatmapLabel label = new BeatmapLabel(labelFrequency * i);
				labels.Add(label);
				canvas.Children.Add(label);
			}

			BeatmapLabel end = new BeatmapLabel(beatAmount);
			labels.Add(end);
			canvas.Children.Add(end);

			for (int i = 0; i < labels.Count; i++)
			{
				Canvas.SetLeft(labels[i], spacing * i);
				Canvas.SetTop(labels[i], 1);
			}

			Measure(new System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
			Arrange(new System.Windows.Rect(0, 0, width, height));

			Border border = new Border
			{
				BorderThickness = new System.Windows.Thickness(1),
				BorderBrush = new SolidColorBrush(Color.FromRgb(20, 22, 24)),
				Background = new SolidColorBrush(Color.FromRgb(30, 32, 34))
			};
			canvas.Children.Add(border);
			Canvas.SetTop(border, 1 + start.ActualHeight);
			elementTop = 1 + (int)start.ActualHeight + 1;
			border.Width = 1 + Canvas.GetLeft(end);
			border.Height = height - 46;
			innerHeight = height - 46 - 2;

			pixelDistance = (int)border.Width - 1;
			canvas.Width = (spacing * (labels.Count - 1)) + (int)end.ActualWidth;
		}
	}
}
