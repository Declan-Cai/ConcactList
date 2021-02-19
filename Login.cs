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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //获取用户输入的账号和密码
            string userName = txtName.Text.Trim();
            string password = txtPwd.Text.Trim();
            string connString = "Data Source=.;Initial Catalog=ContactList;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);    //创建Connection对象
            //获取用户名和密码匹配的行数的SQL语句
            string sql = String.Format("select count(*) from Account where Username='{0}' and Password='{1}'", userName, password);
            try
            {
                conn.Open();        //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);        //创建Command对象
                int num = (int)comm.ExecuteScalar();                //执行查询语句，返回匹配的行数
                if (num == 1)
                {
                    //如果有匹配的行，则表明用户名和密码正确
                    MessageBox.Show("欢迎进入通讯录管理系统！", "登录成功", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    mainFrm mainFrm = new mainFrm();//创建主窗体对象
                    mainFrm.Show();           //显示主窗体
                    this.Visible = false;
                }
                else
                {
                    txtPwd.Text = "";
                    MessageBox.Show("账号或密码错误！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"数据库操作出错！",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            finally
            {
                conn.Close();           //关闭数据库连接
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPwd.Text = "";
            txtName.Focus();
        }

        private void LoginRg_Click(object sender, EventArgs e)
        {
            Regist rigist = new Regist();
            rigist.Show();
            this.Visible = false;
        }


    }
}
