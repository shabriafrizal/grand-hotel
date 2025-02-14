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

namespace desktop
{
    public partial class FormMasterEmployee : Form
    {
        Helper helper = new Helper();
        DataTable dt_employee;
        int id = 0;

        public FormMasterEmployee()
        {
            InitializeComponent();
        }

        private void loadDgv()
        {
            dt_employee = helper.getTable("select tbl_employee.id as ID, username as Username, name_job as [Name Job], name as Name, address as Address, date_birth as [Date Birth] from tbl_employee inner join tbl_job on tbl_job.id = tbl_employee.id_job");
            dgv_employee.DataSource = dt_employee;
        }
        private void searchDgv()
        {
            dt_employee = helper.getTable($"select tbl_employee.id as ID, username as Username, name_job as [Name Job], name as Name, address as Address, date_birth as [Date Birth] from tbl_employee inner join tbl_job on tbl_job.id = tbl_employee.id_job where tbl_employee.id like '%{textBox_search.Text}%' or username like '%{textBox_search.Text}%' or name_job like '%{textBox_search.Text}%' or address like '%{textBox_search.Text}%' or date_birth like '%{textBox_search.Text}%'");
            dgv_employee.DataSource = dt_employee;
        }

        private void comboBoxSet()
        {
            DataTable dt_job = helper.getTable("select * from tbl_job");
            comboBox_job.DataSource = dt_job;
            comboBox_job.DisplayMember = "name_job";
            comboBox_job.ValueMember = "id";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel_view.Hide();
            panel_create.Show();
        }

        private void FormMasterEmployee_Load(object sender, EventArgs e)
        {
            comboBoxSet();
            loadDgv();
            panel_create.Hide();
            panel_create.Location = new Point(12, 12);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox_user.Text) || string.IsNullOrEmpty(textBox_password.Text) || string.IsNullOrEmpty(textBox_name.Text) || string.IsNullOrEmpty(textBox_address.Text) || string.IsNullOrEmpty(textBox_email.Text) || string.IsNullOrEmpty(comboBox_job.Text))
            {
                MessageBox.Show("Field is Empty.");
            }
            else
            {
                if (id == 0)
                {
                    try
                    {
                        string insert = $"insert into tbl_employee values( " +
                            $"'{textBox_user.Text}'," +
                            $"'{textBox_password.Text}'," +
                            $"'{textBox_name.Text}'," +
                            $"'{textBox_address.Text}'," +
                            $"@dateBirth," +
                            $"'{comboBox_job.SelectedValue}'," +
                            $"'{textBox_email.Text}')";
                        SqlCommand cmd = new SqlCommand(insert);
                        cmd.Parameters.AddWithValue("@dateBirth", dateTimePicker_date_birth.Value);
                        var res = helper.insertCmd(cmd);
                        MessageBox.Show("Success Created");
                        panel_create.Hide();
                        panel_view.Show();
                        loadDgv();

                        id = 0;

                        textBox_user.Text = "";
                        textBox_password.Text = "";
                        textBox_name.Text = "";
                        textBox_address.Text = "";
                        textBox_email.Text = "";
                        comboBox_job.Text = "";

                        button4.Text = "Create";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        string update = $"update tbl_employee set " +
                            $"name='{textBox_name.Text}'," +
                            $"username='{textBox_user.Text}'," +
                            $"password='{textBox_password.Text}'," +
                            $"address='{textBox_address.Text}'," +
                            $"date_birth=@dateBirth," +
                            $"id_job='{comboBox_job.SelectedValue}'," +
                            $"email='{textBox_email.Text}' where id = {id}";
                        SqlCommand cmd = new SqlCommand(update);
                        cmd.Parameters.AddWithValue("@dateBirth", dateTimePicker_date_birth.Value);
                        var res = helper.insertCmd(cmd);
                        MessageBox.Show("Success Updated");
                        panel_create.Hide();
                        panel_view.Show();
                        loadDgv();

                        id = 0;

                        textBox_user.Text = "";
                        textBox_password.Text = "";
                        textBox_name.Text = "";
                        textBox_address.Text = "";
                        textBox_email.Text = "";
                        comboBox_job.Text = "";

                        button4.Text = "Create";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dgv_employee.SelectedCells != null)
            {
                try
                {
                    id = int.Parse(dt_employee.Rows[dgv_employee.CurrentCell.RowIndex][0].ToString());
                    DataTable dt = helper.getTable($"select * from tbl_employee where id = {id}");
                    DataRow row = dt.Rows[0];

                    button4.Text = "Update";

                    textBox_name.Text = row["name"].ToString();
                    textBox_user.Text = row["username"].ToString();
                    textBox_password.Text = row["password"].ToString();
                    textBox_address.Text = row["address"].ToString();
                    dateTimePicker_date_birth.Text = row["date_birth"].ToString();
                    comboBox_job.SelectedValue = row["id_job"].ToString();
                    textBox_email.Text = row["email"].ToString();
                    panel_view.Hide();
                    panel_create.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 
            }
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            searchDgv();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure?","Confirmation",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (dgv_employee.SelectedRows != null)
                    {
                        id = int.Parse(dt_employee.Rows[dgv_employee.CurrentCell.RowIndex][0].ToString());
                        var res = helper.insert($"delete from tbl_employee where id = {id}");
                        loadDgv();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data is Usage.");
                }
            }
        }
    }
}
