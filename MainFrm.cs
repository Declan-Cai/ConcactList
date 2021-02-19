using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList
{
    public partial class mainFrm : Form
    {
        public mainFrm()
        {
            InitializeComponent();
        }

        

        private void MainFrm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“contactListDataSet4.Contact”中。您可以根据需要移动或删除它。
            this.contactTableAdapter2.Fill(this.contactListDataSet4.Contact);
            // TODO: 这行代码将数据加载到表“contactListDataSet3.Contact”中。您可以根据需要移动或删除它。
            this.contactTableAdapter1.Fill(this.contactListDataSet3.Contact);
            // TODO: 这行代码将数据加载到表“contactListDataSet2.Contact”中。您可以根据需要移动或删除它。
            this.contactTableAdapter.Fill(this.contactListDataSet2.Contact);

        }


        string connString = "Data Source=.;Initial Catalog=ContactList;Integrated Security=True";
        private void BtnShow_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);    //创建Connection对象
            string sql = "select * from Contact";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "MyData");
            dgvList.DataSource = dataSet.Tables[0];
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddContact addContact = new AddContact();
            addContact.Show();
        }

        //查询事件
        private void BtnFind_Click(object sender, EventArgs e)
        {
            string condition = "";
            try
            {
                if (txtMid.Text != "")
                {
                    //姓名
                    condition = condition + " id ='" + txtMid.Text + "%'";
                }
                if (txtMname.Text != "")
                {
                    //姓名
                    condition = condition + " name like'" + txtMname.Text + "%'";
                }
                if (txtMsex.Text != "")
                {
                    //性别
                    condition = condition + " sex ='" + txtMsex.Text + "%'";
                }
                if (txtMbirth.Text != "")
                {
                    //生日
                    condition = condition + " birthdata like'" + txtMbirth.Text + "%'";
                }
                if (txtMphone.Text != "")
                {
                    //电话
                    condition = condition + " phone like'" + txtMphone.Text + "%'";
                }
                if (txtMemail.Text != "")
                {
                    //邮箱
                    condition = condition + " email like'" + txtMemail.Text + "%'";
                }
                if (txtMadd.Text != "")
                {
                    //地址
                    condition = condition + " address like'" + txtMadd.Text + "%'";
                }
            
            string sql1 = "select * from Contact where" + condition;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql1, conn);
            //设置默认列不显示
            //dgvShow.AutoGenerateColumns = false;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dgvShow.DataSource = dataSet.Tables[0]; //绑定
            conn.Close();           //关闭数据库连接

            }
            catch
            {
                MessageBox.Show("数据库操作错误！", "查询失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            //清空文本框
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        //修改事件
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string upId = txtMid.Text;
            if (upId != "")
            {
                string condition = "";
                /*if (txtMname.Text != "")
                {
                    //姓名
                    condition = condition + " ,name like'" + txtMname.Text + "'";
                }*/
                if (txtMsex.Text != "")
                {
                    //性别
                    condition = condition + " ,sex ='" + txtMsex.Text + "'";
                }
                if (txtMbirth.Text != "")
                {
                    //生日
                    condition = condition + ", birthdata ='" + txtMbirth.Text + "'";
                }
                if (txtMphone.Text != "")
                {
                    //电话
                    condition = condition + " ,phone ='" + txtMphone.Text + "'";
                }
                if (txtMemail.Text != "")
                {
                    //邮箱
                    condition = condition + " ,email ='" + txtMemail.Text + "'";
                }
                if (txtMadd.Text != "")
                {
                    //地址
                    condition = condition + " ,address ='" + txtMadd.Text + "'";
                }
                string sql2 = "update Contact set name='" + txtMname.Text + "'" + condition + " where id = '" + txtMid.Text + "'";
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand comm = new SqlCommand(sql2, conn);
                conn.Open();
                int eq = comm.ExecuteNonQuery();
                if (eq != 0)
                {
                    MessageBox.Show("修改成功！");
                }
                else
                {
                    MessageBox.Show("修改失败！");
                }
                conn.Close();

                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            else MessageBox.Show("请先点击联系人再进行修改操作！");
        }

        private void BtnRup_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);    //创建Connection对象
            string sql = "select * from Contact";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "MyData");
            dgvShow.DataSource = dataSet.Tables[0];
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string dele_ID = txtMid.Text;
            string dele_Name = txtMname.Text;
            if (dele_ID != "" || dele_Name != "")
            {
                string sql3 = "delete from Contact where id='" + dele_ID + " 'or name='" + dele_Name + "'";
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand comm = new SqlCommand(sql3, conn);
                conn.Open();
                int eq = comm.ExecuteNonQuery();
                if (eq != 0)
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
                conn.Close();
            }

            //清空文本框
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            lblShow.Text = "这个是一个通讯录管理系统！";
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            lblShow.Text = "详情请咨询管理员~！";

        }
    }
}
