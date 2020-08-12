using HL_塾管理;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace HL_塾管理
{
    public partial class 宿題分配 : DockContent
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int BringWindowToTop(IntPtr hWnd);
        private AutoSizeFormClass asc = new AutoSizeFormClass();

        public string 教師コード = "";

        //クラス分配、学生分配フラグ
        public string OpenedBy = "クラス";

        //項目データ取得
        public string 学生コード = "";
        public string 学生名 = "";
        public string 課程 = "";
        public string クラスコード = "";
        public string 宿題コード = "";
        public string 予定日 = "";
        Dictionary<string, string> list_学生 = new Dictionary<string, string>();

        //データベース接続情報
        private string connectionString = ComClass.connectionString;

        public 宿題分配()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref System.Windows.Forms.Message msg)
        {
            switch (msg.Msg)
            {
                case Form1.CUSTOM_MESSAGE:
                    {
                        DisplayGridView();
                    }
                    break;

                default:
                    base.WndProc(ref msg);
                    break;
            }
        }

        private void 宿題分配_Load(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);

            if (OpenedBy == "クラス")
            {
                SetClassName();
                予定日 = txt_予定日.Text;
                //lbl_学生名.Visible = false;
                //txt_学生名.Visible = false;
            }
            else
            {
                予定日 = txt_予定日.Text;
                cmb_学生名.Text = 学生名;
                lbl_学生名.Location = lbl_クラス名.Location;
                cmb_学生名.Location = cmb_クラス名.Location;
                lbl_クラス名.Visible = false;
                cmb_クラス名.Visible = false;
            }
            DisplayGridView();
        }

        private void DisplayGridView()
        {
            dgv_宿題.Rows.Clear();

            SqlConnection sqlcon = new SqlConnection(connectionString); //连接数据库

            try
            {
                sqlcon.Open();
            }
            catch
            {
                //((Form1)(this.Tag)).toolStripStatusLabel2.ForeColor = Color.Red;
                //((Form1)(this.Tag)).toolStripStatusLabel2.Text = "DBサーバーの接続に失敗しました.";
                //((Form1)(this.Tag)).reLoad = true;
                //return;
            }

            try
            {
                string str_sqlcmd = "Select 宿題コード,宿題名,宿題内容 From HL_JUKUKANRI_宿題マスタ "; 

                if (OpenedBy != "クラス")  
                {
                    str_sqlcmd+= "Where 言語 = " + "'" + 課程 + "'";
                }


                SqlCommand com = new SqlCommand(str_sqlcmd, sqlcon);
                SqlDataReader reader = com.ExecuteReader();

                int index = 0;

                while (reader.Read())
                {
                    dgv_宿題.Rows.Add();
                    dgv_宿題.Rows[index].Cells["宿題番号"].Value = reader["宿題コード"].ToString();
                    dgv_宿題.Rows[index].Cells["宿題名"].Value = reader["宿題名"].ToString();
                    dgv_宿題.Rows[index].Cells["宿題内容"].Value = reader["宿題内容"].ToString();
                    index++;
                }
            }
            catch (Exception ex)
            {
                //((Form1)(this.Tag)).toolStripStatusLabel2.ForeColor = Color.Red;
                //((Form1)(this.Tag)).toolStripStatusLabel2.Text = "検索処理に失敗しました." + ex.Message;
                //((Form1)(this.Tag)).reLoad = false;
                MessageBox.Show("検索処理に失敗しました.");
                if (sqlcon != null)
                {
                    sqlcon.Close();
                }
                return;
            }

            if (sqlcon != null)
            {
                sqlcon.Close();
            }
        }

        public void SetClassName()
        {
            SqlConnection sqlcon = new SqlConnection(connectionString); //连接数据库

            try
            {
                sqlcon.Open();
            }
            catch
            {
                //((Form1)(this.Tag)).toolStripStatusLabel2.ForeColor = Color.Red;
                //((Form1)(this.Tag)).toolStripStatusLabel2.Text = "DBサーバーの接続に失敗しました.";
                //((Form1)(this.Tag)).reLoad = true;
                //return;
            }

            string sql = "Select クラスコード,クラス名,課程 From HL_JUKUKANRI_クラス履歴　Where 教師コード = " + "'" + 教師コード + "' And 有効 ='1'";
            SqlDataAdapter sqlda = new SqlDataAdapter(sql,sqlcon);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            cmb_クラス名.DisplayMember = "クラス名";
            cmb_クラス名.ValueMember = "課程";
            cmb_クラス名.DataSource = dt;
            課程 = cmb_クラス名.ValueMember;
            sqlcon.Close();
        }

        private void SetStudentList()
        {
            SqlConnection sqlcon = new SqlConnection(connectionString); //连接数据库

            try
            {
                sqlcon.Open();
            }
            catch
            {
                //((Form1)(this.Tag)).toolStripStatusLabel2.ForeColor = Color.Red;
                //((Form1)(this.Tag)).toolStripStatusLabel2.Text = "DBサーバーの接続に失敗しました.";
                //((Form1)(this.Tag)).reLoad = true;
                //return;
            }

            string sql = string.Format(@"Select a.学生コード,b.学生名  From　HL_JUKUKANRI_学生クラス as a
                         Left Join HL_JUKUKANRI_学生マスタ as b on a.学生コード = b.学生コード 
                         Where a.クラスコード = '{0}'",クラスコード);

            //SqlCommand com = new SqlCommand(sql, sqlcon);
            //SqlDataReader reader = com.ExecuteReader();
            //while (reader.Read())
            //{
            //    string code = reader["学生コード"].ToString();
            //    string name = reader["学生名"].ToString();
            //    list_学生.Add(code, name);
            //}

            SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlcon);

            DataTable dt = new DataTable();

            sqlda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                cmb_学生名.DisplayMember = "学生名";

                cmb_学生名.ValueMember = "学生コード";

                cmb_学生名.DataSource = dt;

                for(int i=0; i < dt.Rows.Count; i++)
                {
                    string code = dt.Rows[i]["学生コード"].ToString();

                    string name = dt.Rows[i]["学生名"].ToString();

                    list_学生.Add(code, name);
                }
            }

            sqlcon.Close();

        }

        private void btn_新規_Click(object sender, EventArgs e)
        {
            宿題追加 宿題追加 = new 宿題追加();
            宿題追加.Show();
        }

        private void btn_変更_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(宿題コード))
            {
                //((Form1)(this.Tag)).toolStripStatusLabel2.ForeColor = Color.Red;
                //((Form1)(this.Tag)).toolStripStatusLabel2.Text = "課題を選択してください。";
                //((Form1)(this.Tag)).reLoad = true;
                //return;
            }
            else
            {
                宿題追加 m_NewForm_宿題追加 = new 宿題追加();
                m_NewForm_宿題追加.IsNew = "Old";
                m_NewForm_宿題追加.宿題コード = 宿題コード;
                m_NewForm_宿題追加.Show();
            }         
        }

        private void btn_追加_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(宿題コード))
            {
                //((Form1)(this.Tag)).toolStripStatusLabel2.ForeColor = Color.Red;
                //((Form1)(this.Tag)).toolStripStatusLabel2.Text = "課題を選択してください。";
                //((Form1)(this.Tag)).reLoad = true;
                //return;
            }

            if (string.IsNullOrEmpty(予定日))
            {
                //((Form1)(this.Tag)).toolStripStatusLabel2.ForeColor = Color.Red;
                //((Form1)(this.Tag)).toolStripStatusLabel2.Text = "予定日を入力してください。";
                //((Form1)(this.Tag)).reLoad = true;
                //return;
            }

            SqlConnection sqlcon = new SqlConnection(connectionString); //连接数据库

            try
            {
                sqlcon.Open();
            }
            catch
            {
                //((Form1)(this.Tag)).toolStripStatusLabel2.ForeColor = Color.Red;
                //((Form1)(this.Tag)).toolStripStatusLabel2.Text = "DBサーバーの接続に失敗しました.";
                //((Form1)(this.Tag)).reLoad = true;
                //return;
            }

            string date = DateTime.Now.ToString("d");
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.Connection = sqlcon;
            int result = 0;

            try
            {
                if (OpenedBy == "クラス")
                {
                    SetStudentList();
                    string[] Student_Code = new string[] { };
                    if (list_学生.Count > 0)
                    {
                        Student_Code = new string[list_学生.Count];

                        for (int i = 0; i < list_学生.Count; i++)  
                        {
                            foreach (string code in list_学生.Keys)
                            {
                                Student_Code.SetValue(code, i);

                                sqlcom.CommandText=string.Format(@"Insert Into HL_JUKUKANRI_学生進捗 (学生コード,クラスコード,宿題コード,宿題完成度,開始日,予定日,完成フラグ) 
                                            Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", 学生コード, クラスコード, 宿題コード, 0, date,予定日,null);

                                result = sqlcom.ExecuteNonQuery();

                                if (result > 0)
                                {
                                    //((Form1)(Tag)).toolStripStatusLabel2.ForeColor = Color.Green;
                                    //((Form1)(Tag)).toolStripStatusLabel2.Text = string.Format("クラス[{0}]の課題分配が成功しました。", クラスコード);
                                    return;
                                }

                                i++;
                            }
                        }
                    }
                    else
                    {
                        //((Form1)(this.Tag)).toolStripStatusLabel2.ForeColor = Color.Red;
                        //((Form1)(this.Tag)).toolStripStatusLabel2.Text = "学生がいませんので課題分配が失敗しました。";
                        //((Form1)(this.Tag)).reLoad = true;
                        //return;
                    }

                }
                else
                {
                    sqlcom.CommandText = string.Format(@"Insert Into HL_JUKUKANRI_学生進捗 (学生コード,クラスコード,宿題コード,宿題完成度,開始日,予定日,完成フラグ) 
                                            Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", 学生コード, クラスコード, 宿題コード, 0, date, 予定日, null);

                    result = sqlcom.ExecuteNonQuery();

                    if (result == 1)
                    {
                        //((Form1)(this.Tag)).toolStripStatusLabel2.ForeColor = Color.Green;
                        //((Form1)(this.Tag)).toolStripStatusLabel2.Text = "課題が正常に分配されました。";
                    }

                }
            }
            catch (Exception ex)
            {
                //((Form1)(this.Tag)).toolStripStatusLabel2.ForeColor = Color.Red;
                //((Form1)(this.Tag)).toolStripStatusLabel2.Text = "課題の分配処理が失敗しました。" + ex.Message;
            }
            finally
            {
                if (sqlcon != null)
                {
                    sqlcon.Close();
                }
            }
        }

        private void btn_キャンセル_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_宿題_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if(dgv.Columns[e.ColumnIndex].Name == "選択")
            {
                宿題コード = dgv_宿題.CurrentRow.Cells["宿題番号"].Value.ToString();
            }
        }
        
        /// <summary>
        /// クラス変更
        /// </summary>

        private void cmb_クラス名_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayGridView();
        }

        private void dgv_宿題_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgv_宿題.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell ck = dgv_宿題.Rows[i].Cells[0] as DataGridViewCheckBoxCell;
                if (i != e.RowIndex)
                {
                    ck.Value = false;
                }
                else
                {
                    ck.Value = true;
                }
            }
        }
        /// <summary>
        /// 画面閉じ
        /// </summary>
        private void 宿題分配_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form1)(this.Tag)).m_宿題分配Handle = IntPtr.Zero;
        }

    }
}
