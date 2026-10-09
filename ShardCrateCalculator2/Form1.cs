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
        bool running, first, seccond, enterMode;
        int real, goal;
        public void Calculator(int mode/*What button called the function*/)
        {
            goal = mode;
            running = true;
            while (running)
            {
                first = true;
                while (first)
                {
                    whatTypeLabel.Text = "How many shards do you have?";
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
            }
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

                }
            }
        }
    }
}
