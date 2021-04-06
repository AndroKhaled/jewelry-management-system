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
    public partial class adddahab : Form
    {
        public adddahab()
        {
            InitializeComponent();
        }

        private void adddahab_Load(object sender, EventArgs e)
        {
            //-----------------------full screen----------------------
            //this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;
        }

        private void adddata_Click(object sender, EventArgs e)
        {
            //----------------if txtbox is empty----------------
            if (id.Text == "")
            {
                id2.Visible = true;
            }
            else
            {
                id2.Visible = false;
            }

            if (name.Text == "")
            {
                name2.Visible = true;
            }
            else
            {
                name2.Visible = false;
            }

            if (weight.Text == "")
            {
                gold2.Visible = true;
            }
            else
            {
                gold2.Visible = false;
            }

            if (wnumb.Text == "")
            {
                diam2.Visible = true;
            }
            else
            {
                diam2.Visible = false;
            }

            if (sprice.Text == "")
            {
                sell2.Visible = true;
            }
            else
            {
                sell2.Visible = false;
            }

            if (bprice.Text == "")
            {
                buy2.Visible = true;
            }
            else
            {
                buy2.Visible = false;
            }

            if (comp.Text == "")
            {
                comp2.Visible = true;
            }
            else
            {
                comp2.Visible = false;
            }
            if (place.Text == "")
            {
                place2.Visible = true;
            }
            else
            {
                place2.Visible = false;
            }


            if (id2.Visible == false && name2.Visible == false && gold2.Visible == false && diam2.Visible == false && sell2.Visible == false && buy2.Visible == false && comp2.Visible == false && place2.Visible == false)
            {
                //---------------------------------------insert data buy report-------------------------------------
                string conString = "Data Source=.;Initial Catalog=store;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO dahab ([الكود],[اسم الصنف],[الوزن],[العدد],[سعر الشراء],[سعر البيع],[الشركة المنتجة],[ملاحظات],[تاريخ الضم],[المكان],[وصل الضم],[شراء ])" +
                    "VALUES ('" + id.Text + "' , '" + name.Text + "','" + weight.Text
                    + "' ,'" + wnumb.Text + "','" + bprice.Text + "','" + sprice.Text + "','" + comp.Text + "','" + note.Text + "','" + dtdam.Value.Date + "','" + place.Text + "','" + buyno.Text + "','" + true + "');";
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception b)
                {
                 //   MessageBox.Show(b.ToString());
                }

                double wazn = 0, adad = 0, bea = 0, shera = 0, nwazn = 0, nadad = 0, nbea = 0, nshera = 0;

                //---------------------------------------get data wazn to add the new number ------------------------------------
                con.Open();
                try
                {
                    SqlCommand cm = new SqlCommand();
                    cm.Connection = con;
                    cm.CommandText = "SELECT الوزن FROM dahab WHERE  الكود='مجموع'  AND [اسم الصنف] = '" + name.Text + "'";
                  //  SqlDataReader readerz = cm.ExecuteReader();
                    wazn = (double)cm.ExecuteScalar();
                 //   while (readerz.Read())
                    {
                  //      wazn = readerz.GetDecimal(0);
                    }
                }
                catch (Exception ex)
                {
                 //   MessageBox.Show(ex.ToString());
                }
                con.Close();

                //---------------------------------------get data 3adad to add the new number ------------------------------------
                con.Open();
                try
                {
                    SqlCommand cm = new SqlCommand();
                    cm.Connection = con;
                    cm.CommandText = "SELECT العدد FROM dahab WHERE الكود='مجموع' AND [اسم الصنف] = '" + name.Text + "'";
                  //  SqlDataReader readerz = cm.ExecuteReader();
                    adad = (double)cm.ExecuteScalar();
                 //   while (readerz.Read())
                    {
                 //       adad = readerz.GetDecimal(0);
                    }
                }
                catch (Exception ex)
                {
                 //   MessageBox.Show(ex.ToString());
                }
                con.Close();

                //---------------------------------------get data be3 to add the new number ------------------------------------
                con.Open();
                try
                {
                    SqlCommand cm = new SqlCommand();
                    cm.Connection = con;
                    cm.CommandText = "SELECT [سعر البيع] FROM dahab WHERE الكود='مجموع' AND [اسم الصنف] = '" + name.Text + "'";
                  //  SqlDataReader readerz = cm.ExecuteReader();
                    bea = (double)cm.ExecuteScalar();
                 //   while (readerz.Read())
                    {
                  //      bea = readerz.GetDecimal(0);
                    }
                }
                catch (Exception ex)
                {
                  //  MessageBox.Show(ex.ToString());
                }
                con.Close();
                
                //---------------------------------------get data shera to add the new number ------------------------------------
                con.Open();
                try
                {
                    SqlCommand cm = new SqlCommand();
                    cm.Connection = con;
                    cm.CommandText = "SELECT [سعر الشراء] FROM dahab WHERE الكود='مجموع' AND [اسم الصنف] = '" + name.Text + "'";
                 //   SqlDataReader readerz = cm.ExecuteReader();
                    shera = (double)cm.ExecuteScalar();
                 //   while (readerz.Read())
                    {
                  //      shera = readerz.GetDecimal(0);
                    }
                }
                catch (Exception ex)
                {
                //    MessageBox.Show(ex.ToString());
                }
                con.Close();
                

                nwazn = wazn + double.Parse(weight.Text);
                nadad = adad + double.Parse(wnumb.Text);
                nbea = bea + double.Parse(sprice.Text);
                nshera = shera + double.Parse(bprice.Text);

                //---------------------------------------update the new number ------------------------------------
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = " UPDATE dahab SET [الوزن] = '" + nwazn + "', [العدد]= '" + nadad + "', [سعر البيع]= '" + nbea + "', [سعر الشراء]= '" + nshera + "'  WHERE الكود='مجموع' AND [اسم الصنف] = '" + name.Text + "'";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                //    MessageBox.Show(ex.ToString());
                }
                con.Close();


            }
            //id name gold diam sell buy comp place loan loanno ext1 ext2 ext3 ext4 ext5 note fullname
            id.Clear();
            weight.Clear();
            wnumb.Clear();
            sprice.Clear();
            bprice.Clear();
            comp.Clear();
            buyno.Clear();
            note.Clear();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new main().Show();
            this.Hide();
        }

        private void comp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
