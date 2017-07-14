using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace USBLocker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

       }

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool LockWorkStation();

        string _serialNumber;
        string _driveLetter;



        private void timer1_Tick(object sender, EventArgs e)
        {
            check_lock();
        }

        private void check_lock()
        {
            string myString = "";

            foreach (System.IO.DriveInfo drive in System.IO.DriveInfo.GetDrives())
            {
                if ((drive.DriveType == System.IO.DriveType.Removable))
                {
                    string resumeFile = drive.Name + @Properties.Settings.Default.filename;

                    if (File.Exists(resumeFile))
                    {
                         System.IO.StreamReader myFile = new System.IO.StreamReader(resumeFile);
                         myString = myString + " " + myFile.ReadToEnd();
                         myFile.Close();

                        if (myString.Contains(Properties.Settings.Default.filedata))
                        {

                        }
                        else
                        {
                            bool result = LockWorkStation();

                            if (result == false)
                            {
                                throw new Win32Exception(Marshal.GetLastWin32Error());
                            }
                        }


                    }
                    else
                    {
                        LockWorkStation();
                    }
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Form1_Resize(object sender, EventArgs e)
        {
                notifyIcon1.BalloonTipTitle = "USB Locker";
                notifyIcon1.BalloonTipText = "Running in system tray.";

              if (FormWindowState.Minimized == this.WindowState)
               {
                 notifyIcon1.Visible = true;
                 notifyIcon1.ShowBalloonTip(500);
                 this.Hide();
             }
             else if (FormWindowState.Normal == this.WindowState)
             {
                 notifyIcon1.Visible = false;
             }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //to minimize window
            this.WindowState = FormWindowState.Minimized;

            //to hide from taskbar
            this.Hide();
        }
    }
}
