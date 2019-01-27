using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlamesGame
{
    public partial class Form1 : Form
    {
        Func<string, string, string> Result;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label4.Text != "")
            {
                label4.Text = "";
            }
            string result;
            string YourName = textBox1.Text.ToString();
            string PartnerName = textBox2.Text.ToString();
            MatchingLogic matchingLogic = new MatchingLogic();
            if (YourName =="" || PartnerName == "")
            {
                MessageBox.Show("Please enter Name");
            }
            else
	        {
                result = matchingLogic.GetMatchingResult(YourName, PartnerName).ToString();
                switch (result)
                {
                    case "f":
                        label4.Text = "Friend";
                        break;
                    case "l":
                        label4.Text = "Love";
                        break;
                    case "a":
                        label4.Text = "Affection";
                        break;
                    case "m":
                        label4.Text = "Marriage";
                        break;
                    case "e":
                        label4.Text = "Enemy";
                        break;
                    case "s":
                        label4.Text = "Sister/Brother";
                        break;
                } 
            }
            
        }
    }
}
