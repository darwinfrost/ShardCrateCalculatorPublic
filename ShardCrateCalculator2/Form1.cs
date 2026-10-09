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
        bool running;
        public void Calculator(int mode/*What button called the function*/)
        {
            running = true;
            while (running)
            {
                bool first = true;
                while (first)
                {
                    whatTypeLabel.Text = "How many shards do you have?";
                    uptieLbl.Enabled = false;
                    uptiePic.Enabled = false;
                    twoStarLbl.Enabled = false;
                    twoStarPic.Enabled = false;
                    threeStarLbl.Enabled = false;
                    threeStarPic.Enabled = false;
                    enterBtn.Enabled = true;
                    exitBtn.Enabled = true;
                    realShardsTxt.Enabled = true;

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
    }
}
