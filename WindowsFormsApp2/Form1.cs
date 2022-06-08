using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;
using System.Diagnostics;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Mem mem = new Mem();
        public Form1()
        {
            InitializeComponent();
        }

        async private void Form1_Load(object sender, EventArgs e)
        {
            // remove minimize button
            this.MinimizeBox = false;
            // remove maximize button
            this.MaximizeBox = false;
            // change the title to
            this.Text = "";
            siticoneHtmlLabel1.Location = new Point(
                (siticonePanel1.Width - siticoneHtmlLabel1.Width) / 2,
                (siticonePanel1.Height - siticoneHtmlLabel1.Height) / 2);
        }

        async private void siticoneCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneCheckBox1.Checked)
            {
                Process[] processlist = Process.GetProcesses();
                bool found = false;
                foreach (Process theprocess in processlist)
                {
                    if (theprocess.ProcessName == "ac_client")
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    siticoneCheckBox1.Checked = false;
                    MessageBox.Show("Please start ac_client.exe first!", "ERROR");
                    return;
                }
                mem.OpenProcess(Process.GetProcessesByName("ac_client").FirstOrDefault().Id);
                while (true)
                {
                    await Task.Delay(1000);
                    mem.WriteMemory("ac_client.exe+0017E0A8,140", "int", "1337");
                }
            }
            else
            {
                
            }
        }

        async private void siticoneCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneCheckBox2.Checked)
            {
                Process[] processlist = Process.GetProcesses();
                bool found = false;
                foreach (Process theprocess in processlist)
                {
                    if (theprocess.ProcessName == "ac_client")
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    siticoneCheckBox2.Checked = false;
                    MessageBox.Show("Please start ac_client.exe first!", "ERROR");
                    return;
                }
                mem.OpenProcess(Process.GetProcessesByName("ac_client").FirstOrDefault().Id);
                while (true)
                {
                    await Task.Delay(1000);
                    mem.WriteMemory("ac_client.exe+0017E0A8,12C", "int", "1337");
                }
            }
            else
            {
                
            }
        }

        async private void siticoneCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneCheckBox3.Checked)
            {
                Process[] processlist = Process.GetProcesses();
                bool found = false;
                foreach (Process theprocess in processlist)
                {
                    if (theprocess.ProcessName == "ac_client")
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    siticoneCheckBox3.Checked = false;
                    MessageBox.Show("Please start ac_client.exe first!", "ERROR");
                    return;
                }
                mem.OpenProcess(Process.GetProcessesByName("ac_client").FirstOrDefault().Id);
                while (true)
                {
                    await Task.Delay(1000);
                    mem.WriteMemory("ac_client.exe+0017E0A8,148", "int", "1337");
                }
            }
            else
            {

            }
        }

        async private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Process[] processlist = Process.GetProcesses();
            bool found = false;
            foreach (Process theprocess in processlist)
            {
                if (theprocess.ProcessName == "ac_client")
                {
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                MessageBox.Show("Please start ac_client.exe first!", "ERROR");
                return;
            }
            mem.OpenProcess(Process.GetProcessesByName("ac_client").FirstOrDefault().Id);
            mem.WriteMemory("ac_client.exe+0017E0A8,30", "float", siticoneTextBox2.Text);
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Configured Yet", "ERROR");
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Configured Yet", "ERROR");
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            Process[] processlist = Process.GetProcesses();
            bool found = false;
            foreach (Process theprocess in processlist)
            {
                if (theprocess.ProcessName == "ac_client")
                {
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                MessageBox.Show("Please start ac_client.exe first!", "ERROR");
                return;
            }
            mem.OpenProcess(Process.GetProcessesByName("ac_client").FirstOrDefault().Id);
            mem.WriteMemory("ac_client.exe+0017E0A8,144", "int", siticoneTextBox4.Text);
        }
    }
}
