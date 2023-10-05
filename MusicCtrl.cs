using System.Windows.Controls;
using VPet_Simulator.Windows.Interface;
using LinePutScript.Localization.WPF;
using System.Windows;

namespace MusicCtrl
{
	public class MusicCtrl : MainPlugin
	{
		public MCSetting Settings;
		MenuItem menuItem;
		MCController controller;

		public MusicCtrl(IMainWindow mainwin) : base(mainwin)
		{
		}

		public override void LoadPlugin()
		{
			// Init
			Settings = new MCSetting();
			controller = new MCController(this);
			// Build up menu items in DIY
			menuItem = new MenuItem()
			{
				Header = "音乐控制".Translate(),
				HorizontalContentAlignment = HorizontalAlignment.Center,
			};

			var showItem = new MenuItem()
			{
				Header = "显示".Translate(),
				HorizontalContentAlignment = HorizontalAlignment.Center,
			};
			showItem.Click += controller.Show;
			menuItem.Items.Add(showItem);

			var hideItem = new MenuItem()
			{
				Header = "隐藏".Translate(),
				HorizontalContentAlignment = HorizontalAlignment.Center,
			};
			hideItem.Click += controller.Hide;
			menuItem.Items.Add(hideItem);

			// Get show/hide status
			if (Settings.ShowWindow == 1)
			{
				controller.Show();
			}
			else
			{
				controller.Hide();
			}
		}

		public override void LoadDIY()
		{
			MW.Main.ToolBar.MenuDIY.Items.Add(menuItem);
		}

		public override string PluginName => "MusicCtrl";

		public override void Setting()
		{
			base.Setting();
		}
	}
}
