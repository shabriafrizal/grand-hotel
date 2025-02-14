using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop
{
    public partial class FormLogin : Form
    {
        Helper helper = new Helper();
        DataTable dt;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                dt = helper.getTable($"select * from tbl_employee inner join tbl_job on tbl_job.id = tbl_employee.id_job where username = '{textBox_username.Text}'");
                if(dt.Rows.Count < 1)
                {
                    MessageBox.Show("User not found");
                }
                else
                {
                    DataRow row = dt.Rows[0];
                    if(textBox_password.Text != row["password"].ToString())
                    {
                        MessageBox.Show("Incorrect Password.");
                    }
                    else
                    {
                        Session_login.id = int.Parse(row["id_job"].ToString());
                        Session_login.name = row["name"].ToString();
                        Session_login.job = row["name_job"].ToString();
                        this.Hide();
                        FormMain obj = new FormMain();
                        obj.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
