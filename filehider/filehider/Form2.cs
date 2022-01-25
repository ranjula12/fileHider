using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filehider
{

      
    public partial class Form2 : Form
    {
    
        public Form2()
        {
            InitializeComponent();
        }
       
        private void button1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            if (pathx == null)
            {
                string warning = "please select the key fitst";
                MessageBox.Show(warning, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                Form3 F3 = new Form3();
                F3.Show();
                this.Hide();
            }
            
        }

        StreamReader inputFile;


        public static string pathx;
        


        private void Form2_Load(object sender, EventArgs e)
        {


            

           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pathx == null)
            {
                string warning = "please select the key fitst";
                MessageBox.Show(warning, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form4 f4 = new Form4();
                f4.Show();
                this.Hide();
            }
            
            

        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {

             if (openFileDialog1.ShowDialog() == DialogResult.OK)
             {

                 pathx = openFileDialog1.FileName;

                 string[] lines = System.IO.File.ReadAllLines(pathx);
                 for (int i = 0; i < lines.Length; i++)
                 {
                     listBox1.Items.Add(lines[i]);

                 }
             }
        }
        public String path=pathx;
    }
}
