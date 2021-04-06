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
    public partial class datadahab : Form
    {
        int numb = 0;
        string ord = "", query = "";
        List<String> stringList = new List<String>();
        public datadahab()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            //--------------------order by------------------------------
            string ocode = "", oname = "", ogold = "", odiam = "", obuy = "", osold = "", ocomp = "", onamebuy = "", odate = "",odato = "", oplace = "", selected = "";

            selected = this.sortin.GetItemText(this.sortin.SelectedItem);

            if (selected != "")
            {
                if (selected == "الكود")
                {
                    ocode = " ORDER BY [الكود] ASC";
                    ord = ocode;
                }
                if (selected == "اسم الصنف")
                {
                    oname = " ORDER BY [اسم الصنف] ASC";
                    ord = oname;
                }
                if (selected == "الوزن")
                {
                    ogold = " ORDER BY [الوزن] ASC";
                    ord = ogold;
                }
                if (selected == "العدد")
                {
                    odiam = " ORDER BY [العدد] ASC";
                    ord = odiam;
                }
                if (selected == "سعر شراء")
                {
                    obuy = " ORDER BY [سعر الشراء] ASC";
                    ord = obuy;
                }
                if (selected == "سعر بيع")
                {
                    osold = " ORDER BY [سعر البيع] ASC";
                    ord = osold;
                }
                if (selected == "الشركة المنتجه")
                {
                    ocomp = " ORDER BY [الشركة المنتجة] ASC";
                    ord = ocomp;
                }
                if (selected == "اسم المشتري")
                {
                    onamebuy = " ORDER BY [اسم المشتري] ASC";
                    ord = onamebuy;
                }
                if (selected == "تاريخ البيع")
                {
                    odate = " ORDER BY [تاريخ البيع] ASC";
                    ord = odate;
                }
                if (selected == "المكان")
                {
                    oplace = " ORDER BY المكان ASC";
                    ord = oplace;
                }
                if (selected == "تاريخ الضم")
                {
                    odato = " ORDER BY [تاريخ الضم] ASC";
                    ord = odato;
                }

            }


            //------------filter by--------code name compa sold buyname dtfrom dtto------------------------------
            string wh = "", cq = "", nq = "", sq = "", bnq = "", dtz = "", com = "", pnq = "", psq = "", pcom = "", pbnq = "", pdtz = "", sshow = "", showzi = "", pshowzi = "",ddam="",pddam="",pl="",ppl="";

            sshow = this.cbshow.GetItemText(this.cbshow.SelectedItem);

            if (code.Text != "")
            {
                wh = " WHERE ";
                cq = " [الكود] = '" + code.Text + "' ";
            }
            if (name.Text != "")
            {
                wh = " WHERE ";
                if (code.Text != "")
                {
                    pnq = " AND ";
                }
                else
                {
                    pnq = "";
                }
                nq = pnq + " [اسم الصنف] = '" + name.Text + "' ";
            }
            if (compa.Text != "")
            {
                wh = " WHERE ";
                if (code.Text != "" || name.Text != "")
                {
                    pcom = " AND ";
                }
                else
                {
                    pcom = "";
                }
                com = pcom + " [الشركة المنتجة] = '" + compa.Text + "' ";
            }
            if (checkdt.Checked)
            {
                wh = " WHERE ";
                if (code.Text != "" || name.Text != "" || compa.Text != "")
                {
                    pdtz = " AND ";
                }
                else
                {
                    pdtz = "";
                }
                dtz = pdtz + " [تاريخ البيع] BETWEEN '" + dtfrom.Value.Date + "' AND '" + dtto.Value.Date + "'";
            }
            if (sshow != "")
            {
                wh = " WHERE ";
                if (code.Text != "" || name.Text != "" || compa.Text != "" || checkdt.Checked)
                {
                    pshowzi = " AND ";
                }
                else
                {
                    pshowzi = "";
                }
                
                if (sshow == "شراء")
                {
                    showzi = pshowzi + " [شراء] IS NOT NULL ";
                    buyname.Enabled = false;
                }
                else if (sshow == "مجموع")
                {
                    showzi = pshowzi + " [الكود] = '" + "مجموع" + "' ";
                    buyname.Enabled = false;
                }
                else if (sshow == "بيع")
                {
                    showzi = pshowzi + " [بيع] IS NOT NULL ";
                    buyname.Enabled = true;
                }
                else if (sshow == "الكل")
                {
                    showzi = pshowzi + "  NOT [الكود] = '" + "مجموع" + "' ";
                    buyname.Enabled = false;
                }

            }
            if (checkdam.Checked)
            {
                wh = " WHERE ";
                if (code.Text != "" || name.Text != "" || compa.Text != "" || checkdt.Checked || sshow != "")
                {
                    pddam = " AND ";
                }
                else
                {
                    pddam = "";
                }
                ddam = pddam + " [تاريخ الضم] BETWEEN '" + dfromdam.Value.Date + "' AND '" + dtodam.Value.Date + "'";
            }
            if (cbplace.Text != "") {
                wh = " WHERE ";
                if (code.Text != "" || name.Text != "" || compa.Text != "" || checkdt.Checked || sshow != "" || checkdam.Checked)
                {
                    ppl = " AND ";
                }
                else
                {
                    ppl = "";
                }
                pl = ppl + " [المكان] ='"+ cbplace.Text +"'";

            }


            query = wh + cq + nq + com + sq + bnq + dtz + showzi + ddam + pl;

            string conStrin = "Data Source=.;Initial Catalog=store;Integrated Security=True";
            SqlConnection co = new SqlConnection(conStrin);
            //------------------------------------ COUNT ID ------------------------------
            co.Open();
            try
            {
                SqlCommand cmdzz = new SqlCommand();
                cmdzz.Connection = co;
                cmdzz.CommandText = "SELECT COUNT(الكود) FROM dahab" + query + ord; ;
                SqlDataReader readerzz = cmdzz.ExecuteReader();

                while (readerzz.Read())
                {
                    numb = readerzz.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
            co.Close();

            double sg = 0, sd = 0, ss = 0, sb = 0;
            //------------------------------------ SUM GOLD ------------------------------
            co.Open();
            try
            {
                SqlCommand cmdsg = new SqlCommand();
                cmdsg.Connection = co;
                cmdsg.CommandText = "SELECT SUM([الوزن]) FROM dahab" + query + ord;
                sg = (double)cmdsg.ExecuteScalar();
              //  SqlDataReader readersg = cmdsg.ExecuteReader();

             //   while (readersg.Read())
                {
             //       sg = readersg.GetDecimal(0);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            co.Close();

            //------------------------------------ SUM DIAM ------------------------------
            co.Open();
            try
            {
                SqlCommand cmdsd = new SqlCommand();
                cmdsd.Connection = co;
                cmdsd.CommandText = "SELECT SUM([العدد]) FROM dahab" + query + ord;
                sd = (double)cmdsd.ExecuteScalar();
            //    SqlDataReader readersd = cmdsd.ExecuteReader();

             //   while (readersd.Read())
                {
               //     sd = readersd.GetDecimal(0);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            co.Close();
            //------------------------------------ SUM SELL ------------------------------
            co.Open();
            try
            {
                SqlCommand cmdss = new SqlCommand();
                cmdss.Connection = co;
                cmdss.CommandText = "SELECT SUM([سعر البيع]) FROM dahab" + query + ord;
                ss = (double)cmdss.ExecuteScalar();
                //SqlDataReader readerss = cmdss.ExecuteReader();

            //    while (readerss.Read())
                {
              //      ss = readerss.GetDecimal(0);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            co.Close();
            //------------------------------------ SUM BUY ------------------------------
            co.Open();
            try
            {
                SqlCommand cmdsb = new SqlCommand();
                cmdsb.Connection = co;
                cmdsb.CommandText = "SELECT SUM([سعر الشراء]) FROM dahab" + query + ord;
                sb = (double)cmdsb.ExecuteScalar();
              //  SqlDataReader readersb = cmdsb.ExecuteReader();

               // while (readersb.Read())
                {
               //     sb = readersb.GetDecimal(0);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            co.Close();
            sgold.Text = sg.ToString();
            sdiam.Text = sd.ToString();
            ssel.Text = ss.ToString();
            sbuy.Text = sb.ToString();
            coun.Text = numb.ToString();

            //------------------------------------Show all data------------------------------
            string conString = "Data Source=.;Initial Catalog=store;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT [الكود],[اسم الصنف],[الوزن],[العدد],[سعر الشراء],[سعر البيع],[الشركة المنتجة],[تاريخ الضم],[تاريخ البيع],[وصل الضم],[المكان],[اسم المشتري],[معار],[وصل الاعارة],[ملاحظات ] FROM dahab" + query + " " + ord;
////////////////////////////////////////////////////////
            //    tb.Text = cmd.CommandText;
///////////////////////////////////////////////////////
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dg.DataSource = dt;
            }
            catch (Exception ex)
            {
             //   MessageBox.Show(ex.ToString());
            }
            con.Close();

            //-------------------------------disable sorting--------------------------------------------------
            foreach (DataGridViewColumn column in dg.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
   
        }

        private void datadahab_Load(object sender, EventArgs e)
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
            //dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);

            dg.AllowUserToResizeColumns = true;
            dg.AllowUserToOrderColumns = true;

            //------------------save list of cods for autocomplete-------------
            string conString = "Data Source=.;Initial Catalog=store;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT الكود FROM dahab " + " " + ord;
                SqlDataReader reader = cmd.ExecuteReader();
                AutoCompleteStringCollection idz = new AutoCompleteStringCollection();

                while (reader.Read())
                {
                    string x = reader.GetString(0);
                    idz.Add(x.ToString());
                }
                code.AutoCompleteCustomSource = idz;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            con.Close();

            //------------------save list of cods for autocomplete comp name-------------
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT [الشركة المنتجة] FROM dahab " + " " + ord;
                SqlDataReader reader = cmd.ExecuteReader();
                AutoCompleteStringCollection compz = new AutoCompleteStringCollection();

                while (reader.Read())
                {
                    if (reader.GetString(0) != null)
                    {
                        string x = reader.GetString(0);
                        compz.Add(x.ToString());
                    }
                }
                compa.AutoCompleteCustomSource = compz;
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.ToString());
            }
            con.Close();

            //------------------save list of cods for autocomplete buy name-------------
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT [اسم المشتري] FROM dahab " + " " + ord;
                SqlDataReader reader = cmd.ExecuteReader();
                AutoCompleteStringCollection buyz = new AutoCompleteStringCollection();

                while (reader.Read())
                {
                    if (reader.GetString(0) != null)
                    {
                        string x = reader.GetString(0);
                        buyz.Add(x.ToString());
                    }
                }
                buyname.AutoCompleteCustomSource = buyz;
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.ToString());
            }
            con.Close();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void sold_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new main().Show();
            this.Hide();
        }

        private void checkdt_CheckedChanged(object sender, EventArgs e)
        {
            if (checkdt.Checked)
            {
                dtfrom.Enabled = true;
                dtto.Enabled = true;
            }
            else
            {
                dtfrom.Enabled = false;
                dtto.Enabled = false;
            }
        }

        private void checkdam_CheckedChanged(object sender, EventArgs e)
        {
            if (checkdam.Checked)
            {
                dfromdam.Enabled = true;
                dtodam.Enabled = true;
            }
            else
            {
                dfromdam.Enabled = false;
                dtodam.Enabled = false;
            }
        }

        private void cbshow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbshow.Text == "مجموع" || cbshow.Text == "شراء")
            {
                buyname.Enabled = false;
            }
            else
            {
                buyname.Enabled = true;
            }
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
