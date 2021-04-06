using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace store
{
    public partial class splash : Form
    {
        Timer tmr;
        public splash()
        {
            InitializeComponent();
        }

        private void splash_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();
            //set time interval 3 sec
            tmr.Interval = 3000;
            //starts the timer
            tmr.Start();
            tmr.Tick += tmr_Tick;
       }
        void tmr_Tick(object sender, EventArgs e)
        {
            //after 3 sec stop the timer
            tmr.Stop();
            //display mainform
            new login().Show();
            //hide this form
            this.Hide();
        }

        private void splash_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void splash_Load(object sender, EventArgs e)
        {
            
//            if ( (DateTime.Now.ToString("dd") == "09" && DateTime.Now.ToString("MM") == "12" && DateTime.Now.ToString("yyyy") == ("2019")) &&
//                 (DateTime.Now.ToString("dd") == "09" && DateTime.Now.ToString("MM") == "12" && DateTime.Now.ToString("yyyy") == ("2019")) 
//                )
//           {
//                Application.Exit();
//            }
        
        }
    }
}
