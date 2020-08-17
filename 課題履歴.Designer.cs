using System.Windows.Forms;

namespace HL_塾管理
{
    partial class 課題履歴
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
            this.dgv_st = new System.Windows.Forms.DataGridView();
            this.lbl_stcode = new System.Windows.Forms.Label();
            this.lbl_stname = new System.Windows.Forms.Label();
            this.lbl_code = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.件数toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_st)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_st
            // 
            this.dgv_st.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_st.Location = new System.Drawing.Point(54, 55);
            this.dgv_st.Name = "dgv_st";
            this.dgv_st.RowTemplate.Height = 24;
            this.dgv_st.Size = new System.Drawing.Size(581, 204);
            this.dgv_st.TabIndex = 4;
            // 
            // lbl_stcode
            // 
            this.lbl_stcode.AutoSize = true;
            this.lbl_stcode.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.lbl_stcode.Location = new System.Drawing.Point(302, 22);
            this.lbl_stcode.Name = "lbl_stcode";
            this.lbl_stcode.Size = new System.Drawing.Size(99, 20);
            this.lbl_stcode.TabIndex = 6;
            this.lbl_stcode.Text = "学生番号：";
            // 
            // lbl_stname
            // 
            this.lbl_stname.AutoSize = true;
            this.lbl_stname.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.lbl_stname.Location = new System.Drawing.Point(50, 22);
            this.lbl_stname.Name = "lbl_stname";
            this.lbl_stname.Size = new System.Drawing.Size(99, 20);
            this.lbl_stname.TabIndex = 5;
            this.lbl_stname.Text = "学生名前：";
            // 
            // lbl_code
            // 
            this.lbl_code.AutoSize = true;
            this.lbl_code.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.lbl_code.Location = new System.Drawing.Point(407, 22);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(0, 20);
            this.lbl_code.TabIndex = 8;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.lbl_name.Location = new System.Drawing.Point(155, 22);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 20);
            this.lbl_name.TabIndex = 9;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.件数toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 366);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(837, 22);
            this.statusStrip1.TabIndex = 10;
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
            // 件数toolStripStatusLabel
            // 
            this.件数toolStripStatusLabel.Name = "件数toolStripStatusLabel";
            this.件数toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // 課題履歴
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 388);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_code);
            this.Controls.Add(this.lbl_stcode);
            this.Controls.Add(this.lbl_stname);
            this.Controls.Add(this.dgv_st);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "課題履歴";
            this.Text = "宿題履歴";
            this.Load += new System.EventHandler(this.宿題履歴_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_st)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_st;
        private System.Windows.Forms.Label lbl_stcode;
        private System.Windows.Forms.Label lbl_stname;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private Label lbl_code;
        private Label lbl_name;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel 件数toolStripStatusLabel;
    }
}