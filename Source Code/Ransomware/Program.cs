using System;
using System.Windows.Forms;

namespace SysWOW64
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x06000008 RID: 8 RVA: 0x00002E0B File Offset: 0x0000100B
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Worm_patch());
		}
	}
}
