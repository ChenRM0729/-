namespace HL_塾管理
{
    partial class 学生評価追加
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
            this.cmb_クラス = new System.Windows.Forms.ComboBox();
            this.lbl_クラス = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_評価月 = new System.Windows.Forms.Label();
            this.btn_今月評価追加 = new System.Windows.Forms.Button();
            this.cmb_学生名 = new System.Windows.Forms.ComboBox();
            this.lbl_学生 = new System.Windows.Forms.Label();
            this.txt_授業態度 = new System.Windows.Forms.TextBox();
            this.lbl_授業態度 = new System.Windows.Forms.Label();
            this.lbl_総合評価 = new System.Windows.Forms.Label();
            this.txt_総合評価 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1_count = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_クラス
            // 
            this.cmb_クラス.FormattingEnabled = true;
            this.cmb_クラス.Location = new System.Drawing.Point(99, 32);
            this.cmb_クラス.Name = "cmb_クラス";
            this.cmb_クラス.Size = new System.Drawing.Size(121, 20);
            this.cmb_クラス.TabIndex = 25;
            // 
            // lbl_クラス
            // 
            this.lbl_クラス.AutoSize = true;
            this.lbl_クラス.Location = new System.Drawing.Point(38, 35);
            this.lbl_クラス.Name = "lbl_クラス";
            this.lbl_クラス.Size = new System.Drawing.Size(41, 12);
            this.lbl_クラス.TabIndex = 24;
            this.lbl_クラス.Text = "クラス";
            // 
            // dtp_date
            // 
            this.dtp_date.CustomFormat = "yyyy年MM月";
            this.dtp_date.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date.Location = new System.Drawing.Point(543, 26);
            this.dtp_date.Margin = new System.Windows.Forms.Padding(5);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.ShowUpDown = true;
            this.dtp_date.Size = new System.Drawing.Size(195, 22);
            this.dtp_date.TabIndex = 127;
            // 
            // lbl_評価月
            // 
            this.lbl_評価月.AutoSize = true;
            this.lbl_評価月.Location = new System.Drawing.Point(480, 31);
            this.lbl_評価月.Name = "lbl_評価月";
            this.lbl_評価月.Size = new System.Drawing.Size(41, 12);
            this.lbl_評価月.TabIndex = 126;
            this.lbl_評価月.Text = "評価月";
            // 
            // btn_今月評価追加
            // 
            this.btn_今月評価追加.Location = new System.Drawing.Point(311, 339);
            this.btn_今月評価追加.Name = "btn_今月評価追加";
            this.btn_今月評価追加.Size = new System.Drawing.Size(101, 34);
            this.btn_今月評価追加.TabIndex = 128;
            this.btn_今月評価追加.Text = "追加";
            this.btn_今月評価追加.UseVisualStyleBackColor = true;
            this.btn_今月評価追加.Click += new System.EventHandler(this.btn_今月評価追加_Click);
            // 
            // cmb_学生名
            // 
            this.cmb_学生名.FormattingEnabled = true;
            this.cmb_学生名.Location = new System.Drawing.Point(99, 80);
            this.cmb_学生名.Name = "cmb_学生名";
            this.cmb_学生名.Size = new System.Drawing.Size(121, 20);
            this.cmb_学生名.TabIndex = 130;
            // 
            // lbl_学生
            // 
            this.lbl_学生.AutoSize = true;
            this.lbl_学生.Location = new System.Drawing.Point(38, 83);
            this.lbl_学生.Name = "lbl_学生";
            this.lbl_学生.Size = new System.Drawing.Size(41, 12);
            this.lbl_学生.TabIndex = 129;
            this.lbl_学生.Text = "学生名";
            // 
            // txt_授業態度
            // 
            this.txt_授業態度.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_授業態度.Location = new System.Drawing.Point(99, 126);
            this.txt_授業態度.Margin = new System.Windows.Forms.Padding(4);
            this.txt_授業態度.Multiline = true;
            this.txt_授業態度.Name = "txt_授業態度";
            this.txt_授業態度.Size = new System.Drawing.Size(639, 64);
            this.txt_授業態度.TabIndex = 131;
            // 
            // lbl_授業態度
            // 
            this.lbl_授業態度.AutoSize = true;
            this.lbl_授業態度.Location = new System.Drawing.Point(28, 135);
            this.lbl_授業態度.Name = "lbl_授業態度";
            this.lbl_授業態度.Size = new System.Drawing.Size(53, 12);
            this.lbl_授業態度.TabIndex = 132;
            this.lbl_授業態度.Text = "授業態度";
            // 
            // lbl_総合評価
            // 
            this.lbl_総合評価.AutoSize = true;
            this.lbl_総合評価.Location = new System.Drawing.Point(28, 225);
            this.lbl_総合評価.Name = "lbl_総合評価";
            this.lbl_総合評価.Size = new System.Drawing.Size(53, 12);
            this.lbl_総合評価.TabIndex = 134;
            this.lbl_総合評価.Text = "総合評価";
            // 
            // txt_総合評価
            // 
            this.txt_総合評価.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_総合評価.Location = new System.Drawing.Point(99, 216);
            this.txt_総合評価.Margin = new System.Windows.Forms.Padding(4);
            this.txt_総合評価.Multiline = true;
            this.txt_総合評価.Name = "txt_総合評価";
            this.txt_総合評価.Size = new System.Drawing.Size(639, 104);
            this.txt_総合評価.TabIndex = 133;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel1_count});
            this.statusStrip1.Location = new System.Drawing.Point(0, 394);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 135;
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
            // 学生評価追加
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lbl_総合評価);
            this.Controls.Add(this.txt_総合評価);
            this.Controls.Add(this.lbl_授業態度);
            this.Controls.Add(this.txt_授業態度);
            this.Controls.Add(this.cmb_学生名);
            this.Controls.Add(this.lbl_学生);
            this.Controls.Add(this.btn_今月評価追加);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.lbl_評価月);
            this.Controls.Add(this.cmb_クラス);
            this.Controls.Add(this.lbl_クラス);
            this.Name = "学生評価追加";
            this.Text = "学生評価追加";
            this.Load += new System.EventHandler(this.学生評価追加_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_クラス;
        private System.Windows.Forms.Label lbl_クラス;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label lbl_評価月;
        private System.Windows.Forms.Button btn_今月評価追加;
        private System.Windows.Forms.ComboBox cmb_学生名;
        private System.Windows.Forms.Label lbl_学生;
        private System.Windows.Forms.TextBox txt_授業態度;
        private System.Windows.Forms.Label lbl_授業態度;
        private System.Windows.Forms.Label lbl_総合評価;
        private System.Windows.Forms.TextBox txt_総合評価;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1_count;
    }
}