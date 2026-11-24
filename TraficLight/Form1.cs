using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraficLight
{
    public partial class Form1 : Form
    {
      
        int state = 0;
        int blinkCount = 0;
        public Form1()
        {
            InitializeComponent();
            ResetLights();
            tmrLight.Interval = 1000;
        }
        private void ResetLights()
        {
            pnlRed.BackColor = Color.Gray;
            pnlYellow.BackColor = Color.Gray;
            pnlGreen.BackColor = Color.Gray;
        }
        private void tmrLight_Tick(object sender, EventArgs e)
        {


            if (state == 0) 
            {
                ResetLights();
                pnlRed.BackColor = Color.Red;
                tmrLight.Interval = 3000;
                state = 4;
            }
            else if (state == 4) 
            {
                ResetLights();
                pnlRed.BackColor = Color.Red;
                pnlYellow.BackColor = Color.Yellow;
                tmrLight.Interval = 1000;
                state = 2;
            }
            else if (state == 2)
            {
                ResetLights();
                pnlGreen.BackColor = Color.Green;
                tmrLight.Interval = 3000;
                blinkCount = 0;
                state = 3;
            }
            else if (state == 3) 
            {
                tmrLight.Interval = 400;

                if (pnlGreen.BackColor == Color.Green)
                    pnlGreen.BackColor = Color.Gray;
                else
                    pnlGreen.BackColor = Color.Green;

                blinkCount++;

                if (blinkCount >= 6)
                {
                    blinkCount = 0; 
                    state = 1;
                }
            }
            else if (state == 1) 
            {
                ResetLights();
                pnlYellow.BackColor = Color.Yellow;
                tmrLight.Interval = 1500;
                state = 0;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrLight.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrLight.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tmrLight.Stop();
            ResetLights();
            state = 0;
            blinkCount = 0;
            tmrLight.Interval = 1000;
        }
    }
}
