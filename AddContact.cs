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
    public partial class AddContact : Form
    {
        public AddContact()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //判断姓名和电话是否输入
            if (txtCname.Text.Length == 0 && txtCphone.Text.Length == 0)
            {
                MessageBox.Show("请填写电话和姓名！");
                return;
            }

            string addName = txtCname.Text.Trim();
            string addSex = txtCsex.Text.Trim();
            string addBirthdata = txtCbirth.Text.Trim();
            string addPhone = txtCphone.Text.Trim();
            string addEmail = txtCemail.Text.Trim();
            string addAddress = txtCadd.Text.Trim();
            string addId = txtCid.Text.Trim();
            string connString = "Data Source=.;Initial Catalog=ContactList;Integrated Security=True";
            //获取用户名和密码匹配的行数的SQL语句
            SqlConnection conn = new SqlConnection(connString);    //创建Connection对象
            try
            {
                conn.Open();        //打开数据库连接
                string sql = String.Format("insert into Contact(name,sex,birthdata,phone,email,address,id) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", addName, addSex , addBirthdata, addPhone, addEmail , addAddress, addId);
                SqlCommand comm = new SqlCommand(sql, conn);        //创建Command对象
                    int eq = comm.ExecuteNonQuery();
                    if (eq != 0)
                    {
                        MessageBox.Show("添加成功！");
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "数据库操作出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                conn.Close();           //关闭数据库连接
            }

            //清空所有文本框
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}
