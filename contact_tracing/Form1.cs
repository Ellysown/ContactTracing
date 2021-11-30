using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System;

namespace contact_tracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string gender;
        string num_q1;
        string num_q2;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                gender = "yes";
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                gender = "no";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                gender = "no";
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                gender = "yes";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtcon.Text=="" || txtfname.Text=="" || txtcon.Text=="" )
            {
                MessageBox.Show("fill in all the fields", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            else if(radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
            {
                MessageBox.Show("missing gender", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (radioButton4.Checked == false && radioButton5.Checked == false)
            {
                MessageBox.Show("no answer on #1 question", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (radioButton6.Checked == false && radioButton7.Checked == false)
            {
                MessageBox.Show("no answer on #2 question", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                var path = "/contact_tracing/contact_tracing/bin/Debug/my.txt";
                var dirName = Path.GetDirectoryName(path);

                string[] my_data = new string[6];
                my_data[0] = txtfname.Text;
                my_data[1] = txtfname.Text;
                my_data[2] = gender;
                my_data[3] = num_q1;
                my_data[4] = num_q2;
                my_data[5] = txtcon.Text;
                StreamReader sr = new StreamReader(@"my.txt");
                string old_data = sr.ReadLine();
                sr.Close();
                StreamWriter sw = new StreamWriter(@"my.txt");
                sw.WriteLine(old_data + (Environment.NewLine) +"First name"+my_data[0]+ (Environment.NewLine)+"Last name:"+my_data[1]+ (Environment.NewLine)+"Gender:"+my_data[2]+ (Environment.NewLine)+ "Have you traveled outside the country anytime from June 2021 until now?"+my_data[3]+(Environment.NewLine)+ "Have you come into contact with anyone who has traveled outside your country between the period of June 2021 until now?"+my_data[4]+(Environment.NewLine)+"Contact:"+my_data[5]);
                sw.Close();
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                gender = "Male";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                gender = "Female";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                gender = "others";
            }
        }
    }
}
