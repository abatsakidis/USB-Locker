using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USBLocker
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.filename.ToString();
            textBox2.Text = Properties.Settings.Default.filedata.ToString();
        }

        //Cancel
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //OK
        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["filename"] = textBox1.Text;
            Properties.Settings.Default["filedata"] = textBox2.Text;
            Properties.Settings.Default.Save();

            MessageBox.Show("Saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
