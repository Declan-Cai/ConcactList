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
    public partial class Regist : Form
    {
        public Regist()
        {
            InitializeComponent();
        }

        private void BtnRegist_Click(object sender, EventArgs e)
        {
            string regist_Username = txtName.Text;
            string regist_Password = txtPwd.Text;
            string regist_Password1 = txtPwd1.Text;

            if (regist_Username == "" || regist_Password == "" || regist_Password1 == "")
            {
                MessageBox.Show("请确认输入用户名或密码正确！");
                return;
            }
            if (!regist_Password.Equals(regist_Password1))
            {
                MessageBox.Show("两次输入的密码不一致，请重新输入！");
                return;
            }

            //连接数据库，判断用户名是否已经存在
            string connString = "Data Source=.;Initial Catalog=ContactList;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);    //创建Connection对象
            string sql = String.Format("select count(*) from Account where Username='{0}'", regist_Username);
            try
            {
                conn.Open();        //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);        //创建Command对象
                int num = (int)comm.ExecuteScalar();                //执行查询语句，返回匹配的行数
                if (num == 1)
                {
                    //如果有匹配的行，则表明用户名和密码正确
                    MessageBox.Show("用户名已存在，请重新输入用户名！", "注册失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string sql1 = String.Format("insert into Account(Username,Password) values('{0}','{1}')", regist_Username, regist_Password);
                    SqlCommand comm1 = new SqlCommand(sql1, conn);
                    int eq = comm1.ExecuteNonQuery();
                    if (eq != 0)
                    {
                        MessageBox.Show("注册成功！将调整到登录页面！");
                        this.Close();
                        Login login = new Login();
                        login.Show();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "数据库操作出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                conn.Close();           //关闭数据库连接
            }
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPwd.Text = "";
            txtPwd1.Text = "";
            txtName.Focus();
        }

    }
}
