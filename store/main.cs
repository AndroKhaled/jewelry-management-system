using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace store
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new data().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new add().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new sell().Show();
            this.Hide();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void main_Load(object sender, EventArgs e)
        {
            //-----------------------full screen----------------------
            //this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new loan().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new adddahab().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new datadahab().Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new selldahab().Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new edit().Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string conStrin = "Data Source=.;Initial Catalog=store;Integrated Security=True";
            SqlConnection co = new SqlConnection(conStrin);
            co.Open();
            try
            {
                SqlCommand cm = new SqlCommand();
                cm.Connection = co;
                cm.CommandText = "DELETE FROM dahab ";
                cm.ExecuteNonQuery();
                //SqlDataReader readerz = cm.ExecuteReader();
                //while (readerz.Read())
                //{
                //    string x = readerz.GetString(0);
                //}

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            co.Close();
        }
    }
}
