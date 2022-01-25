using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filehider
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        StreamWriter sw;
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Text = openFileDialog1.FileName;
            }
            

          
        }

        Form2 f2 = new Form2();

        private void button2_Click(object sender, EventArgs e)
        {

            if (label1.Text == "NO ANY FILE CHOSEN" || label1.Text=="")
            {
                string warning = "please chose a file";
                MessageBox.Show(warning, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (sw = File.AppendText(f2.path))
                {
                    sw.WriteLine(label1.Text);

                }
                

                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();

                cmd.StandardInput.WriteLine("attrib +s +h " + label1.Text);
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();

                cmd.StandardOutput.ReadToEnd();
                cmd.Close();
                string succes = "file hiden successful";
                MessageBox.Show(succes, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sw.Close();
            }
            

        }
        
        private void button3_Click(object sender, EventArgs e)
        {

            

            Form2 f2 = new Form2();
            f2.Show();
           
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
