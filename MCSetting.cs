using LinePutScript.Dictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCtrl
{
	// MusicCtrl's Settings
	public class MCSetting : LPS_D
	{
		// 是否显示控制窗体
		public int ShowWindow
		{
			get
			{
				return GetInt("MC_ShowWindow", 1);
			}
			set {
				SetInt("MC_ShowWindow", value);
			}
		}
	}
}
