using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace ShadowBBR_Editor
{
	public partial class MainWindow : Window
	{
		//Constants
		private const int UpdateInterval = 10;
		private const string PlayImageLocation = @"/icon/play.png";
		private const string PauseImageLocation = @"/icon/pause.png";
		private const string OpenImageLocation = @"icon/bpmOff.png";
		private const string CloseImageLocation = @"icon/bpmOn.png";
		private const string TimelineFormat = "{0}:{1} ({2})";

		//Private variables
		private DispatcherTimer dispatcherTimer;
		private PlaybackSpeed playbackSpeed = PlaybackSpeed.Normal;
		private double lastSliderPosition = 0.5;
		private bool playbackAcive = false;
		private bool bpmIconFill = false;
		private bool sliderAnimated = false;
		private int lastBPM = 0;

		private static readonly Dictionary<PlaybackSpeed, double> playbackSpeedLookup = new Dictionary<PlaybackSpeed, double>()
		{ { PlaybackSpeed.VerySlow, 0.35 }, { PlaybackSpeed.Slow, 0.7 }, { PlaybackSpeed.Normal, 1 }, { PlaybackSpeed.Fast, 1.25 }, { PlaybackSpeed.VeryFast, 1.5 }, { PlaybackSpeed.Fastest, 2 }};

		//Properties
		public int SongBeatLength => (int)Math.Floor(MediaPlayer.NaturalDuration.TimeSpan.TotalMinutes * BPMSlider.Value);
		public string VolumeString => VolumeSlider.Value == 0 ? @"/icon/volume-muted.png" : VolumeSlider.Value > 0.75 ? @"/icon/volume-loud.png" : VolumeSlider.Value > 0.2 ? @"/icon/volume.png" : @"/icon/volume-low.png";
		public int SongMaxMinutes => (int)MediaPlayer.NaturalDuration.TimeSpan.TotalMinutes;
		public int SongMaxSeconds => MediaPlayer.NaturalDuration.TimeSpan.Seconds;
		public int SongBeatPosition => (int)Math.Floor(MediaPlayer.Position.TotalMinutes * BPMSlider.Value);

		#region Utility Events
		private void ImportButton_Click(object sender, RoutedEventArgs e)
		{

		}

		private void ExportButton_Click(object sender, RoutedEventArgs e)
		{

		}
		#endregion

		#region Timeline Control Events
		private void PlayButton_Click(object sender, RoutedEventArgs e)
		{
			SetPlayState(!playbackAcive);
		}

		private void RestartButton_Click(object sender, RoutedEventArgs e)
		{
			if (double.TryParse(RestartField.Text, out double value))
			{
				MediaPlayer.Position = TimeSpan.FromMilliseconds((int)Math.Ceiling(value / BPMSlider.Value * 60000));
			}
			else
			{
				MediaPlayer.Position = new TimeSpan(0);
				RestartField.Text = "0";
			}
		}

		private void VolumeButton_Click(object sender, RoutedEventArgs e)
		{
			SetMuteState(VolumeSlider.Value != 0);
		}

		private void AudioImportButton_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();

			if (openFileDialog.ShowDialog() == true)
			{
				SetPlayState(false);
				MediaPlayer.Source = new Uri(openFileDialog.FileName, UriKind.Absolute);
			}
		}

		private void PlaybackSpeedButton_Click(object sender, RoutedEventArgs e)
		{
			playbackSpeed = (PlaybackSpeed)(((int)playbackSpeed + 1) % Enum.GetNames(typeof(PlaybackSpeed)).Length);
			SetPlaybackSpeed(playbackSpeedLookup[playbackSpeed]);
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

		private void MediaPlayer_MediaOpened(object sender, RoutedEventArgs e)
		{
			TimelineSlider.Maximum = MediaPlayer.NaturalDuration.TimeSpan.TotalMilliseconds;
			playbackSpeed = PlaybackSpeed.Normal;
			SetPlaybackSpeed(playbackSpeedLookup[playbackSpeed]);
		}

		private void MediaPlayer_MediaEnded(object sender, RoutedEventArgs e)
		{
			MediaPlayer.Position = new TimeSpan(0);
		}

		private void VolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			MediaPlayer.Volume = VolumeSlider.Value;
			VolumeIcon.Source = new BitmapImage(new Uri(VolumeString, UriKind.Relative));
		}

		private void TimelineSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			if (sliderAnimated) return;
			MediaPlayer.Position = TimeSpan.FromMilliseconds((int)TimelineSlider.Value);
		}
		#endregion

		#region Metadata Events
		private void BPMSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			SetMetadataBPM(Math.Round(BPMSlider.Value, Mouse.LeftButton == MouseButtonState.Pressed ? 0 : 1));
		}

		private void BPMField_LostFocus(object sender, RoutedEventArgs e)
		{
			if (double.TryParse(BPMField.Text, out double value))
			{
				SetMetadataBPM(value);
			}
			else
			{
				BPMField.Text = BPMSlider.Value.ToString();
			}
		}
		#endregion

		public MainWindow()
		{
			InitializeComponent();

			MediaPlayer.Volume = VolumeSlider.Value;
			dispatcherTimer = new DispatcherTimer
			{
				Interval = TimeSpan.FromMilliseconds(UpdateInterval)
			};
			dispatcherTimer.Tick += new EventHandler(UpdateTimelineSlider);
			dispatcherTimer.Tick += new EventHandler(UpdateMetronome);
			dispatcherTimer.Start();

			BeatmapTimeline timeline = new BeatmapTimeline(1153, 304);
			timeline.Setup(60, 150, 4);
			TimelineViewer.Children.Add(timeline);
			timeline.AddBeat(12);
			timeline.AddBeat(25);
			timeline.AddBeat(26);
		}

		/// <summary>
		/// Set the metadata BPM value and update UI elements to reflect the value.
		/// </summary>
		/// <param name="value">The BPM value to set. (Will be clamped to the BPM slider range)</param>
		private void SetMetadataBPM(double value)
		{
			double newValue = Math.Max(Math.Min(value, BPMSlider.Maximum), BPMSlider.Minimum);
			BPMSlider.Value = newValue;
			BPMField.Text = newValue.ToString();
		}

		/// <summary>
		/// Updates the timeline values to reflect the current playback state.
		/// </summary>
		private void UpdateTimelineSlider(object sender, EventArgs e)
		{
			sliderAnimated = true;

			TimelineSlider.Value = MediaPlayer.Position.TotalMilliseconds;
			if (MediaPlayer.NaturalDuration.HasTimeSpan)
			{
				TimelineObjectiveLabel.Text = string.Format(TimelineFormat, SongMaxMinutes, SongMaxSeconds.ToString("D2"), SongBeatLength);
				TimelineCurrentLabel.Text = string.Format(TimelineFormat, (int)MediaPlayer.Position.TotalMinutes, MediaPlayer.Position.Seconds.ToString("D2"), SongBeatPosition);
			}

			sliderAnimated = false;
		}

		/// <summary>
		/// Checks if the current beat has changed, if it has toggles the metronome icon. Hides icon if playback has stopped.
		/// </summary>
		private void UpdateMetronome(object sender, EventArgs e)
		{
			BPMIcon.Visibility = playbackAcive ? Visibility.Visible : Visibility.Hidden;

			if (lastBPM != SongBeatPosition && Mouse.LeftButton == MouseButtonState.Released)
			{
				lastBPM = SongBeatPosition;
				bpmIconFill = !bpmIconFill;
				BPMIcon.Source = new BitmapImage(new Uri(bpmIconFill ? CloseImageLocation : OpenImageLocation, UriKind.Relative));
			}
		}

		/// <summary>
		/// Set the playback speed of the media player and update UI elements to reflect the speed.
		/// </summary>
		/// <param name="value">The playback speed to play at.</param>
		private void SetPlaybackSpeed(double value)
		{
			MediaPlayer.SpeedRatio = value;
			PlaybackSpeedText.Text = string.Format("{0}x", Math.Round(value, 1).ToString());
		}

		/// <summary>
		/// Set the mute state of the media player and set UI elements to reflect the mute state.
		/// </summary>
		/// <param name="value">True for muted, false for unmuted</param>
		private void SetMuteState(bool value)
		{
			lastSliderPosition = value ? Math.Max(VolumeSlider.Value, 0.1) : lastSliderPosition;
			VolumeSlider.Value = MediaPlayer.Volume = value ? 0 : lastSliderPosition;
			VolumeIcon.Source = new BitmapImage(new Uri(VolumeString, UriKind.Relative));
		}

		/// <summary>
		/// Set the playback state of the media player and set UI elements to reflect playback.
		/// </summary>
		/// <param name="value">True to play, false to pause</param>
		private void SetPlayState(bool value)
		{
			if (value) MediaPlayer.Play();
			else MediaPlayer.Pause();
			PlayIcon.Source = new BitmapImage(new Uri(value ? PauseImageLocation : PlayImageLocation, UriKind.Relative));
			playbackAcive = value;
		}
	}
}

public enum PlaybackSpeed
{
	VerySlow,
	Slow,
	Normal,
	Fast,
	VeryFast,
	Fastest
}