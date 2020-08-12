namespace HL_塾管理
{
    partial class 学生進捗一覧
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(学生進捗一覧));
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_クラス課題分配 = new System.Windows.Forms.Button();
            this.gv_studentsInfo = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.課題分配ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.宿題履歴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_課題一覧 = new System.Windows.Forms.Button();
            this.学生番号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学生名前 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.クラス = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.使用言語 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.課題名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.課題コード = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.完成度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.開始日 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.予定完成時間 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.終了日 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gv_studentsInfo)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_search.Location = new System.Drawing.Point(28, 35);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(265, 30);
            this.txt_search.TabIndex = 2;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(332, 34);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 36);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "検索";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // btn_クラス課題分配
            // 
            this.btn_クラス課題分配.Location = new System.Drawing.Point(502, 35);
            this.btn_クラス課題分配.Name = "btn_クラス課題分配";
            this.btn_クラス課題分配.Size = new System.Drawing.Size(118, 34);
            this.btn_クラス課題分配.TabIndex = 4;
            this.btn_クラス課題分配.Text = "クラス課題分配";
            this.btn_クラス課題分配.UseVisualStyleBackColor = true;
            this.btn_クラス課題分配.Click += new System.EventHandler(this.btn_クラス課題分配_Click);
            // 
            // gv_studentsInfo
            // 
            this.gv_studentsInfo.AllowUserToAddRows = false;
            this.gv_studentsInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_studentsInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_studentsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_studentsInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.学生番号,
            this.学生名前,
            this.クラス,
            this.使用言語,
            this.課題名,
            this.課題コード,
            this.完成度,
            this.開始日,
            this.予定完成時間,
            this.終了日});
            this.gv_studentsInfo.ContextMenuStrip = this.contextMenuStrip1;
            this.gv_studentsInfo.Location = new System.Drawing.Point(28, 79);
            this.gv_studentsInfo.Margin = new System.Windows.Forms.Padding(4);
            this.gv_studentsInfo.Name = "gv_studentsInfo";
            this.gv_studentsInfo.RowTemplate.Height = 24;
            this.gv_studentsInfo.Size = new System.Drawing.Size(870, 442);
            this.gv_studentsInfo.TabIndex = 6;
            this.gv_studentsInfo.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.gv_studentsInfo_CellBeginEdit);
            this.gv_studentsInfo.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_studentsInfo_CellEndEdit);
            this.gv_studentsInfo.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_studentsInfo_CellMouseDown);
            this.gv_studentsInfo.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_studentsInfo_CellValueChanged);
            this.gv_studentsInfo.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gv_studentsInfo_DataError);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.課題分配ToolStripMenuItem,
            this.宿題履歴ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 48);
            // 
            // 課題分配ToolStripMenuItem
            // 
            this.課題分配ToolStripMenuItem.Name = "課題分配ToolStripMenuItem";
            this.課題分配ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.課題分配ToolStripMenuItem.Text = "課題分配";
            // 
            // 宿題履歴ToolStripMenuItem
            // 
            this.宿題履歴ToolStripMenuItem.Name = "宿題履歴ToolStripMenuItem";
            this.宿題履歴ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.宿題履歴ToolStripMenuItem.Text = "課題履歴";
            this.宿題履歴ToolStripMenuItem.Click += new System.EventHandler(this.宿題履歴ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 530);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(957, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // btn_課題一覧
            // 
            this.btn_課題一覧.Location = new System.Drawing.Point(697, 34);
            this.btn_課題一覧.Name = "btn_課題一覧";
            this.btn_課題一覧.Size = new System.Drawing.Size(103, 34);
            this.btn_課題一覧.TabIndex = 5;
            this.btn_課題一覧.Text = "課題一覧";
            this.btn_課題一覧.UseVisualStyleBackColor = true;
            this.btn_課題一覧.Click += new System.EventHandler(this.btn_課題一覧_Click);
            // 
            // 学生番号
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.学生番号.DefaultCellStyle = dataGridViewCellStyle2;
            this.学生番号.HeaderText = "学生番号";
            this.学生番号.Name = "学生番号";
            this.学生番号.ReadOnly = true;
            // 
            // 学生名前
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.学生名前.DefaultCellStyle = dataGridViewCellStyle3;
            this.学生名前.HeaderText = "学生名前";
            this.学生名前.Name = "学生名前";
            this.学生名前.ReadOnly = true;
            // 
            // クラス
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.クラス.DefaultCellStyle = dataGridViewCellStyle4;
            this.クラス.HeaderText = "クラス";
            this.クラス.Name = "クラス";
            this.クラス.ReadOnly = true;
            // 
            // 使用言語
            // 
            this.使用言語.HeaderText = "使用言語";
            this.使用言語.Name = "使用言語";
            this.使用言語.Visible = false;
            // 
            // 課題名
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.課題名.DefaultCellStyle = dataGridViewCellStyle5;
            this.課題名.HeaderText = "宿題名";
            this.課題名.Name = "課題名";
            this.課題名.ReadOnly = true;
            // 
            // 課題コード
            // 
            this.課題コード.HeaderText = "課題コード";
            this.課題コード.Name = "課題コード";
            this.課題コード.Visible = false;
            // 
            // 完成度
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Blue;
            this.完成度.DefaultCellStyle = dataGridViewCellStyle6;
            this.完成度.HeaderText = "完成度(%)";
            this.完成度.Name = "完成度";
            // 
            // 開始日
            // 
            this.開始日.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.開始日.DefaultCellStyle = dataGridViewCellStyle7;
            this.開始日.HeaderText = "開始日";
            this.開始日.Name = "開始日";
            this.開始日.ReadOnly = true;
            this.開始日.Width = 180;
            // 
            // 予定完成時間
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.予定完成時間.DefaultCellStyle = dataGridViewCellStyle8;
            this.予定完成時間.HeaderText = "予定完成時間";
            this.予定完成時間.Name = "予定完成時間";
            this.予定完成時間.Width = 130;
            // 
            // 終了日
            // 
            this.終了日.HeaderText = "終了日";
            this.終了日.Name = "終了日";
            this.終了日.Visible = false;
            // 
            // 学生進捗一覧
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(957, 552);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btn_課題一覧);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gv_studentsInfo);
            this.Controls.Add(this.btn_クラス課題分配);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "学生進捗一覧";
            this.Text = "学生進捗一覧";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.学生進捗一覧_FormClosed);
            this.Load += new System.EventHandler(this.学生進捗一覧_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_studentsInfo)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_クラス課題分配;
        public System.Windows.Forms.DataGridView gv_studentsInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 課題分配ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 宿題履歴ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button btn_課題一覧;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学生番号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学生名前;
        private System.Windows.Forms.DataGridViewTextBoxColumn クラス;
        private System.Windows.Forms.DataGridViewTextBoxColumn 使用言語;
        private System.Windows.Forms.DataGridViewTextBoxColumn 課題名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 課題コード;
        private System.Windows.Forms.DataGridViewTextBoxColumn 完成度;
        private System.Windows.Forms.DataGridViewTextBoxColumn 開始日;
        private System.Windows.Forms.DataGridViewTextBoxColumn 予定完成時間;
        private System.Windows.Forms.DataGridViewTextBoxColumn 終了日;
    }
}