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
    public partial class 課題追加 : DockContent
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int BringWindowToTop(IntPtr hWnd);
        private AutoSizeFormClass asc = new AutoSizeFormClass();

        //データベース接続情報
        private string connectionString = ComClass.connectionString;

        //画面項目
        public string 課題コード = string.Empty;
        public string 課題名 = string.Empty;
        public string 課題内容 = string.Empty;
        public string 言語 = string.Empty;

        //クラス、学生フラグ
        public string IsOpenedBy = "クラス";

        //更新フラグ
        public string IsNew = "New";

        //エラーメッセージ
        private Dictionary<string, string> errmsg = new Dictionary<string, string>();

        public 課題追加()
        {
            InitializeComponent();
        }


        private void 課題追加_Load(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);

            if (IsNew == "New")
            {
                Set課題コード();
            }
            else
            {
                GetData();
                this.Text = "課題変更";
                btn_追加.Text = "変更";
            }

        }

        private void Set課題コード()
        {
            言語 = cmb_言語.Text;
            SqlConnection sqlcon = new SqlConnection(connectionString); //连接数据库

            try
            {
                sqlcon.Open();
            }
            catch
            {
                this.toolStripStatusLabel1.ForeColor = Color.Red;
                this.toolStripStatusLabel1.Text = "DBサーバーの接続に失敗しました";
                return;
            }

            string sql = string.Format(@"Select Count (*) FROM HL_JUKUKANRI_課題マスタ Where 言語='{0}'", 言語);

            SqlCommand com = new SqlCommand(sql, sqlcon);
            int result = (int)com.ExecuteScalar();

            課題コード = 言語 + result.ToString();
        }

        public void InputCheck()
        {
            errmsg = new Dictionary<string, string>();
            課題名 = txt_課題名.Text;
            言語 = cmb_言語.Text;
            課題内容 = txt_課題内容.Text;

            SqlConnection sqlcon = new SqlConnection(connectionString); //连接数据库

            try
            {
                sqlcon.Open();
            }
            catch
            {
                this.toolStripStatusLabel1.ForeColor = Color.Red;
                this.toolStripStatusLabel1.Text = "DBサーバーの接続に失敗しました";
                return;
            }

            if (string.IsNullOrWhiteSpace(課題名))
            {
                AddErrMsgList(lbl_課題名.Text, "課題名を入力してください。");
                return;
            }
            
            if (string.IsNullOrWhiteSpace(言語))
            {
                AddErrMsgList(lbl_言語.Text, "言語を選択してください。");
                return;
            }

            if (string.IsNullOrWhiteSpace(課題内容))
            {
                AddErrMsgList(lbl_課題内容.Text, "課題内容を入力してください。");
                return;
            }

            //同じ課題の重複チェック
            if (IsNew == "New")
            {
                SqlCommand sqlcom = new SqlCommand();
                sqlcom.Connection = sqlcon;

                string str_sqlcmd = string.Format(@"Select * From HL_JUKUKANRI_課題マスタ Where 課題名 = '{0}'", 課題名);

                SqlCommand com = new SqlCommand(str_sqlcmd, sqlcon);
                SqlDataReader reader = com.ExecuteReader();

                if (reader.Read())
                {
                    errmsg.Add(lbl_課題名.Text, string.Format("[課題名]({0})が既に登録されています。", 課題名));
                    return;
                }
            }

            if (sqlcon != null)
            {
                sqlcon.Close();
            }
        }

        /// <summary>
        ///  エラーメッセージ追加
        /// </summary>
        private void AddErrMsgList(string name, string msg)
        {
            if (errmsg.ContainsKey(name))
            {
                errmsg[name] += msg + "\r\n";
            }
            else
            {
                errmsg.Add(name, msg);
            }
        }

        private void SetErrMsg()
        {
            foreach (string ControlName in errmsg.Keys)
            {            
                toolStripStatusLabel1.ForeColor = Color.Red;
                toolStripStatusLabel1.Text += errmsg[ControlName] + Environment.NewLine;
            }
        }

        private void GetData()
        {
            SqlConnection sqlcon = new SqlConnection(connectionString); //连接数据库

            try
            {
                sqlcon.Open();
            }
            catch
            {
                this.toolStripStatusLabel1.ForeColor = Color.Red;
                this.toolStripStatusLabel1.Text = "DBサーバーの接続に失敗しました";
                return;
            }

            string sql = string.Format(@"Select 課題名,言語,課題内容 From  HL_JUKUKANRI_課題マスタ Where 課題コード= '{0}'", 課題コード);

            SqlCommand com = new SqlCommand(sql,sqlcon);
            SqlDataReader reader = com.ExecuteReader();

            if(reader.Read())
            {
                txt_課題名.Text = reader["課題名"].ToString();
                cmb_言語.Text = reader["言語"].ToString();
                txt_課題内容.Text = reader["課題内容"].ToString();
            }

            sqlcon.Close();

        }

        private void btn_追加_Click(object sender, EventArgs e)
        {
            //入力チェック
            InputCheck();
            if (errmsg.Count > 0)
            {
                toolStripStatusLabel1.Text = "";
                //エラーメッセージ表示
                SetErrMsg();
                return;
            }

            SqlConnection sqlcon = new SqlConnection(connectionString); //连接数据库

            int result = 0;
            try
            {
                sqlcon.Open();
            }
            catch
            {
                toolStripStatusLabel1.Text = "";
                toolStripStatusLabel1.Text = "DBサーバーの接続に失敗しました。";
                return;
            }
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.Connection = sqlcon;

            try
            {
                //追加の場合
                if (IsNew == "New")
                {
                    sqlcom.CommandText = string.Format(@"Insert Into HL_JUKUKANRI_課題マスタ Values ('{0}', '{1}', '{2}','{3}') ",
                                                         課題コード, 課題名, 課題内容, 言語);

                    result = sqlcom.ExecuteNonQuery();

                    if (result == 1)
                    {
                        //((Form1)(this.Tag)).toolStripStatusLabel2.ForeColor = Color.Green;
                        //((Form1)(this.Tag)).toolStripStatusLabel2.Text = "課題が正常に登録されました。";
                        MessageBox.Show("課題が正常に登録されました。");
                    }
                }
                //変更の場合
                else
                {
                    sqlcom.CommandText = string.Format(@"Update HL_JUKUKANRI_課題マスタ Set 
                                                       課題名 = '{0}', 課題内容 = '{1}', 言語 = '{2}' Where 課題コード = '{3}'",
                                                       課題名, 課題内容, 言語,課題コード);

                    result = sqlcom.ExecuteNonQuery();

                    if (result == 1)
                    {
                        //((Form1)(this.Tag)).toolStripStatusLabel2.ForeColor = Color.Green;
                        //((Form1)(this.Tag)).toolStripStatusLabel2.Text = "課題が正常に登録されました。";
                        MessageBox.Show("課題が正常に更新されました。");
                    }
                }

            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.ForeColor = Color.Red;
                toolStripStatusLabel1.Text = "課題の登録、変更処理が失敗しました。" + ex.Message;
            }
            finally
            {
                if (sqlcon != null)
                {
                    sqlcon.Close();
                }
            }

        }

        private void cmb_言語_SelectedValueChanged(object sender, EventArgs e)
        {
            if (IsNew == "New")
            {
                Set課題コード();
            }
        }

        private void 課題追加_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form1)(this.Tag)).m_課題追加Handle = IntPtr.Zero;
        }
    }
}
