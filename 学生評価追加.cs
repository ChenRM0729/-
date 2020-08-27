using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using WeifenLuo.WinFormsUI.Docking;

namespace HL_塾管理
{
    public partial class 学生評価追加 : DockContent
    {
        //データベース接続情報
        private string connectionString = ComClass.connectionString;
        //画面項目
        public string code_クラス = string.Empty;
        public string code_学生コード = string.Empty;
        public bool flag_学生情報 = false;
        public bool flag_クラス情報 = false;
        //検索データテーブル
        private DataTable dtInfo = null;

        public 学生評価追加()
        {
            InitializeComponent();
        }

        private void btn_今月評価追加_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(DateTime.Now.ToString("yyyyMM")) < Convert.ToInt32(dtp_date.Value.ToString("yyyyMM")))
            {
                this.toolStripStatusLabel1.ForeColor = Color.Red;
                this.toolStripStatusLabel1.Text = "未来月の評価は追加できません";
                return;
            }
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

            try
            {
                //データ取得開始

                string str_sqlcmd = "SELECT"
                + " * "
                + " FROM "
                + " HL_JUKUKANRI_学生評価  "
                + " WHERE  学生コード='" + cmb_学生名.SelectedValue+ "'"
                + " AND    評価年月='" + dtp_date.Value.ToString("yyyy年MM月") + "'";

                SqlDataAdapter sqlDa = new SqlDataAdapter(str_sqlcmd, sqlcon);
                dtInfo = new DataTable();
                sqlDa.Fill(dtInfo);

            }
            catch (Exception ee)
            {
                this.toolStripStatusLabel1.ForeColor = Color.Red;
                this.toolStripStatusLabel1.Text = ee.ToString();
                return;
            }
            finally
            {
                if (sqlcon != null)
                {
                    sqlcon.Close();
                }
            }

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

            try
            {
                //SqlTransaction transaction = sqlcon.BeginTransaction();
                if (dtInfo.Rows.Count == 0)
                {
                    SqlCommand sqlcom = new SqlCommand();
                    sqlcom.Connection = sqlcon;
                    //sqlcom.Transaction = transaction;

                    //登録行う
                    sqlcom.CommandText += string.Format(@"Insert Into HL_JUKUKANRI_学生評価 
                                                          Values( {0}, {1}, '{2}' , '{3}', '{4}')", cmb_学生名.SelectedValue, cmb_クラス.SelectedValue, txt_授業態度.Text, dtp_date.Value.ToString("yyyy年MM月"), txt_総合評価.Text);
       
                    int result = sqlcom.ExecuteNonQuery();
                    if (result == 1)
                    {
                        ((Form1)(this.Tag)).toolStripStatusLabel2.ForeColor = Color.Green;
                        ((Form1)(this.Tag)).toolStripStatusLabel2.Text = "今月の学生評価が正常に追加されました.";
                        //((Form1)(this.Tag)).reLoad = false;
                    }
                }
                else
                {
                    ((Form1)(this.Tag)).toolStripStatusLabel2.ForeColor = Color.Red;
                    ((Form1)(this.Tag)).toolStripStatusLabel2.Text = "本月の評価はすでに登録しました";
                }
            }
            catch(Exception ee)
            {
                ((Form1)(this.Tag)).toolStripStatusLabel2.ForeColor = Color.Red;
                ((Form1)(this.Tag)).toolStripStatusLabel2.Text = ee.ToString();
            }
            finally
            {
                if (sqlcon != null)
                {
                    sqlcon.Close();
                }
            }

        }

        private void 学生評価追加_Load(object sender, EventArgs e)
        {
            GetClass();
            if (flag_学生情報)
            {
                cmb_学生名.SelectedValue = code_学生コード;
                cmb_学生名.Enabled = false;
            }
        }


        /// <summary>
        /// クラス情報を取得する
        /// </summary>
        public void GetClass()
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

            if (flag_学生情報)
            {
                try
                {
                    //データ取得開始

                    string str_sqlcmd = "SELECT"
                    + "　　t2.学生コード "
                    + "　, t2.名前  "
                    + "　, t3.クラスコード  "
                    + "　, t3.クラス名  "
                    + " FROM "
                    + " HL_JUKUKANRI_学生クラス t1 "
                    + " LEFT OUTER JOIN HL_JUKUKANRI_学生マスタ t2 on  t1.学生コード=t2.学生コード "
                    + " LEFT OUTER JOIN HL_JUKUKANRI_クラス履歴 t3 on  t1.クラスコード=t3.クラスコード "
                    + " WHERE t1.学生コード='" + code_学生コード + "' "
                    + " AND t1.クラスコード='" + code_クラス + "'"
                    ;

                    SqlDataAdapter sqlDa = new SqlDataAdapter(str_sqlcmd, sqlcon);
                    dtInfo = new DataTable();
                    sqlDa.Fill(dtInfo);

                    //該当項目に値を設定する
                    cmb_クラス.DataSource = dtInfo;
                    cmb_学生名.DataSource = dtInfo;
                    cmb_クラス.DisplayMember = "クラス名";
                    cmb_クラス.ValueMember = "クラスコード";
                    cmb_学生名.DisplayMember = "名前";
                    cmb_学生名.ValueMember = "学生コード";
                    cmb_クラス.SelectedValue = code_クラス;
                    cmb_学生名.SelectedValue = code_学生コード;
                    cmb_学生名.Enabled = false;
                }
                catch (Exception ee)
                {
                    this.toolStripStatusLabel1.ForeColor = Color.Red;
                    this.toolStripStatusLabel1.Text = ee.ToString();
                    return;
                }
                finally
                {
                    if (sqlcon != null)
                    {
                        sqlcon.Close();
                    }
                }
            }
            else if (flag_クラス情報)
            {
                try
                {
                    //データ取得開始

                    string str_sqlcmd = "SELECT"
                    + "　　t2.学生コード "
                    + "　, t2.名前  "
                    + "　, t3.クラスコード  "
                    + "　, t3.クラス名  "
                    + " FROM "
                    + " HL_JUKUKANRI_学生クラス t1 "
                    + " LEFT OUTER JOIN HL_JUKUKANRI_学生マスタ t2 on  t1.学生コード=t2.学生コード "
                    + " LEFT OUTER JOIN HL_JUKUKANRI_クラス履歴 t3 on  t1.クラスコード=t3.クラスコード "
                    + " WHERE  t1.クラスコード='" + code_クラス + "'";

                    SqlDataAdapter sqlDa = new SqlDataAdapter(str_sqlcmd, sqlcon);
                    dtInfo = new DataTable();
                    sqlDa.Fill(dtInfo);

                    //該当項目に値を設定する
                    cmb_クラス.DataSource = dtInfo;
                    cmb_学生名.DataSource = dtInfo;
                    cmb_クラス.DisplayMember = "クラス名";
                    cmb_クラス.ValueMember = "クラスコード";
                    cmb_学生名.DisplayMember = "名前";
                    cmb_学生名.ValueMember = "学生コード";
                    cmb_クラス.SelectedValue = code_クラス;
                }
                catch (Exception ee)
                {
                    this.toolStripStatusLabel1.ForeColor = Color.Red;
                    this.toolStripStatusLabel1.Text = ee.ToString();
                    return;
                }
                finally
                {
                    if (sqlcon != null)
                    {
                        sqlcon.Close();
                    }
                }
            }
        }
    }
}
