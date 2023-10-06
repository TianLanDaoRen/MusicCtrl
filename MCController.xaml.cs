using System.Windows;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MusicCtrl
{
	/// <summary>
	/// MCController.xaml 的交互逻辑
	/// </summary>
	public partial class MCController : System.Windows.Controls.UserControl
	{
		private MusicCtrl master;

		[DllImport("user32.dll", SetLastError = true)]
		static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

		public MCController(MusicCtrl mst)
		{
			InitializeComponent();
			master = mst;
			master.MW.Main.UIGrid.Children.Insert(0, this);
			Opacity = 0.85;
			Margin = new Thickness(0, 500, 0, 0);
		}

		private void PrevBtn_Click(object sender, RoutedEventArgs e)
		{
			keybd_event((byte)Keys.MediaPreviousTrack, 0, 0, 0);
		}

		private void PlayBtn_Click(object sender, RoutedEventArgs e)
		{
			keybd_event((byte)Keys.MediaPlayPause, 0, 0, 0);
		}

		private void NextBtn_Click(object sender, RoutedEventArgs e)
		{
			keybd_event((byte)Keys.MediaNextTrack, 0, 0, 0);
		}

		private void VolUpBtn_Click(object sender, RoutedEventArgs e)
		{
			keybd_event((byte)Keys.VolumeUp, 0, 0, 0);
		}

		private void MuteBtn_Click(object sender, RoutedEventArgs e)
		{
			keybd_event((byte)Keys.VolumeMute, 0, 0, 0);
		}

		private void VolDownBtn_Click(object sender, RoutedEventArgs e)
		{
			keybd_event((byte)Keys.VolumeDown, 0, 0, 0);
		}

		public void Show(object sender = null, RoutedEventArgs e = null)
		{
			master.Settings.ShowWindow = 1;
			Visibility = Visibility.Visible;
		}

		public void Hide(object sender = null, RoutedEventArgs e = null)
		{
			master.Settings.ShowWindow = 0;
			Visibility = Visibility.Hidden;
		}
	}
}
