using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShardCrateCalculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool enterMode;
        int real, goal;
        public void Calculator(int mode/*What button called the function*/)
        {
            goal = mode;
                    whatTypeLabel.Text = "How many shards do you have?";
                    enterBtn.Text = "Enter";
            uptieLbl.Hide();
            uptiePic.Hide();
            twoStarLbl.Hide();
            twoStarPic.Hide();
            threeStarLbl.Hide();
            threeStarPic.Hide();
            luckyLbl.Hide();
            luckyNumLbl.Hide();
            luckyPic.Hide();
            midLbl.Hide();
            midNumLbl.Hide();
            midPic.Hide();
            unluckyLbl.Hide();
            unluckyNumLbl.Hide();
            unluckyPic.Hide();
            enterBtn.Show();
            exitBtn.Show();
            realShardsTxt.Show();
                    enterMode = true;
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            whatTypeLabel.Text = "What are you sharding?";
            luckyLbl.Hide();
            luckyNumLbl.Hide();
            luckyPic.Hide();
            midLbl.Hide();
            midNumLbl.Hide();
            midPic.Hide();
            unluckyLbl.Hide();
            unluckyNumLbl.Hide();
            unluckyPic.Hide();
            enterBtn.Hide();
            exitBtn.Hide();
            realShardsTxt.Hide();
            uptieLbl.Show();
            uptiePic.Show();
            twoStarLbl.Show();
            twoStarPic.Show();
            threeStarLbl.Show();
            threeStarPic.Show();
        }

        private void threeStarPic_Click(object sender, EventArgs e)
        {
            Calculator(400);
        }

        private void twoStarPic_Click(object sender, EventArgs e)
        {
            Calculator(150);
        }

        private void uptiePic_Click(object sender, EventArgs e)
        {
            Calculator(50);
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            if (enterMode)
            {
                real = int.Parse(realShardsTxt.Text);
                if (goal <= real)
                {
                    whatTypeLabel.Text = "You already have enough.";
                    enterBtn.Hide();
                    realShardsTxt.Hide();
                }
                else
                {
                    int open;
                    enterMode = false;
                    enterBtn.Text = "Continue";
                    whatTypeLabel.Text = "Press Continue to open more";
                    realShardsTxt.Hide();
                    luckyLbl.Show();
                    luckyNumLbl.Show();
                    luckyPic.Show() ;
                     midLbl.Show();
                    midNumLbl.Show();
                    midPic.Show();
                    unluckyLbl.Show();
                    unluckyNumLbl.Show();
                    unluckyPic.Show();
                    open = goal - real;
                    unluckyNumLbl.Text = open.ToString();
                    open = (goal - real) / 2;
                    midNumLbl.Text = open.ToString();
                    open = (goal - real) / 3;
                    luckyNumLbl.Text = open.ToString();
                }
            }
            else
            {
                Calculator(goal);
            }
        }
    }
}
