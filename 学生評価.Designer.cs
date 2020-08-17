namespace HL_塾管理
{
    partial class 学生評価
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
            this.txt_クラス開催期間 = new System.Windows.Forms.Label();
            this.btn_今月評価追加 = new System.Windows.Forms.Button();
            this.cmb_クラス = new System.Windows.Forms.ComboBox();
            this.lbl_クラス = new System.Windows.Forms.Label();
            this.dgv_studentgrade = new System.Windows.Forms.DataGridView();
            this.学生コード = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学生名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.課題完成度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.クラスコード = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出勤数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.授業態度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.担当教師 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.総合評価 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.評価年月 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_クラス開催期間 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1_count = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_searchKey = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studentgrade)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_クラス開催期間
            // 
            this.txt_クラス開催期間.AutoSize = true;
            this.txt_クラス開催期間.Location = new System.Drawing.Point(326, 29);
            this.txt_クラス開催期間.Name = "txt_クラス開催期間";
            this.txt_クラス開催期間.Size = new System.Drawing.Size(95, 12);
            this.txt_クラス開催期間.TabIndex = 27;
            this.txt_クラス開催期間.Text = "2020/01~2020/09";
            // 
            // btn_今月評価追加
            // 
            this.btn_今月評価追加.Location = new System.Drawing.Point(912, 24);
            this.btn_今月評価追加.Name = "btn_今月評価追加";
            this.btn_今月評価追加.Size = new System.Drawing.Size(95, 23);
            this.btn_今月評価追加.TabIndex = 24;
            this.btn_今月評価追加.Text = "月評価追加";
            this.btn_今月評価追加.UseVisualStyleBackColor = true;
            this.btn_今月評価追加.Click += new System.EventHandler(this.btn_今月評価追加_Click);
            // 
            // cmb_クラス
            // 
            this.cmb_クラス.FormattingEnabled = true;
            this.cmb_クラス.Location = new System.Drawing.Point(75, 26);
            this.cmb_クラス.Name = "cmb_クラス";
            this.cmb_クラス.Size = new System.Drawing.Size(121, 20);
            this.cmb_クラス.TabIndex = 23;
            // 
            // lbl_クラス
            // 
            this.lbl_クラス.AutoSize = true;
            this.lbl_クラス.Location = new System.Drawing.Point(14, 29);
            this.lbl_クラス.Name = "lbl_クラス";
            this.lbl_クラス.Size = new System.Drawing.Size(41, 12);
            this.lbl_クラス.TabIndex = 21;
            this.lbl_クラス.Text = "クラス";
            // 
            // dgv_studentgrade
            // 
            this.dgv_studentgrade.AllowUserToAddRows = false;
            this.dgv_studentgrade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_studentgrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_studentgrade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.学生コード,
            this.学生名,
            this.課題完成度,
            this.クラスコード,
            this.出勤数,
            this.授業態度,
            this.担当教師,
            this.総合評価,
            this.評価年月});
            this.dgv_studentgrade.Location = new System.Drawing.Point(12, 62);
            this.dgv_studentgrade.Name = "dgv_studentgrade";
            this.dgv_studentgrade.RowTemplate.Height = 23;
            this.dgv_studentgrade.Size = new System.Drawing.Size(1006, 344);
            this.dgv_studentgrade.TabIndex = 20;
            this.dgv_studentgrade.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv_studentgrade_CellBeginEdit);
            this.dgv_studentgrade.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_studentgrade_CellEndEdit);
            this.dgv_studentgrade.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_studentgrade_CellValueChanged);
            // 
            // 学生コード
            // 
            this.学生コード.Frozen = true;
            this.学生コード.HeaderText = "学生コード";
            this.学生コード.Name = "学生コード";
            this.学生コード.ReadOnly = true;
            // 
            // 学生名
            // 
            this.学生名.Frozen = true;
            this.学生名.HeaderText = "学生名";
            this.学生名.Name = "学生名";
            this.学生名.ReadOnly = true;
            // 
            // 課題完成度
            // 
            this.課題完成度.Frozen = true;
            this.課題完成度.HeaderText = "宿題完成度";
            this.課題完成度.Name = "課題完成度";
            this.課題完成度.ReadOnly = true;
            // 
            // クラスコード
            // 
            this.クラスコード.Frozen = true;
            this.クラスコード.HeaderText = "クラスコード";
            this.クラスコード.Name = "クラスコード";
            this.クラスコード.ReadOnly = true;
            this.クラスコード.Visible = false;
            // 
            // 出勤数
            // 
            this.出勤数.HeaderText = "出勤数";
            this.出勤数.Name = "出勤数";
            this.出勤数.ReadOnly = true;
            // 
            // 授業態度
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua;
            this.授業態度.DefaultCellStyle = dataGridViewCellStyle1;
            this.授業態度.HeaderText = "授業態度";
            this.授業態度.Name = "授業態度";
            this.授業態度.Width = 200;
            // 
            // 担当教師
            // 
            this.担当教師.HeaderText = "担当教師";
            this.担当教師.Name = "担当教師";
            this.担当教師.ReadOnly = true;
            this.担当教師.Visible = false;
            // 
            // 総合評価
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Aqua;
            this.総合評価.DefaultCellStyle = dataGridViewCellStyle2;
            this.総合評価.HeaderText = "総合評価";
            this.総合評価.Name = "総合評価";
            this.総合評価.Width = 200;
            // 
            // 評価年月
            // 
            this.評価年月.HeaderText = "評価年月";
            this.評価年月.Name = "評価年月";
            this.評価年月.ReadOnly = true;
            // 
            // lbl_クラス開催期間
            // 
            this.lbl_クラス開催期間.AutoSize = true;
            this.lbl_クラス開催期間.Location = new System.Drawing.Point(222, 29);
            this.lbl_クラス開催期間.Name = "lbl_クラス開催期間";
            this.lbl_クラス開催期間.Size = new System.Drawing.Size(89, 12);
            this.lbl_クラス開催期間.TabIndex = 29;
            this.lbl_クラス開催期間.Text = "クラス開催期間";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel1_count});
            this.statusStrip1.Location = new System.Drawing.Point(0, 409);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1030, 22);
            this.statusStrip1.TabIndex = 133;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1_count
            // 
            this.toolStripStatusLabel1_count.Name = "toolStripStatusLabel1_count";
            this.toolStripStatusLabel1_count.Size = new System.Drawing.Size(0, 17);
            // 
            // txt_searchKey
            // 
            this.txt_searchKey.Location = new System.Drawing.Point(518, 24);
            this.txt_searchKey.Name = "txt_searchKey";
            this.txt_searchKey.Size = new System.Drawing.Size(185, 21);
            this.txt_searchKey.TabIndex = 134;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(719, 24);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(95, 23);
            this.btn_search.TabIndex = 135;
            this.btn_search.Text = "検索";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.button1_Click);
            // 
            // 学生評価
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 431);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_searchKey);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lbl_クラス開催期間);
            this.Controls.Add(this.txt_クラス開催期間);
            this.Controls.Add(this.btn_今月評価追加);
            this.Controls.Add(this.cmb_クラス);
            this.Controls.Add(this.lbl_クラス);
            this.Controls.Add(this.dgv_studentgrade);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "学生評価";
            this.Text = "学生評価";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.学生評価_FormClosed);
            this.Load += new System.EventHandler(this.学生評価_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studentgrade)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_クラス開催期間;
        private System.Windows.Forms.Button btn_今月評価追加;
        private System.Windows.Forms.ComboBox cmb_クラス;
        private System.Windows.Forms.Label lbl_クラス;
        private System.Windows.Forms.DataGridView dgv_studentgrade;
        private System.Windows.Forms.Label lbl_クラス開催期間;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学生コード;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学生名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 課題完成度;
        private System.Windows.Forms.DataGridViewTextBoxColumn クラスコード;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出勤数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 授業態度;
        private System.Windows.Forms.DataGridViewTextBoxColumn 担当教師;
        private System.Windows.Forms.DataGridViewTextBoxColumn 総合評価;
        private System.Windows.Forms.DataGridViewTextBoxColumn 評価年月;
        private System.Windows.Forms.TextBox txt_searchKey;
        private System.Windows.Forms.Button btn_search;
    }
}