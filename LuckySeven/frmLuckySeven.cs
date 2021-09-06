using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckySeven
{
    public partial class frmLuckySeven : Form
    {
        private int credits = 100;

        public frmLuckySeven()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            SetCreditsText();
            lblResult.Text = "";
        }

        private void SetCreditsText()
        {
            lblCredits.Text = credits.ToString();
        }

        private void GenerateDigits()
        {
            int digit;
            Random random = new Random();

            digit = random.Next(0, 10);
            txtDigit1.Text = digit.ToString();
            digit = random.Next(0, 10);
            txtDigit2.Text = digit.ToString();
            digit = random.Next(0, 10);
            txtDigit3.Text = digit.ToString();
        }

        private int PayOut()
        {
            string digits = txtDigit1.Text + txtDigit2.Text + txtDigit3.Text;
            int retval = credits;
            credits -= 1;  // pay for spin
            if (digits.Contains("777"))
            {
                credits += 100;
            }
            else if (digits.Contains("77"))
            {
                credits += 10;
            }
            else if (digits.Contains("7"))
            {
                credits += 1;
            }
            return credits - retval;
        }
        
        private void SpinClick(object sender, EventArgs e)
        {
            if (credits > 0)
            {
                GenerateDigits();
                lblResult.Text = PayOut().ToString();
                SetCreditsText();
            }
        }
    }
}
