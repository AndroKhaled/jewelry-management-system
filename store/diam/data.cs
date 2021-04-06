using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace store
{
    public partial class data : Form
    {
        string ord = "", query="";
        int numb = 0;
        List<String> stringList = new List<String>();
        String[] stringArray;
        DataGridViewImageColumn buttonColumn = new DataGridViewImageColumn();

        
        public data()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //--------------------order by------------------------------
            string ocode = "", oname = "", ogold = "", odiam = "", obuy = "", osold = "", ocomp = "", onamebuy = "", odate = "", oplace = "", selected = "";
            //ORDER BY [اسم الصنف] ASC

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
                if (selected == "وزن ذهب")
                {
                    ogold = " ORDER BY [وزن ذهب] ASC";
                    ord = ogold;
                }
                if (selected == "وزن ماس")
                {
                    odiam = " ORDER BY [وزن ماس] ASC";
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
                    ocomp = " ORDER BY [الشركة المنتجه] ASC";
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

            }


            //------------filter by--------code name compa sold buyname dtfrom dtto------------------------------
            string wh = "", cq = "", nq = "", sq = "", bnq = "", dtz = "", com = "", pnq = "", psq = "", pcom = "", pbnq = "", pdtz = "", pl = "", ppl = "", ddam = "", pddam = "";

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
                com = pcom + " [الشركة المنتجه] = '" + compa.Text + "' ";
            }
            if (cbso.Text != "")
            {
                if (cbso.Text == "الكل")
                {
                    buyname.Enabled = false;
                }
                else if (cbso.Text == "بيع")
                {
                    wh = " WHERE ";
                    if (code.Text != "" || name.Text != "" || compa.Text != "")
                    {
                        psq = " AND ";
                    }
                    else
                    {
                        psq = "";
                    }
                    sq = psq + " [اسم المشتري] IS NOT NULL";
                    buyname.Enabled = true;
                    if (buyname.Text != "")
                    {
                        if (code.Text != "" || name.Text != "" || compa.Text != "")
                        {
                            pbnq = " AND ";
                        }
                        else
                        {
                            pbnq = "";
                        }

                        bnq = pbnq + " [اسم المشتري] = '" + buyname.Text + "' ";
                        sq = "";
                    }
                }
                else if (cbso.Text == "شراء")
                {
                    buyname.Enabled = false;
                    wh = " WHERE ";
                    if (code.Text != "" || name.Text != "" || compa.Text != "")
                    {
                        psq = " AND ";
                    }
                    else
                    {
                        psq = "";
                    }
                    sq = psq + " [اسم المشتري] IS NULL";
                }
            }
            if (checkdt.Checked)
            {
                wh = " WHERE ";
                if (code.Text != "" || name.Text != "" || compa.Text != "" || cbso.Text != "")
                {
                    pdtz = " AND ";
                }
                else
                {
                    pdtz = "";
                }
                dtz = pdtz + " [تاريخ البيع] BETWEEN '" + dtfrom.Value.Date + "' AND '" + dtto.Value.Date + "'";

            }
            if (cbplace.Text != "")
            {
                wh = " WHERE ";
                if (code.Text != "" || name.Text != "" || compa.Text != "" || cbso.Text != "" || checkdt.Checked)
                {
                    ppl = " AND ";
                }
                else
                {
                    ppl = "";
                }
                pl = ppl + " [المكان] ='" + cbplace.Text + "'";

            }
            if (checkdam.Checked)
            {
                wh = " WHERE ";
                if (code.Text != "" || name.Text != "" || compa.Text != "" || cbso.Text != "" || checkdt.Checked || cbplace.Text != "")
                {
                    pddam = " AND ";
                }
                else
                {
                    pddam = "";
                }
                ddam = pddam + " [تاريخ شراء] BETWEEN '" + dfromdam.Value.Date + "' AND '" + dtodam.Value.Date + "'";
            }
                query = wh + cq + nq + com + sq + bnq + dtz + pl + ddam;


                stringList.Clear();
                //------------------save list of cods for pics-------------
                string conStrin = "Data Source=.;Initial Catalog=store;Integrated Security=True";
                SqlConnection co = new SqlConnection(conStrin);
                co.Open();
                try
                {
                    SqlCommand cm = new SqlCommand();
                    cm.Connection = co;
                    cm.CommandText = "SELECT الكود FROM fmain " + query + ord;
                    SqlDataReader readerz = cm.ExecuteReader();
                    while (readerz.Read())
                    {
                        string x = readerz.GetString(0);
                        stringList.Add(x);
                    }
                    stringArray = stringList.ToArray();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString());
                }
                co.Close();

                //-------------------------------count codes for pics-------------------------
                string conStringzz = "Data Source=.;Initial Catalog=store;Integrated Security=True";
                SqlConnection conzz = new SqlConnection(conStringzz);
                conzz.Open();
                try
                {
                    SqlCommand cmdzz = new SqlCommand();
                    cmdzz.Connection = conzz;
                    cmdzz.CommandText = "SELECT COUNT(الكود) FROM fmain" + query + ord; ;
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
                conzz.Close();

                double sg = 0, sd = 0, ss = 0, sb = 0, ssf = 0;
                //numb
                //------------------------------------ SUM GOLD ------------------------------
                conzz.Open();
                try
                {
                    SqlCommand cmdsg = new SqlCommand();
                    cmdsg.Connection = conzz;
                    cmdsg.CommandText = "SELECT SUM([وزن ذهب]) FROM fmain" + query + ord;
                    sg = (double)cmdsg.ExecuteScalar();
                    //  SqlDataReader readersg = cmdsg.ExecuteReader();

                    //  while (readersg.Read())
                    {
                        //      sg = readersg.GetFloat(0);
                    }
                }
                catch (Exception ex)
                {
                    //   MessageBox.Show(ex.ToString());
                }
                conzz.Close();

                //------------------------------------ SUM DIAM ------------------------------
                conzz.Open();
                try
                {
                    SqlCommand cmdsd = new SqlCommand();
                    cmdsd.Connection = conzz;
                    cmdsd.CommandText = "SELECT SUM([وزن ماس]) FROM fmain" + query + ord;
                    sd = (double)cmdsd.ExecuteScalar();
                    // SqlDataReader readersd = cmdsd.ExecuteReader();

                    //  while (readersd.Read())
                    {
                        //     sd = readersd.GetFloat(0);
                    }
                }
                catch (Exception ex)
                {
                    //   MessageBox.Show(ex.ToString());
                }
                conzz.Close();
                //------------------------------------ SUM SELL ------------------------------
                conzz.Open();
                try
                {
                    SqlCommand cmdss = new SqlCommand();
                    cmdss.Connection = conzz;
                    cmdss.CommandText = "SELECT SUM([سعر البيع]) FROM fmain" + query + ord;
                    ss = (double)cmdss.ExecuteScalar();
                    //    SqlDataReader readerss = cmdss.ExecuteReader();

                    //   while (readerss.Read())
                    {
                        //      ss = readerss.GetFloat(0);
                    }
                }
                catch (Exception ex)
                {
                    //   MessageBox.Show(ex.ToString());
                }
                conzz.Close();
                //------------------------------------ SUM BUY ------------------------------
                conzz.Open();
                try
                {
                    SqlCommand cmdsb = new SqlCommand();
                    cmdsb.Connection = conzz;
                    cmdsb.CommandText = "SELECT SUM([سعر الشراء]) FROM fmain" + query + ord;
                    sb = (double)cmdsb.ExecuteScalar();
                    //  SqlDataReader readersb = cmdsb.ExecuteReader();

                    //  while (readersb.Read())
                    {
                        //       sb = readersb.GetFloat(0);
                    }
                }
                catch (Exception ex)
                {
                    //   MessageBox.Show(ex.ToString());
                }
                conzz.Close();
                //------------------------------------ SUM Sell F ------------------------------
                conzz.Open();
                try
                {
                    SqlCommand cmdsb = new SqlCommand();
                    cmdsb.Connection = conzz;
                    cmdsb.CommandText = "SELECT SUM([سعر بيع فعلي]) FROM fmain" + query + ord;
                    ssf = (double)cmdsb.ExecuteScalar();
                    //  SqlDataReader readersb = cmdsb.ExecuteReader();

                    //  while (readersb.Read())
                    {
                        //       sb = readersb.GetFloat(0);
                    }
                }
                catch (Exception ex)
                {
                    //   MessageBox.Show(ex.ToString());
                }
                conzz.Close();


                sellf.Text = ssf.ToString();
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
                    //--------------3shan myzwdsh col. kol ma ndos-----------------------------
                    if (dg.Columns.Contains("picture") == true)
                    {
                        dg.Columns.Remove("picture");
                    }

                    if (dg.ColumnCount != 16)
                        dg.Columns.Add(buttonColumn);
                    buttonColumn.HeaderText = "الصورة";
                    buttonColumn.Name = "picture";
                    buttonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT [الكود],[اسم الصنف],[وزن ذهب],[وزن ماس],[اضافه 1],[اضافه 2],[اضافه 3],[اضافه 4],[اضافه 5],[سعر الشراء],[سعر البيع],[الشركة المنتجه],[اسم المشتري],[سعر بيع فعلي],[تاريخ البيع],[ملاحظات],[المكان],[معار],[وصل الاعارة],[وصل الضم],[تاريخ شراء] FROM fmain" + query + " " + ord;
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


                con.Open();
                //-------------------------------show pics only-------------------------------------------------
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT الصوره FROM fmain" + query + " " + ord;
                    //tb.Text = cmd.CommandText;
                    cmd.ExecuteNonQuery();
                    SqlDataReader reader = cmd.ExecuteReader();
                    int i = 0;
                    while (reader.Read())
                    {
                        string imp = reader.GetString(0);
                        if (imp != "" && imp != null && imp != "NULL")
                        {
                            string fileName = Path.GetFileName(imp);
                            string fullname = AppDomain.CurrentDomain.BaseDirectory + "\\" + fileName;
                            dg.Rows[i].Cells["picture"].Value = Image.FromFile(fullname);
                            i++;
                        }
                        else
                        {
                            i++;
                        }
                    }
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
        
        

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //-------------------------------when click on pics-------------------------------------------------
            if (dg.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                if (dg.CurrentCell != null && dg.CurrentCell.Value != null )
                {
                    string conString = "Data Source=.;Initial Catalog=store;Integrated Security=True";
                    SqlConnection con = new SqlConnection(conString);
                    con.Open();

                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        if (query != "")
                        {
                            cmd.CommandText = "SELECT الصوره FROM fmain " + query + " AND الكود = '" + stringArray[dg.CurrentCell.RowIndex] + "' " + ord;
                        }
                        else {
                            cmd.CommandText = "SELECT الصوره FROM fmain WHERE الكود = '" + stringArray[dg.CurrentCell.RowIndex] + "' " + ord;
                         
                        }
                        
                        tb.Text = cmd.CommandText;
                        cmd.ExecuteNonQuery();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            string imp = reader.GetString(0);
                            if (imp != "" && imp != null)
                            {
                                string fileName = Path.GetFileName(imp);
                                string fullname = Application.StartupPath + "\\" + fileName;
                                               Form form = new Form();
                                PictureBox pictureBox = new PictureBox();
                                pictureBox.Dock = DockStyle.Fill;
                                pictureBox.Image = Image.FromFile(fullname);
                                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                                form.Controls.Add(pictureBox);
                                form.TopMost = true;
                                form.Width = Screen.PrimaryScreen.WorkingArea.Height;
                                form.Height = Screen.PrimaryScreen.WorkingArea.Height;
                                form.Focus();
                                form.ShowDialog();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                     //   MessageBox.Show(ex.ToString());
                    }
                    con.Close();
                }
            }
        }

        private void data_Load(object sender, EventArgs e)
        {
            //-----------------------full screen----------------------
            this.TopMost = true;
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

            //------------------save list of cods for autocomplete id-------------
            string conString = "Data Source=.;Initial Catalog=store;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT الكود FROM fmain " + " " + ord;
                SqlDataReader reader = cmd.ExecuteReader();
                AutoCompleteStringCollection idz = new AutoCompleteStringCollection();

                while (reader.Read())
                {
                    string x = reader.GetString(0);
                    idz.Add(x.ToString());
                    stringList.Add(x);
                }
                stringArray = stringList.ToArray();
                code.AutoCompleteCustomSource = idz;
            }
            catch (Exception ex)
            {
             //   MessageBox.Show(ex.ToString());
            }
            con.Close();

            //------------------save list of cods for autocomplete comp name-------------
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT [الشركة المنتجه] FROM fmain " + " " + ord;
                SqlDataReader reader = cmd.ExecuteReader();
                AutoCompleteStringCollection compz = new AutoCompleteStringCollection();

                while (reader.Read())
                {
                    string x = reader.GetString(0);
                    compz.Add(x.ToString());
                }
                compa.AutoCompleteCustomSource = compz;
            }
            catch (Exception ex)
            {
              //  MessageBox.Show(ex.ToString());
            }
            con.Close();

            //------------------save list of cods for autocomplete buy name-------------
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT [اسم المشتري] FROM fmain " + " " + ord;
                SqlDataReader reader = cmd.ExecuteReader();
                AutoCompleteStringCollection buyz = new AutoCompleteStringCollection();

                while (reader.Read())
                {
                    string x = reader.GetString(0);
                    buyz.Add(x.ToString());
                }
                buyname.AutoCompleteCustomSource = buyz;
            }
            catch (Exception ex)
            {
             //   MessageBox.Show(ex.ToString());
            }
            con.Close();
            
            //-------------------------------count codes for pics-------------------------
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT COUNT(الكود) FROM fmain";
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    numb = reader.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
           //     MessageBox.Show(ex.ToString());
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            new main().Show();
            this.Hide();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

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

        private void sortin_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void cbso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbso.Text == "الكل" || cbso.Text == "شراء")
            {
                buyname.Enabled = false;
            }
            else
            {
                buyname.Enabled = true;
            }
        }
    }
}