using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neo3._0
{
   
    public partial class Form1 : Form
    {
        int a33;
        int a34;
        int pccards1 = 0;
        int getmoney ;
        int allmoney;
        public Form1()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           string bet = textBox1.Text;
           getmoney = int.Parse(bet);

            label15.Text = getmoney.ToString();
            Random rnd3 = new Random();
            button1.PerformClick();
            button1.PerformClick();

            int pccards =    rnd3.Next(1,11);
           
            pccards = 0;
            panel2.Visible = false;
           // Random rnd1 = new Random();
        //     a33 = rnd1.Next(1,11);
            // a34 = rnd1.Next(1, 11);
            //CR1.Text = a33.ToString();
          //  cr2.Text = a34.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private int CARDSİNT = 0;
        private int labelCount = 0;
        private void button1_Click(object sender, EventArgs e)
        {
      
           
            Random rnd = new Random();
       int b =     rnd.Next(1,11);
            Label yeniLabel = new Label();
            yeniLabel.Text = b.ToString();
            yeniLabel.Font = new Font("Microsoft YaHei UI", 15.75f, FontStyle.Bold);
            yeniLabel.AutoSize = true;

            // Her yeni Label'ı bir öncekinin altına yerleştirmek için hesaplanan konum
            int y = (labelCount == 0) ? 50 : this.Controls[this.Controls.Count - 1].Bottom + 10;
            yeniLabel.Location = new Point(50, y);
           
            this.Controls.Add(yeniLabel);
            labelCount++;
            
            CARDSİNT += b;
          
       
         
            button8.PerformClick();
            label9.Text = CARDSİNT.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (pccards1 > 21)
            {
                panel1.Visible = true;
                label10.Text = "YOU WİN";
                allmoney += getmoney;
                label7.Text = CARDSİNT.ToString();
            }
            if (CARDSİNT > 21)
            {
                panel1.Visible = true;
                allmoney -= getmoney;
                label10.Text = "YOU LOSE";
                label7.Text = CARDSİNT.ToString();
            }
            if (CARDSİNT == 21)
            {

                panel1.Visible = true;
                allmoney += getmoney;
                label10.Text = "YOU WİN";
                label7.Text = CARDSİNT.ToString();
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
            getmoney =  getmoney * 2;
            label15.Text = getmoney.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            label7.Text = CARDSİNT.ToString();
          Random rnd = new Random();
            int pchave = rnd.Next(1,11); 
            Label yeniLabel = new Label();
            yeniLabel.Text = pchave.ToString();
            yeniLabel.Font = new Font("Microsoft YaHei UI", 15.75f, FontStyle.Bold);
            yeniLabel.AutoSize = true;

            // Her yeni Label'ı bir öncekinin altına yerleştirmek için hesaplanan konum
            int y = (labelCount == 0) ? 50 : this.Controls[this.Controls.Count - 1].Bottom + 10;
            yeniLabel.Location = new Point(50, y);

            this.Controls.Add(yeniLabel);
            labelCount++;

            pchave += pccards1;
            if (pccards1== 21)
            {
                panel1.Visible = true;
               
                allmoney -= getmoney;
            }
            if (pccards1 > 21)
            {
                panel1.Visible = true;
                label10.Text = "YOU WİN";
                allmoney += getmoney;
            }
            label9.Text = CARDSİNT.ToString();
       int g1 =     21 - CARDSİNT;
            int g2 = 21 - pccards1;
            if (g1 > g2)
            {
                panel1.Visible = true;
                
            }
            if (g2 > g1)
            {
                panel1.Visible = true;
                label10.Text = "YOU WİN";

            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Random rmd = new Random();
        double a6 =    rmd.Next(2,12);
            label6.Text = "refunded amount:";
         double bbb =    Convert.ToInt32(textBox1.Text);
            double böl = bbb / a6;
            label7.Text = a6.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
    }
    

