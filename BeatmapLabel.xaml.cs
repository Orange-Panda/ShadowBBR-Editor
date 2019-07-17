using System.Windows.Controls;

namespace ShadowBBR_Editor
{
	/// <summary>
	/// Interaction logic for BeatmapLabel.xaml
	/// </summary>
	public partial class BeatmapLabel : UserControl
	{
		public BeatmapLabel(int beat)
		{
			InitializeComponent();

			text.Text = beat.ToString();
		}
	}
}
