using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormApp
{
    public partial class MyFirstForm : Form
    {

        int interval = 1000;
        bool flag = false;

        public MyFirstForm()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, World!");
            if (flag == false)
            {
                this.BackColor=Color.Red;
                flag = true;
            }
            else 
            {
                this.BackColor = Color.Blue;
                flag = false;

            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("you entered: "+txtName.Text);
        }


        private void btnStart_Click(object sender, EventArgs e) 
        {
            tmr.Interval = interval;
            tmr.Start();

        
        }

        private void btnStop_Click(object sender, EventArgs e) 
        {
            tmr.Stop();
        
        
        }


        private void tmr_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        

    }
}













 




