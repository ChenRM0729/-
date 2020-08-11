namespace HL_塾管理
{
    partial class 宿題分配
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
            this.dgv_宿題 = new System.Windows.Forms.DataGridView();
            this.btn_新規 = new System.Windows.Forms.Button();
            this.btn_変更 = new System.Windows.Forms.Button();
            this.btn_追加 = new System.Windows.Forms.Button();
            this.btn_キャンセル = new System.Windows.Forms.Button();
            this.cmb_クラス名 = new System.Windows.Forms.ComboBox();
            this.lbl_クラス名 = new System.Windows.Forms.Label();
            this.lbl_学生名 = new System.Windows.Forms.Label();
            this.txt_予定日 = new System.Windows.Forms.TextBox();
            this.lbl_予定日 = new System.Windows.Forms.Label();
            this.cmb_学生名 = new System.Windows.Forms.ComboBox();
            this.選択 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.宿題番号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.宿題名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.宿題内容 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_宿題)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_宿題
            // 
            this.dgv_宿題.AllowUserToAddRows = false;
            this.dgv_宿題.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_宿題.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.選択,
            this.宿題番号,
            this.宿題名,
            this.宿題内容});
            this.dgv_宿題.Location = new System.Drawing.Point(49, 28);
            this.dgv_宿題.Name = "dgv_宿題";
            this.dgv_宿題.RowTemplate.Height = 23;
            this.dgv_宿題.Size = new System.Drawing.Size(714, 238);
            this.dgv_宿題.TabIndex = 0;
            this.dgv_宿題.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_宿題_CellContentClick);
            this.dgv_宿題.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_宿題_CellValueChanged);
            // 
            // btn_新規
            // 
            this.btn_新規.Location = new System.Drawing.Point(58, 303);
            this.btn_新規.Name = "btn_新規";
            this.btn_新規.Size = new System.Drawing.Size(75, 23);
            this.btn_新規.TabIndex = 1;
            this.btn_新規.Text = "新規";
            this.btn_新規.UseVisualStyleBackColor = true;
            this.btn_新規.Click += new System.EventHandler(this.btn_新規_Click);
            // 
            // btn_変更
            // 
            this.btn_変更.Location = new System.Drawing.Point(163, 303);
            this.btn_変更.Name = "btn_変更";
            this.btn_変更.Size = new System.Drawing.Size(75, 23);
            this.btn_変更.TabIndex = 2;
            this.btn_変更.Text = "変更";
            this.btn_変更.UseVisualStyleBackColor = true;
            this.btn_変更.Click += new System.EventHandler(this.btn_変更_Click);
            // 
            // btn_追加
            // 
            this.btn_追加.Location = new System.Drawing.Point(546, 402);
            this.btn_追加.Name = "btn_追加";
            this.btn_追加.Size = new System.Drawing.Size(93, 35);
            this.btn_追加.TabIndex = 3;
            this.btn_追加.Text = "追加";
            this.btn_追加.UseVisualStyleBackColor = true;
            this.btn_追加.Click += new System.EventHandler(this.btn_追加_Click);
            // 
            // btn_キャンセル
            // 
            this.btn_キャンセル.Location = new System.Drawing.Point(671, 402);
            this.btn_キャンセル.Name = "btn_キャンセル";
            this.btn_キャンセル.Size = new System.Drawing.Size(92, 35);
            this.btn_キャンセル.TabIndex = 4;
            this.btn_キャンセル.Text = "キャンセル";
            this.btn_キャンセル.UseVisualStyleBackColor = true;
            this.btn_キャンセル.Click += new System.EventHandler(this.btn_キャンセル_Click);
            // 
            // cmb_クラス名
            // 
            this.cmb_クラス名.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_クラス名.FormattingEnabled = true;
            this.cmb_クラス名.Location = new System.Drawing.Point(115, 361);
            this.cmb_クラス名.Name = "cmb_クラス名";
            this.cmb_クラス名.Size = new System.Drawing.Size(121, 20);
            this.cmb_クラス名.TabIndex = 5;
            this.cmb_クラス名.SelectedIndexChanged += new System.EventHandler(this.cmb_クラス名_SelectedIndexChanged);
            // 
            // lbl_クラス名
            // 
            this.lbl_クラス名.AutoSize = true;
            this.lbl_クラス名.Location = new System.Drawing.Point(56, 364);
            this.lbl_クラス名.Name = "lbl_クラス名";
            this.lbl_クラス名.Size = new System.Drawing.Size(53, 12);
            this.lbl_クラス名.TabIndex = 7;
            this.lbl_クラス名.Text = "クラス名";
            // 
            // lbl_学生名
            // 
            this.lbl_学生名.AutoSize = true;
            this.lbl_学生名.Location = new System.Drawing.Point(313, 364);
            this.lbl_学生名.Name = "lbl_学生名";
            this.lbl_学生名.Size = new System.Drawing.Size(41, 12);
            this.lbl_学生名.TabIndex = 8;
            this.lbl_学生名.Text = "学生名";
            // 
            // txt_予定日
            // 
            this.txt_予定日.Location = new System.Drawing.Point(363, 410);
            this.txt_予定日.MaxLength = 10;
            this.txt_予定日.Name = "txt_予定日";
            this.txt_予定日.Size = new System.Drawing.Size(124, 21);
            this.txt_予定日.TabIndex = 10;
            // 
            // lbl_予定日
            // 
            this.lbl_予定日.AutoSize = true;
            this.lbl_予定日.Location = new System.Drawing.Point(313, 413);
            this.lbl_予定日.Name = "lbl_予定日";
            this.lbl_予定日.Size = new System.Drawing.Size(41, 12);
            this.lbl_予定日.TabIndex = 11;
            this.lbl_予定日.Text = "予定日";
            // 
            // cmb_学生名
            // 
            this.cmb_学生名.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_学生名.FormattingEnabled = true;
            this.cmb_学生名.Location = new System.Drawing.Point(363, 361);
            this.cmb_学生名.Name = "cmb_学生名";
            this.cmb_学生名.Size = new System.Drawing.Size(121, 20);
            this.cmb_学生名.TabIndex = 12;
            // 
            // 選択
            // 
            this.選択.HeaderText = "選択";
            this.選択.Name = "選択";
            this.選択.Width = 50;
            // 
            // 宿題番号
            // 
            this.宿題番号.HeaderText = "宿題番号";
            this.宿題番号.Name = "宿題番号";
            this.宿題番号.ReadOnly = true;
            this.宿題番号.Visible = false;
            // 
            // 宿題名
            // 
            this.宿題名.HeaderText = "課題名";
            this.宿題名.Name = "宿題名";
            this.宿題名.ReadOnly = true;
            // 
            // 宿題内容
            // 
            this.宿題内容.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.宿題内容.HeaderText = "課題内容";
            this.宿題内容.Name = "宿題内容";
            this.宿題内容.ReadOnly = true;
            // 
            // 宿題分配
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 475);
            this.Controls.Add(this.cmb_学生名);
            this.Controls.Add(this.lbl_予定日);
            this.Controls.Add(this.txt_予定日);
            this.Controls.Add(this.lbl_学生名);
            this.Controls.Add(this.lbl_クラス名);
            this.Controls.Add(this.cmb_クラス名);
            this.Controls.Add(this.btn_キャンセル);
            this.Controls.Add(this.btn_追加);
            this.Controls.Add(this.btn_変更);
            this.Controls.Add(this.btn_新規);
            this.Controls.Add(this.dgv_宿題);
            this.Name = "宿題分配";
            this.Text = "課題分配";
            this.Load += new System.EventHandler(this.宿題分配_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_宿題)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_宿題;
        private System.Windows.Forms.Button btn_新規;
        private System.Windows.Forms.Button btn_変更;
        private System.Windows.Forms.Button btn_追加;
        private System.Windows.Forms.Button btn_キャンセル;
        private System.Windows.Forms.ComboBox cmb_クラス名;
        private System.Windows.Forms.Label lbl_クラス名;
        private System.Windows.Forms.Label lbl_学生名;
        private System.Windows.Forms.TextBox txt_予定日;
        private System.Windows.Forms.Label lbl_予定日;
        private System.Windows.Forms.ComboBox cmb_学生名;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 選択;
        private System.Windows.Forms.DataGridViewTextBoxColumn 宿題番号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 宿題名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 宿題内容;
    }
}