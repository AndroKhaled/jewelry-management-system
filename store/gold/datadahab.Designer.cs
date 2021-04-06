namespace store
{
    partial class datadahab
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.checkdt = new System.Windows.Forms.CheckBox();
            this.name = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TextBox();
            this.sortin = new System.Windows.Forms.ComboBox();
            this.dtto = new System.Windows.Forms.DateTimePicker();
            this.dtfrom = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buyname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.compa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.dg = new System.Windows.Forms.DataGridView();
            this.cbshow = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.checkdam = new System.Windows.Forms.CheckBox();
            this.dtodam = new System.Windows.Forms.DateTimePicker();
            this.dfromdam = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.ssel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.sbuy = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.sdiam = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.sgold = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbplace = new System.Windows.Forms.ComboBox();
            this.coun = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // checkdt
            // 
            this.checkdt.AutoSize = true;
            this.checkdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkdt.Location = new System.Drawing.Point(463, 15);
            this.checkdt.Name = "checkdt";
            this.checkdt.Size = new System.Drawing.Size(15, 14);
            this.checkdt.TabIndex = 82;
            this.checkdt.UseVisualStyleBackColor = true;
            this.checkdt.CheckedChanged += new System.EventHandler(this.checkdt_CheckedChanged);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.name.FormattingEnabled = true;
            this.name.Items.AddRange(new object[] {
            "خاتم",
            "اسوره",
            "حلق",
            "دلايه",
            "كوليه",
            "توينز",
            "سلاسل",
            "دبل ",
            "شاسيه",
            "تركيب",
            "حجر مدور",
            "حجر ناعم"});
            this.name.Location = new System.Drawing.Point(1109, 40);
            this.name.Name = "name";
            this.name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name.Size = new System.Drawing.Size(84, 28);
            this.name.TabIndex = 81;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(1145, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 38);
            this.button1.TabIndex = 80;
            this.button1.Text = "رجوع";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(1199, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 79;
            this.label4.Text = "اسم الصنف";
            // 
            // tb
            // 
            this.tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb.Location = new System.Drawing.Point(23, 487);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(1221, 26);
            this.tb.TabIndex = 78;
            // 
            // sortin
            // 
            this.sortin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sortin.FormattingEnabled = true;
            this.sortin.Items.AddRange(new object[] {
            "الكود",
            "اسم الصنف",
            "الوزن",
            "العدد",
            "سعر شراء",
            "سعر بيع",
            "الشركة المنتجه",
            "اسم المشتري",
            "تاريخ البيع",
            "تاريخ الضم",
            "المكان"});
            this.sortin.Location = new System.Drawing.Point(1109, 74);
            this.sortin.Name = "sortin";
            this.sortin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sortin.Size = new System.Drawing.Size(84, 28);
            this.sortin.TabIndex = 76;
            // 
            // dtto
            // 
            this.dtto.Enabled = false;
            this.dtto.Location = new System.Drawing.Point(480, 49);
            this.dtto.Name = "dtto";
            this.dtto.Size = new System.Drawing.Size(200, 20);
            this.dtto.TabIndex = 75;
            // 
            // dtfrom
            // 
            this.dtfrom.Enabled = false;
            this.dtfrom.Location = new System.Drawing.Point(480, 12);
            this.dtfrom.Name = "dtfrom";
            this.dtfrom.Size = new System.Drawing.Size(200, 20);
            this.dtfrom.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(686, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 20);
            this.label8.TabIndex = 73;
            this.label8.Text = "الي";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(686, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 20);
            this.label7.TabIndex = 72;
            this.label7.Text = "من";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(704, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 71;
            this.label6.Text = "تاريخ البيع";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(1025, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 70;
            this.label5.Text = "اسم المشتري";
            // 
            // buyname
            // 
            this.buyname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.buyname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.buyname.Enabled = false;
            this.buyname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buyname.Location = new System.Drawing.Point(923, 78);
            this.buyname.Name = "buyname";
            this.buyname.Size = new System.Drawing.Size(98, 26);
            this.buyname.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(1027, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "اسم الشركة";
            // 
            // compa
            // 
            this.compa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.compa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.compa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.compa.Location = new System.Drawing.Point(923, 8);
            this.compa.Name = "compa";
            this.compa.Size = new System.Drawing.Size(98, 26);
            this.compa.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(1199, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "ترتيب بــ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(1212, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "الكود";
            // 
            // code
            // 
            this.code.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.code.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.code.Location = new System.Drawing.Point(1109, 7);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(84, 26);
            this.code.TabIndex = 64;
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.search.Location = new System.Drawing.Point(22, 5);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(93, 37);
            this.search.TabIndex = 63;
            this.search.Text = "بحث";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg.DefaultCellStyle = dataGridViewCellStyle4;
            this.dg.Location = new System.Drawing.Point(22, 113);
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
            this.dg.Size = new System.Drawing.Size(1222, 318);
            this.dg.TabIndex = 62;
            this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
            // 
            // cbshow
            // 
            this.cbshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbshow.FormattingEnabled = true;
            this.cbshow.Items.AddRange(new object[] {
            "الكل",
            "شراء",
            "بيع",
            "مجموع"});
            this.cbshow.Location = new System.Drawing.Point(923, 43);
            this.cbshow.Name = "cbshow";
            this.cbshow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbshow.Size = new System.Drawing.Size(98, 28);
            this.cbshow.TabIndex = 92;
            this.cbshow.SelectedIndexChanged += new System.EventHandler(this.cbshow_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(1027, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 20);
            this.label13.TabIndex = 91;
            this.label13.Text = "اظهار";
            // 
            // checkdam
            // 
            this.checkdam.AutoSize = true;
            this.checkdam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkdam.Location = new System.Drawing.Point(145, 14);
            this.checkdam.Name = "checkdam";
            this.checkdam.Size = new System.Drawing.Size(15, 14);
            this.checkdam.TabIndex = 98;
            this.checkdam.UseVisualStyleBackColor = true;
            this.checkdam.CheckedChanged += new System.EventHandler(this.checkdam_CheckedChanged);
            // 
            // dtodam
            // 
            this.dtodam.Enabled = false;
            this.dtodam.Location = new System.Drawing.Point(162, 48);
            this.dtodam.Name = "dtodam";
            this.dtodam.Size = new System.Drawing.Size(200, 20);
            this.dtodam.TabIndex = 97;
            // 
            // dfromdam
            // 
            this.dfromdam.Enabled = false;
            this.dfromdam.Location = new System.Drawing.Point(162, 11);
            this.dfromdam.Name = "dfromdam";
            this.dfromdam.Size = new System.Drawing.Size(200, 20);
            this.dfromdam.TabIndex = 96;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(368, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 20);
            this.label14.TabIndex = 95;
            this.label14.Text = "الي";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.Location = new System.Drawing.Point(368, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 20);
            this.label15.TabIndex = 94;
            this.label15.Text = "من";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label16.Location = new System.Drawing.Point(386, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 20);
            this.label16.TabIndex = 93;
            this.label16.Text = "تاريخ الضم";
            // 
            // ssel
            // 
            this.ssel.Enabled = false;
            this.ssel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ssel.Location = new System.Drawing.Point(200, 449);
            this.ssel.Name = "ssel";
            this.ssel.Size = new System.Drawing.Size(100, 26);
            this.ssel.TabIndex = 106;
            this.ssel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(306, 452);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 105;
            this.label11.Text = "مجموع البيع";
            // 
            // sbuy
            // 
            this.sbuy.Enabled = false;
            this.sbuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sbuy.Location = new System.Drawing.Point(389, 449);
            this.sbuy.Name = "sbuy";
            this.sbuy.Size = new System.Drawing.Size(100, 26);
            this.sbuy.TabIndex = 104;
            this.sbuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(495, 452);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 20);
            this.label12.TabIndex = 103;
            this.label12.Text = "مجموع الشراء";
            // 
            // sdiam
            // 
            this.sdiam.Enabled = false;
            this.sdiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sdiam.Location = new System.Drawing.Point(588, 449);
            this.sdiam.Name = "sdiam";
            this.sdiam.Size = new System.Drawing.Size(100, 26);
            this.sdiam.TabIndex = 102;
            this.sdiam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(694, 452);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 101;
            this.label10.Text = "مجموع العدد";
            // 
            // sgold
            // 
            this.sgold.Enabled = false;
            this.sgold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sgold.Location = new System.Drawing.Point(777, 449);
            this.sgold.Name = "sgold";
            this.sgold.Size = new System.Drawing.Size(100, 26);
            this.sgold.TabIndex = 100;
            this.sgold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(883, 452);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 99;
            this.label9.Text = "مجموع الوزن";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label17.Location = new System.Drawing.Point(872, 80);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 20);
            this.label17.TabIndex = 107;
            this.label17.Text = "المكان";
            // 
            // cbplace
            // 
            this.cbplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbplace.FormattingEnabled = true;
            this.cbplace.Items.AddRange(new object[] {
            "بيمن",
            "ميدان الجامع",
            "سيتي ستار",
            "الكوربه"});
            this.cbplace.Location = new System.Drawing.Point(777, 74);
            this.cbplace.Name = "cbplace";
            this.cbplace.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbplace.Size = new System.Drawing.Size(90, 28);
            this.cbplace.TabIndex = 108;
            // 
            // coun
            // 
            this.coun.Enabled = false;
            this.coun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.coun.Location = new System.Drawing.Point(979, 449);
            this.coun.Name = "coun";
            this.coun.Size = new System.Drawing.Size(42, 26);
            this.coun.TabIndex = 114;
            this.coun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label18.Location = new System.Drawing.Point(1027, 452);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 20);
            this.label18.TabIndex = 113;
            this.label18.Text = "العدد";
            // 
            // datadahab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1266, 519);
            this.Controls.Add(this.coun);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cbplace);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.ssel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sbuy);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.sdiam);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sgold);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkdam);
            this.Controls.Add(this.dtodam);
            this.Controls.Add(this.dfromdam);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cbshow);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.checkdt);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.sortin);
            this.Controls.Add(this.dtto);
            this.Controls.Add(this.dtfrom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buyname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.compa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.code);
            this.Controls.Add(this.search);
            this.Controls.Add(this.dg);
            this.Name = "datadahab";
            this.Text = "تقارير";
            this.Load += new System.EventHandler(this.datadahab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkdt;
        private System.Windows.Forms.ComboBox name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.ComboBox sortin;
        private System.Windows.Forms.DateTimePicker dtto;
        private System.Windows.Forms.DateTimePicker dtfrom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox buyname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox compa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.ComboBox cbshow;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkdam;
        private System.Windows.Forms.DateTimePicker dtodam;
        private System.Windows.Forms.DateTimePicker dfromdam;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox ssel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox sbuy;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox sdiam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox sgold;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbplace;
        private System.Windows.Forms.TextBox coun;
        private System.Windows.Forms.Label label18;
    }
}