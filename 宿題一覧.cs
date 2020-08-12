using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace HL_塾管理
{
    public partial class 宿題一覧 : DockContent
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int BringWindowToTop(IntPtr hWnd);
        private AutoSizeFormClass asc = new AutoSizeFormClass();

        //データベース接続情報
        private string connectionString = ComClass.connectionString;


        //セル編集フラグ
        private bool isEditing = false;

        public 宿題一覧()
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

        /// <summary>
        /// 画面表示
        /// </summary>
        private void 宿題一覧_Load(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);

            //datagridview表示
            DisplayGridView();
        }

        /// <summary>
        /// datagridviewデータ取得
        /// </summary>
        private void DisplayGridView()
        {
            gv_homework.ScrollBars = ScrollBars.None;
            gv_homework.Rows.Clear();
            if (((Form1)(this.Tag)).reLoad)
            {
                ((Form1)(this.Tag)).toolStripStatusLabel2.Text = "";
            }
            //连接数据库
            SqlConnection sqlcon = new SqlConnection(connectionString);
            try
            {
                sqlcon.Open();
            }
            catch (Exception ex)
            {
                ((Form1)(this.Tag)).toolStripStatusLabel2.ForeColor = Color.Red;
                ((Form1)(this.Tag)).toolStripStatusLabel2.Text = "DBサーバーの接続に失敗しました。";
                ((Form1)(this.Tag)).reLoad = false;
                //this.toolStripStatusLabel2.Text = "";
                //this.toolStripStatusLabel2.ForeColor = Color.Red;
                //this.toolStripStatusLabel2.Text = "DBサーバーの接続に失敗しました.";
                return;
            }

            string str_sqlcmd = @"select 宿題コード,宿題名,言語,宿題内容,予定完成時間 " +
                                 "from HL_JUKUKANRI_宿題マスタ ";

            SqlCommand com = new SqlCommand(str_sqlcmd, sqlcon);
            SqlDataReader reader = com.ExecuteReader();
            int index = 0;
            try
            {
                while (reader.Read())
                {
                    if (
                       (reader["宿題コード"].ToString().IndexOf(this.txt_search.Text) < 0)
                       &&
                       (reader["宿題名"].ToString().IndexOf(this.txt_search.Text) < 0)
                       &&
                       (reader["言語"].ToString().IndexOf(this.txt_search.Text) < 0)
                       &&
                       (reader["宿題内容"].ToString().IndexOf(this.txt_search.Text) < 0)
                       &&
                       (reader["予定完成時間"].ToString().IndexOf(this.txt_search.Text) < 0)
                       )
                    {
                        continue;
                    }

                    //データ値表示
                    this.gv_homework.Rows.Add();
                    this.gv_homework.Rows[index].Cells["宿題番号"].Value = reader["宿題コード"].ToString();
                    this.gv_homework.Rows[index].Cells["宿題名"].Value = reader["宿題名"].ToString();
                    this.gv_homework.Rows[index].Cells["言語"].Value = reader["言語"].ToString();
                    this.gv_homework.Rows[index].Cells["宿題内容"].Value = reader["宿題内容"].ToString();
                    this.gv_homework.Rows[index].Cells["予定完成時間"].Value = reader["予定完成時間"].ToString();
                    index++;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                ((Form1)(this.Tag)).toolStripStatusLabel2.ForeColor = Color.Red;
                ((Form1)(this.Tag)).toolStripStatusLabel2.Text = "検索処理に失敗しました。" + ex.Message;
                ((Form1)(this.Tag)).reLoad = false;
                //this.toolStripStatusLabel2.Text = "";
                //this.toolStripStatusLabel2.ForeColor = Color.Red;
                //this.toolStripStatusLabel2.Text = "検索処理に失敗しました." + ex.Message;

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
            //件数表示
            this.toolStripStatusLabel1.Text = string.Format("{0}件", index);
            ((Form1)(this.Tag)).reLoad = true;
        }

        //検索ボタン押下
        private void btn_search_Click(object sender, EventArgs e)
        {
            //datagridview表示
            DisplayGridView();
        }

        /// <summary>
        /// セル編集開始
        /// </summary>
        private void gv_homework_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            isEditing = true;
        }

        /// <summary>
        /// セル編集終了
        /// </summary>
        private void gv_homework_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            isEditing = false;
        }

        /// <summary>
        /// 画面値変更、更新処理
        /// </summary>
        private void gv_homework_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (isEditing && this.gv_homework.CurrentCell != null)
            {
                this.gv_homework.CurrentCell.Selected = true;
                
                //画面値取得
                string 宿題コード = this.gv_homework.CurrentRow.Cells["宿題番号"].Value.ToString();
                string 宿題名 = this.gv_homework.CurrentRow.Cells["宿題名"].Value.ToString();
                string 宿題内容 = this.gv_homework.CurrentRow.Cells["宿題内容"].Value.ToString();

                if (宿題内容.Length > 200)
                {
                    ((Form1)(this.Tag)).toolStripStatusLabel2.ForeColor = Color.Red;
                    ((Form1)(this.Tag)).toolStripStatusLabel2.Text = "課題内容の長さを200以内にしてください。";
                    ((Form1)(this.Tag)).reLoad = false;
                    //this.toolStripStatusLabel2.Text = "";
                    //this.toolStripStatusLabel2.ForeColor = Color.Red;
                    //this.toolStripStatusLabel2.Text = "宿題内容の長さを200以内にしてください。";
                    //datagridview再表示
                    DisplayGridView();
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
                    ((Form1)(this.Tag)).toolStripStatusLabel2.ForeColor = Color.Red;
                    ((Form1)(this.Tag)).toolStripStatusLabel2.Text = "DBサーバーの接続に失敗しました。";
                    ((Form1)(this.Tag)).reLoad = false;
                    //this.toolStripStatusLabel2.Text = "";
                    //this.toolStripStatusLabel2.ForeColor = Color.Red;
                    //this.toolStripStatusLabel2.Text = "DBサーバーの接続に失敗しました.";
                    return;
                }
                SqlCommand sqlcom = new SqlCommand();
                sqlcom.Connection = sqlcon;

                try
                {
                    //更新行う
                    string sql_update = @"Update HL_JUKUKANRI_宿題マスタ Set " +
                                        "宿題内容 = '{0}' " +
                                        "Where  宿題コード = '{1}' and 宿題名 = '{2}' ";

                    sqlcom.CommandText = string.Format(sql_update, 宿題内容,宿題コード,宿題名);

                    result = sqlcom.ExecuteNonQuery();

                    if (result == 1)
                    {
                        ((Form1)(this.Tag)).toolStripStatusLabel2.ForeColor = Color.Red;
                        ((Form1)(this.Tag)).toolStripStatusLabel2.Text = "課題内容が正常に更新されました。";
                        ((Form1)(this.Tag)).reLoad = false;
                        //this.toolStripStatusLabel2.Text = "";
                        //this.toolStripStatusLabel2.ForeColor = Color.Red;
                        //this.toolStripStatusLabel2.Text = "宿題記録が正常に更新されました.";
                        sqlcon.Close();
                    }
                }
                catch (Exception ex)
                {
                    ((Form1)(this.Tag)).toolStripStatusLabel2.ForeColor = Color.Red;
                    ((Form1)(this.Tag)).toolStripStatusLabel2.Text = "課題内容の更新処理が失敗しました." + ex.Message;
                    ((Form1)(this.Tag)).reLoad = false;
                    //this.toolStripStatusLabel2.Text = "";
                    //this.toolStripStatusLabel2.ForeColor = Color.Red;
                    //this.toolStripStatusLabel2.Text = "宿題記録の更新処理が失敗しました."+ex.Message;
                }
                finally
                {
                    if (sqlcon != null)
                    {
                        sqlcon.Close();
                    }
                }

                //datagridview再表示
                DisplayGridView();
            }
        }

        private void btn_宿題追加_Click(object sender, EventArgs e)
        {
            if (((Form1)(this.Tag)).m_宿題追加Handle != IntPtr.Zero)
            {
                BringWindowToTop(((Form1)(this.Tag)).m_宿題追加Handle);
                return;
            }
            //宿題追加画面呼び出す
            宿題追加 m_NewForm_宿題追加 = new 宿題追加();
            m_NewForm_宿題追加.Tag = ((Form1)(Tag));
            m_NewForm_宿題追加.Show(((Form1)(Tag)).dockPanel1);
            ((Form1)(Tag)).m_宿題一覧Handle = m_NewForm_宿題追加.Handle;
            toolStripStatusLabel2.Text = "";
        }

        private void btn_宿題分配_Click(object sender, EventArgs e)
        {
            if (((Form1)(this.Tag)).m_宿題分配Handle != IntPtr.Zero)
            {
                BringWindowToTop(((Form1)(this.Tag)).m_宿題分配Handle);
                return;
            }
            //宿題分配画面呼び出す
            宿題分配 m_NewForm_宿題分配 = new 宿題分配();
            m_NewForm_宿題分配.Tag = ((Form1)(Tag));
            m_NewForm_宿題分配.Show(((Form1)(Tag)).dockPanel1);
            ((Form1)(Tag)).m_宿題一覧Handle = m_NewForm_宿題分配.Handle;
            toolStripStatusLabel2.Text = "";
        }
        /// <summary>
        /// データがおかしい時
        /// </summary>
        private void gv_homework_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            ((Form1)(this.Tag)).toolStripStatusLabel2.ForeColor = Color.Red;
            ((Form1)(this.Tag)).toolStripStatusLabel2.Text = "データの取得処理が失敗しました、データベースをチェックしてください。";
            ((Form1)(this.Tag)).reLoad = false;
        }

        /// <summary>
        /// 画面閉じ
        /// </summary>
        private void 宿題一覧_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form1)(this.Tag)).m_宿題一覧Handle = IntPtr.Zero;
        }
    }
}
