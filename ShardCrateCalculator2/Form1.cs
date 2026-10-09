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
                    uptieLbl.Enabled = false;
                    uptiePic.Enabled = false;
                    twoStarLbl.Enabled = false;
                    twoStarPic.Enabled = false;
                    threeStarLbl.Enabled = false;
                    threeStarPic.Enabled = false;
                    luckyLbl.Enabled = false;
                    luckyNumLbl.Enabled = false;
                    luckyPic.Enabled = false;
                    midLbl.Enabled = false;
                    midNumLbl.Enabled = false;
                    midPic.Enabled = false;
                    unluckyLbl.Enabled = false;
                    unluckyNumLbl.Enabled = false;
                    unluckyPic.Enabled = false;
                    enterBtn.Enabled = true;
                    exitBtn.Enabled = true;
                    realShardsTxt.Enabled = true;
                    enterMode = true;
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            whatTypeLabel.Text = "What are you sharding?";
            luckyLbl.Enabled = false;
            luckyNumLbl.Enabled = false;
            luckyPic.Enabled = false;
            midLbl.Enabled = false;
            midNumLbl.Enabled = false;
            midPic.Enabled = false;
            unluckyLbl.Enabled = false;
            unluckyNumLbl.Enabled = false;
            unluckyPic.Enabled = false;
            enterBtn.Enabled = false;
            exitBtn.Enabled = false;
            realShardsTxt.Enabled = false;
            uptieLbl.Enabled = true;
            uptiePic.Enabled = true;
            twoStarLbl.Enabled = true;
            twoStarPic.Enabled = true;
            threeStarLbl.Enabled = true;
            threeStarPic.Enabled = true;
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
                if (goal >= real)
                {
                    whatTypeLabel.Text = "You already have enough.";
                    enterBtn.Enabled = false;
                    realShardsTxt.Enabled = false;
                }
                else
                {
                    int open;
                    enterMode = false;
                    enterBtn.Text = "Continue";
                    whatTypeLabel.Text = "Press Continue to open more";
                    realShardsTxt.Enabled = false;
                    luckyLbl.Enabled = true;
                    luckyNumLbl.Enabled = true;
                    luckyPic.Enabled = true;
                    midLbl.Enabled = true;
                    midNumLbl.Enabled = true;
                    midPic.Enabled = true;
                    unluckyLbl.Enabled = true;
                    unluckyNumLbl.Enabled = true;
                    unluckyPic.Enabled = true;
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
