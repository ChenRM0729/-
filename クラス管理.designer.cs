namespace HL_塾管理
{
    partial class クラス管理
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(クラス管理));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_insert = new System.Windows.Forms.Button();
            this.lbl_教室コード = new System.Windows.Forms.Label();
            this.cmb_教室コード = new System.Windows.Forms.ComboBox();
            this.lbl_教師コード = new System.Windows.Forms.Label();
            this.lbl_言語 = new System.Windows.Forms.Label();
            this.cmb_課程 = new System.Windows.Forms.ComboBox();
            this.dtp_開始日 = new System.Windows.Forms.DateTimePicker();
            this.lbl_開始日 = new System.Windows.Forms.Label();
            this.dtp_終了日 = new System.Windows.Forms.DateTimePicker();
            this.lbl_終了日 = new System.Windows.Forms.Label();
            this.lbl_クラスコード = new System.Windows.Forms.Label();
            this.txt_クラスコード = new System.Windows.Forms.Label();
            this.lbl_学生 = new System.Windows.Forms.Label();
            this.txt_教師名前 = new System.Windows.Forms.Label();
            this.cmb_教師コード = new System.Windows.Forms.ComboBox();
            this.dgv_left = new System.Windows.Forms.DataGridView();
            this.leftcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_right = new System.Windows.Forms.DataGridView();
            this.rightcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_classname = new System.Windows.Forms.Label();
            this.txt_classname = new System.Windows.Forms.TextBox();
            this.lbl_研修CheckBox = new System.Windows.Forms.Label();
            this.chkbx_研修 = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_right)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 765);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 44, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1123, 22);
            this.statusStrip1.TabIndex = 115;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // btn_insert
            // 
            this.btn_insert.Font = new System.Drawing.Font("Meiryo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_insert.Location = new System.Drawing.Point(498, 718);
            this.btn_insert.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(116, 47);
            this.btn_insert.TabIndex = 8;
            this.btn_insert.Text = "登録";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // lbl_教室コード
            // 
            this.lbl_教室コード.AutoSize = true;
            this.lbl_教室コード.Font = new System.Drawing.Font("Meiryo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_教室コード.Location = new System.Drawing.Point(60, 117);
            this.lbl_教室コード.Margin = new System.Windows.Forms.Padding(9, 8, 9, 0);
            this.lbl_教室コード.Name = "lbl_教室コード";
            this.lbl_教室コード.Size = new System.Drawing.Size(99, 23);
            this.lbl_教室コード.TabIndex = 137;
            this.lbl_教室コード.Text = "教室　[必須]";
            this.lbl_教室コード.Paint += new System.Windows.Forms.PaintEventHandler(this.lbl_必須_Paint);
            // 
            // cmb_教室コード
            // 
            this.cmb_教室コード.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_教室コード.Font = new System.Drawing.Font("Meiryo", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmb_教室コード.FormattingEnabled = true;
            this.cmb_教室コード.Location = new System.Drawing.Point(302, 114);
            this.cmb_教室コード.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.cmb_教室コード.Name = "cmb_教室コード";
            this.cmb_教室コード.Size = new System.Drawing.Size(191, 31);
            this.cmb_教室コード.TabIndex = 1;
            // 
            // lbl_教師コード
            // 
            this.lbl_教師コード.AutoSize = true;
            this.lbl_教師コード.Font = new System.Drawing.Font("Meiryo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_教師コード.Location = new System.Drawing.Point(60, 175);
            this.lbl_教師コード.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lbl_教師コード.Name = "lbl_教師コード";
            this.lbl_教師コード.Size = new System.Drawing.Size(144, 23);
            this.lbl_教師コード.TabIndex = 139;
            this.lbl_教師コード.Text = "教師コード　[必須]";
            this.lbl_教師コード.Paint += new System.Windows.Forms.PaintEventHandler(this.lbl_必須_Paint);
            // 
            // lbl_言語
            // 
            this.lbl_言語.AutoSize = true;
            this.lbl_言語.Font = new System.Drawing.Font("Meiryo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_言語.Location = new System.Drawing.Point(61, 227);
            this.lbl_言語.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lbl_言語.Name = "lbl_言語";
            this.lbl_言語.Size = new System.Drawing.Size(114, 23);
            this.lbl_言語.TabIndex = 142;
            this.lbl_言語.Text = "課　程　[必須]";
            this.lbl_言語.Paint += new System.Windows.Forms.PaintEventHandler(this.lbl_必須_Paint);
            // 
            // cmb_課程
            // 
            this.cmb_課程.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_課程.Font = new System.Drawing.Font("Meiryo", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmb_課程.FormattingEnabled = true;
            this.cmb_課程.Items.AddRange(new object[] {
            ".Net",
            "iOS",
            "php",
            "pyhton",
            "Java",
            "Android",
            "Salesforce"});
            this.cmb_課程.Location = new System.Drawing.Point(303, 225);
            this.cmb_課程.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.cmb_課程.Name = "cmb_課程";
            this.cmb_課程.Size = new System.Drawing.Size(190, 31);
            this.cmb_課程.TabIndex = 3;
            // 
            // dtp_開始日
            // 
            this.dtp_開始日.CalendarFont = new System.Drawing.Font("Meiryo", 11.25F);
            this.dtp_開始日.Font = new System.Drawing.Font("Meiryo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtp_開始日.Location = new System.Drawing.Point(304, 595);
            this.dtp_開始日.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.dtp_開始日.Name = "dtp_開始日";
            this.dtp_開始日.Size = new System.Drawing.Size(152, 28);
            this.dtp_開始日.TabIndex = 6;
            // 
            // lbl_開始日
            // 
            this.lbl_開始日.AutoSize = true;
            this.lbl_開始日.Font = new System.Drawing.Font("Meiryo", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_開始日.Location = new System.Drawing.Point(60, 600);
            this.lbl_開始日.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_開始日.Name = "lbl_開始日";
            this.lbl_開始日.Size = new System.Drawing.Size(114, 23);
            this.lbl_開始日.TabIndex = 152;
            this.lbl_開始日.Text = "開始日　[必須]";
            this.lbl_開始日.Paint += new System.Windows.Forms.PaintEventHandler(this.lbl_必須_Paint);
            // 
            // dtp_終了日
            // 
            this.dtp_終了日.CalendarFont = new System.Drawing.Font("Meiryo", 11.25F);
            this.dtp_終了日.Font = new System.Drawing.Font("Meiryo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtp_終了日.Location = new System.Drawing.Point(304, 650);
            this.dtp_終了日.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.dtp_終了日.Name = "dtp_終了日";
            this.dtp_終了日.Size = new System.Drawing.Size(152, 28);
            this.dtp_終了日.TabIndex = 7;
            // 
            // lbl_終了日
            // 
            this.lbl_終了日.AutoSize = true;
            this.lbl_終了日.Font = new System.Drawing.Font("Meiryo", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_終了日.Location = new System.Drawing.Point(61, 655);
            this.lbl_終了日.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_終了日.Name = "lbl_終了日";
            this.lbl_終了日.Size = new System.Drawing.Size(114, 23);
            this.lbl_終了日.TabIndex = 154;
            this.lbl_終了日.Text = "終了日　[必須]";
            this.lbl_終了日.Paint += new System.Windows.Forms.PaintEventHandler(this.lbl_必須_Paint);
            // 
            // lbl_クラスコード
            // 
            this.lbl_クラスコード.AutoSize = true;
            this.lbl_クラスコード.Font = new System.Drawing.Font("Meiryo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_クラスコード.Location = new System.Drawing.Point(60, 23);
            this.lbl_クラスコード.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lbl_クラスコード.Name = "lbl_クラスコード";
            this.lbl_クラスコード.Size = new System.Drawing.Size(100, 23);
            this.lbl_クラスコード.TabIndex = 157;
            this.lbl_クラスコード.Text = "クラスコード";
            // 
            // txt_クラスコード
            // 
            this.txt_クラスコード.AutoSize = true;
            this.txt_クラスコード.Font = new System.Drawing.Font("Meiryo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_クラスコード.Location = new System.Drawing.Point(298, 23);
            this.txt_クラスコード.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.txt_クラスコード.Name = "txt_クラスコード";
            this.txt_クラスコード.Size = new System.Drawing.Size(20, 23);
            this.txt_クラスコード.TabIndex = 158;
            this.txt_クラスコード.Text = "1";
            // 
            // lbl_学生
            // 
            this.lbl_学生.AutoSize = true;
            this.lbl_学生.Font = new System.Drawing.Font("Meiryo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_学生.Location = new System.Drawing.Point(61, 280);
            this.lbl_学生.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lbl_学生.Name = "lbl_学生";
            this.lbl_学生.Size = new System.Drawing.Size(114, 23);
            this.lbl_学生.TabIndex = 160;
            this.lbl_学生.Text = "学　生　[必須]";
            this.lbl_学生.Paint += new System.Windows.Forms.PaintEventHandler(this.lbl_必須_Paint);
            // 
            // txt_教師名前
            // 
            this.txt_教師名前.AutoSize = true;
            this.txt_教師名前.Font = new System.Drawing.Font("Meiryo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_教師名前.Location = new System.Drawing.Point(513, 175);
            this.txt_教師名前.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.txt_教師名前.Name = "txt_教師名前";
            this.txt_教師名前.Size = new System.Drawing.Size(0, 23);
            this.txt_教師名前.TabIndex = 163;
            // 
            // cmb_教師コード
            // 
            this.cmb_教師コード.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_教師コード.Font = new System.Drawing.Font("Meiryo", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmb_教師コード.FormattingEnabled = true;
            this.cmb_教師コード.Location = new System.Drawing.Point(302, 172);
            this.cmb_教師コード.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.cmb_教師コード.Name = "cmb_教師コード";
            this.cmb_教師コード.Size = new System.Drawing.Size(191, 31);
            this.cmb_教師コード.TabIndex = 2;
            this.cmb_教師コード.SelectedIndexChanged += new System.EventHandler(this.Cmb_教師コード_SelectedIndexChanged);
            // 
            // dgv_left
            // 
            this.dgv_left.AllowDrop = true;
            this.dgv_left.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_left.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_left.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_left.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.leftcode,
            this.leftname});
            this.dgv_left.Location = new System.Drawing.Point(304, 280);
            this.dgv_left.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgv_left.Name = "dgv_left";
            this.dgv_left.RowTemplate.Height = 23;
            this.dgv_left.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_left.Size = new System.Drawing.Size(345, 289);
            this.dgv_left.TabIndex = 165;
            this.dgv_left.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_left_CellClick);
            this.dgv_left.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dgv_left_SortCompare);
            this.dgv_left.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgv_left_DragDrop);
            this.dgv_left.DragOver += new System.Windows.Forms.DragEventHandler(this.dgv_left_DragOver);
            this.dgv_left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgv_left_MouseDown);
            this.dgv_left.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgv_left_MouseMove);
            // 
            // leftcode
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.leftcode.DefaultCellStyle = dataGridViewCellStyle2;
            this.leftcode.HeaderText = "学生コード";
            this.leftcode.Name = "leftcode";
            this.leftcode.ReadOnly = true;
            // 
            // leftname
            // 
            this.leftname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.leftname.DefaultCellStyle = dataGridViewCellStyle3;
            this.leftname.HeaderText = "学生名";
            this.leftname.Name = "leftname";
            this.leftname.ReadOnly = true;
            // 
            // dgv_right
            // 
            this.dgv_right.AllowDrop = true;
            this.dgv_right.AllowUserToAddRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_right.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_right.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_right.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rightcode,
            this.rightname});
            this.dgv_right.Location = new System.Drawing.Point(778, 280);
            this.dgv_right.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgv_right.Name = "dgv_right";
            this.dgv_right.RowTemplate.Height = 23;
            this.dgv_right.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_right.Size = new System.Drawing.Size(345, 289);
            this.dgv_right.TabIndex = 166;
            this.dgv_right.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_right_CellClick);
            this.dgv_right.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dgv_left_SortCompare);
            this.dgv_right.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgv_right_DragDrop);
            this.dgv_right.DragOver += new System.Windows.Forms.DragEventHandler(this.dgv_right_DragOver);
            this.dgv_right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgv_right_MouseDown);
            this.dgv_right.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgv_right_MouseMove);
            // 
            // rightcode
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.rightcode.DefaultCellStyle = dataGridViewCellStyle5;
            this.rightcode.HeaderText = "学生コード";
            this.rightcode.Name = "rightcode";
            this.rightcode.ReadOnly = true;
            // 
            // rightname
            // 
            this.rightname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.rightname.DefaultCellStyle = dataGridViewCellStyle6;
            this.rightname.HeaderText = "学生名";
            this.rightname.Name = "rightname";
            this.rightname.ReadOnly = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(693, 467);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(52, 60);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = ">>";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(693, 339);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(52, 60);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "<<";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_classname
            // 
            this.lbl_classname.AutoSize = true;
            this.lbl_classname.Font = new System.Drawing.Font("Meiryo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_classname.Location = new System.Drawing.Point(60, 65);
            this.lbl_classname.Margin = new System.Windows.Forms.Padding(9, 8, 9, 0);
            this.lbl_classname.Name = "lbl_classname";
            this.lbl_classname.Size = new System.Drawing.Size(129, 23);
            this.lbl_classname.TabIndex = 167;
            this.lbl_classname.Text = "クラス名　[必須]";
            this.lbl_classname.Paint += new System.Windows.Forms.PaintEventHandler(this.lbl_必須_Paint);
            // 
            // txt_classname
            // 
            this.txt_classname.Font = new System.Drawing.Font("Meiryo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_classname.Location = new System.Drawing.Point(302, 62);
            this.txt_classname.Name = "txt_classname";
            this.txt_classname.Size = new System.Drawing.Size(240, 30);
            this.txt_classname.TabIndex = 168;
            // 
            // lbl_研修CheckBox
            // 
            this.lbl_研修CheckBox.AutoSize = true;
            this.lbl_研修CheckBox.Font = new System.Drawing.Font("Meiryo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_研修CheckBox.Location = new System.Drawing.Point(672, 22);
            this.lbl_研修CheckBox.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lbl_研修CheckBox.Name = "lbl_研修CheckBox";
            this.lbl_研修CheckBox.Size = new System.Drawing.Size(70, 23);
            this.lbl_研修CheckBox.TabIndex = 169;
            this.lbl_研修CheckBox.Text = "研修社員";
            // 
            // chkbx_研修
            // 
            this.chkbx_研修.AutoSize = true;
            this.chkbx_研修.Location = new System.Drawing.Point(767, 29);
            this.chkbx_研修.Name = "chkbx_研修";
            this.chkbx_研修.Size = new System.Drawing.Size(15, 14);
            this.chkbx_研修.TabIndex = 170;
            this.chkbx_研修.UseVisualStyleBackColor = true;
            this.chkbx_研修.CheckedChanged += new System.EventHandler(this.chkbx_研修_CheckedChanged);
            // 
            // クラス管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1028, 599);
            this.Controls.Add(this.chkbx_研修);
            this.Controls.Add(this.lbl_研修CheckBox);
            this.Controls.Add(this.txt_classname);
            this.Controls.Add(this.lbl_classname);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dgv_right);
            this.Controls.Add(this.dgv_left);
            this.Controls.Add(this.cmb_教師コード);
            this.Controls.Add(this.txt_教師名前);
            this.Controls.Add(this.lbl_学生);
            this.Controls.Add(this.txt_クラスコード);
            this.Controls.Add(this.lbl_クラスコード);
            this.Controls.Add(this.dtp_終了日);
            this.Controls.Add(this.lbl_終了日);
            this.Controls.Add(this.dtp_開始日);
            this.Controls.Add(this.lbl_開始日);
            this.Controls.Add(this.cmb_課程);
            this.Controls.Add(this.lbl_言語);
            this.Controls.Add(this.lbl_教師コード);
            this.Controls.Add(this.cmb_教室コード);
            this.Controls.Add(this.lbl_教室コード);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "クラス管理";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "新規クラス";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.クラス管理_FormClosed);
            this.Load += new System.EventHandler(this.Page_load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_right)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label lbl_教室コード;
        private System.Windows.Forms.ComboBox cmb_教室コード;
        private System.Windows.Forms.Label lbl_教師コード;
        private System.Windows.Forms.Label lbl_言語;
        private System.Windows.Forms.ComboBox cmb_課程;
        private System.Windows.Forms.DateTimePicker dtp_開始日;
        private System.Windows.Forms.Label lbl_開始日;
        private System.Windows.Forms.DateTimePicker dtp_終了日;
        private System.Windows.Forms.Label lbl_終了日;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label lbl_クラスコード;
        private System.Windows.Forms.Label txt_クラスコード;
        private System.Windows.Forms.Label lbl_学生;
        private System.Windows.Forms.Label txt_教師名前;
        public System.Windows.Forms.ComboBox cmb_教師コード;
        private System.Windows.Forms.DataGridView dgv_left;
        private System.Windows.Forms.DataGridView dgv_right;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn leftcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn leftname;
        private System.Windows.Forms.DataGridViewTextBoxColumn rightcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn rightname;
        private System.Windows.Forms.Label lbl_classname;
        private System.Windows.Forms.TextBox txt_classname;
        private System.Windows.Forms.Label lbl_研修CheckBox;
        private System.Windows.Forms.CheckBox chkbx_研修;
    }
}