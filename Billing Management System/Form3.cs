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
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Billing_Management_System
{
    public partial class Form3 : Form
    {

        static string filePath = @"C:\Users\omeru\Desktop\PF Project\Database PF\p1.txt";
        static string filePath2 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p2.txt";
        static string filePath3 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p3.txt";
        static string filePath4 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p4.txt";
        static string filePath5 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p5.txt";
        static string filePath6 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p6.txt";
        static string filePath7 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p7.txt";
        static string filePath8 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p8.txt";
        static string filePath9 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p9.txt";
        static string filePath10 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p10.txt";
        static string filePath11 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p11.txt";
        static string filePath12 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p12.txt";
        static string filePath13 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p13.txt";
        static string filePath14 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p14.txt";
        static string filePath15 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p15.txt";
        static string filePath16 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p16.txt";
        static string filePath17 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p17.txt";
        static string filePath18 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p18.txt";
        static string filePath19 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p19.txt";
        static string filePath20 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p20.txt";
        static string filePath21 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p21.txt";
        static string filePath22 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p22.txt";
        static string filePath23 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p23.txt";
        static string filePath24 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p24.txt";
        static string filePath25 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p25.txt";
        static string filePath26 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p26.txt";
        static string filePath27 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p27.txt";
        static string filePath28 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p28.txt";
        static string filePath29 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p29.txt";
        static string filePath30 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p30.txt";
        static string filePath31 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p31.txt";
        static string filePath32 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p32.txt";
        static string filePath33 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p33.txt";
        static string filePath34 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p34.txt";
        static string filePath35 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p35.txt";
        static string filePath36 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p36.txt";
        static string filePath37 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p37.txt";
        static string filePath38 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p38.txt";
        static string filePath39 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p39.txt";
        static string filePath40 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p40.txt";
        static string filePath41 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p41.txt";
        static string filePath42 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p42.txt";
        static string filePath43 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p43.txt";
        static string filePath44 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p44.txt";
        static string filePath45 = @"C:\Users\omeru\Desktop\PF Project\Database PF\p45.txt";

        static string filePathuser1 = @"C:\Users\omeru\Desktop\PF Project\Database PF\user1.txt";
        static string filePathuser2 = @"C:\Users\omeru\Desktop\PF Project\Database PF\user2.txt";
        static string filePathuser3 = @"C:\Users\omeru\Desktop\PF Project\Database PF\user3.txt";
        static string filePathuser4 = @"C:\Users\omeru\Desktop\PF Project\Database PF\user4.txt";

        static string filePathgst = @"C:\Users\omeru\Desktop\PF Project\Database PF\gst.txt";
        static string filePathdiscount = @"C:\Users\omeru\Desktop\PF Project\Database PF\discount.txt";



        public Form3()
        {
            InitializeComponent();

            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p1.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    label41.Text = Convert.ToString(a1);
                }
            }

            int a2;
            string[] lines2 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p2.txt");
            if (lines2.Length > 0)
            {
                string lastLine2 = lines2[lines2.Length - 1];

                if (int.TryParse(lastLine2, out a2))
                {
                    label7.Text = Convert.ToString(a2);
                }
            }

            int a3;
            string[] lines3 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p3.txt");
            if (lines3.Length > 0)
            {
                string lastLine3 = lines3[lines3.Length - 1];

                if (int.TryParse(lastLine3, out a3))
                {
                    label8.Text = Convert.ToString(a3);
                }
            }

            int a4;
            string[] lines4 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p4.txt");
            if (lines4.Length > 0)
            {
                string lastLine4 = lines4[lines4.Length - 1];

                if (int.TryParse(lastLine4, out a4))
                {
                    label9.Text = Convert.ToString(a4);
                }
            }

            int a5;
            string[] lines5 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p5.txt");
            if (lines5.Length > 0)
            {
                string lastLine5 = lines5[lines5.Length - 1];

                if (int.TryParse(lastLine5, out a5))
                {
                    label11.Text = Convert.ToString(a5);
                }
            }

            int a6;
            string[] lines6 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p6.txt");
            if (lines6.Length > 0)
            {
                string lastLine6 = lines6[lines6.Length - 1];

                if (int.TryParse(lastLine6, out a6))
                {
                    label12.Text = Convert.ToString(a6);
                }
            }

            int a7;
            string[] lines7 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p7.txt");
            if (lines7.Length > 0)
            {
                string lastLine7 = lines7[lines7.Length - 1];

                if (int.TryParse(lastLine7, out a7))
                {
                    label13.Text = Convert.ToString(a7);
                }
            }

            int a8;
            string[] lines8 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p8.txt");
            if (lines8.Length > 0)
            {
                string lastLine8 = lines8[lines8.Length - 1];

                if (int.TryParse(lastLine8, out a8))
                {
                    label14.Text = Convert.ToString(a8);
                }
            }

            int a9;
            string[] lines9 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p9.txt");
            if (lines9.Length > 0)
            {
                string lastLine9 = lines9[lines9.Length - 1];

                if (int.TryParse(lastLine9, out a9))
                {
                    label15.Text = Convert.ToString(a9);
                }
            }

            int a10;
            string[] lines10 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p10.txt");
            if (lines10.Length > 0)
            {
                string lastLine10 = lines10[lines10.Length - 1];

                if (int.TryParse(lastLine10, out a10))
                {
                    label16.Text = Convert.ToString(a10);
                }
            }

            int a11;
            string[] lines11 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p11.txt");
            if (lines11.Length > 0)
            {
                string lastLine11 = lines11[lines11.Length - 1];

                if (int.TryParse(lastLine11, out a11))
                {
                    label17.Text = Convert.ToString(a11);
                }
            }

            int a12;
            string[] lines12 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p12.txt");
            if (lines12.Length > 0)
            {
                string lastLine12 = lines12[lines12.Length - 1];

                if (int.TryParse(lastLine12, out a12))
                {
                    label18.Text = Convert.ToString(a12);
                }
            }

            int a13;
            string[] lines13 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p13.txt");
            if (lines13.Length > 0)
            {
                string lastLine13 = lines13[lines13.Length - 1];

                if (int.TryParse(lastLine13, out a13))
                {
                    label19.Text = Convert.ToString(a13);
                }
            }

            int a14;
            string[] lines14 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p14.txt");
            if (lines14.Length > 0)
            {
                string lastLine14 = lines14[lines14.Length - 1];

                if (int.TryParse(lastLine14, out a14))
                {
                    label20.Text = Convert.ToString(a14);
                }
            }

            int a15;
            string[] lines15 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p15.txt");
            if (lines15.Length > 0)
            {
                string lastLine15 = lines15[lines15.Length - 1];

                if (int.TryParse(lastLine15, out a15))
                {
                    label21.Text = Convert.ToString(a15);
                }
            }

            int a16;
            string[] lines16 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p16.txt");
            if (lines16.Length > 0)
            {
                string lastLine16 = lines16[lines16.Length - 1];

                if (int.TryParse(lastLine16, out a16))
                {
                    label36.Text = Convert.ToString(a16);
                }
            }

            int a17;
            string[] lines17 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p17.txt");
            if (lines17.Length > 0)
            {
                string lastLine17 = lines17[lines17.Length - 1];

                if (int.TryParse(lastLine17, out a17))
                {
                    label35.Text = Convert.ToString(a17);
                }
            }

            int a18;
            string[] lines18 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p18.txt");
            if (lines18.Length > 0)
            {
                string lastLine18 = lines18[lines18.Length - 1];

                if (int.TryParse(lastLine18, out a18))
                {
                    label34.Text = Convert.ToString(a18);
                }
            }

            int a19;
            string[] lines19 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p19.txt");
            if (lines19.Length > 0)
            {
                string lastLine19 = lines19[lines19.Length - 1];

                if (int.TryParse(lastLine19, out a19))
                {
                    label33.Text = Convert.ToString(a19);
                }
            }

            int a20;
            string[] lines20 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p20.txt");
            if (lines20.Length > 0)
            {
                string lastLine20 = lines20[lines20.Length - 1];

                if (int.TryParse(lastLine20, out a20))
                {
                    label32.Text = Convert.ToString(a20);
                }
            }

            int a21;
            string[] lines21 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p21.txt");
            if (lines21.Length > 0)
            {
                string lastLine21 = lines21[lines21.Length - 1];

                if (int.TryParse(lastLine21, out a21))
                {
                    label31.Text = Convert.ToString(a21);
                }
            }

            int a22;
            string[] lines22 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p22.txt");
            if (lines22.Length > 0)
            {
                string lastLine22 = lines22[lines22.Length - 1];

                if (int.TryParse(lastLine22, out a22))
                {
                    label30.Text = Convert.ToString(a22);
                }
            }

            int a23;
            string[] lines23 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p23.txt");
            if (lines23.Length > 0)
            {
                string lastLine23 = lines23[lines23.Length - 1];

                if (int.TryParse(lastLine23, out a23))
                {
                    label29.Text = Convert.ToString(a23);
                }
            }

            int a24;
            string[] lines24 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p24.txt");
            if (lines24.Length > 0)
            {
                string lastLine24 = lines24[lines24.Length - 1];

                if (int.TryParse(lastLine24, out a24))
                {
                    label28.Text = Convert.ToString(a24);
                }
            }

            int a25;
            string[] lines25 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p25.txt");
            if (lines25.Length > 0)
            {
                string lastLine25 = lines25[lines25.Length - 1];

                if (int.TryParse(lastLine25, out a25))
                {
                    label27.Text = Convert.ToString(a25);
                }
            }

            int a26;
            string[] lines26 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p26.txt");
            if (lines26.Length > 0)
            {
                string lastLine26 = lines26[lines26.Length - 1];

                if (int.TryParse(lastLine26, out a26))
                {
                    label26.Text = Convert.ToString(a26);
                }
            }

            int a27;
            string[] lines27 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p27.txt");
            if (lines27.Length > 0)
            {
                string lastLine27 = lines27[lines27.Length - 1];

                if (int.TryParse(lastLine27, out a27))
                {
                    label25.Text = Convert.ToString(a27);
                }
            }

            int a28;
            string[] lines28 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p28.txt");
            if (lines28.Length > 0)
            {
                string lastLine28 = lines28[lines28.Length - 1];

                if (int.TryParse(lastLine28, out a28))
                {
                    label24.Text = Convert.ToString(a28);
                }
            }

            int a29;
            string[] lines29 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p29.txt");
            if (lines29.Length > 0)
            {
                string lastLine29 = lines29[lines29.Length - 1];

                if (int.TryParse(lastLine29, out a29))
                {
                    label23.Text = Convert.ToString(a29);
                }
            }

            int a30;
            string[] lines30 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p30.txt");
            if (lines30.Length > 0)
            {
                string lastLine30 = lines30[lines30.Length - 1];

                if (int.TryParse(lastLine30, out a30))
                {
                    label22.Text = Convert.ToString(a30);
                }
            }

            int a31;
            string[] lines31 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p31.txt");
            if (lines31.Length > 0)
            {
                string lastLine31 = lines31[lines31.Length - 1];

                if (int.TryParse(lastLine31, out a31))
                {
                    label52.Text = Convert.ToString(a31);
                }
            }

            int a32;
            string[] lines32 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p32.txt");
            if (lines32.Length > 0)
            {
                string lastLine32 = lines32[lines32.Length - 1];

                if (int.TryParse(lastLine32, out a32))
                {
                    label51.Text = Convert.ToString(a32);
                }
            }

            int a33;
            string[] lines33 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p33.txt");
            if (lines33.Length > 0)
            {
                string lastLine33 = lines33[lines33.Length - 1];

                if (int.TryParse(lastLine33, out a33))
                {
                    label50.Text = Convert.ToString(a33);
                }
            }

            int a34;
            string[] lines34 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p34.txt");
            if (lines34.Length > 0)
            {
                string lastLine34 = lines34[lines34.Length - 1];

                if (int.TryParse(lastLine34, out a34))
                {
                    label49.Text = Convert.ToString(a34);
                }
            }

            int a35;
            string[] lines35 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p35.txt");
            if (lines35.Length > 0)
            {
                string lastLine35 = lines35[lines35.Length - 1];

                if (int.TryParse(lastLine35, out a35))
                {
                    label48.Text = Convert.ToString(a35);
                }
            }

            int a36;
            string[] lines36 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p36.txt");
            if (lines36.Length > 0)
            {
                string lastLine36 = lines36[lines36.Length - 1];

                if (int.TryParse(lastLine36, out a36))
                {
                    label47.Text = Convert.ToString(a36);
                }
            }

            int a37;
            string[] lines37 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p37.txt");
            if (lines37.Length > 0)
            {
                string lastLine37 = lines37[lines37.Length - 1];

                if (int.TryParse(lastLine37, out a37))
                {
                    label46.Text = Convert.ToString(a37);
                }
            }

            int a38;
            string[] lines38 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p38.txt");
            if (lines38.Length > 0)
            {
                string lastLine38 = lines38[lines38.Length - 1];

                if (int.TryParse(lastLine38, out a38))
                {
                    label45.Text = Convert.ToString(a38);
                }
            }

            int a39;
            string[] lines39 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p39.txt");
            if (lines39.Length > 0)
            {
                string lastLine39 = lines39[lines39.Length - 1];

                if (int.TryParse(lastLine39, out a39))
                {
                    label44.Text = Convert.ToString(a39);
                }
            }

            int a40;
            string[] lines40 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p40.txt");
            if (lines40.Length > 0)
            {
                string lastLine40 = lines40[lines40.Length - 1];

                if (int.TryParse(lastLine40, out a40))
                {
                    label43.Text = Convert.ToString(a40);
                }
            }

            int a41;
            string[] lines41 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p41.txt");
            if (lines41.Length > 0)
            {
                string lastLine41 = lines41[lines41.Length - 1];

                if (int.TryParse(lastLine41, out a41))
                {
                    label42.Text = Convert.ToString(a41);
                }
            }

            int a42;
            string[] lines42 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p42.txt");
            if (lines42.Length > 0)
            {
                string lastLine42 = lines42[lines42.Length - 1];

                if (int.TryParse(lastLine42, out a42))
                {
                    label40.Text = Convert.ToString(a42);
                }
            }

            int a43;
            string[] lines43 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p43.txt");
            if (lines43.Length > 0)
            {
                string lastLine43 = lines43[lines43.Length - 1];

                if (int.TryParse(lastLine43, out a43))
                {
                    label39.Text = Convert.ToString(a43);
                }
            }

            int a44;
            string[] lines44 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p44.txt");
            if (lines44.Length > 0)
            {
                string lastLine44 = lines44[lines44.Length - 1];

                if (int.TryParse(lastLine44, out a44))
                {
                    label38.Text = Convert.ToString(a44);
                }
            }

            int a45;
            string[] lines45 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p45.txt");
            if (lines45.Length > 0)
            {
                string lastLine45 = lines45[lines45.Length - 1];

                if (int.TryParse(lastLine45, out a45))
                {
                    label37.Text = Convert.ToString(a45);
                }
            }

            string[] lines46 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\user1.txt");
            if (lines46.Length != 0)
            {
                string lastLine46 = lines46[lines46.Length - 1];
                textBox53.Text = lastLine46;
            }

            string[] lines47 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\user2.txt");
            if (lines47.Length != 0)
            {
                string lastLine47 = lines47[lines47.Length - 1];
                textBox52.Text = lastLine47;
            }

            string[] lines48 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\user3.txt");
            if (lines48.Length != 0)
            {
                string lastLine48 = lines48[lines48.Length - 1];
                textBox51.Text = lastLine48;
            }

            string[] lines49 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\user4.txt");
            if (lines49.Length != 0)
            {
                string lastLine49 = lines49[lines49.Length - 1];
                textBox50.Text = lastLine49;
            }

            int a50;
            string[] lines50 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\gst.txt");
            if (lines50.Length > 0)
            {
                string lastLine50 = lines50[lines50.Length - 1];

                if (int.TryParse(lastLine50, out a50))
                {
                    label53.Text = Convert.ToString(a50+"%");
                }
            }

            int a51;
            string[] lines51 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\discount.txt");
            if (lines51.Length > 0)
            {
                string lastLine51 = lines51[lines51.Length - 1];

                if (int.TryParse(lastLine51, out a51))
                {
                    label54.Text = Convert.ToString(a51 + "%");
                }
            }
        }

        private void label60_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePathuser1, true))
            {
                writer.WriteLine(textBox1.Text);
            }

            string[] lines46 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\user1.txt");
            if (lines46.Length != 0)
            {
                string lastLine46 = lines46[lines46.Length - 1];
                textBox53.Text = lastLine46;
            }
        }

        private void numericUpDown15_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown14_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown13_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown9_ValueChanged_1(object sender, EventArgs e)
        {
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown2_ValueChanged_1(object sender, EventArgs e)
        {
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
        }

        private void numericUpDown30_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown29_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown28_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown27_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown26_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown25_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown24_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown23_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown22_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown21_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown20_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown19_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown18_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown17_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown16_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown45_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown44_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown43_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown42_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown41_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown40_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown39_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown38_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown37_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown36_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown35_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown34_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown33_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown32_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown31_ValueChanged(object sender, EventArgs e)
        {
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePathuser2, true))
            {
                writer.WriteLine(textBox2.Text);
            }

            string[] lines47 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\user2.txt");
            if (lines47.Length != 0)
            {
                string lastLine47 = lines47[lines47.Length - 1];
                textBox52.Text = lastLine47;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePathuser3, true))
            {
                writer.WriteLine(textBox3.Text);
            }

            string[] lines48 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\user3.txt");
            if (lines48.Length != 0)
            {
                string lastLine48 = lines48[lines48.Length - 1];
                textBox51.Text = lastLine48;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePathuser4, true))
            {
                writer.WriteLine(textBox4.Text);
            }

            string[] lines49 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\user4.txt");
            if (lines49.Length != 0)
            {
                string lastLine49 = lines49[lines49.Length - 1];
                textBox50.Text = lastLine49;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(textBox5.Text);
            }

            int a1;
            string[] lines = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p1.txt");
            if (lines.Length > 0)
            {
                string lastLine = lines[lines.Length - 1];

                if (int.TryParse(lastLine, out a1))
                {
                    label41.Text = Convert.ToString(a1);
                }
            }
        }

    private void button10_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath2, true))
            {
                writer.WriteLine(textBox6.Text);
            }

            int a2;
            string[] lines2 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p2.txt");
            if (lines2.Length > 0)
            {
                string lastLine2 = lines2[lines2.Length - 1];

                if (int.TryParse(lastLine2, out a2))
                {
                    label7.Text = Convert.ToString(a2);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath3, true))
            {
                writer.WriteLine(textBox7.Text);
            }

            int a3;
            string[] lines3 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p3.txt");
            if (lines3.Length > 0)
            {
                string lastLine3 = lines3[lines3.Length - 1];

                if (int.TryParse(lastLine3, out a3))
                {
                    label8.Text = Convert.ToString(a3);
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath4, true))
            {
                writer.WriteLine(textBox8.Text);
            }

            int a4;
            string[] lines4 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p4.txt");
            if (lines4.Length > 0)
            {
                string lastLine4 = lines4[lines4.Length - 1];

                if (int.TryParse(lastLine4, out a4))
                {
                    label9.Text = Convert.ToString(a4);
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath5, true))
            {
                writer.WriteLine(textBox9.Text);
            }

            int a5;
            string[] lines5 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p5.txt");
            if (lines5.Length > 0)
            {
                string lastLine5 = lines5[lines5.Length - 1];

                if (int.TryParse(lastLine5, out a5))
                {
                    label11.Text = Convert.ToString(a5);
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath6, true))
            {
                writer.WriteLine(textBox10.Text);
            }

            int a6;
            string[] lines6 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p6.txt");
            if (lines6.Length > 0)
            {
                string lastLine6 = lines6[lines6.Length - 1];

                if (int.TryParse(lastLine6, out a6))
                {
                    label12.Text = Convert.ToString(a6);
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath7, true))
            {
                writer.WriteLine(textBox11.Text);
            }

            int a7;
            string[] lines7 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p7.txt");
            if (lines7.Length > 0)
            {
                string lastLine7 = lines7[lines7.Length - 1];

                if (int.TryParse(lastLine7, out a7))
                {
                    label13.Text = Convert.ToString(a7);
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath8, true))
            {
                writer.WriteLine(textBox12.Text);
            }

            int a8;
            string[] lines8 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p8.txt");
            if (lines8.Length > 0)
            {
                string lastLine8 = lines8[lines8.Length - 1];

                if (int.TryParse(lastLine8, out a8))
                {
                    label14.Text = Convert.ToString(a8);
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath9, true))
            {
                writer.WriteLine(textBox13.Text);
            }

            int a9;
            string[] lines9 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p9.txt");
            if (lines9.Length > 0)
            {
                string lastLine9 = lines9[lines9.Length - 1];

                if (int.TryParse(lastLine9, out a9))
                {
                    label15.Text = Convert.ToString(a9);
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath10, true))
            {
                writer.WriteLine(textBox14.Text);
            }

            int a10;
            string[] lines10 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p10.txt");
            if (lines10.Length > 0)
            {
                string lastLine10 = lines10[lines10.Length - 1];

                if (int.TryParse(lastLine10, out a10))
                {
                    label16.Text = Convert.ToString(a10);
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath11, true))
            {
                writer.WriteLine(textBox15.Text);
            }

            int a11;
            string[] lines11 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p11.txt");
            if (lines11.Length > 0)
            {
                string lastLine11 = lines11[lines11.Length - 1];

                if (int.TryParse(lastLine11, out a11))
                {
                    label17.Text = Convert.ToString(a11);
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath12, true))
            {
                writer.WriteLine(textBox16.Text);
            }

            int a12;
            string[] lines12 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p12.txt");
            if (lines12.Length > 0)
            {
                string lastLine12 = lines12[lines12.Length - 1];

                if (int.TryParse(lastLine12, out a12))
                {
                    label18.Text = Convert.ToString(a12);
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath13, true))
            {
                writer.WriteLine(textBox17.Text);
            }

            int a13;
            string[] lines13 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p13.txt");
            if (lines13.Length > 0)
            {
                string lastLine13 = lines13[lines13.Length - 1];

                if (int.TryParse(lastLine13, out a13))
                {
                    label19.Text = Convert.ToString(a13);
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath14, true))
            {
                writer.WriteLine(textBox18.Text);
            }

            int a14;
            string[] lines14 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p14.txt");
            if (lines14.Length > 0)
            {
                string lastLine14 = lines14[lines14.Length - 1];

                if (int.TryParse(lastLine14, out a14))
                {
                    label20.Text = Convert.ToString(a14);
                }
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath15, true))
            {
                writer.WriteLine(textBox19.Text);
            }

            int a15;
            string[] lines15 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p15.txt");
            if (lines15.Length > 0)
            {
                string lastLine15 = lines15[lines15.Length - 1];

                if (int.TryParse(lastLine15, out a15))
                {
                    label21.Text = Convert.ToString(a15);
                }
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath16, true))
            {
                writer.WriteLine(textBox34.Text);
            }

            int a16;
            string[] lines16 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p16.txt");
            if (lines16.Length > 0)
            {
                string lastLine16 = lines16[lines16.Length - 1];

                if (int.TryParse(lastLine16, out a16))
                {
                    label36.Text = Convert.ToString(a16);
                }
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath17, true))
            {
                writer.WriteLine(textBox33.Text);
            }

            int a17;
            string[] lines17 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p17.txt");
            if (lines17.Length > 0)
            {
                string lastLine17 = lines17[lines17.Length - 1];

                if (int.TryParse(lastLine17, out a17))
                {
                    label35.Text = Convert.ToString(a17);
                }
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath18, true))
            {
                writer.WriteLine(textBox32.Text);
            }

            int a18;
            string[] lines18 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p18.txt");
            if (lines18.Length > 0)
            {
                string lastLine18 = lines18[lines18.Length - 1];

                if (int.TryParse(lastLine18, out a18))
                {
                    label34.Text = Convert.ToString(a18);
                }
            }

        }

        private void button35_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath19, true))
            {
                writer.WriteLine(textBox31.Text);
            }

            int a19;
            string[] lines19 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p19.txt");
            if (lines19.Length > 0)
            {
                string lastLine19 = lines19[lines19.Length - 1];

                if (int.TryParse(lastLine19, out a19))
                {
                    label33.Text = Convert.ToString(a19);
                }
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath20, true))
            {
                writer.WriteLine(textBox30.Text);
            }

            int a20;
            string[] lines20 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p20.txt");
            if (lines20.Length > 0)
            {
                string lastLine20 = lines20[lines20.Length - 1];

                if (int.TryParse(lastLine20, out a20))
                {
                    label32.Text = Convert.ToString(a20);
                }
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath21, true))
            {
                writer.WriteLine(textBox29.Text);
            }

            int a21;
            string[] lines21 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p21.txt");
            if (lines21.Length > 0)
            {
                string lastLine21 = lines21[lines21.Length - 1];

                if (int.TryParse(lastLine21, out a21))
                {
                    label31.Text = Convert.ToString(a21);
                }
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath22, true))
            {
                writer.WriteLine(textBox28.Text);
            }

            int a22;
            string[] lines22 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p22.txt");
            if (lines22.Length > 0)
            {
                string lastLine22 = lines22[lines22.Length - 1];

                if (int.TryParse(lastLine22, out a22))
                {
                    label30.Text = Convert.ToString(a22);
                }
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath23, true))
            {
                writer.WriteLine(textBox27.Text);
            }

            int a23;
            string[] lines23 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p23.txt");
            if (lines23.Length > 0)
            {
                string lastLine23 = lines23[lines23.Length - 1];

                if (int.TryParse(lastLine23, out a23))
                {
                    label29.Text = Convert.ToString(a23);
                }
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath24, true))
            {
                writer.WriteLine(textBox26.Text);
            }

            int a24;
            string[] lines24 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p24.txt");
            if (lines24.Length > 0)
            {
                string lastLine24 = lines24[lines24.Length - 1];

                if (int.TryParse(lastLine24, out a24))
                {
                    label28.Text = Convert.ToString(a24);
                }
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath25, true))
            {
                writer.WriteLine(textBox25.Text);
            }

            int a25;
            string[] lines25 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p25.txt");
            if (lines25.Length > 0)
            {
                string lastLine25 = lines25[lines25.Length - 1];

                if (int.TryParse(lastLine25, out a25))
                {
                    label27.Text = Convert.ToString(a25);
                }
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath26, true))
            {
                writer.WriteLine(textBox24.Text);
            }

            int a26;
            string[] lines26 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p26.txt");
            if (lines26.Length > 0)
            {
                string lastLine26 = lines26[lines26.Length - 1];

                if (int.TryParse(lastLine26, out a26))
                {
                    label26.Text = Convert.ToString(a26);
                }
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath27, true))
            {
                writer.WriteLine(textBox23.Text);
            }

            int a27;
            string[] lines27 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p27.txt");
            if (lines27.Length > 0)
            {
                string lastLine27 = lines27[lines27.Length - 1];

                if (int.TryParse(lastLine27, out a27))
                {
                    label25.Text = Convert.ToString(a27);
                }
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath28, true))
            {
                writer.WriteLine(textBox22.Text);
            }

            int a28;
            string[] lines28 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p28.txt");
            if (lines28.Length > 0)
            {
                string lastLine28 = lines28[lines28.Length - 1];

                if (int.TryParse(lastLine28, out a28))
                {
                    label24.Text = Convert.ToString(a28);
                }
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath29, true))
            {
                writer.WriteLine(textBox21.Text);
            }

            int a29;
            string[] lines29 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p29.txt");
            if (lines29.Length > 0)
            {
                string lastLine29 = lines29[lines29.Length - 1];

                if (int.TryParse(lastLine29, out a29))
                {
                    label23.Text = Convert.ToString(a29);
                }
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath30, true))
            {
                writer.WriteLine(textBox20.Text);
            }

            int a30;
            string[] lines30 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p30.txt");
            if (lines30.Length > 0)
            {
                string lastLine30 = lines30[lines30.Length - 1];

                if (int.TryParse(lastLine30, out a30))
                {
                    label22.Text = Convert.ToString(a30);
                }
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath31, true))
            {
                writer.WriteLine(textBox49.Text);
            }

            int a31;
            string[] lines31 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p31.txt");
            if (lines31.Length > 0)
            {
                string lastLine31 = lines31[lines31.Length - 1];

                if (int.TryParse(lastLine31, out a31))
                {
                    label52.Text = Convert.ToString(a31);
                }
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath32, true))
            {
                writer.WriteLine(textBox48.Text);
            }

            int a32;
            string[] lines32 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p32.txt");
            if (lines32.Length > 0)
            {
                string lastLine32 = lines32[lines32.Length - 1];

                if (int.TryParse(lastLine32, out a32))
                {
                    label51.Text = Convert.ToString(a32);
                }
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath33, true))
            {
                writer.WriteLine(textBox47.Text);
            }

            int a33;
            string[] lines33 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p33.txt");
            if (lines33.Length > 0)
            {
                string lastLine33 = lines33[lines33.Length - 1];

                if (int.TryParse(lastLine33, out a33))
                {
                    label50.Text = Convert.ToString(a33);
                }
            }

        }

        private void button50_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath34, true))
            {
                writer.WriteLine(textBox46.Text);
            }

            int a34;
            string[] lines34 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p34.txt");
            if (lines34.Length > 0)
            {
                string lastLine34 = lines34[lines34.Length - 1];

                if (int.TryParse(lastLine34, out a34))
                {
                    label49.Text = Convert.ToString(a34);
                }
            }

        }

        private void button49_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath35, true))
            {
                writer.WriteLine(textBox45.Text);
            }

            int a35;
            string[] lines35 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p35.txt");
            if (lines35.Length > 0)
            {
                string lastLine35 = lines35[lines35.Length - 1];

                if (int.TryParse(lastLine35, out a35))
                {
                    label48.Text = Convert.ToString(a35);
                }
            }

        }

        private void button48_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath36, true))
            {
                writer.WriteLine(textBox44.Text);
            }

            int a36;
            string[] lines36 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p36.txt");
            if (lines36.Length > 0)
            {
                string lastLine36 = lines36[lines36.Length - 1];

                if (int.TryParse(lastLine36, out a36))
                {
                    label47.Text = Convert.ToString(a36);
                }
            }

        }

        private void button47_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath37, true))
            {
                writer.WriteLine(textBox43.Text);
            }

            int a37;
            string[] lines37 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p37.txt");
            if (lines37.Length > 0)
            {
                string lastLine37 = lines37[lines37.Length - 1];

                if (int.TryParse(lastLine37, out a37))
                {
                    label46.Text = Convert.ToString(a37);
                }
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath38, true))
            {
                writer.WriteLine(textBox42.Text);
            }

            int a38;
            string[] lines38 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p38.txt");
            if (lines38.Length > 0)
            {
                string lastLine38 = lines38[lines38.Length - 1];

                if (int.TryParse(lastLine38, out a38))
                {
                    label45.Text = Convert.ToString(a38);
                }
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath39, true))
            {
                writer.WriteLine(textBox41.Text);
            }

            int a39;
            string[] lines39 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p39.txt");
            if (lines39.Length > 0)
            {
                string lastLine39 = lines39[lines39.Length - 1];

                if (int.TryParse(lastLine39, out a39))
                {
                    label44.Text = Convert.ToString(a39);
                }
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath40, true))
            {
                writer.WriteLine(textBox40.Text);
            }

            int a40;
            string[] lines40 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p40.txt");
            if (lines40.Length > 0)
            {
                string lastLine40 = lines40[lines40.Length - 1];

                if (int.TryParse(lastLine40, out a40))
                {
                    label43.Text = Convert.ToString(a40);
                }
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath41, true))
            {
                writer.WriteLine(textBox39.Text);
            }

            int a41;
            string[] lines41 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p41.txt");
            if (lines41.Length > 0)
            {
                string lastLine41 = lines41[lines41.Length - 1];

                if (int.TryParse(lastLine41, out a41))
                {
                    label42.Text = Convert.ToString(a41);
                }
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath42, true))
            {
                writer.WriteLine(textBox38.Text);
            }

            int a42;
            string[] lines42 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p42.txt");
            if (lines42.Length > 0)
            {
                string lastLine42 = lines42[lines42.Length - 1];

                if (int.TryParse(lastLine42, out a42))
                {
                    label40.Text = Convert.ToString(a42);
                }
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath43, true))
            {
                writer.WriteLine(textBox37.Text);
            }

            int a43;
            string[] lines43 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p43.txt");
            if (lines43.Length > 0)
            {
                string lastLine43 = lines43[lines43.Length - 1];

                if (int.TryParse(lastLine43, out a43))
                {
                    label39.Text = Convert.ToString(a43);
                }
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath44, true))
            {
                writer.WriteLine(textBox36.Text);
            }

            int a44;
            string[] lines44 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p44.txt");
            if (lines44.Length > 0)
            {
                string lastLine44 = lines44[lines44.Length - 1];

                if (int.TryParse(lastLine44, out a44))
                {
                    label38.Text = Convert.ToString(a44);
                }
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePath45, true))
            {
                writer.WriteLine(textBox35.Text);
            }

            int a45;
            string[] lines45 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\p45.txt");
            if (lines45.Length > 0)
            {
                string lastLine45 = lines45[lines45.Length - 1];

                if (int.TryParse(lastLine45, out a45))
                {
                    label37.Text = Convert.ToString(a45);
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button57_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox53_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox53.UseSystemPasswordChar = false;

            }
            else
            {
                textBox53.UseSystemPasswordChar = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox52.UseSystemPasswordChar = false;

            }
            else
            {
                textBox52.UseSystemPasswordChar = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox51.UseSystemPasswordChar = false;

            }
            else
            {
                textBox51.UseSystemPasswordChar = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                textBox50.UseSystemPasswordChar = false;

            }
            else
            {
                textBox50.UseSystemPasswordChar = true;
            }
        }

        private void label41_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void label58_Click(object sender, EventArgs e)
        {

        }

        private void button55_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePathdiscount, true))
            {
                writer.WriteLine(textBox55.Text);
            }

            int a51;
            string[] lines51 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\discount.txt");
            if (lines51.Length > 0)
            {
                string lastLine51 = lines51[lines51.Length - 1];

                if (int.TryParse(lastLine51, out a51))
                {
                    label54.Text = Convert.ToString(a51 + "%");
                }
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(filePathgst, true))
            {
                writer.WriteLine(textBox54.Text);
            }

            int a50;
            string[] lines50 = File.ReadAllLines("C:\\Users\\omeru\\Desktop\\PF Project\\Database PF\\gst.txt");
            if (lines50.Length > 0)
            {
                string lastLine50 = lines50[lines50.Length - 1];

                if (int.TryParse(lastLine50, out a50))
                {
                    label53.Text = Convert.ToString(a50 + "%");
                }
            }
        }
    }
}
