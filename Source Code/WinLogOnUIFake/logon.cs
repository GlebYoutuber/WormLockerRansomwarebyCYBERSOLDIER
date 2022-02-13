using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace wormlogon
{
	// Token: 0x02000002 RID: 2
	public partial class logon : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public logon()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
		private void logon_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002073 File Offset: 0x00000273
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002076 File Offset: 0x00000276
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.timer1.Stop();
			this.pictureBox1.Visible = false;
			this.timer2.Start();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000209E File Offset: 0x0000029E
		private void logon_Load(object sender, EventArgs e)
		{
			this.timer1.Start();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020AD File Offset: 0x000002AD
		private void timer2_Tick(object sender, EventArgs e)
		{
			this.timer2.Stop();
			this.pictureBox1.Visible = true;
			this.timer1.Start();
		}
	}
}
