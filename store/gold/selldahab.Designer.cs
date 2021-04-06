namespace store
{
    partial class selldahab
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.btnsell = new System.Windows.Forms.Button();
            this.dtbuy = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbbuyname = new System.Windows.Forms.TextBox();
            this.dg = new System.Windows.Forms.DataGridView();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbnum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbwei = new System.Windows.Forms.TextBox();
            this.cbname = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sprice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bprice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(1154, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 38);
            this.button1.TabIndex = 49;
            this.button1.Text = "رجوع";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsell
            // 
            this.btnsell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnsell.Location = new System.Drawing.Point(13, 429);
            this.btnsell.Name = "btnsell";
            this.btnsell.Size = new System.Drawing.Size(93, 37);
            this.btnsell.TabIndex = 47;
            this.btnsell.Text = "بيع";
            this.btnsell.UseVisualStyleBackColor = true;
            this.btnsell.Click += new System.EventHandler(this.btnsell_Click);
            // 
            // dtbuy
            // 
            this.dtbuy.Location = new System.Drawing.Point(953, 269);
            this.dtbuy.Name = "dtbuy";
            this.dtbuy.Size = new System.Drawing.Size(200, 20);
            this.dtbuy.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(1159, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 45;
            this.label9.Text = "تاريخ البيع";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(1159, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 20);
            this.label10.TabIndex = 44;
            this.label10.Text = "اسم المشتري";
            // 
            // tbbuyname
            // 
            this.tbbuyname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbbuyname.Location = new System.Drawing.Point(953, 226);
            this.tbbuyname.Name = "tbbuyname";
            this.tbbuyname.Size = new System.Drawing.Size(200, 26);
            this.tbbuyname.TabIndex = 43;
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg.Location = new System.Drawing.Point(13, 85);
            this.dg.MultiSelect = false;
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dg.ShowCellErrors = false;
            this.dg.ShowCellToolTips = false;
            this.dg.ShowEditingIcon = false;
            this.dg.ShowRowErrors = false;
            this.dg.Size = new System.Drawing.Size(1240, 85);
            this.dg.TabIndex = 42;
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnsearch.Location = new System.Drawing.Point(13, 13);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(93, 37);
            this.btnsearch.TabIndex = 41;
            this.btnsearch.Text = "بحث";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(1159, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "الصنف";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(704, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "العدد";
            // 
            // tbnum
            // 
            this.tbnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbnum.Location = new System.Drawing.Point(498, 229);
            this.tbnum.Name = "tbnum";
            this.tbnum.Size = new System.Drawing.Size(200, 26);
            this.tbnum.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(704, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "الوزن";
            // 
            // tbwei
            // 
            this.tbwei.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbwei.Location = new System.Drawing.Point(498, 265);
            this.tbwei.Name = "tbwei";
            this.tbwei.Size = new System.Drawing.Size(200, 26);
            this.tbwei.TabIndex = 52;
            // 
            // cbname
            // 
            this.cbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbname.FormattingEnabled = true;
            this.cbname.Items.AddRange(new object[] {
            "خاتم",
            "اسوره",
            "حلق",
            "دلايه",
            "كوليه",
            "توينز",
            "سلاسل",
            "دبل ",
            "شاسيه",
            "تركيب"});
            this.cbname.Location = new System.Drawing.Point(953, 22);
            this.cbname.Name = "cbname";
            this.cbname.Size = new System.Drawing.Size(200, 28);
            this.cbname.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(308, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "سعر البيع";
            // 
            // sprice
            // 
            this.sprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sprice.Location = new System.Drawing.Point(102, 265);
            this.sprice.Name = "sprice";
            this.sprice.Size = new System.Drawing.Size(200, 26);
            this.sprice.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(308, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "سعر الشراء";
            // 
            // bprice
            // 
            this.bprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bprice.Location = new System.Drawing.Point(102, 229);
            this.bprice.Name = "bprice";
            this.bprice.Size = new System.Drawing.Size(200, 26);
            this.bprice.TabIndex = 55;
            // 
            // selldahab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 480);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sprice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bprice);
            this.Controls.Add(this.cbname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbwei);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbnum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsell);
            this.Controls.Add(this.dtbuy);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbbuyname);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.label1);
            this.Name = "selldahab";
            this.Text = "بيع";
            this.Load += new System.EventHandler(this.selldahab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnsell;
        private System.Windows.Forms.DateTimePicker dtbuy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbbuyname;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbnum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbwei;
        private System.Windows.Forms.ComboBox cbname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bprice;
    }
}