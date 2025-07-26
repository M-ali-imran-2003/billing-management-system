using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Billing_Management_System
{
    public partial class Form1 : Form
    {
        public static string SetValueForTextname = "";
        public Form1()
        {
            InitializeComponent();
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines46 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\user1.txt");
            if (lines46.Length != 0)
            {
                string lastLine46 = lines46[lines46.Length - 1];

                string[] lines47 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\user2.txt");
                if (lines47.Length != 0)
                {
                    string lastLine47 = lines47[lines47.Length - 1];

                string[] lines48 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\user3.txt");
                if (lines48.Length != 0)
                {
                    string lastLine48 = lines48[lines48.Length - 1];

                string[] lines49 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\user4.txt");
                if (lines49.Length != 0)
                {
                    string lastLine49 = lines49[lines49.Length - 1];

                if (textBox1.Text == "omerullah ansari" && textBox2.Text == lastLine46 || textBox1.Text == "bilal hassan" && textBox2.Text == lastLine47 || textBox1.Text == "ali imran" && textBox2.Text == lastLine48 || textBox1.Text == "sir ahmed" && textBox2.Text == lastLine49)
                {
                    SetValueForTextname = textBox1.Text;
                    string d1 = "";
                    label4.Text = d1.ToString();
                    this.Hide();
                    Form2 form2 = new Form2();
                    form2.ShowDialog();
                }
                else if (textBox1.Text == "admin" && textBox2.Text == "4994admin")
                {
                    SetValueForTextname = textBox1.Text;
                    string d1 = "";
                    label4.Text = d1.ToString();
                    this.Hide();
                    Form3 form3 = new Form3();
                    form3.ShowDialog();
                }
                else
                {
                    string d1 = "Invalid Username Or Password";
                    label4.Text = d1.ToString();
                }
            }
                    }
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
