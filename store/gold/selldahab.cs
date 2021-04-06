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
    public partial class selldahab : Form
    {
        public selldahab()
        {
            InitializeComponent();
        }

        private void selldahab_Load(object sender, EventArgs e)
        {
            //-----------------------full screen----------------------
            //this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;
            //------------------------w & h of DG------------------------
            // dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;

            dg.RowTemplate.Height = 30;
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dg.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
            dg.AllowUserToResizeColumns = true;
            dg.AllowUserToOrderColumns = true;

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            //------------------------------------Show all data------------------------------
            string conString = "Data Source=.;Initial Catalog=store;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT [الكود],[اسم الصنف],[الوزن],[العدد],[سعر الشراء],[سعر البيع],[الشركة المنتجة],[تاريخ الضم],[تاريخ البيع],[وصل الضم],[المكان],[اسم المشتري],[معار],[وصل الاعارة],[ملاحظات ] FROM dahab WHERE الكود = 'مجموع' AND [اسم الصنف]= '" + cbname.Text +"'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dg.DataSource = dt;
            }
            catch (Exception ex)
            {
            //    MessageBox.Show(ex.ToString());
            }
            con.Close();

            //-------------------------------disable sorting--------------------------------------------------
            foreach (DataGridViewColumn column in dg.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
   
        }

        private void btnsell_Click(object sender, EventArgs e)
        {
            //---------------------------------------insert data buy report-------------------------------------
            string conString = "Data Source=.;Initial Catalog=store;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO dahab ([اسم الصنف],[الوزن],[العدد],[سعر الشراء],[سعر البيع],[اسم المشتري],[تاريخ البيع],[بيع])" +
                "VALUES ('" + cbname.Text + "' , '" + tbwei.Text + "','" + tbnum.Text + "','" + bprice.Text + "','" + sprice.Text + "','" + tbbuyname.Text + "','" + dtbuy.Value.Date + "','" + true + "');";
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
                cm.CommandText = "SELECT الوزن FROM dahab WHERE  الكود='مجموع'  AND [اسم الصنف] = '" + cbname.Text + "'";
             //   SqlDataReader readerz = cm.ExecuteReader();
                wazn = (double)cm.ExecuteScalar();
               // while (readerz.Read())
                {
               //     wazn = readerz.GetDecimal(0);
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
                cm.CommandText = "SELECT العدد FROM dahab WHERE الكود='مجموع' AND [اسم الصنف] = '" + cbname.Text + "'";
              //  SqlDataReader readerz = cm.ExecuteReader();
                adad = (double)cm.ExecuteScalar();
               // while (readerz.Read())
                {
               //     adad = readerz.GetDecimal(0);
                }
            }
            catch (Exception ex)
            {
            //    MessageBox.Show(ex.ToString());
            }
            con.Close();

            //---------------------------------------get data be3 to add the new number ------------------------------------
            con.Open();
            try
            {
                SqlCommand cm = new SqlCommand();
                cm.Connection = con;
                cm.CommandText = "SELECT [سعر البيع] FROM dahab WHERE الكود='مجموع' AND [اسم الصنف] = '" + cbname.Text + "'";
              //  SqlDataReader readerz = cm.ExecuteReader();
                bea = (double)cm.ExecuteScalar();
            //    while (readerz.Read())
                {
              //      bea = readerz.GetDecimal(0);
                }
            }
            catch (Exception ex)
            {
            //    MessageBox.Show(ex.ToString());
            }
            con.Close();

            //---------------------------------------get data shera to add the new number ------------------------------------
            con.Open();
            try
            {
                SqlCommand cm = new SqlCommand();
                cm.Connection = con;
                cm.CommandText = "SELECT [سعر الشراء] FROM dahab WHERE الكود='مجموع' AND [اسم الصنف] = '" + cbname.Text + "'";
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


            nwazn = wazn - double.Parse(tbwei.Text);
            nadad = adad - double.Parse(tbnum.Text);
            nbea = bea - double.Parse(sprice.Text);
            nshera = shera - double.Parse(bprice.Text);

            //---------------------------------------update the new number ------------------------------------
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = " UPDATE dahab SET [الوزن] = '" + nwazn + "', [العدد]= '" + nadad + "', [سعر البيع]= '" + nbea + "', [سعر الشراء]= '" + nshera + "'  WHERE الكود='مجموع' AND [اسم الصنف] = '" + cbname.Text + "'";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
             //   MessageBox.Show(ex.ToString());
            }
            con.Close();

            tbbuyname.Clear();
            tbnum.Clear();
            tbwei.Clear();
            sprice.Clear();
            bprice.Clear();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new main().Show();
            this.Hide();
        }
    }
}
