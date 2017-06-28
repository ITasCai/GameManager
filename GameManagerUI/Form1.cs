using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameManagerBLL;
using System.Data.SqlClient;
using GameManagerModel;

namespace GameManagerUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getGeLx();
            getYx();
            getShow();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 游戏类别绑定
        /// </summary>
        public void getGeLx()
        {
            DataSet ds = new DataSet();
            ds = GameBLL.GetGameLxBLL();
            DataRow row = ds.Tables[0].NewRow();
            row[0] = -1;
            row[1] = "全部";
            ds.Tables[0].Rows.InsertAt(row, 0);
            cmblx.DataSource = ds.Tables[0];
            cmblx.ValueMember = "gid";
            cmblx.DisplayMember = "gname";
        }

        /// 游戏类别绑定
        /// </summary>
        /// </summary>
        public void getYx() {
            DataSet ds = new DataSet();
            ds = GameBLL.GetGameLxBLL();
            DataRow row = ds.Tables[0].NewRow();
            row[0] = -1;
            row[1] = "全部";
            ds.Tables[0].Rows.InsertAt(row, 0);
            cmbyxlx.DataSource = ds.Tables[0];
            cmbyxlx.ValueMember = "gid";
            cmbyxlx.DisplayMember = "gname";
        }


        public void getShow() {

            try
            {
                DataSet ds = new DataSet();

                ds = GameBLL.GetShowLxDAL(Convert.ToInt32(this.cmblx.SelectedValue));
                dgvshow.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
   

        }

        private void btnlxca_Click(object sender, EventArgs e)
        {
            getShow();
        }

        private void btnmc_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = GameBLL.BlurryBLL(txtmc.Text.Trim());
                dgvshow.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnadd_Click(object sender, EventArgs e)
        {

            try
            {
                Gaming ga = new Gaming();

                ga.Pgs = txtgs.Text.Trim();
                ga.Pname = txtname.Text.Trim();
                ga.Pje = Convert.ToInt32(txtqian.Text.Trim());
                ga.Gid = Convert.ToInt32(cmbyxlx.SelectedValue);

                GameBLL.AddBLL(ga);

                getShow();
                MessageBox.Show("添加成功");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvshow_Click(object sender, EventArgs e)
        {
            //取出行的下标
            int index = dgvshow.CurrentCell.RowIndex;
            //取出卡号
            txtpid.Text = dgvshow.Rows[index].Cells[0].Value.ToString();
            //游戏名称
            txtname.Text = dgvshow.Rows[index].Cells[1].Value.ToString();
            //游戏类别
            cmbyxlx.Text = dgvshow.Rows[index].Cells[2].Value.ToString();
            //游戏公司
            txtgs.Text = dgvshow.Rows[index].Cells[3].Value.ToString();
            //充值金额
            txtqian.Text = dgvshow.Rows[index].Cells[4].Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dgvshow.SelectedCells.Count==0)
            {
                return;
            }

            if (DialogResult.Yes== MessageBox.Show("你确定要删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                int pid = Convert.ToInt32(txtpid.Text.Trim());
                if (GameBLL.DeleteBLL(pid)>0)
                {
                    MessageBox.Show("删除成功");
                    getShow();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
        }

        private void btnxg_Click(object sender, EventArgs e)
        {
            try
            {
                Gaming ga = new Gaming();

                ga.Pgs = txtgs.Text.Trim();
                ga.Pname = txtname.Text.Trim();
                ga.Pje = Convert.ToInt32(txtqian.Text.Trim());
                ga.Gid = Convert.ToInt32(cmbyxlx.SelectedValue);
                ga.Pid = Convert.ToInt32(txtpid.Text.Trim());

                GameBLL.AddBLL(ga);

                getShow();
                MessageBox.Show("修改成功");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsx_Click(object sender, EventArgs e)
        {
          
            }
        }
    }
}
