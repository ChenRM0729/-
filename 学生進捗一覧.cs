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
    public partial class 学生進捗一覧 : DockContent
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int BringWindowToTop(IntPtr hWnd);
        private AutoSizeFormClass asc = new AutoSizeFormClass();

        //データベース接続情報
        private string connectionString = ComClass.connectionString;

        //セル編集フラグ
        private bool isEditing = false;
        //判断用フラグ
        public string isFlag = "";
        //学生コード
        public string studentcode = "";
        //教師コード
        private string login_教師コード = "";
        //クラスコード
        public string classcode = "";

        public 学生進捗一覧()
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
        private void 学生進捗一覧_Load(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);

            login_教師コード = ((Form1)(this.Tag)).m_ユーザ登録.m_ログイン_教師コード;

            //datagridview表示
            DisplayGridView();
        }

        /// <summary>
        /// datagridviewデータ取得
        /// </summary>
        private void DisplayGridView()
        {
            gv_studentsInfo.ScrollBars = ScrollBars.None;
            gv_studentsInfo.Rows.Clear();
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
                ((Form1)(this.Tag)).toolStripStatusLabel2.Text = "DBサーバーの接続に失敗しました.";
                ((Form1)(this.Tag)).reLoad = false;
                //this.toolStripStatusLabel2.Text = "";
                //this.toolStripStatusLabel2.ForeColor = Color.Red;            
                //this.toolStripStatusLabel2.Text = "DBサーバーの接続に失敗しました.";               
                return;
            }

            string str_sqlcmd = @"select a.学生コード,c.名前,e.クラス名,d.課題名,d.課題コード,a.課題完成度,a.開始日,a.終了日,d.予定完成時間 " +
                                "from HL_JUKUKANRI_学生進捗 AS a " +
                                "left join HL_JUKUKANRI_学生クラス AS b " +
                                "on a.学生コード = b.学生コード " +
                                "left join HL_JUKUKANRI_学生マスタ AS c " +
                                "on a.学生コード = c.学生コード " +
                                "left join HL_JUKUKANRI_課題マスタ AS d " +
                                "on a.課題コード = d.課題コード " +
                                "left join HL_JUKUKANRI_クラス履歴 AS e " +
                                "on e.学生コード like '%'+a.学生コード+'%' ";
            if (isFlag == "クラス")
            {
                str_sqlcmd += "where b.クラスコード = " + classcode + " ";
            }
            if (isFlag == "教師")
            {
                str_sqlcmd += "where e.教師コード = '" + login_教師コード + "' ";
            }
            if (isFlag == "学生")
            {
                str_sqlcmd += "where a.学生コード = '" + studentcode + "' ";
            }
            str_sqlcmd += "and a.完成フラグ = 'false' order by a.学生コード + 0 ASC";

            SqlCommand com = new SqlCommand(str_sqlcmd, sqlcon);
            SqlDataReader reader = com.ExecuteReader();
            int index = 0;
            try
            {
                while (reader.Read())
                {
                    if (
                       (reader["学生コード"].ToString().IndexOf(this.txt_search.Text) < 0)
                       &&
                       (reader["名前"].ToString().IndexOf(this.txt_search.Text) < 0)
                       &&
                       (reader["クラスコード"].ToString().IndexOf(this.txt_search.Text) < 0)
                       &&
                       (reader["宿題名"].ToString().IndexOf(this.txt_search.Text) < 0)
                       &&
                       (reader["宿題完成度"].ToString().IndexOf(this.txt_search.Text) < 0)
                       &&
                       (reader["開始日"].ToString().Replace('/', '-').IndexOf(this.txt_search.Text) < 0)
                       &&
                       (reader["予定完成時間"].ToString().IndexOf(this.txt_search.Text) < 0)
                       )
                    {
                        continue;
                    }

                    //データ値表示
                    this.gv_studentsInfo.Rows.Add();
                    this.gv_studentsInfo.Rows[index].Cells["学生番号"].Value = reader["学生コード"].ToString();
                    this.gv_studentsInfo.Rows[index].Cells["学生名前"].Value = reader["名前"].ToString();
                    this.gv_studentsInfo.Rows[index].Cells["クラス"].Value = reader["クラス名"].ToString();
                    this.gv_studentsInfo.Rows[index].Cells["宿題名"].Value = reader["宿題名"].ToString();
                    this.gv_studentsInfo.Rows[index].Cells["宿題コード"].Value = reader["宿題コード"].ToString();
                    this.gv_studentsInfo.Rows[index].Cells["完成度"].Value = reader["宿題完成度"].ToString();
                    this.gv_studentsInfo.Rows[index].Cells["開始日"].Value = string.IsNullOrWhiteSpace(reader["開始日"].ToString()) ? "" : ((DateTime)reader["開始日"]).ToString("yyyy-MM-dd");
                    this.gv_studentsInfo.Rows[index].Cells["終了日"].Value = string.IsNullOrWhiteSpace(reader["終了日"].ToString()) ? "" : ((DateTime)reader["終了日"]).ToString("yyyy-MM-dd");
                    this.gv_studentsInfo.Rows[index].Cells["予定完成時間"].Value = reader["予定完成時間"].ToString();
                    index++;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                ((Form1)(this.Tag)).toolStripStatusLabel2.ForeColor = Color.Red;
                ((Form1)(this.Tag)).toolStripStatusLabel2.Text = "検索処理に失敗しました." + ex.Message;
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

        /// <summary>
        ///  右クリックで一行を選択
        /// </summary>
        private void gv_studentsInfo_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if ((this.gv_studentsInfo.Rows[e.RowIndex].Selected == false))
                    {
                        this.gv_studentsInfo.ClearSelection();
                        this.gv_studentsInfo.Rows[e.RowIndex].Selected = true;
                    }
                    //'只选中一行时设置活动单元格
                    if ((this.gv_studentsInfo.SelectedRows.Count == 1))
                    {
                        this.gv_studentsInfo.CurrentCell = this.gv_studentsInfo.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                    contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
                }

            }
        }

        /// <summary>
        /// 右クリックメニューを開く
        /// </summary>
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            System.Drawing.Point startPosition = Cursor.Position;

            System.Drawing.Point point = this.gv_studentsInfo.PointToClient(startPosition);
            DataGridView.HitTestInfo hitinfo;
            hitinfo = this.gv_studentsInfo.HitTest(point.X, point.Y);

            this.gv_studentsInfo.ClearSelection();
            if (hitinfo.RowIndex >= 0)
            {
                this.gv_studentsInfo.Rows[hitinfo.RowIndex].Selected = true;
            }
            else
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// セル編集開始
        /// </summary>
        private void gv_studentsInfo_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            isEditing = true;
        }

        /// <summary>
        /// セル編集終了
        /// </summary>
        private void gv_studentsInfo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            isEditing = false;
        }

        /// <summary>
        /// 画面値変更、更新処理
        /// </summary>
        private void gv_studentsInfo_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (isEditing && this.gv_studentsInfo.CurrentCell != null)
            {
                this.gv_studentsInfo.CurrentCell.Selected = true;
                DateTime? 終了日;
                終了日 = null;
                //画面値取得
                string 学生コード = this.gv_studentsInfo.CurrentRow.Cells["学生番号"].Value.ToString();
                string クラスコード = this.gv_studentsInfo.CurrentRow.Cells["クラス"].Value.ToString(); ;
                string 宿題名 = this.gv_studentsInfo.CurrentRow.Cells["宿題名"].Value.ToString();
                string 宿題コード = this.gv_studentsInfo.CurrentRow.Cells["宿題コード"].Value.ToString();
                string 宿題完成度 = this.gv_studentsInfo.CurrentRow.Cells["完成度"].Value.ToString();
                string 開始日 = this.gv_studentsInfo.CurrentRow.Cells["開始日"].Value.ToString().Replace('-', '/');
                string 完成フラグ = "0";
                int a = 0;
                if (int.TryParse(宿題完成度, out a) == true && 0 <= Convert.ToInt32(宿題完成度) && Convert.ToInt32(宿題完成度) <= 100) 
                {
                    if (Convert.ToInt32(宿題完成度) == 100)
                    {
                        終了日 = DateTime.Now.Date;
                        完成フラグ = "1";
                    }
                }
                else
                {
                    ((Form1)(this.Tag)).toolStripStatusLabel2.ForeColor = Color.Red;
                    ((Form1)(this.Tag)).toolStripStatusLabel2.Text = "正しい完成度を入力してください。";
                    ((Form1)(this.Tag)).reLoad = false;
                    //this.toolStripStatusLabel2.Text = "";
                    //this.toolStripStatusLabel2.ForeColor = Color.Red;
                    //this.toolStripStatusLabel2.Text = "正しい完成度を入力してください。";
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
                    ((Form1)(this.Tag)).toolStripStatusLabel2.Text = "DBサーバーの接続に失敗しました.";
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
                    string sql_update = @"Update HL_JUKUKANRI_学生進捗 Set " +
                                        "宿題完成度 = '{0}'," +
                                        "終了日 = '{1}'," +
                                        "完成フラグ = '{2}' " +
                                        "Where  学生コード = '{3}' and 開始日 = '{4}' " +
                                        "and 宿題コード = '{5}'";


                    sqlcom.CommandText = string.Format(sql_update, 宿題完成度, 終了日, 完成フラグ, 学生コード, 開始日, 宿題コード);

                    result = sqlcom.ExecuteNonQuery();

                    if (result == 1)
                    {
                        ((Form1)(this.Tag)).toolStripStatusLabel2.ForeColor = Color.Red;
                        ((Form1)(this.Tag)).toolStripStatusLabel2.Text = "進捗記録が正常に更新されました。";
                        ((Form1)(this.Tag)).reLoad = false;
                        //this.toolStripStatusLabel2.Text = "";
                        //this.toolStripStatusLabel2.ForeColor = Color.Red;
                        //this.toolStripStatusLabel2.Text = "進捗記録が正常に更新されました.";
                        sqlcon.Close();
                    }
                }
                catch (Exception ex)
                {
                    ((Form1)(this.Tag)).toolStripStatusLabel2.ForeColor = Color.Red;
                    ((Form1)(this.Tag)).toolStripStatusLabel2.Text = "進捗記録の更新処理が失敗しました.";
                    ((Form1)(this.Tag)).reLoad = false;
                    //this.toolStripStatusLabel2.Text = "";
                    //this.toolStripStatusLabel2.ForeColor = Color.Red;
                    //this.toolStripStatusLabel2.Text = "進捗記録の更新処理が失敗しました.";
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

        //検索ボタン押下
        private void btn_search_Click(object sender, EventArgs e)
        {
            //datagridview再表示
            DisplayGridView();
        }

        /// <summary>
        /// 宿題分配
        /// </summary>
        private void 宿題分配ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((Form1)(this.Tag)).m_宿題分配Handle != IntPtr.Zero)
            {
                BringWindowToTop(((Form1)(this.Tag)).m_宿題分配Handle);
                return;
            }
            //宿題分配画面呼び出す
            宿題分配 m_NewForm_宿題分配 = new 宿題分配();
            m_NewForm_宿題分配.OpenedBy = "";
            m_NewForm_宿題分配.学生名 = this.gv_studentsInfo.CurrentRow.Cells["学生名前"].Value.ToString();
            m_NewForm_宿題分配.Tag = ((Form1)(Tag));
            m_NewForm_宿題分配.Show(((Form1)(Tag)).dockPanel1);
            ((Form1)(Tag)).m_宿題一覧Handle = m_NewForm_宿題分配.Handle;
            toolStripStatusLabel2.Text = "";
        }

        /// <summary>
        /// 宿題履歴
        /// </summary>
        private void 宿題履歴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((Form1)(this.Tag)).m_宿題履歴Handle != IntPtr.Zero)
            {
                BringWindowToTop(((Form1)(this.Tag)).m_宿題履歴Handle);
                return;
            }

            宿題履歴 m_NewForm_宿題履歴 = new 宿題履歴();
            m_NewForm_宿題履歴.Tag = ((Form1)(this.Tag));
            m_NewForm_宿題履歴.StudentCode = this.gv_studentsInfo.CurrentRow.Cells["学生番号"].Value.ToString();
            m_NewForm_宿題履歴.StudentName = this.gv_studentsInfo.CurrentRow.Cells["学生名前"].Value.ToString();
            m_NewForm_宿題履歴.Show(((Form1)(this.Tag)).dockPanel1);
            ((Form1)(this.Tag)).m_宿題履歴Handle = m_NewForm_宿題履歴.Handle;
            toolStripStatusLabel2.Text = "";
        }

        /// <summary>
        /// データがおかしい時
        /// </summary>
        private void gv_studentsInfo_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            ((Form1)(this.Tag)).toolStripStatusLabel2.ForeColor = Color.Red;
            ((Form1)(this.Tag)).toolStripStatusLabel2.Text = "データの取得処理が失敗しました、データベースをチェックしてください。";
            ((Form1)(this.Tag)).reLoad = false;
        }

        /// <summary>
        /// 画面閉じ
        /// </summary>
        private void 学生進捗一覧_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form1)(this.Tag)).m_学生進捗一覧Handle = IntPtr.Zero;
        }

        private void btn_クラス宿題分配_Click(object sender, EventArgs e)
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
            ((Form1)(Tag)).m_宿題分配Handle = m_NewForm_宿題分配.Handle;
            toolStripStatusLabel2.Text = "";
        }

        private void btn_宿題一覧_Click(object sender, EventArgs e)
        {
            if (((Form1)(this.Tag)).m_宿題一覧Handle != IntPtr.Zero)
            {
                BringWindowToTop(((Form1)(this.Tag)).m_宿題一覧Handle);
                return;
            }
            //宿題一覧画面呼び出す
            宿題一覧 m_NewForm_宿題一覧 = new 宿題一覧();
            m_NewForm_宿題一覧.Tag = ((Form1)(Tag));
            m_NewForm_宿題一覧.Show(((Form1)(Tag)).dockPanel1);
            ((Form1)(Tag)).m_宿題一覧Handle = m_NewForm_宿題一覧.Handle;
        }
    }
}
