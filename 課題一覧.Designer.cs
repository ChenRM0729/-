namespace HL_塾管理
{
    partial class 課題一覧
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(課題一覧));
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_課題追加 = new System.Windows.Forms.Button();
            this.btn_課題分配 = new System.Windows.Forms.Button();
            this.gv_homework = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.課題番号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.課題名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.言語 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.予定完成時間 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.課題内容 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gv_homework)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_search.Location = new System.Drawing.Point(40, 40);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(265, 30);
            this.txt_search.TabIndex = 3;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(348, 39);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 36);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "検索";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_課題追加
            // 
            this.btn_課題追加.Location = new System.Drawing.Point(585, 42);
            this.btn_課題追加.Name = "btn_課題追加";
            this.btn_課題追加.Size = new System.Drawing.Size(107, 34);
            this.btn_課題追加.TabIndex = 5;
            this.btn_課題追加.Text = "課題追加";
            this.btn_課題追加.UseVisualStyleBackColor = true;
            this.btn_課題追加.Click += new System.EventHandler(this.btn_課題追加_Click);
            // 
            // btn_課題分配
            // 
            this.btn_課題分配.Location = new System.Drawing.Point(765, 42);
            this.btn_課題分配.Name = "btn_課題分配";
            this.btn_課題分配.Size = new System.Drawing.Size(87, 34);
            this.btn_課題分配.TabIndex = 6;
            this.btn_課題分配.Text = "課題分配";
            this.btn_課題分配.UseVisualStyleBackColor = true;
            this.btn_課題分配.Click += new System.EventHandler(this.btn_課題分配_Click);
            // 
            // gv_homework
            // 
            this.gv_homework.AllowUserToAddRows = false;
            this.gv_homework.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_homework.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_homework.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_homework.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.課題番号,
            this.課題名,
            this.言語,
            this.予定完成時間,
            this.課題内容});
            this.gv_homework.Location = new System.Drawing.Point(40, 104);
            this.gv_homework.Name = "gv_homework";
            this.gv_homework.RowTemplate.Height = 24;
            this.gv_homework.Size = new System.Drawing.Size(872, 415);
            this.gv_homework.TabIndex = 7;
            this.gv_homework.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.gv_homework_CellBeginEdit);
            this.gv_homework.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_homework_CellEndEdit);
            this.gv_homework.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_homework_CellValueChanged);
            this.gv_homework.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gv_homework_DataError);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 521);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(962, 22);
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
            // 課題番号
            // 
            this.課題番号.HeaderText = "課題番号";
            this.課題番号.Name = "課題番号";
            this.課題番号.ReadOnly = true;
            // 
            // 課題名
            // 
            this.課題名.HeaderText = "課題名";
            this.課題名.Name = "課題名";
            this.課題名.ReadOnly = true;
            this.課題名.Width = 120;
            // 
            // 言語
            // 
            this.言語.HeaderText = "言語";
            this.言語.Name = "言語";
            this.言語.ReadOnly = true;
            this.言語.Width = 70;
            // 
            // 予定完成時間
            // 
            this.予定完成時間.HeaderText = "予定完成時間";
            this.予定完成時間.Name = "予定完成時間";
            this.予定完成時間.Width = 130;
            // 
            // 課題内容
            // 
            this.課題内容.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue;
            this.課題内容.DefaultCellStyle = dataGridViewCellStyle2;
            this.課題内容.HeaderText = "課題内容";
            this.課題内容.Name = "課題内容";
            // 
            // 課題一覧
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 543);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gv_homework);
            this.Controls.Add(this.btn_課題分配);
            this.Controls.Add(this.btn_課題追加);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "課題一覧";
            this.Text = "課題一覧";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.課題一覧_FormClosed);
            this.Load += new System.EventHandler(this.課題一覧_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_homework)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_課題追加;
        private System.Windows.Forms.Button btn_課題分配;
        private System.Windows.Forms.DataGridView gv_homework;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 課題番号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 課題名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 言語;
        private System.Windows.Forms.DataGridViewTextBoxColumn 予定完成時間;
        private System.Windows.Forms.DataGridViewTextBoxColumn 課題内容;
    }
}