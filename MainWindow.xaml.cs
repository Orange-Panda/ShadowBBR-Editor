using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Threading;

namespace ShadowBBR_Editor
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private bool playbackAcive = false;
		private double mutePosition = 0.5;
		private DispatcherTimer dispatcherTimer;
		private bool sliderAnimated = false;

		public MainWindow()
		{
			InitializeComponent();

			InitializeValues();
		}

		private void InitializeValues()
		{
			MediaPlayer.Volume = VolumeSlider.Value;
			dispatcherTimer = new DispatcherTimer();
			dispatcherTimer.Interval = TimeSpan.FromMilliseconds(100);
			dispatcherTimer.Tick += new EventHandler(UpdateTimelineSlider);
			dispatcherTimer.Start();
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
			MediaPlayer.Position = new TimeSpan(0);
		}

		private void AudioImportButton_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();

			if (openFileDialog.ShowDialog() == true)
			{
				MediaPlayer.Stop();
				MediaPlayer.Source = new Uri(openFileDialog.FileName, UriKind.Absolute);
				playbackAcive = false;
				PlayIcon.Source = new BitmapImage(new Uri(@"/icon/play.png", UriKind.Relative));
			}
		}

		private void VolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			VolumeIcon.Source = new BitmapImage(new Uri(VolumeSlider.Value == 0 ?  @"/icon/muted.png" : VolumeSlider.Value < 0.45 ? @"/icon/volume-low.png" : @"/icon/volume.png", UriKind.Relative));
			MediaPlayer.Volume = VolumeSlider.Value;
		}

		private void VolumeButton_Click(object sender, RoutedEventArgs e)
		{
			SetMuteState(VolumeSlider.Value != 0);
		}

		private void SetMuteState(bool value)
		{
			mutePosition = value ? Math.Max(VolumeSlider.Value, 0.1) : mutePosition;
			VolumeSlider.Value = MediaPlayer.Volume = value ? 0 : mutePosition;
			VolumeIcon.Source = new BitmapImage(new Uri(VolumeSlider.Value == 0 ? @"/icon/muted.png" : VolumeSlider.Value < 0.45 ? @"/icon/volume-low.png" : @"/icon/volume.png", UriKind.Relative));
		}

		private void MediaPlayer_MediaOpened(object sender, RoutedEventArgs e)
		{
			TimelineSlider.Maximum = MediaPlayer.NaturalDuration.TimeSpan.TotalMilliseconds;
		}

		private void MediaPlayer_MediaEnded(object sender, RoutedEventArgs e)
		{
			MediaPlayer.Stop();
			PlayIcon.Source = new BitmapImage(new Uri(@"/icon/play.png", UriKind.Relative));
		}

		private void TimelineSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			if (sliderAnimated) return;
			TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)TimelineSlider.Value);
			MediaPlayer.Position = ts;
		}

		private void UpdateTimelineSlider(object sender, EventArgs e)
		{
			sliderAnimated = true;
			TimelineSlider.Value = MediaPlayer.Position.TotalMilliseconds;
			sliderAnimated = false;
		}
	}
}
