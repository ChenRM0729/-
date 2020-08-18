using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace HL_塾管理
{
    public partial class 学生評価 : DockContent
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

        public RowMergeView gv_studentsInfo;

        //セル編集フラグ
        private bool isEditing = false;
        //編集前のセル値
        private string beforValue = "";

        public 学生評価()
        {
            InitializeComponent();
        }

        private void 学生評価_Load(object sender, EventArgs e)
        {
            cmb_クラス.SelectedValue = code_クラス;

            GetClass();
            Set_Info();
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

            try
            {
                //データ取得開始

                string str_sqlcmd = "SELECT"
                + "　　クラスコード "
                + "　, クラス名  "
                + " FROM "
                + " HL_JUKUKANRI_クラス履歴 ";

                SqlDataAdapter sqlDa = new SqlDataAdapter(str_sqlcmd, sqlcon);
                dtInfo = new DataTable();
                sqlDa.Fill(dtInfo);

                //該当項目に値を設定する
                cmb_クラス.DataSource = dtInfo;
                cmb_クラス.DisplayMember = "クラス名";
                cmb_クラス.ValueMember = "クラスコード";
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
        /// <summary>
        /// 初期表示
        /// </summary>
        public void Set_Info()
        {
            dgv_studentgrade.Rows.Clear();
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
                string dgv_sqlcmd = string.Empty;
                if (flag_学生情報)
                {
                    //データ取得開始
                    dgv_sqlcmd = "SELECT"
                    + "　　T1.学生コード "
                    + "　, T2.名前　AS 学生名"
                    + "　, ( select count(*) from HL_JINJI_出勤機_登録ユーザマスタ s1　"
                    + "　  left outer join HL_JINJI_出勤機元記録 s2 on s1.登録コード = s2.登録コード　"
                    + "　　where 学生コード = T1.学生コード and s2.出退勤フラグ = 1 and Format(出退勤時間, 'yyyy年MM月')= T1.評価年月 ) as　出勤数"
                    + "　, T1.クラスコード "
                    + "  , ( select count(*) from HL_JUKUKANRI_学生進捗 where 学生コード = T1.学生コード and 完成フラグ = 1 and Format(開始日, 'yyyy年MM月')= T1.評価年月　) as 課題完成数"
                    + "　, ( select count(*) from HL_JUKUKANRI_学生進捗 where 学生コード = T1.学生コード and Format(開始日, 'yyyy年MM月')= T1.評価年月　) as 課題数 "
                    + "　, T1.総合評価 "
                    + "　, T1.授業態度 "
                    + "　, T1.評価年月 "
                    + " FROM "
                    + " HL_JUKUKANRI_学生評価 T1 "
                    + " LEFT JOIN HL_JUKUKANRI_学生マスタ T2 ON T1.学生コード=T2.学生コード "
                    + " WHERE T1.学生コード = '" + code_学生コード + "'";

                    //SqlDataAdapter dgv_sqlDa = new SqlDataAdapter(dgv_sqlcmd, sqlcon);
                    //dtInfo = new DataTable();
                    //dgv_sqlDa.Fill(dtInfo);
                }
                else if (flag_クラス情報)
                {
                    //データ取得開始
                    dgv_sqlcmd = "SELECT"
                    + "　　T1.学生コード "
                    + "　, T2.名前　AS 学生名 "
                    + "　, ( select count(*) from HL_JINJI_出勤機_登録ユーザマスタ s1　"
                    + "　  left outer join HL_JINJI_出勤機元記録 s2 on s1.登録コード = s2.登録コード　"
                    + "　　where T1.学生コード = 32 and s2.出退勤フラグ = 1 and Format(出退勤時間, 'yyyy年MM月')= T1.評価年月 ) as　出勤数"
                    + "　, T1.クラスコード "
                    + "  , ( select count(*) from HL_JUKUKANRI_学生進捗 where 学生コード = T1.学生コード  and 完成フラグ = 1 and Format(開始日, 'yyyy年MM月')= T1.評価年月　) as 課題完成数"
                    + "　, ( select count(*) from HL_JUKUKANRI_学生進捗 where 学生コード = T1.学生コード  and Format(開始日, 'yyyy年MM月')= T1.評価年月　) as 課題数 "
                    + "　, T1.総合評価 "
                    + "　, T1.授業態度 "
                    + "　, T1.評価年月 "
                    + " FROM "
                    + " HL_JUKUKANRI_学生評価 T1 "
                    + " LEFT JOIN HL_JUKUKANRI_学生マスタ T2　ON T1.学生コード=T2.学生コード"
                    + " WHERE クラスコード = '" + cmb_クラス.SelectedValue + "'";
                    //SqlDataAdapter dgv_sqlDa = new SqlDataAdapter(dgv_sqlcmd, sqlcon);
                    //dtInfo = new DataTable();
                    //dgv_sqlDa.Fill(dtInfo);
                }
                dgv_sqlcmd += " ORDER BY T1.学生コード + 0 ASC";
                SqlCommand com = new SqlCommand(dgv_sqlcmd, sqlcon);
                SqlDataReader reader = com.ExecuteReader();
                
                int index = 0;

                while (reader.Read())
                {
                    if ((reader["学生コード"].ToString().IndexOf(this.txt_searchKey.Text) < 0)
                     &&
                     (reader["学生名"].ToString().IndexOf(this.txt_searchKey.Text) < 0)
                     &&
                     (reader["出勤数"].ToString().IndexOf(this.txt_searchKey.Text) < 0)
                     &&
                    (reader["課題完成数"].ToString().IndexOf(this.txt_searchKey.Text) < 0)
                     &&
                    (reader["課題数"].ToString().Replace('/', '-').IndexOf(this.txt_searchKey.Text) < 0)
                     &&
                    (reader["総合評価"].ToString().IndexOf(this.txt_searchKey.Text) < 0)
                     &&
                    (reader["授業態度"].ToString().IndexOf(this.txt_searchKey.Text) < 0)
                     &&
                    (reader["評価年月"].ToString().IndexOf(this.txt_searchKey.Text) < 0))
                    {
                        continue;
                    }
                    this.dgv_studentgrade.Rows.Add();
                    this.dgv_studentgrade.Rows[index].Cells["学生コード"].Value = reader["学生コード"].ToString();
                    this.dgv_studentgrade.Rows[index].Cells["学生名"].Value = reader["学生名"].ToString();
                    this.dgv_studentgrade.Rows[index].Cells["出勤数"].Value = reader["出勤数"].ToString() + "日";
                    this.dgv_studentgrade.Rows[index].Cells["クラスコード"].Value = reader["クラスコード"].ToString();
                    this.dgv_studentgrade.Rows[index].Cells["課題完成度"].Value = reader["課題完成数"].ToString() + "/" + reader["課題数"].ToString();
                    this.dgv_studentgrade.Rows[index].Cells["総合評価"].Value = reader["総合評価"].ToString();
                    this.dgv_studentgrade.Rows[index].Cells["授業態度"].Value = reader["授業態度"].ToString();
                    this.dgv_studentgrade.Rows[index].Cells["評価年月"].Value = reader["評価年月"].ToString();
                    index++;
                }
      
                //件数表示
                this.toolStripStatusLabel1.Text = string.Format("{0}件", dtInfo.Rows.Count);
                ((Form1)(this.Tag)).reLoad = true;
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

        private void btn_今月評価追加_Click(object sender, EventArgs e)
        {

            学生評価追加 m_NewForm_学生評価追加 = new 学生評価追加();
            m_NewForm_学生評価追加.code_学生コード = code_学生コード;
            m_NewForm_学生評価追加.code_クラス = code_クラス;
            m_NewForm_学生評価追加.flag_学生情報 = flag_学生情報;
            m_NewForm_学生評価追加.flag_クラス情報 = flag_クラス情報;
            m_NewForm_学生評価追加.Tag = ((Form1)(this.Tag));
            m_NewForm_学生評価追加.Show(((Form1)(this.Tag)).dockPanel1);
            ((Form1)(this.Tag)).m_学生評価追加Handle = m_NewForm_学生評価追加.Handle;

            int ptr = (int)((Form1)(this.Tag)).m_学生評価追加Handle;
            if (!((Form1)(this.Tag)).codeDic.ContainsKey(code_学生コード))
            {
                ((Form1)(this.Tag)).codeDic.Add(code_学生コード, ptr);
            }

            Set_Info();
        }

        private void dtp_date_ValueChanged(object sender, EventArgs e)
        {
            Set_Info();
        }

        private void dgv_studentgrade_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (isEditing && dgv_studentgrade.CurrentCell.EditedFormattedValue.ToString() != beforValue)
            {
                DataGridViewRow updateRow = this.dgv_studentgrade.CurrentRow;
                if (updateRow != null)
                {
                    string code_学生 = "";
                    string columnName = "";
                    object[] cellValue = null;

                    code_学生 = updateRow.Cells[0].Value.ToString();
                    columnName = dgv_studentgrade.Columns[dgv_studentgrade.CurrentCell.ColumnIndex].Name;
                    cellValue = new object[] { dgv_studentgrade.CurrentCell.EditedFormattedValue.ToString() };

                    //更新を行う
                    Update_GridViewRow(code_学生, dgv_studentgrade.Columns[dgv_studentgrade.CurrentCell.ColumnIndex].Name, cellValue);
                    //画面再表示
                    Set_Info();
                }
            }
        }

        /// <summary>
        ///更新処理
        /// </summary>
        private bool Update_GridViewRow(string code_学生, string columnName, object[] cellValue)
        {
            bool isUpdate = false;
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

                return isUpdate;
            }

            SqlCommand sqlcom = new SqlCommand();
            sqlcom.Connection = sqlcon;

            //データチェック
            string cell_value = cellValue[0].ToString();
            cell_value = cell_value == "-" ? null : cell_value;


            try
            {
                string sql_update = @"Update HL_JUKUKANRI_学生評価 "
                  + " Set {0} = '{1}' "
                  + " Where 学生コード = '{2}' ";

                sqlcom.CommandText = string.Format(sql_update, columnName, cell_value, code_学生);

                result = sqlcom.ExecuteNonQuery();

                if (result == 1)
                {
                    ((Form1)(this.Tag)).toolStripStatusLabel2.ForeColor = Color.Green;
                    ((Form1)(this.Tag)).toolStripStatusLabel2.Text = string.Format("学生評価[{0}]の情報が正常に更新しました.", code_学生);
                    isUpdate = true;
                }
                else
                {
                    ((Form1)(this.Tag)).toolStripStatusLabel2.ForeColor = Color.Red;
                    ((Form1)(this.Tag)).toolStripStatusLabel2.Text = string.Format("学生評価[{0}]の更新処理が失敗しました.", code_学生);
                    ((Form1)(this.Tag)).reLoad = false;
                }
            }
            catch (Exception ee)
            {
                ((Form1)(this.Tag)).toolStripStatusLabel2.ForeColor = Color.Red;
                ((Form1)(this.Tag)).toolStripStatusLabel2.Text = string.Format("学生評価[{0}]の更新処理が失敗しました.", code_学生);
                ((Form1)(this.Tag)).toolStripStatusLabel2.Text = string.Format(ee.ToString(), code_学生);
            }
            finally
            {
                if (sqlcon != null)
                {
                    sqlcon.Close();
                }
            }
            ((Form1)(this.Tag)).reLoad = false;
            return isUpdate;
        }
        /// <summary>
        /// セル編集開始
        /// </summary>
        private void dgv_studentgrade_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            beforValue = dgv_studentgrade.CurrentCell.Value.ToString();
            isEditing = true;
        }

        /// <summary>
        /// セル編集終了
        /// </summary>
        private void dgv_studentgrade_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            isEditing = false;
        }

        private void 学生評価_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form1)(this.Tag)).m_学生評価Handle = IntPtr.Zero;
            if (((Form1)(this.Tag)).codeDic.ContainsKey(code_学生コード))
            {
                ((Form1)(this.Tag)).codeDic.Remove(code_学生コード);
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Set_Info();
        }


        private void dgv_studentgrade_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if ((this.dgv_studentgrade.Rows[e.RowIndex].Selected == false))
                    {
                        this.dgv_studentgrade.ClearSelection();
                        this.dgv_studentgrade.Rows[e.RowIndex].Selected = true;
                    }
                    //'只选中一行时设置活动单元格
                    if ((this.dgv_studentgrade.SelectedRows.Count == 1))
                    {
                        this.dgv_studentgrade.CurrentCell = this.dgv_studentgrade.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                    if (e.ColumnIndex==2)
                    {
                        contextMenuStrip1.Show();
                    }

                }
            }
        }

        private void 課題履歴contextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Drawing.Point startPosition = Cursor.Position;

            System.Drawing.Point point = dgv_studentgrade.PointToClient(startPosition);
            DataGridView.HitTestInfo hitinfo;
            hitinfo = dgv_studentgrade.HitTest(point.X, point.Y);

            dgv_studentgrade.ClearSelection();
            if (hitinfo.RowIndex >= 0)
            {
                dgv_studentgrade.Rows[hitinfo.RowIndex].Selected = true;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
