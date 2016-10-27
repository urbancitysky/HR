namespace WindowsFormsApplication3
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_lName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_eid = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.fname_select = new System.Windows.Forms.ComboBox();
            this.txt_fName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Deduct_date = new System.Windows.Forms.DateTimePicker();
            this.btn_addRecord = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.edit_rec = new System.Windows.Forms.Button();
            this.btn_del_rec = new System.Windows.Forms.Button();
            this.Reason = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_dept = new System.Windows.Forms.ComboBox();
            this.Am_Pm = new System.Windows.Forms.ComboBox();
            this.nm_Point = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_rid = new System.Windows.Forms.TextBox();
            this.Ded_point = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.btn_Print = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TimeIn_hh = new System.Windows.Forms.NumericUpDown();
            this.Proc_date = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.TimeIn_mm = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ded_point)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeIn_hh)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(235, 115);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(36, 36);
            this.btn_add.TabIndex = 7;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name";
            // 
            // txt_lName
            // 
            this.txt_lName.Location = new System.Drawing.Point(121, 52);
            this.txt_lName.Name = "txt_lName";
            this.txt_lName.Size = new System.Drawing.Size(129, 23);
            this.txt_lName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Remaining Points";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "EID ";
            this.label4.Visible = false;
            // 
            // txt_eid
            // 
            this.txt_eid.Location = new System.Drawing.Point(74, 118);
            this.txt_eid.Name = "txt_eid";
            this.txt_eid.Size = new System.Drawing.Size(66, 23);
            this.txt_eid.TabIndex = 0;
            this.txt_eid.Visible = false;
            // 
            // btn_edit
            // 
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.Location = new System.Drawing.Point(164, 115);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(36, 36);
            this.btn_edit.TabIndex = 5;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_del
            // 
            this.btn_del.Image = ((System.Drawing.Image)(resources.GetObject("btn_del.Image")));
            this.btn_del.Location = new System.Drawing.Point(200, 115);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(36, 36);
            this.btn_del.TabIndex = 6;
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // fname_select
            // 
            this.fname_select.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.fname_select.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.fname_select.FormattingEnabled = true;
            this.fname_select.Location = new System.Drawing.Point(121, 21);
            this.fname_select.Name = "fname_select";
            this.fname_select.Size = new System.Drawing.Size(129, 24);
            this.fname_select.TabIndex = 0;
            this.fname_select.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_fName
            // 
            this.txt_fName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_fName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_fName.Location = new System.Drawing.Point(121, 23);
            this.txt_fName.Name = "txt_fName";
            this.txt_fName.Size = new System.Drawing.Size(129, 23);
            this.txt_fName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Time In";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Deduct point";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Hi";
            // 
            // Deduct_date
            // 
            this.Deduct_date.CalendarForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Deduct_date.CustomFormat = "yyyy-MM-dd";
            this.Deduct_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Deduct_date.Location = new System.Drawing.Point(152, 32);
            this.Deduct_date.Name = "Deduct_date";
            this.Deduct_date.Size = new System.Drawing.Size(126, 23);
            this.Deduct_date.TabIndex = 1;
            // 
            // btn_addRecord
            // 
            this.btn_addRecord.Image = ((System.Drawing.Image)(resources.GetObject("btn_addRecord.Image")));
            this.btn_addRecord.Location = new System.Drawing.Point(277, 213);
            this.btn_addRecord.Name = "btn_addRecord";
            this.btn_addRecord.Size = new System.Drawing.Size(36, 36);
            this.btn_addRecord.TabIndex = 11;
            this.btn_addRecord.UseVisualStyleBackColor = true;
            this.btn_addRecord.Click += new System.EventHandler(this.btn_addRecord_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(107, 411);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(667, 208);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "Reason";
            // 
            // edit_rec
            // 
            this.edit_rec.Image = ((System.Drawing.Image)(resources.GetObject("edit_rec.Image")));
            this.edit_rec.Location = new System.Drawing.Point(206, 213);
            this.edit_rec.Name = "edit_rec";
            this.edit_rec.Size = new System.Drawing.Size(36, 36);
            this.edit_rec.TabIndex = 9;
            this.edit_rec.UseVisualStyleBackColor = true;
            this.edit_rec.Click += new System.EventHandler(this.button1_Click);
            this.edit_rec.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            // 
            // btn_del_rec
            // 
            this.btn_del_rec.Image = ((System.Drawing.Image)(resources.GetObject("btn_del_rec.Image")));
            this.btn_del_rec.Location = new System.Drawing.Point(241, 213);
            this.btn_del_rec.Name = "btn_del_rec";
            this.btn_del_rec.Size = new System.Drawing.Size(36, 36);
            this.btn_del_rec.TabIndex = 10;
            this.btn_del_rec.UseVisualStyleBackColor = true;
            this.btn_del_rec.Click += new System.EventHandler(this.btn_del_rec_Click);
            // 
            // Reason
            // 
            this.Reason.FormattingEnabled = true;
            this.Reason.Items.AddRange(new object[] {
            "Tardy - No Call",
            "Tardy",
            "Absent - No Call",
            "Absent",
            "Half Day - No Call",
            "Half Day",
            "Other"});
            this.Reason.Location = new System.Drawing.Point(152, 119);
            this.Reason.Name = "Reason";
            this.Reason.Size = new System.Drawing.Size(126, 25);
            this.Reason.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = "Department";
            // 
            // txt_dept
            // 
            this.txt_dept.FormattingEnabled = true;
            this.txt_dept.Items.AddRange(new object[] {
            "Accounting",
            "Customer Service",
            "Graphic",
            "Inventory Control",
            "Marketing",
            "Operation",
            "Purchasing",
            "RMA",
            "R&D",
            "Sales",
            "Warehouse"});
            this.txt_dept.Location = new System.Drawing.Point(121, 78);
            this.txt_dept.Name = "txt_dept";
            this.txt_dept.Size = new System.Drawing.Size(129, 25);
            this.txt_dept.TabIndex = 3;
            // 
            // Am_Pm
            // 
            this.Am_Pm.BackColor = System.Drawing.SystemColors.Window;
            this.Am_Pm.FormattingEnabled = true;
            this.Am_Pm.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.Am_Pm.Location = new System.Drawing.Point(252, 60);
            this.Am_Pm.Name = "Am_Pm";
            this.Am_Pm.Size = new System.Drawing.Size(54, 25);
            this.Am_Pm.TabIndex = 4;
            // 
            // nm_Point
            // 
            this.nm_Point.FormattingEnabled = true;
            this.nm_Point.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.nm_Point.Location = new System.Drawing.Point(153, 178);
            this.nm_Point.Name = "nm_Point";
            this.nm_Point.Size = new System.Drawing.Size(66, 25);
            this.nm_Point.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(26, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 16);
            this.label12.TabIndex = 41;
            this.label12.Text = "Record ID";
            this.label12.Visible = false;
            // 
            // txt_rid
            // 
            this.txt_rid.Location = new System.Drawing.Point(112, 224);
            this.txt_rid.Name = "txt_rid";
            this.txt_rid.Size = new System.Drawing.Size(44, 23);
            this.txt_rid.TabIndex = 0;
            this.txt_rid.Visible = false;
            // 
            // Ded_point
            // 
            this.Ded_point.DecimalPlaces = 1;
            this.Ded_point.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.Ded_point.Location = new System.Drawing.Point(153, 92);
            this.Ded_point.Name = "Ded_point";
            this.Ded_point.Size = new System.Drawing.Size(66, 23);
            this.Ded_point.TabIndex = 5;
            this.Ded_point.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 646);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(831, 22);
            this.statusStrip1.TabIndex = 46;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(831, 24);
            this.menuStrip1.TabIndex = 48;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btn_Print
            // 
            this.btn_Print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Print.Image = ((System.Drawing.Image)(resources.GetObject("btn_Print.Image")));
            this.btn_Print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(23, 22);
            this.btn_Print.Text = "toolStripButton2";
            this.btn_Print.ToolTipText = "Print report";
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Print,
            this.toolStripSeparator1,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(831, 25);
            this.toolStrip1.TabIndex = 50;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(681, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_fName);
            this.groupBox1.Controls.Add(this.txt_lName);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_eid);
            this.groupBox1.Controls.Add(this.btn_edit);
            this.groupBox1.Controls.Add(this.btn_del);
            this.groupBox1.Controls.Add(this.txt_dept);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 158);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employees";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(29, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = "First Name";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.TimeIn_hh);
            this.groupBox2.Controls.Add(this.Proc_date);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_rid);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Deduct_date);
            this.groupBox2.Controls.Add(this.btn_addRecord);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.Ded_point);
            this.groupBox2.Controls.Add(this.nm_Point);
            this.groupBox2.Controls.Add(this.edit_rec);
            this.groupBox2.Controls.Add(this.btn_del_rec);
            this.groupBox2.Controls.Add(this.Reason);
            this.groupBox2.Controls.Add(this.Am_Pm);
            this.groupBox2.Controls.Add(this.TimeIn_mm);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(328, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 306);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Record";
            // 
            // TimeIn_hh
            // 
            this.TimeIn_hh.Location = new System.Drawing.Point(152, 61);
            this.TimeIn_hh.Name = "TimeIn_hh";
            this.TimeIn_hh.Size = new System.Drawing.Size(43, 23);
            this.TimeIn_hh.TabIndex = 2;
            this.TimeIn_hh.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // Proc_date
            // 
            this.Proc_date.CustomFormat = "yyyy-MM-dd";
            this.Proc_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Proc_date.Location = new System.Drawing.Point(153, 148);
            this.Proc_date.Name = "Proc_date";
            this.Proc_date.Size = new System.Drawing.Size(126, 23);
            this.Proc_date.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "Deduction date";
            // 
            // TimeIn_mm
            // 
            this.TimeIn_mm.FormattingEnabled = true;
            this.TimeIn_mm.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "00"});
            this.TimeIn_mm.Location = new System.Drawing.Point(202, 60);
            this.TimeIn_mm.Name = "TimeIn_mm";
            this.TimeIn_mm.Size = new System.Drawing.Size(44, 25);
            this.TimeIn_mm.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.fname_select);
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(299, 133);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 16);
            this.label15.TabIndex = 8;
            this.label15.Text = "To";
            this.label15.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 16);
            this.label13.TabIndex = 8;
            this.label13.Text = "From";
            this.label13.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(121, 85);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(129, 24);
            this.dateTimePicker2.TabIndex = 7;
            this.dateTimePicker2.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(129, 24);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 33);
            this.button1.TabIndex = 43;
            this.button1.Text = "Q";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(831, 668);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "HR Orz (v1.1 built 1.1.2)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ded_point)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeIn_hh)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_lName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_eid;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.ComboBox fname_select;
        private System.Windows.Forms.TextBox txt_fName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker Deduct_date;
        private System.Windows.Forms.Button btn_addRecord;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button edit_rec;
        private System.Windows.Forms.Button btn_del_rec;
        private System.Windows.Forms.ComboBox Reason;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox txt_dept;
        private System.Windows.Forms.ComboBox Am_Pm;
        private System.Windows.Forms.ComboBox nm_Point;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_rid;
        private System.Windows.Forms.NumericUpDown Ded_point;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.ToolStripButton btn_Print;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker Proc_date;
        private System.Windows.Forms.NumericUpDown TimeIn_hh;
        private System.Windows.Forms.ComboBox TimeIn_mm;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
    }
}