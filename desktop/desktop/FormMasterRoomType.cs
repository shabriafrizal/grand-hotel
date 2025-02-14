using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop.MasterRoomType
{
    public partial class FormMasterRoomType : Form
    {
        Helper helper = new Helper();
        DataTable dt_room_type;
        int id = 0;

        public FormMasterRoomType()
        {
            InitializeComponent();
        }
        private void loadDgv()
        {
            dt_room_type = helper.getTable("Select id as ID, name as Name, capacity as Capacity, room_price as [Room Price] from tbl_room_type");
            dgv_room_type.DataSource = dt_room_type;
        }
        private void searchDgv()
        {
            dt_room_type = helper.getTable($"Select * from tbl_room_type where id like '%{textBox_search.Text}%' or name like '%{textBox_search.Text}%' or capacity like '%{textBox_search.Text}%' or room_price like '%{textBox_search.Text}%'");
            dgv_room_type.DataSource = dt_room_type;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel_view.Hide();
            panel_create.Show();
        }

        private void FormMasterRoomType_Load(object sender, EventArgs e)
        {
            loadDgv();
            panel_create.Hide();
            panel_create.Location = new Point(12, 12);
        }



        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_name.Text) || string.IsNullOrEmpty(textBox_price.Text) || numericUpDown_capacity.Value <= 0)
            {
                MessageBox.Show("Field is Empty.");
            }
            else
            {
                if (id == 0)
                {
                    try
                    {
                        string insert = $"insert into tbl_room_type values( " +
                            $"'{textBox_name.Text}'," +
                            $"'{numericUpDown_capacity.Value}'," +
                            $"'{textBox_price.Text}')";
                        var res = helper.insert(insert);
                        MessageBox.Show("Success Created");
                        panel_create.Hide();
                        panel_view.Show();
                        loadDgv();

                        id = 0;

                        textBox_name.Text = "";
                        numericUpDown_capacity.Value = 1;
                        textBox_price.Text = "";

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
                        string update = $"update tbl_room_type set " +
                            $"name='{textBox_name.Text}'," +
                            $"capacity='{numericUpDown_capacity.Value}'," +
                            $"room_price='{textBox_price.Text}' where id = {id}";
                        var res = helper.insert(update);
                        MessageBox.Show("Success Updated");
                        panel_create.Hide();
                        panel_view.Show();
                        loadDgv();

                        id = 0;

                        textBox_name.Text = "";
                        numericUpDown_capacity.Value = 1;
                        textBox_price.Text = "";

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
            if (dgv_room_type.SelectedRows != null)
            {
                id = int.Parse(dt_room_type.Rows[dgv_room_type.CurrentCell.RowIndex][0].ToString());
                DataTable dt = helper.getTable($"select * from tbl_room_type where id = {id}");
                DataRow row = dt.Rows[0];

                button4.Text = "Update";

                textBox_name.Text = row["name"].ToString();
                textBox_price.Text = row["room_price"].ToString();
                numericUpDown_capacity.Value = int.Parse(row["capacity"].ToString());

                panel_view.Hide();
                panel_create.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure?","Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (dgv_room_type.SelectedRows != null)
                    {
                        id = int.Parse(dt_room_type.Rows[dgv_room_type.CurrentCell.RowIndex][0].ToString());
                        string delete = $"delete from tbl_room_type where id = {id}";
                        var res = helper.getTable(delete);
                        loadDgv();
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    MessageBox.Show("Data is usage.");
                }
            }
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            searchDgv();
        }
    }
}
