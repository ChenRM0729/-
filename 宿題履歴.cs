using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace HL_塾管理
{
    public partial class 宿題履歴: DockContent
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int BringWindowToTop(IntPtr hWnd);
        private AutoSizeFormClass asc = new AutoSizeFormClass();

        //DB接続情報
        private string connectionString = ComClass.connectionString;


        public string StudentCode = "";
     
        public string StudentName = "";

        public 宿題履歴()
        {
            InitializeComponent();
        }

        /// <summary>
        /// DGV表示
        /// </summary>
        private void DisplayGridView()
        {
            if (((Form1)(Tag)).reLoad)
            {
                ((Form1)(Tag)).toolStripStatusLabel2.Text = "";
            }
            dgv_st.Rows.Clear();

            SqlConnection sqlcon = new SqlConnection(connectionString);

            try
            {
                sqlcon.Open();
            }
            catch
            {
                StatusLabel.ForeColor = Color.Red;
                StatusLabel.Text = "DBサーバーの接続に失敗しました。インターネット接続をチェックしてください！";
                return;
            }

            string sql_cmd =String.Format( @"select a.宿題名,b.クラスコード,a.言語,c.宿題評価,b.開始日,b.終了日 
                               from HL_JUKUKANRI_宿題マスタ  a
                               left join HL_JUKUKANRI_学生進捗  b 
                               on a.宿題コード=b.宿題コード
　                             left join HL_JUKUKANRI_学生評価  c
                               on  b.学生コード=c.学生コード
                               where b.学生コード={0}",lbl_code.Text);
                 
           
            try
            {
                DataTable dt = new DataTable();
                dt = GetDatatable(sql_cmd);
                dgv_st.DataSource = dt;
                lbl_件数.Text = dt.Rows.Count.ToString()+"件";
            }
            catch (Exception ex)
            {
                ((Form1)(this.Tag)).toolStripStatusLabel2.ForeColor = Color.Red;
                ((Form1)(this.Tag)).toolStripStatusLabel2.Text =  ex.Message;
                ((Form1)(Tag)).reLoad = false;
                sqlcon.Close();
                return;

            }
            finally
            {
                sqlcon.Close();
            }

            ((Form1)(Tag)).reLoad = true;
        }

        /// <summary>
        /// 画面開く処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 宿題履歴_Load(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
           lbl_code.Text = StudentCode;
           lbl_name.Text = StudentName;
            DisplayGridView();
        }

        /// <summary>
        /// 画面閉じる処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 宿題履歴_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form1)(this.Tag)).m_宿題履歴Handle = IntPtr.Zero;
        }

        /// <summary>
        /// テーブル取得
        /// </summary>
        /// <param name="str_cmd"></param>
        /// <returns></returns>
        private DataTable GetDatatable(string str_cmd)
        {
            SqlConnection sqlcon = new SqlConnection(connectionString);
            try
            {
                sqlcon.Open();
            }
            catch
            {
                ((Form1)(Tag)).toolStripStatusLabel2.ForeColor = Color.Red;
                ((Form1)(Tag)).toolStripStatusLabel2.Text = "DBサーバーの接続に失敗しました。";
                ((Form1)(Tag)).reLoad = false;
            }

            try
            {
                DataTable table = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(str_cmd, sqlcon);
                DataSet ds = new DataSet();
                da.Fill(ds);
                table = ds.Tables[0];
                return table;

            }
            catch (Exception ex)
            {
                ((Form1)(Tag)).toolStripStatusLabel2.ForeColor = Color.Red;
                ((Form1)(Tag)).toolStripStatusLabel2.Text = ex.ToString();
            }
            finally
            {
                sqlcon.Close();
            }

            return null;
        }
    }
}
