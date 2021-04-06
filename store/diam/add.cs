using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace store
{
    public partial class add : Form
    {
        Bitmap squareImage;
        string fullname;

        public add()
        {
            InitializeComponent();
            
        }

        //"K0" + DateTime.Now.ToString("yy") + "-" + ((Int32.Parse(textBox2.Text.Substring(textBox2.Text.LastIndexOf('-') + 1)) + 1).ToString());
        
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void adddata_Click(object sender, EventArgs e)
        {
                if (fullname != null){
                    Image yourImage = (Image)(new Bitmap(squareImage, new Size(1000,1000)));
                    yourImage.Save(fullname, ImageFormat.Jpeg);
                }

                string conString = "Data Source=.;Initial Catalog=store;Integrated Security=True";
                SqlConnection con = new SqlConnection(conString);
                try{
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO fmain ([الكود],[اسم الصنف],[وزن ذهب],[وزن ماس],[اضافه 1],[اضافه 2],[اضافه 3],[اضافه 4],[اضافه 5],[سعر الشراء],[سعر البيع],[الشركة المنتجه],[ملاحظات],[الصوره],[المكان],[وصل الضم],[تاريخ شراء])" +
                    "VALUES ('" + id.Text + "' , '" + name.Text + "','" + gweight.Text + "' ,'" + dweight.Text + "','" + ext1.Text + "','" + ext2.Text + "','" + ext3.Text + "','" + ext4.Text + "','" + ext5.Text + "','" + bprice.Text + "','" + sprice.Text + "','" + comp.Text + "','" + note.Text + "','" + fullname + "','" + place.Text + "','" + buyno.Text + "','" + dtda.Value.Date + "');";
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception b){
                    throw b;
                }
            
            //id name gold diam sell buy comp place loan loanno ext1 ext2 ext3 ext4 ext5 note fullname
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
            fullname = "";
        }

        private void browseimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                string path = open.FileName;
                
                
                
                string fileName = Path.GetFileName(path);
                fullname = Application.StartupPath + "\\" + fileName;
                System.IO.File.Copy(path, fullname);

                Bitmap bm = new Bitmap(path);
                int largestDimension = Math.Max(bm.Height, bm.Width);
                Size squareSize = new Size(largestDimension, largestDimension);
                squareImage = new Bitmap(squareSize.Width, squareSize.Height);
                using (Graphics graphics = Graphics.FromImage(squareImage))
                {
                    graphics.FillRectangle(Brushes.White, 0, 0, squareSize.Width, squareSize.Height);
                    graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                    graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    graphics.DrawImage(bm, (squareSize.Width / 2) - (bm.Width / 2), (squareSize.Height / 2) - (bm.Height / 2), bm.Width, bm.Height);
                }
                pictureBox1.Image = squareImage;
            }
        }

        private void add_Load(object sender, EventArgs e)
        {
            //-----------------------full screen----------------------
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new main().Show();
            this.Hide();
        }
    }
}
