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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            foreach (string line in System.IO.File.ReadLines(f2.path))
            {
                comboBox1.Items.Add(line);

            }  
        }
        StreamWriter w;
        Form2 f2 = new Form2();

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                string warning = "please chose a file";
                MessageBox.Show(warning, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string succses = "file is unhiden";
                MessageBox.Show(succses, "", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();

                cmd.StandardInput.WriteLine("attrib -s -h " + comboBox1.Text);
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();
                cmd.StandardOutput.ReadToEnd();

                comboBox1.Items.Remove(comboBox1.Text);
                
                
                for (int i = 0; i < comboBox1.Items.Count; i++)
                {
                    string value = comboBox1.GetItemText(comboBox1.Items[i]);

                    using (w=File.AppendText(f2.path))
                    {
                        w.WriteLine(value);
                    }

                }
                w.Close();


            }


           
            
            

        }
    }
}
