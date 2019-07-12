using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShadowBBR_Editor
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private bool playbackAcive = false;

		public MainWindow()
		{
			InitializeComponent();
		}

		private void ImportButton_Click(object sender, RoutedEventArgs e)
		{

		}

		private void ExportButton_Click(object sender, RoutedEventArgs e)
		{

		}

		private void PlayButton_Click(object sender, RoutedEventArgs e)
		{
			if (playbackAcive)
			{
				MediaPlayer.Pause();
				playbackAcive = false;
				PlayIcon.Source = new BitmapImage(new Uri(@"/icon/play.png", UriKind.Relative));
			}
			else
			{
				MediaPlayer.Play();
				playbackAcive = true;
				PlayIcon.Source = new BitmapImage(new Uri(@"/icon/pause.png", UriKind.Relative));
			}
		}

		private void RestartButton_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}
