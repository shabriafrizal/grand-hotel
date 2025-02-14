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
    public partial class FormMasterRoom : Form
    {
        Helper helper = new Helper();
        DataTable dt_room;
        int id = 0;

        public FormMasterRoom()
        {
            InitializeComponent();
        }

        private void loadDgv()
        {
            dt_room = helper.getTable("Select tbl_room.id as ID, tbl_room.room_number as [Room Number], tbl_room.room_floor as [Room Floor], tbl_room_type.name as Type, tbl_room_type.room_price as Price from tbl_room inner join tbl_room_type on tbl_room_type.id = tbl_room.id_room_type");
            dgv_room.DataSource = dt_room;
        }
        private void searchDgv()
        {
            dt_room = helper.getTable($"Select tbl_room.id as ID, tbl_room.room_number as [Room Number], tbl_room.room_floor as [Room Floor], tbl_room_type.name as Type, tbl_room_type.room_price as Price from tbl_room inner join tbl_room_type on tbl_room_type.id = tbl_room.id_room_type where tbl_room.id like '%{textBox_search.Text}%' or tbl_room.room_number like '%{textBox_search.Text}%' or tbl_room.room_floor like '%{textBox_search.Text}%' or tbl_room_type.name like '%{textBox_search.Text}%' or tbl_room_type.room_price like '%{textBox_search.Text}%'");
            dgv_room.DataSource = dt_room;
        }

        private void comboBoxSet()
        {
            comboBox_room_type.DataSource = helper.getTable("select * from tbl_room_type");
            comboBox_room_type.DisplayMember = "name";
            comboBox_room_type.ValueMember = "id";
        }
        private void FormMasterRoom_Load(object sender, EventArgs e)
        {
            comboBoxSet();
            loadDgv();
            panel_create.Hide();
            panel_create.Location = new Point(12, 12);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel_create.Show();
            panel_view.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (dgv_room.SelectedRows != null)
            {
                id = int.Parse(dt_room.Rows[dgv_room.CurrentCell.RowIndex][0].ToString());
                DataTable dt = helper.getTable($"select * from tbl_room where id = {id}");
                DataRow row = dt.Rows[0];

                button4.Text = "Update";

                textBox_room_number.Text = row["room_number"].ToString();
                textBox_room_floor.Text = row["room_floor"].ToString();
                textBox_description.Text = row["description"].ToString();
                comboBox_room_type.SelectedValue = int.Parse(row["id_room_type"].ToString());

                panel_view.Hide();
                panel_create.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_description.Text) || string.IsNullOrEmpty(textBox_room_floor.Text) || string.IsNullOrEmpty(textBox_room_number.Text) || string.IsNullOrEmpty(comboBox_room_type.Text))
            {
                MessageBox.Show("Field is Empty.");
            }
            else 
            { 
            if (id == 0)
                {
                    try
                    {
                        string insert = $"insert into tbl_room values( " +
                            $"'{comboBox_room_type.SelectedValue}'," +
                            $"'{textBox_room_number.Text}'," +
                            $"'{textBox_room_floor.Text}'," +
                            $"'{textBox_description.Text}')";
                        var res = helper.insert(insert);
                        MessageBox.Show("Success Created");
                        panel_create.Hide();
                        panel_view.Show();
                        loadDgv();

                        textBox_room_number.Text = "";
                        textBox_room_floor.Text = "";
                        textBox_description.Text = "";

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
                        string update = $"update tbl_room set " +
                            $"id_room_type='{comboBox_room_type.SelectedValue}'," +
                            $"room_number='{textBox_room_number.Text}'," +
                            $"room_floor='{textBox_room_floor.Text}'," +
                            $"description='{textBox_description.Text}' where id = {id}";
                        var res = helper.insert(update);
                        MessageBox.Show("Success Updated");
                        panel_create.Hide();
                        panel_view.Show();
                        loadDgv();

                        id = 0;
                        textBox_room_number.Text = "";
                        textBox_room_floor.Text = "";
                        textBox_description.Text = "";

                        button4.Text = "Create";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (dgv_room.SelectedRows != null)
                    {
                        id = int.Parse(dt_room.Rows[dgv_room.CurrentCell.RowIndex][0].ToString());
                        string delete = $"delete from tbl_room where id = {id}";
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
