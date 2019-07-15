using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace ShadowBBR_Editor
{
	public partial class MainWindow : Window
	{
		private const int UpdateInterval = 25;
		private const string PlayImageLocation = @"/icon/play.png";
		private const string PauseImageLocation = @"/icon/pause.png";
		private const string OpenImageLocation = @"icon/bpmOff.png";
		private const string CloseImageLocation = @"icon/bpmOn.png";
		private bool playbackAcive = false;
		private double lastSliderPosition = 0.5;
		private DispatcherTimer dispatcherTimer;
		private bool sliderAnimated = false;
		private int lastBPM;
		private bool bpmIconFill;

		public int SongBeatLength => (int)Math.Floor(MediaPlayer.NaturalDuration.TimeSpan.TotalMinutes * BPMSlider.Value);
		public string VolumeString => VolumeSlider.Value == 0 ? @"/icon/volume-muted.png" : VolumeSlider.Value > 0.75 ? @"/icon/volume-loud.png" : VolumeSlider.Value > 0.2 ? @"/icon/volume.png" : @"/icon/volume-low.png";
		public int SongMaxMinutes => (int)MediaPlayer.NaturalDuration.TimeSpan.TotalMinutes;
		public int SongMaxSeconds => MediaPlayer.NaturalDuration.TimeSpan.Seconds;
		public int SongBeatPosition => (int)Math.Floor(MediaPlayer.Position.TotalMinutes * BPMSlider.Value);

		public MainWindow()
		{
			InitializeComponent();

			InitializeValues();
		}

		private void InitializeValues()
		{
			MediaPlayer.Volume = VolumeSlider.Value;
			dispatcherTimer = new DispatcherTimer
			{
				Interval = TimeSpan.FromMilliseconds(UpdateInterval)
			};
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
				PlayIcon.Source = new BitmapImage(new Uri(PlayImageLocation, UriKind.Relative));
			}
			else
			{
				MediaPlayer.Play();
				playbackAcive = true;
				PlayIcon.Source = new BitmapImage(new Uri(PauseImageLocation, UriKind.Relative));
			}
		}

		private void RestartButton_Click(object sender, RoutedEventArgs e)
		{
			if (double.TryParse(RestartField.Text, out double value))
			{
				MediaPlayer.Position = new TimeSpan(0, 0, 0, 0, (int)Math.Ceiling(value / BPMSlider.Value * 60000));
			}
			else
			{
				MediaPlayer.Position = new TimeSpan(0, 0, 0, 0);
				RestartField.Text = "0";
			}
		}

		private void RestartField_LostFocus(object sender, RoutedEventArgs e)
		{
			if (double.TryParse(RestartField.Text, out double value))
			{
				if (MediaPlayer.NaturalDuration.HasTimeSpan)
				{
					double newValue = Math.Max(Math.Min(value, SongBeatLength), 0);
					RestartField.Text = newValue.ToString();
				}
			}
			else
			{
				RestartField.Text = "0";
			}
		}

		private void AudioImportButton_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();

			if (openFileDialog.ShowDialog() == true)
			{
				MediaPlayer.Stop();
				MediaPlayer.Source = new Uri(openFileDialog.FileName, UriKind.Absolute);
				playbackAcive = false;
				PlayIcon.Source = new BitmapImage(new Uri(PlayImageLocation, UriKind.Relative));
			}
		}

		private void VolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			VolumeIcon.Source = new BitmapImage(new Uri(VolumeString, UriKind.Relative));
			MediaPlayer.Volume = VolumeSlider.Value;
		}

		private void VolumeButton_Click(object sender, RoutedEventArgs e)
		{
			SetMuteState(VolumeSlider.Value != 0);
		}

		private void SetMuteState(bool value)
		{
			lastSliderPosition = value ? Math.Max(VolumeSlider.Value, 0.1) : lastSliderPosition;
			VolumeSlider.Value = MediaPlayer.Volume = value ? 0 : lastSliderPosition;
			VolumeIcon.Source = new BitmapImage(new Uri(VolumeString, UriKind.Relative));
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
			BPMIcon.Visibility = playbackAcive ? Visibility.Visible : Visibility.Hidden;

			if (lastBPM != SongBeatPosition && Mouse.LeftButton == MouseButtonState.Released)
			{
				lastBPM = SongBeatPosition;
				bpmIconFill = !bpmIconFill;
				BPMIcon.Source = new BitmapImage(new Uri(bpmIconFill ? CloseImageLocation : OpenImageLocation, UriKind.Relative)); 
			}

			if (MediaPlayer.NaturalDuration.HasTimeSpan)
			{
				TimelineObjectiveLabel.Text = string.Format("{0}:{1} ({2})", SongMaxMinutes, SongMaxSeconds.ToString("D2"), SongBeatLength);
				TimelineCurrentLabel.Text = string.Format("{0}:{1} ({2})", (int)MediaPlayer.Position.TotalMinutes, MediaPlayer.Position.Seconds.ToString("D2"), SongBeatPosition);
			}
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
