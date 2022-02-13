namespace wormlogon
{
	// Token: 0x02000002 RID: 2
	public partial class logon : global::System.Windows.Forms.Form
	{
		// Token: 0x06000007 RID: 7 RVA: 0x000020D8 File Offset: 0x000002D8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002110 File Offset: 0x00000310
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::wormlogon.logon));
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.timer2 = new global::System.Windows.Forms.Timer(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.pictureBox1.BackColor = global::System.Drawing.Color.Red;
			this.pictureBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(640, 480);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.timer1.Enabled = true;
			this.timer1.Interval = 1;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.timer2.Enabled = true;
			this.timer2.Interval = 1;
			this.timer2.Tick += new global::System.EventHandler(this.timer2_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("$this.BackgroundImage");
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new global::System.Drawing.Size(640, 480);
			base.Controls.Add(this.pictureBox1);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "logon";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "logon";
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.logon_FormClosing);
			base.Load += new global::System.EventHandler(this.logon_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000001 RID: 1
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000002 RID: 2
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000003 RID: 3
		public global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000004 RID: 4
		public global::System.Windows.Forms.Timer timer2;
	}
}
