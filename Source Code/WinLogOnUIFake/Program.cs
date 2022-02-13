using System;
using System.Windows.Forms;

namespace wormlogon
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002384 File Offset: 0x00000584
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new logon());
		}
	}
}
