namespace HL_塾管理
{
    partial class 課題追加
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
            this.lbl_課題名 = new System.Windows.Forms.Label();
            this.lbl_言語 = new System.Windows.Forms.Label();
            this.lbl_課題内容 = new System.Windows.Forms.Label();
            this.cmb_言語 = new System.Windows.Forms.ComboBox();
            this.txt_課題名 = new System.Windows.Forms.TextBox();
            this.txt_課題内容 = new System.Windows.Forms.TextBox();
            this.btn_追加 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_課題名
            // 
            this.lbl_課題名.AutoSize = true;
            this.lbl_課題名.Location = new System.Drawing.Point(61, 44);
            this.lbl_課題名.Name = "lbl_課題名";
            this.lbl_課題名.Size = new System.Drawing.Size(41, 12);
            this.lbl_課題名.TabIndex = 2;
            this.lbl_課題名.Text = "課題名";
            // 
            // lbl_言語
            // 
            this.lbl_言語.AutoSize = true;
            this.lbl_言語.Location = new System.Drawing.Point(61, 103);
            this.lbl_言語.Name = "lbl_言語";
            this.lbl_言語.Size = new System.Drawing.Size(29, 12);
            this.lbl_言語.TabIndex = 3;
            this.lbl_言語.Text = "言語";
            // 
            // lbl_課題内容
            // 
            this.lbl_課題内容.AutoSize = true;
            this.lbl_課題内容.Location = new System.Drawing.Point(61, 162);
            this.lbl_課題内容.Name = "lbl_課題内容";
            this.lbl_課題内容.Size = new System.Drawing.Size(53, 12);
            this.lbl_課題内容.TabIndex = 4;
            this.lbl_課題内容.Text = "課題内容";
            // 
            // cmb_言語
            // 
            this.cmb_言語.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_言語.FormattingEnabled = true;
            this.cmb_言語.Items.AddRange(new object[] {
            ".Net",
            "iOS",
            "php",
            "pyhton",
            "Java",
            "Android",
            "Salesforce"});
            this.cmb_言語.Location = new System.Drawing.Point(158, 100);
            this.cmb_言語.Name = "cmb_言語";
            this.cmb_言語.Size = new System.Drawing.Size(139, 20);
            this.cmb_言語.TabIndex = 2;
            this.cmb_言語.SelectedValueChanged += new System.EventHandler(this.cmb_言語_SelectedValueChanged);
            // 
            // txt_課題名
            // 
            this.txt_課題名.Location = new System.Drawing.Point(158, 41);
            this.txt_課題名.MaxLength = 100;
            this.txt_課題名.Name = "txt_課題名";
            this.txt_課題名.Size = new System.Drawing.Size(153, 21);
            this.txt_課題名.TabIndex = 1;
            // 
            // txt_課題内容
            // 
            this.txt_課題内容.Location = new System.Drawing.Point(63, 190);
            this.txt_課題内容.MaxLength = 200;
            this.txt_課題内容.Multiline = true;
            this.txt_課題内容.Name = "txt_課題内容";
            this.txt_課題内容.Size = new System.Drawing.Size(670, 155);
            this.txt_課題内容.TabIndex = 3;
            // 
            // btn_追加
            // 
            this.btn_追加.Location = new System.Drawing.Point(344, 375);
            this.btn_追加.Name = "btn_追加";
            this.btn_追加.Size = new System.Drawing.Size(105, 35);
            this.btn_追加.TabIndex = 8;
            this.btn_追加.Text = "追加";
            this.btn_追加.UseVisualStyleBackColor = true;
            this.btn_追加.Click += new System.EventHandler(this.btn_追加_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // 課題追加
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_追加);
            this.Controls.Add(this.txt_課題内容);
            this.Controls.Add(this.txt_課題名);
            this.Controls.Add(this.cmb_言語);
            this.Controls.Add(this.lbl_課題内容);
            this.Controls.Add(this.lbl_言語);
            this.Controls.Add(this.lbl_課題名);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "課題追加";
            this.Text = "課題追加";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.課題追加_FormClosed);
            this.Load += new System.EventHandler(this.課題追加_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_課題名;
        private System.Windows.Forms.Label lbl_言語;
        private System.Windows.Forms.Label lbl_課題内容;
        private System.Windows.Forms.ComboBox cmb_言語;
        private System.Windows.Forms.TextBox txt_課題名;
        private System.Windows.Forms.TextBox txt_課題内容;
        private System.Windows.Forms.Button btn_追加;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}