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
	public partial class MainWindow : Window
	{
		private bool playbackAcive = false;
		private double lastSliderPosition = 0.5;
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
			dispatcherTimer.Interval = TimeSpan.FromMilliseconds(25);
			dispatcherTimer.Tick += new EventHandler(UpdateTimelineSlider);
			dispatcherTimer.Start();
		}

		#region Utilities
		private void ImportButton_Click(object sender, RoutedEventArgs e)
		{

		}

		private void ExportButton_Click(object sender, RoutedEventArgs e)
		{

		}
		#endregion

		#region Timeline Controls
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
			VolumeIcon.Source = new BitmapImage(new Uri(GetVolumeString(), UriKind.Relative));
			MediaPlayer.Volume = VolumeSlider.Value;
		}

		private string GetVolumeString()
		{
			return VolumeSlider.Value == 0 ? @"/icon/volume-muted.png" : VolumeSlider.Value > 0.8 ? @"/icon/volume-loud.png" : VolumeSlider.Value > 0.25 ?  @"/icon/volume.png" : @"/icon/volume-low.png";
		}

		private void VolumeButton_Click(object sender, RoutedEventArgs e)
		{
			SetMuteState(VolumeSlider.Value != 0);
		}

		private void SetMuteState(bool value)
		{
			lastSliderPosition = value ? Math.Max(VolumeSlider.Value, 0.1) : lastSliderPosition;
			VolumeSlider.Value = MediaPlayer.Volume = value ? 0 : lastSliderPosition;
			VolumeIcon.Source = new BitmapImage(new Uri(GetVolumeString(), UriKind.Relative));
		}

		private void MediaPlayer_MediaOpened(object sender, RoutedEventArgs e)
		{
			TimelineSlider.Maximum = MediaPlayer.NaturalDuration.TimeSpan.TotalMilliseconds;
		}

		private void MediaPlayer_MediaEnded(object sender, RoutedEventArgs e)
		{
			MediaPlayer.Position = new TimeSpan(0);
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
		#endregion

		#region Metadata
		private void BPMSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			double newValue = Math.Max(Math.Min(Math.Round(BPMSlider.Value, Mouse.LeftButton == MouseButtonState.Pressed ? 0 : 1), BPMSlider.Maximum), BPMSlider.Minimum);
			BPMSlider.Value = newValue;
			BPMField.Text = newValue.ToString();
		}

		private void BPMField_LostFocus(object sender, RoutedEventArgs e)
		{
			if (double.TryParse(BPMField.Text, out double value))
			{
				double newValue = Math.Max(Math.Min(value, BPMSlider.Maximum), BPMSlider.Minimum);
				BPMSlider.Value = newValue;
				BPMField.Text = newValue.ToString();
			}
			else
			{
				BPMField.Text = BPMSlider.Value.ToString();
			}
		}
		#endregion
	}
}
