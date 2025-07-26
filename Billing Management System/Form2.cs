using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Billing_Management_System
{
    public partial class Form2 : Form
    {
        static string filePathbill = @"C:\Users\omeru\Desktop\PF Project\Database PF\bill.txt";

        public Form2()
        {
            InitializeComponent();

            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\bill.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    label62.Text = Convert.ToString(a1);
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label60.Text = Form1.SetValueForTextname;
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1;
            timer1.Tick += new System.EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToLongDateString();
            time.Text = DateTime.Now.ToLongTimeString();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(label11.Text);
            int b = Convert.ToInt32(label12.Text);
            int c = Convert.ToInt32(label13.Text);
            int d = Convert.ToInt32(label14.Text);
            int e1 = Convert.ToInt32(label15.Text);
            int f = Convert.ToInt32(label16.Text);
            int g = Convert.ToInt32(label17.Text);
            int h = Convert.ToInt32(label18.Text);
            int i = Convert.ToInt32(label19.Text);
            int j = Convert.ToInt32(label20.Text);
            int k = Convert.ToInt32(label21.Text);
            int l = Convert.ToInt32(label22.Text);
            int m = Convert.ToInt32(label23.Text);
            int n = Convert.ToInt32(label24.Text);
            int o = Convert.ToInt32(label25.Text);
            int p = Convert.ToInt32(label26.Text);
            int q = Convert.ToInt32(label27.Text);
            int r = Convert.ToInt32(label28.Text);
            int s = Convert.ToInt32(label29.Text);
            int t = Convert.ToInt32(label30.Text);
            int u = Convert.ToInt32(label31.Text);
            int v = Convert.ToInt32(label32.Text);
            int w = Convert.ToInt32(label33.Text);
            int x = Convert.ToInt32(label34.Text);
            int y = Convert.ToInt32(label35.Text);
            int z = Convert.ToInt32(label36.Text);
            int a1 = Convert.ToInt32(label37.Text);
            int a2 = Convert.ToInt32(label38.Text);
            int a3 = Convert.ToInt32(label39.Text);
            int a4 = Convert.ToInt32(label40.Text);
            int a5 = Convert.ToInt32(label41.Text);
            int a6 = Convert.ToInt32(label42.Text);
            int a7 = Convert.ToInt32(label43.Text);
            int a8 = Convert.ToInt32(label44.Text);
            int a9 = Convert.ToInt32(label45.Text);
            int a10 = Convert.ToInt32(label46.Text);
            int a11 = Convert.ToInt32(label47.Text);
            int a12 = Convert.ToInt32(label48.Text);
            int a13 = Convert.ToInt32(label49.Text);
            int a14 = Convert.ToInt32(label50.Text);
            int a15 = Convert.ToInt32(label51.Text);
            int a16 = Convert.ToInt32(label52.Text);
            int a17 = Convert.ToInt32(label53.Text);
            int a18 = Convert.ToInt32(label54.Text);
            int a19 = Convert.ToInt32(label55.Text);

            int all = a + b + c + d + e1 + f + g + h + i + j + k + l + m + n + o + p + q + r + s + t + u + v + w + x + y + z + a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11 + a12 + a13 + a14 + a15 + a16 + a17 + a18 + a19;
            label56.Text = all.ToString();

            int gst1;
            int gst;
            int dis;
            int dis1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\gst.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out gst1))
                {
                    gst = (all / 100)*gst1;
                    label57.Text = gst.ToString();
                }
            }

            string[] lines1 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\discount.txt");
            if (lines1.Length > 0)
            {
                string lastLine1 = lines1[lines1.Length - 1];

                if (int.TryParse(lastLine1, out dis1))
                {
                    dis = (all / 100) * dis1;
                    label63.Text = dis.ToString();
                }
            }
            int omer = Convert.ToInt32(label57.Text);
            int ali = Convert.ToInt32(label63.Text);
            int sub = all + omer - ali;
            label58.Text = sub.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText("\n");
            richTextBox1.AppendText("*********************************************************************************" + "\n");
            richTextBox1.AppendText("\t" + "\t" + "\t" + "BILL RECEIPT" + "\n");
            richTextBox1.AppendText("*********************************************************************************" + "\n");
            richTextBox1.AppendText("Cashier Name: " + Form1.SetValueForTextname + "\n");
            richTextBox1.AppendText("Invoice No.: " + label62.Text + "\n");
            richTextBox1.AppendText("Time: " + time.Text + "\n");
            richTextBox1.AppendText("Date: " + date.Text + "\n");
            richTextBox1.AppendText("Name: " + textBox1.Text + "\n");
            richTextBox1.AppendText("Phone No. : " + textBox2.Text + "\n");
            richTextBox1.AppendText("*********************************************************************************" + "\n");
            richTextBox1.AppendText("Sales Items" + "\t" + "\t" + "\t" + "Qty" + "\t" + "           Price" + "\n");
            richTextBox1.AppendText("*********************************************************************************" + "\n");
            if (numericUpDown1.Value > 0)
            {
                richTextBox1.AppendText(l1.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown1.Value + "\t" + "           Rs." + label11.Text + "\n");
            }
            if (numericUpDown2.Value > 0)
            {
                richTextBox1.AppendText(l2.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown2.Value + "\t" + "           Rs." + label12.Text + "\n");
            }
            if (numericUpDown3.Value > 0)
            {
                richTextBox1.AppendText(l3.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown3.Value + "\t" + "           Rs." + label13.Text + "\n");
            }
            if (Down4.Value > 0)
            {
                richTextBox1.AppendText(l4.Text + "\t" + "\t" + "\t" + "\t" + Down4.Value + "\t" + "           Rs." + label14.Text + "\n");
            }
            if (numericUpDown5.Value > 0)
            {
                richTextBox1.AppendText(l5.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown5.Value + "\t" + "           Rs." + label15.Text + "\n");
            }
            if (numericUpDown6.Value > 0)
            {
                richTextBox1.AppendText(l6.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown6.Value + "\t" + "           Rs." + label16.Text + "\n");
            }
            if (numericUpDown7.Value > 0)
            {
                richTextBox1.AppendText(l7.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown7.Value + "\t" + "           Rs." + label17.Text + "\n");
            }
            if (numericUpDown8.Value > 0)
            {
                richTextBox1.AppendText(l8.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown8.Value + "\t" + "           Rs." + label18.Text + "\n");
            }
            if (numericUpDown9.Value > 0)
            {
                richTextBox1.AppendText(l9.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown9.Value + "\t" + "           Rs." + label19.Text + "\n");
            }
            if (numericUpDown10.Value > 0)
            {
                richTextBox1.AppendText(l10.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown10.Value + "\t" + "           Rs." + label20.Text + "\n");
            }
            if (numericUpDown11.Value > 0)
            {
                richTextBox1.AppendText(l11.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown11.Value + "\t" + "           Rs." + label21.Text + "\n");
            }
            if (numericUpDown12.Value > 0)
            {
                richTextBox1.AppendText(l12.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown12.Value + "\t" + "           Rs." + label22.Text + "\n");
            }
            if (numericUpDown13.Value > 0)
            {
                richTextBox1.AppendText(l13.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown13.Value + "\t" + "           Rs." + label23.Text + "\n");
            }
            if (numericUpDown14.Value > 0)
            {
                richTextBox1.AppendText(l14.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown14.Value + "\t" + "           Rs." + label24.Text + "\n");
            }
            if (numericUpDown15.Value > 0)
            {
                richTextBox1.AppendText(l15.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown15.Value + "\t" + "           Rs." + label25.Text + "\n");
            }
            if (numericUpDown30.Value > 0)
            {
                richTextBox1.AppendText(l16.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown30.Value + "\t" + "           Rs." + label26.Text + "\n");
            }
            if (numericUpDown29.Value > 0)
            {
                richTextBox1.AppendText(l17.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown29.Value + "\t" + "           Rs." + label27.Text + "\n");
            }
            if (numericUpDown28.Value > 0)
            {
                richTextBox1.AppendText(l18.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown28.Value + "\t" + "           Rs." + label28.Text + "\n");
            }
            if (numericUpDown27.Value > 0)
            {
                richTextBox1.AppendText(l19.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown27.Value + "\t" + "           Rs." + label29.Text + "\n");
            }
            if (numericUpDown26.Value > 0)
            {
                richTextBox1.AppendText(l20.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown26.Value + "\t" + "           Rs." + label30.Text + "\n");
            }
            if (numericUpDown25.Value > 0)
            {
                richTextBox1.AppendText(l21.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown25.Value + "\t" + "           Rs." + label31.Text + "\n");
            }
            if (numericUpDown24.Value > 0)
            {
                richTextBox1.AppendText(l22.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown24.Value + "\t" + "           Rs." + label32.Text + "\n");
            }
            if (numericUpDown23.Value > 0)
            {
                richTextBox1.AppendText(l23.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown23.Value + "\t" + "           Rs." + label33.Text + "\n");
            }
            if (numericUpDown22.Value > 0)
            {
                richTextBox1.AppendText(l24.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown22.Value + "\t" + "           Rs." + label34.Text + "\n");
            }
            if (numericUpDown21.Value > 0)
            {
                richTextBox1.AppendText(l25.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown21.Value + "\t" + "           Rs." + label35.Text + "\n");
            }
            if (numericUpDown20.Value > 0)
            {
                richTextBox1.AppendText(l26.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown20.Value + "\t" + "           Rs." + label36.Text + "\n");
            }
            if (numericUpDown19.Value > 0)
            {
                richTextBox1.AppendText(l27.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown19.Value + "\t" + "           Rs." + label37.Text + "\n");
            }
            if (numericUpDown18.Value > 0)
            {
                richTextBox1.AppendText(l28.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown18.Value + "\t" + "           Rs." + label38.Text + "\n");
            }
            if (numericUpDown17.Value > 0)
            {
                richTextBox1.AppendText(l29.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown17.Value + "\t" + "           Rs." + label39.Text + "\n");
            }
            if (numericUpDown16.Value > 0)
            {
                richTextBox1.AppendText(l30.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown16.Value + "\t" + "           Rs." + label40.Text + "\n");
            }
            if (numericUpDown45.Value > 0)
            {
                richTextBox1.AppendText(l31.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown45.Value + "\t" + "           Rs." + label41.Text + "\n");
            }
            if (numericUpDown44.Value > 0)
            {
                richTextBox1.AppendText(l32.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown44.Value + "\t" + "           Rs." + label42.Text + "\n");
            }
            if (numericUpDown43.Value > 0)
            {
                richTextBox1.AppendText(l33.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown43.Value + "\t" + "           Rs." + label43.Text + "\n");
            }
            if (numericUpDown42.Value > 0)
            {
                richTextBox1.AppendText(l34.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown42.Value + "\t" + "           Rs." + label44.Text + "\n");
            }
            if (numericUpDown41.Value > 0)
            {
                richTextBox1.AppendText(l35.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown41.Value + "\t" + "           Rs." + label45.Text + "\n");
            }
            if (numericUpDown40.Value > 0)
            {
                richTextBox1.AppendText(l36.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown40.Value + "\t" + "           Rs." + label46.Text + "\n");
            }
            if (numericUpDown39.Value > 0)
            {
                richTextBox1.AppendText(l37.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown39.Value + "\t" + "           Rs." + label47.Text + "\n");
            }
            if (numericUpDown38.Value > 0)
            {
                richTextBox1.AppendText(l38.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown38.Value + "\t" + "           Rs." + label48.Text + "\n");
            }
            if (numericUpDown37.Value > 0)
            {
                richTextBox1.AppendText(l39.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown37.Value + "\t" + "           Rs." + label49.Text + "\n");
            }
            if (numericUpDown36.Value > 0)
            {
                richTextBox1.AppendText(l40.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown36.Value + "\t" + "           Rs." + label50.Text + "\n");
            }
            if (numericUpDown35.Value > 0)
            {
                richTextBox1.AppendText(l41.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown35.Value + "\t" + "           Rs." + label51.Text + "\n");
            }
            if (numericUpDown34.Value > 0)
            {
                richTextBox1.AppendText(l42.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown34.Value + "\t" + "           Rs." + label52.Text + "\n");
            }
            if (numericUpDown33.Value > 0)
            {
                richTextBox1.AppendText(l43.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown33.Value + "\t" + "           Rs." + label53.Text + "\n");
            }
            if (numericUpDown32.Value > 0)
            {
                richTextBox1.AppendText(l44.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown32.Value + "\t" + "           Rs." + label54.Text + "\n");
            }
            if (numericUpDown31.Value > 0)
            {
                richTextBox1.AppendText(l45.Text + "\t" + "\t" + "\t" + "\t" + numericUpDown31.Value + "\t" + "           Rs." + label55.Text + "\n");
            }
            richTextBox1.AppendText("*********************************************************************************" + "\n");
            richTextBox1.AppendText(label104.Text + "\t" + "\t" + "\t" + "\t" + "\t" + "           Rs." + label56.Text + "\n");
            richTextBox1.AppendText(label102.Text + "\t" + "\t" + "\t" + "\t" + "\t" + "           Rs." + label57.Text + "\n");
            richTextBox1.AppendText("Disc." + "\t" + "\t" + "\t" + "\t" + "\t" + "           Rs.- " + label63.Text + "\n");
            richTextBox1.AppendText("*********************************************************************************" + "\n");
            richTextBox1.AppendText(label100.Text + "\t" + "\t" + "\t" + "\t" + "\t" + "           Rs." + label58.Text + "\n");
            richTextBox1.AppendText("*********************************************************************************" + "\n");
            richTextBox1.AppendText("\t" + "      NO RETURN NO EXCHANGE NO REFUND" + "\n");
            richTextBox1.AppendText("*********************************************************************************" + "\n");
            richTextBox1.AppendText("\t" + "\t" + "\t" + "  THANK YOU!" + "\n");
            richTextBox1.AppendText("*********************************************************************************" + "\n");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Billing Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                System.Drawing.Font fntstring = new System.Drawing.Font("Arial", 18, FontStyle.Regular);
                e.Graphics.DrawString(richTextBox1.Text, fntstring, Brushes.Black, 15, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Billing Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p1.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown1.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label11.Text = a2.ToString();
                }
            }
            
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p2.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown2.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label12.Text = a2.ToString();
                }
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p3.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown3.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label13.Text = a2.ToString();
                }
            }
        }

        private void Down4_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p4.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(Down4.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label14.Text = a2.ToString();
                }
            }
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p5.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown5.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label15.Text = a2.ToString();
                }
            }
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p6.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown6.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label16.Text = a2.ToString();
                }
            }
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p7.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown7.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label17.Text = a2.ToString();
                }
            }
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p8.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown8.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label18.Text = a2.ToString();
                }
            }
        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p9.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown9.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label19.Text = a2.ToString();
                }
            }
        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p10.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown10.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label20.Text = a2.ToString();
                }
            }
        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p11.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown11.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label21.Text = a2.ToString();
                }
            }
        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p12.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown12.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label22.Text = a2.ToString();
                }
            }
        }

        private void numericUpDown13_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p13.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown13.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label23.Text = a2.ToString();
                }
            }
        }

        private void numericUpDown14_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p14.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown14.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label24.Text = a2.ToString();
                }
            }
        }

        private void numericUpDown15_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p15.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown15.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label25.Text = a2.ToString();
                }
            }
        }

        private void numericUpDown16_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p30.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown16.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label40.Text = a2.ToString();
                }
            }

        }

        private void numericUpDown17_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p29.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown17.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label39.Text = a2.ToString();
                }
            }
        }

        private void numericUpDown18_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p28.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown18.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label38.Text = a2.ToString();
                }
            }
        }

        private void numericUpDown19_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p27.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown19.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label37.Text = a2.ToString();
                }
            }
        }

        private void numericUpDown20_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p26.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown20.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label36.Text = a2.ToString();
                }
            }

        }

        private void numericUpDown21_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p25.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown21.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label35.Text = a2.ToString();
                }
            }
        }

        private void numericUpDown22_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p24.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown22.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label34.Text = a2.ToString();
                }
            }
        }

        private void numericUpDown23_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p23.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown23.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label33.Text = a2.ToString();
                }
            }
        }

        private void numericUpDown24_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p22.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown24.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label32.Text = a2.ToString();
                }
            }
        }

        private void numericUpDown25_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p21.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown25.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label31.Text = a2.ToString();
                }
            }
        }

        private void numericUpDown26_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p20.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown26.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label30.Text = a2.ToString();
                }
            }
        }

        private void numericUpDown27_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p19.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown27.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label29.Text = a2.ToString();
                }
            }
        }

        private void numericUpDown28_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p18.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown28.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label28.Text = a2.ToString();
                }
            }
        }

        private void numericUpDown29_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p17.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown29.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label27.Text = a2.ToString();
                }
            }
        }

        private void numericUpDown30_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p16.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown30.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label26.Text = a2.ToString();
                }
            }
        }

        private void numericUpDown45_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p31.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown45.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label41.Text = a2.ToString();
                }
            }

        }

        private void numericUpDown31_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p45.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown31.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label55.Text = a2.ToString();
                }
            }

        }

        private void numericUpDown32_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p44.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown32.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label54.Text = a2.ToString();
                }
            }
        }

        private void numericUpDown33_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p43.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown33.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label53.Text = a2.ToString();
                }
            }

        }

        private void numericUpDown34_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p42.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown34.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label52.Text = a2.ToString();
                }
            }
        }

        private void numericUpDown35_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p41.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown35.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label51.Text = a2.ToString();
                }
            }

        }

        private void numericUpDown36_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p40.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown36.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label50.Text = a2.ToString();
                }
            }

        }

        private void numericUpDown37_ValueChanged(object sender, EventArgs e)
        {

            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p39.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown37.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label49.Text = a2.ToString();
                }
            }
        }

        private void numericUpDown38_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p38.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown38.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label48.Text = a2.ToString();
                }
            }
        }

        private void numericUpDown39_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p37.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown39.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label47.Text = a2.ToString();
                }
            }

        }

        private void numericUpDown40_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p36.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown40.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label46.Text = a2.ToString();
                }
            }

        }

        private void numericUpDown41_ValueChanged(object sender, EventArgs e)
        {

            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p35.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown41.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label45.Text = a2.ToString();
                }
            }
        }

        private void numericUpDown42_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p34.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown42.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label44.Text = a2.ToString();
                }
            }

        }

        private void numericUpDown43_ValueChanged(object sender, EventArgs e)
        {
            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p33.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown43.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label43.Text = a2.ToString();
                }
            }

        }

        private void numericUpDown44_ValueChanged(object sender, EventArgs e)
        {

            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p32.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    String a = Convert.ToString(a1);
                    int i = Convert.ToInt32(numericUpDown44.Value);
                    int a2 = i * Convert.ToInt32(a);
                    label42.Text = a2.ToString();
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //PrintDialog printdialog1 = new PrintDialog();
            //printdialog1.Document = printDocument1;

            //DialogResult result = printdialog1.ShowDialog();

            //if (result == DialogResult.OK)
            //{
            //    printDocument1.PrinterSettings.PrintFileName = "Ali.pdf";
            //    printDocument1.Print();
            //}


            PrintDialog printdialog1 = new PrintDialog();
            PrintDocument printDocument1 = new PrintDocument();
            printdialog1.Document = printDocument1;

            printDocument1.DocumentName = "Invoice_No_"+label62.Text;

            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            DialogResult result = printdialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Print the document
                printDocument1.Print();
            }



            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\bill.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    using (StreamWriter writer = new StreamWriter(filePathbill, true))
                    {
                        writer.WriteLine(a1 += 1);
                        label62.Text = Convert.ToString(a1);
                    }
                }
            }

            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            Down4.Value = 0;
            numericUpDown5.Value = 0;
            numericUpDown6.Value = 0;
            numericUpDown7.Value = 0;
            numericUpDown8.Value = 0;
            numericUpDown9.Value = 0;
            numericUpDown10.Value = 0;
            numericUpDown11.Value = 0;
            numericUpDown12.Value = 0;
            numericUpDown13.Value = 0;
            numericUpDown14.Value = 0;
            numericUpDown15.Value = 0;
            numericUpDown16.Value = 0;
            numericUpDown17.Value = 0;
            numericUpDown18.Value = 0;
            numericUpDown19.Value = 0;
            numericUpDown20.Value = 0;
            numericUpDown21.Value = 0;
            numericUpDown22.Value = 0;
            numericUpDown23.Value = 0;
            numericUpDown24.Value = 0;
            numericUpDown25.Value = 0;
            numericUpDown26.Value = 0;
            numericUpDown27.Value = 0;
            numericUpDown28.Value = 0;
            numericUpDown29.Value = 0;
            numericUpDown30.Value = 0;
            numericUpDown31.Value = 0;
            numericUpDown32.Value = 0;
            numericUpDown33.Value = 0;
            numericUpDown34.Value = 0;
            numericUpDown35.Value = 0;
            numericUpDown36.Value = 0;
            numericUpDown37.Value = 0;
            numericUpDown38.Value = 0;
            numericUpDown39.Value = 0;
            numericUpDown40.Value = 0;
            numericUpDown41.Value = 0;
            numericUpDown42.Value = 0;
            numericUpDown43.Value = 0;
            numericUpDown44.Value = 0;
            numericUpDown45.Value = 0;
            richTextBox1.Clear();
            textBox1.Clear();
            textBox2.Clear();
            label11.Text = "0";
            label12.Text = "0";
            label13.Text = "0";
            label14.Text = "0";
            label15.Text = "0";
            label16.Text = "0";
            label17.Text = "0";
            label18.Text = "0";
            label19.Text = "0";
            label20.Text = "0";
            label21.Text = "0";
            label22.Text = "0";
            label23.Text = "0";
            label24.Text = "0";
            label25.Text = "0";
            label26.Text = "0";
            label27.Text = "0";
            label28.Text = "0";
            label29.Text = "0";
            label30.Text = "0";
            label31.Text = "0";
            label32.Text = "0";
            label33.Text = "0";
            label34.Text = "0";
            label35.Text = "0";
            label36.Text = "0";
            label37.Text = "0";
            label38.Text = "0";
            label39.Text = "0";
            label40.Text = "0";
            label41.Text = "0";
            label42.Text = "0";
            label43.Text = "0";
            label44.Text = "0";
            label45.Text = "0";
            label46.Text = "0";
            label47.Text = "0";
            label48.Text = "0";
            label49.Text = "0";
            label50.Text = "0";
            label51.Text = "0";
            label52.Text = "0";
            label53.Text = "0";
            label54.Text = "0";
            label55.Text = "0";
            label56.Text = "0";
            label57.Text = "0";
            label58.Text = "0";
            label63.Text = "0";
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
        }

        private void label62_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            Down4.Value = 0;
            numericUpDown5.Value = 0;
            numericUpDown6.Value = 0;
            numericUpDown7.Value = 0;
            numericUpDown8.Value = 0;
            numericUpDown9.Value = 0;
            numericUpDown10.Value = 0;
            numericUpDown11.Value = 0;
            numericUpDown12.Value = 0;
            numericUpDown13.Value = 0;
            numericUpDown14.Value = 0;
            numericUpDown15.Value = 0;
            numericUpDown16.Value = 0;
            numericUpDown17.Value = 0;
            numericUpDown18.Value = 0;
            numericUpDown19.Value = 0;
            numericUpDown20.Value = 0;
            numericUpDown21.Value = 0;
            numericUpDown22.Value = 0;
            numericUpDown23.Value = 0;
            numericUpDown24.Value = 0;
            numericUpDown25.Value = 0;
            numericUpDown26.Value = 0;
            numericUpDown27.Value = 0;
            numericUpDown28.Value = 0;
            numericUpDown29.Value = 0;
            numericUpDown30.Value = 0;
            numericUpDown31.Value = 0;
            numericUpDown32.Value = 0;
            numericUpDown33.Value = 0;
            numericUpDown34.Value = 0;
            numericUpDown35.Value = 0;
            numericUpDown36.Value = 0;
            numericUpDown37.Value = 0;
            numericUpDown38.Value = 0;
            numericUpDown39.Value = 0;
            numericUpDown40.Value = 0;
            numericUpDown41.Value = 0;
            numericUpDown42.Value = 0;
            numericUpDown43.Value = 0;
            numericUpDown44.Value = 0;
            numericUpDown45.Value = 0;
            richTextBox1.Clear();
            textBox1.Clear();
            textBox2.Clear();
            label11.Text = "0";
            label12.Text = "0";
            label13.Text = "0";
            label14.Text = "0";
            label15.Text = "0";
            label16.Text = "0";
            label17.Text = "0";
            label18.Text = "0";
            label19.Text = "0";
            label20.Text = "0";
            label21.Text = "0";
            label22.Text = "0";
            label23.Text = "0";
            label24.Text = "0";
            label25.Text = "0";
            label26.Text = "0";
            label27.Text = "0";
            label28.Text = "0";
            label29.Text = "0";
            label30.Text = "0";
            label31.Text = "0";
            label32.Text = "0";
            label33.Text = "0";
            label34.Text = "0";
            label35.Text = "0";
            label36.Text = "0";
            label37.Text = "0";
            label38.Text = "0";
            label39.Text = "0";
            label40.Text = "0";
            label41.Text = "0";
            label42.Text = "0";
            label43.Text = "0";
            label44.Text = "0";
            label45.Text = "0";
            label46.Text = "0";
            label47.Text = "0";
            label48.Text = "0";
            label49.Text = "0";
            label50.Text = "0";
            label51.Text = "0";
            label52.Text = "0";
            label53.Text = "0";
            label54.Text = "0";
            label55.Text = "0";
            label56.Text = "0";
            label57.Text = "0";
            label58.Text = "0";
            label63.Text = "0";
        }
    }
}
