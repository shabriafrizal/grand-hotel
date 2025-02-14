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
    public partial class FormMasterItem : Form
    {
        Helper helper = new Helper();
        DataTable dt_item;
        int id = 0;
        public FormMasterItem()
        {
            InitializeComponent();
        }

        private void FormMasterItem_Load(object sender, EventArgs e)
        {
            loadDgv();
            panel_create.Hide();
            panel_create.Location = new Point(12, 12);
        }

        private void loadDgv()
        {
            dt_item = helper.getTable("select id as ID, name as Name, request_price as [Request Price], compesation_fee as [Compensation Fee] from tbl_item");
            dgv_item.DataSource = dt_item;
        }

        private void searchDgv()
        {
            dt_item = helper.getTable($"select id as ID, name as Name, request_price as [Request Price], compesation_fee as [Compensation Fee] from tbl_item where id like '%{textBox_search.Text}%' or name like '%{textBox_search.Text}%' or request_price like '%{textBox_search.Text}%' or compesation_fee like '%{textBox_search.Text}%'");
            dgv_item.DataSource = dt_item;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel_view.Hide();
            panel_create.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox_name.Text) || string.IsNullOrEmpty(textBox_request.Text) || string.IsNullOrEmpty(TextBox_compesation.Text))
            {
                MessageBox.Show("Field is Empty");
            }
            else
            {
                if (id == 0)
                {
                    try
                    {
                        string insert = $"insert into tbl_item values( " +
                            $"'{textBox_name.Text}'," +
                            $"'{textBox_request.Text}'," +
                            $"'{TextBox_compesation.Text}')";
                        var res = helper.insert(insert);
                        MessageBox.Show("Success Created");
                        panel_create.Hide();
                        panel_view.Show();
                        loadDgv();

                        id = 0;

                        textBox_name.Text = "";
                        textBox_request.Text = "";
                        TextBox_compesation.Text = "";

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
                        string update = $"update tbl_item set " +
                            $"name='{textBox_name.Text}'," +
                            $"compesation_fee='{TextBox_compesation.Text}'," +
                            $"request_price='{textBox_request.Text}' where id = {id}";
                        var res = helper.insert(update);
                        MessageBox.Show("Success Updated");
                        panel_create.Hide();
                        panel_view.Show();
                        loadDgv();

                        id = 0;

                        textBox_name.Text = "";
                        textBox_request.Text = "";
                        TextBox_compesation.Text = "";

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
            if (dgv_item.SelectedRows != null)
            {
                id = int.Parse(dt_item.Rows[dgv_item.CurrentCell.RowIndex][0].ToString());
                DataTable dt = helper.getTable($"select * from tbl_item where id = {id}");
                DataRow row = dt.Rows[0];

                button4.Text = "Update";

                textBox_name.Text = row["name"].ToString();
                textBox_request.Text = row["request_price"].ToString();
                TextBox_compesation.Text = row["compesation_fee"].ToString();

                panel_view.Hide();
                panel_create.Show();
            }
        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {
            searchDgv();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?","Confirmation",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (dgv_item.SelectedRows != null)
                    {
                        id = int.Parse(dt_item.Rows[dgv_item.CurrentCell.RowIndex][0].ToString());
                        var res = helper.insert($"delete from tbl_item where id = {id}");
                        loadDgv();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data is usage.");
                }
            }
        }
    }
}
