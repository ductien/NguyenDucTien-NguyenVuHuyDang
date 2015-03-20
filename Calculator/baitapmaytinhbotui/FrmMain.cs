using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace baitapmaytinhbotui
{
    public partial class Form1 : Form
    {
        bool isTypingNumber = false;
        bool isphlay = true;
        string luugiatri;
        double giatri1, giatri2;
        public Form1()
        {
            InitializeComponent();
        }



        private void btn1_Click(object sender, EventArgs e)
        {
            if (isTypingNumber)
            {
                lblDisplay.Text = lblDisplay.Text + btn1.Text;

            }
            else
            {
                lblDisplay.Text = btn1.Text;
                isTypingNumber = true;
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (isTypingNumber)
            {
                lblDisplay.Text = lblDisplay.Text + btn2.Text;

            }
            else
            {
                lblDisplay.Text = btn2.Text;
                isTypingNumber = true;
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (isTypingNumber)
            {
                lblDisplay.Text = lblDisplay.Text + btn3.Text;

            }
            else
            {
                lblDisplay.Text = btn3.Text;
                isTypingNumber = true;
            }

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (isTypingNumber)
            {
                lblDisplay.Text = lblDisplay.Text + btn4.Text;

            }
            else
            {
                lblDisplay.Text = btn4.Text;
                isTypingNumber = true;
            }

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (isTypingNumber)
            {
                lblDisplay.Text = lblDisplay.Text + btn5.Text;

            }
            else
            {
                lblDisplay.Text = btn5.Text;
                isTypingNumber = true;
            }

        }

        private void btn6_Click(object sender, EventArgs e)
        {

            if (isTypingNumber)
            {
                lblDisplay.Text = lblDisplay.Text + btn6.Text;

            }
            else
            {
                lblDisplay.Text = btn6.Text;
                isTypingNumber = true;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (isTypingNumber)
            {
                lblDisplay.Text = lblDisplay.Text + btn7.Text;

            }
            else
            {
                lblDisplay.Text = btn7.Text;
                isTypingNumber = true;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (isTypingNumber)
            {
                lblDisplay.Text = lblDisplay.Text + btn8.Text;

            }
            else
            {
                lblDisplay.Text = btn8.Text;
                isTypingNumber = true;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (isTypingNumber)
            {
                lblDisplay.Text = lblDisplay.Text + btn9.Text;

            }
            else
            {
                lblDisplay.Text = btn9.Text;
                isTypingNumber = true;
            }

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (isTypingNumber)
            {
                lblDisplay.Text = lblDisplay.Text + btn0.Text;

            }
            else
            {
                lblDisplay.Text = btn0.Text;
                isTypingNumber = true;
            }
            
        }

        private void btndaubang_Click(object sender, EventArgs e)
        {
            switch (luugiatri)
            {
                case"+":
                    lblDisplay.Text=(double.Parse(lblDisplay.Text)+giatri1).ToString();
                    break;
                case"-":
                    lblDisplay.Text=(giatri1-double.Parse(lblDisplay.Text)).ToString();
                    break;
                case"*":
                    lblDisplay.Text=(giatri1*double.Parse(lblDisplay.Text)).ToString();
                    break;
                case"/":
                    lblDisplay.Text=(giatri1/double.Parse(lblDisplay.Text)).ToString();
                    break;
                default: break;

            }
        }

        private void btndaucong_Click(object sender, EventArgs e)
        {
            giatri1 = double.Parse(lblDisplay.Text);
            luugiatri = "+";
            lblDisplay.Text = "0";
            isphlay = false;

        }

        private void btndautru_click(object sender, EventArgs e)
        {
            giatri1 = double.Parse(lblDisplay.Text);
            luugiatri = "-";
            lblDisplay.Text = "0";
            isphlay = false;

        }

        private void btndaunhan_Click(object sender, EventArgs e)
        {
            giatri1 = double.Parse(lblDisplay.Text);
            luugiatri = "*";
            lblDisplay.Text = "0";
            isphlay = false;
        }

        private void btndauchia_Click(object sender, EventArgs e)
        {
            giatri1 = double.Parse(lblDisplay.Text);
            luugiatri = "/";
            lblDisplay.Text = "0";
            isphlay = false;
        }

        private void btncanban2_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = (Math.Sqrt(double.Parse(lblDisplay.Text))).ToString();
        }

        private void btnphantram_Click(object sender, EventArgs e)
        {
            switch (luugiatri)
            {
                case "+":
                    lblDisplay.Text = (double.Parse(lblDisplay.Text)*100 + giatri1).ToString();
                    break;
                case "-":
                    lblDisplay.Text = (giatri1 - double.Parse(lblDisplay.Text)*100).ToString();
                    break;
                case "*":
                    lblDisplay.Text = (giatri1 * double.Parse(lblDisplay.Text)*100).ToString();
                    break;
                case "/":
                    lblDisplay.Text = (giatri1 / double.Parse(lblDisplay.Text)*100).ToString();
                    break;
                default: break;

            }
        }

        private void btn1chiax_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = (1 / double.Parse(lblDisplay.Text)).ToString();
            isTypingNumber = false;
        }

        private void btnnutC_Click(object sender, EventArgs e)
        {
            giatri1 = 0;
            giatri2 = 0;
            lblDisplay.Text = "0";
            isTypingNumber = false;
        }

        private void btnnutCE_Click(object sender, EventArgs e)
        {
            giatri1 = 0;
            giatri2 = 0;
            lblDisplay.Text = "0";
            isTypingNumber = false;
        }

        private void btndauamduong_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = (-1 * double.Parse(lblDisplay.Text)).ToString();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            lblDisplay.Text =(double.Parse(lblDisplay.Text)/10).ToString();
            if (lblDisplay.Text == "0")
            {
                isTypingNumber = false;
            }
        }


        
    }
}
