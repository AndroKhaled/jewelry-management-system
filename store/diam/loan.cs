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
    public partial class loan : Form
    {
        AutoCompleteStringCollection idz = new AutoCompleteStringCollection();
        DataGridViewImageColumn buttonColumn = new DataGridViewImageColumn();
        public loan()
        {
            InitializeComponent();
        }

        private void loan_Load(object sender, EventArgs e)
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

            //------------------save list of cods for pics-------------
            string conString = "Data Source=.;Initial Catalog=store;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT الكود FROM fmain";
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    idz.Add(reader.GetString(0));
                    //  stringList.Add(x);
                }
                // stringArray = stringList.ToArray();
                txtid.AutoCompleteCustomSource = idz;
            }
            catch (Exception ex)
            {
            //    MessageBox.Show(ex.ToString());
            }
            con.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
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
                cmd.CommandText = "SELECT [الكود],[اسم الصنف],[وزن ذهب],[وزن ماس],[اضافه 1],[اضافه 2],[اضافه 3],[اضافه 4],[اضافه 5],[سعر الشراء],[سعر البيع],[الشركة المنتجه],[اسم المشتري],[تاريخ البيع],[ملاحظات],[المكان],[معار],[وصل الاعارة] FROM fmain WHERE [الكود]= '" + txtid.Text + "' ";
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
                cmd.CommandText = "SELECT الصوره FROM fmain WHERE [الكود]= '" + txtid.Text + "' ";

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
             //   MessageBox.Show(ex.ToString());
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
                        cmd.CommandText = "SELECT الصوره FROM fmain WHERE [الكود]= '" + txtid.Text + "' ";
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

        private void btnsell_Click(object sender, EventArgs e)
        {
            //------------------------------------edit data------------------------------
            string conString = "Data Source=.;Initial Catalog=store;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = " UPDATE fmain SET [معار] = '" + txtname.Text + "', [وصل الاعارة]= '" + txtloan.Text + "' WHERE [الكود]= '" + txtid.Text + "' ";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            //    MessageBox.Show(ex.ToString());
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new main().Show();
            this.Hide();
        }
    }
}
