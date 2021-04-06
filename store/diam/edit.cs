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
    public partial class edit : Form
    {
                string ord = "", query="";
        int numb = 0;
        List<String> stringList = new List<String>();
        String[] stringArray;
        DataGridViewImageColumn buttonColumn = new DataGridViewImageColumn();

        public edit()
        {
            InitializeComponent();
        }

        private void srch_Click(object sender, EventArgs e)
        {
             id.Clear();
            //name.Clear();
            gweight.Clear();
            dweight.Clear();
            sprice.Clear();
            bprice.Clear();
            comp.Clear();
            buyno.Clear();
            ext1.Clear();
            ext2.Clear();
            ext3.Clear();
            ext4.Clear();
            ext5.Clear();
            note.Clear();
            //fullname = "";
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
                cmdzz.CommandText = "SELECT COUNT(الكود) FROM fmain WHERE [الكود]= '" + searchid.Text + "' ";
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
                cmd.CommandText = "SELECT [الكود],[اسم الصنف],[وزن ذهب],[وزن ماس],[اضافه 1],[اضافه 2],[اضافه 3],[اضافه 4],[اضافه 5],[سعر الشراء],[سعر البيع],[الشركة المنتجه],[اسم المشتري],[سعر بيع فعلي],[تاريخ البيع],[ملاحظات],[المكان],[معار],[وصل الاعارة],[وصل الضم],[تاريخ شراء] FROM fmain WHERE [الكود]= '" + searchid.Text + "' ";


                using (SqlDataReader sdr = cmd.ExecuteReader())
                {

                    sdr.Read();
                    id.Text = sdr["الكود"].ToString();
                    name.Text = sdr["اسم الصنف"].ToString();
                    gweight.Text = sdr["وزن ذهب"].ToString();
                    dweight.Text = sdr["وزن ماس"].ToString();
                    sprice.Text = sdr["سعر البيع"].ToString();
                    bprice.Text = sdr["سعر الشراء"].ToString();
                    comp.Text = sdr["الشركة المنتجه"].ToString();
                    place.Text = sdr["المكان"].ToString();
                    buyno.Text = sdr["وصل الضم"].ToString();
                    dtda.Text = sdr["تاريخ شراء"].ToString();
                    ext1.Text = sdr["اضافه 1"].ToString();
                    ext2.Text = sdr["اضافه 2"].ToString();
                    ext3.Text = sdr["اضافه 3"].ToString();
                    ext4.Text = sdr["اضافه 4"].ToString();
                    ext5.Text = sdr["اضافه 5"].ToString();
                    note.Text = sdr["ملاحظات"].ToString();

                }

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
            try{
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT الصوره FROM fmain  WHERE [الكود]= '" + searchid.Text + "' ";
                //tb.Text = cmd.CommandText;
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    string imp = reader.GetString(0);
                    if (imp != "" && imp != null && imp!="NULL")
                    {
                        string fileName = Path.GetFileName(imp);
                        string fullname = AppDomain.CurrentDomain.BaseDirectory + "\\" + fileName;
                        dg.Rows[i].Cells["picture"].Value = Image.FromFile(fullname);
                        i++;
                    }else{
                        i++;
                    }
                }
            }catch (Exception ex){
            //    MessageBox.Show(ex.ToString());
            }
            con.Close();

            //-------------------------------disable sorting--------------------------------------------------
            foreach (DataGridViewColumn column in dg.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            
  
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        private void adddata_Click(object sender, EventArgs e)
        {
            //------------------------------------edit data------------------------------
            string conString = "Data Source=.;Initial Catalog=store;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = " UPDATE fmain SET  [الكود] = '" + id.Text + "',[اسم الصنف] = '" + name.Text + "', [وزن ذهب]= '" + gweight.Text + "', [وزن ماس]= '" + dweight.Text + "', [سعر الشراء]= '" + bprice.Text + "', [سعر البيع ]= '" + sprice.Text + "', [الشركة المنتجه]= '" + comp.Text + "', [ملاحظات]= '" + note.Text + "', [المكان]= '" + place.Text + "', [وصل الضم]= '" + buyno.Text + "' WHERE [الكود]= '" + searchid.Text + "' ";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //   MessageBox.Show(ex.ToString());
            }
            con.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            new main().Show();
            this.Hide();
        }

        private void edit_Load(object sender, EventArgs e)
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
                cmd.CommandText = "SELECT الكود FROM fmain  ";
                SqlDataReader reader = cmd.ExecuteReader();
                AutoCompleteStringCollection idz = new AutoCompleteStringCollection();

                while (reader.Read())
                {
                    string x = reader.GetString(0);
                    idz.Add(x.ToString());
                    stringList.Add(x);
                }
                stringArray = stringList.ToArray();
                searchid.AutoCompleteCustomSource = idz;
            }
            catch (Exception ex)
            {
                //   MessageBox.Show(ex.ToString());
            }
            con.Close();
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //-------------------------------when click on pics-------------------------------------------------
            if (dg.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                if (dg.CurrentCell != null && dg.CurrentCell.Value != null)
                {
                    string conString = "Data Source=.;Initial Catalog=store;Integrated Security=True";
                    SqlConnection con = new SqlConnection(conString);
                    con.Open();

                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "SELECT الصوره FROM fmain WHERE  [الكود]= '" + searchid.Text + "' ";
                        //tb.Text = cmd.CommandText;
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
    }
}
