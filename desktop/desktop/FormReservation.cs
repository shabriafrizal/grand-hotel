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
    public partial class FormReservation : Form
    {
        DataTable dt_room, dt_reservation, dt_item, dt_costumer;
        Helper helper = new Helper();
        int id_costumer, id_reservation, id_request, id_reservation_room, total = 0;

        public FormReservation()
        {
            InitializeComponent();
        }

        private void loadDgv()
        {
            dt_reservation = helper.getTable("select tbl_reservation.id as ID, tbl_costumer.name as Name, code as Code, reservation_datetime as [Date Time] from tbl_reservation inner join tbl_costumer on tbl_costumer.id = tbl_reservation.id_costumer");
            dgv_reservation.DataSource = dt_reservation;

        }

        private void searchDgv()
        {
            dt_reservation = helper.getTable($"select tbl_reservation.id as ID, tbl_costumer.name as Name, code as Code, reservation_datetime as [Date Time] from tbl_reservation inner join tbl_costumer on tbl_costumer.id = tbl_reservation.id_costumer where tbl_reservation.id like '%{textBox_search1.Text}%' or tbl_costumer.name like '%{textBox_search1.Text}%' or code like '%{textBox_search1.Text}%' or reservation_datetime like '%{textBox_search1.Text}%'");
            dgv_reservation.DataSource = dt_reservation;

        }

        private void loadDgvRoom()
        {
            dt_room = helper.getTable($"select id as ID, room_number as Number, room_floor as Floor from tbl_room where id_room_type = {comboBox_room_type.SelectedValue}");
            dgv_roomleft.DataSource = dt_room;
        }

        private void comboBoxSet()
        {
            DataTable dt_room_type = helper.getTable("select * from tbl_room_type");
            comboBox_room_type.DataSource = dt_room_type;
            comboBox_room_type.DisplayMember = "name";
            comboBox_room_type.ValueMember = "id";

            DataTable dt_item = helper.getTable("select * from tbl_item");
            comboBox_item.DataSource = dt_item;
            comboBox_item.DisplayMember = "name";
            comboBox_item.ValueMember = "id";
        }

        private void FormReservation_Load(object sender, EventArgs e)
        {
            comboBoxSet();
            loadDgv();
            panel_add.Hide();
            panel_add.Location = new Point(12, 12);

            radioButton_search.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_view.Hide();
            panel_add.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            loadDgvRoom();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {

            dt_costumer = helper.getTable($"select id as ID, name as Name, phone as Phone from tbl_costumer where id like '%{textBox_search.Text}%' or name like '%{textBox_search.Text}%' or phone like '%{textBox_search.Text}%'");
            dgv_costumer.DataSource = dt_costumer;
        }

        private void radioButton_search_CheckedChanged(object sender, EventArgs e)
        {
            panelsearch.Show();
            labelsearch.Show();
            dgv_costumer.Show();
            dt_costumer = helper.getTable($"select id as ID, name as Name, phone as Phone from tbl_costumer");
            dgv_costumer.DataSource = dt_costumer;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgv_item.Rows.Add(comboBox_item.SelectedValue, comboBox_item.Text, numericUpDown_qty.Value);
        }

        private void dgv_item_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                this.dgv_item.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dgv_roomright_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dgv_roomright.SelectedRows.Count.ToString());
        }

        private void textBox_search1_TextChanged(object sender, EventArgs e)
        {
            searchDgv();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgv_roomright.Rows.Count == 0)
            {
                MessageBox.Show("Data is Empty.");
            }
            else 
            {
                panel_add.Hide();
                panel_view.Show();

                // Note: Mengecek nilai checkBox dari dgv_costumer lalu memberikan data untuk diproses

                if (radioButton_search.Checked == true)
                {
                    for (int i = 0; i <= dgv_costumer.RowCount - 1; i++)
                    {
                        if (Convert.ToBoolean(dgv_costumer.Rows[i].Cells["Choose"].Value) == true)
                        {
                            id_costumer = int.Parse(dgv_costumer.Rows[i].Cells["ID"].Value.ToString());
                        }
                    }
                }
                else if (radioButton_add_new.Checked == true)
                {
                    if (string.IsNullOrEmpty(textBox_name_costumer.Text) || string.IsNullOrEmpty(textBox_phone_costumer.Text))
                    {
                        
                    }
                    else
                    {
                        var res = helper.insert($"insert into tbl_costumer (name, phone) values('{textBox_name_costumer.Text}','{textBox_phone_costumer.Text}')");
                        DataTable dt = helper.getTable("select * from tbl_costumer order by id desc");
                        DataRow row = dt.Rows[0];
                        id_costumer = int.Parse(row["id"].ToString());
                    }
                }
                

                try
                {
                    DataTable dt = helper.getTable("select * from tbl_reservation order by id desc");

                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        id_reservation = int.Parse(row["id"].ToString());
                    }

                    SqlCommand cmd = new SqlCommand($"insert into tbl_reservation values(" +
                        $"@dateReservation," +
                        $"{Session_login.id}," +
                        $"{id_costumer}," +
                        $"'{id_costumer}-{Session_login.id}-{id_reservation}')");
                    cmd.Parameters.AddWithValue("@dateReservation", DateTime.Now);

                    var res = helper.insertCmd(cmd);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Costumer need to be selected.");
                }

                // Note: Pembuatan untuk reservation_room
                for (int i = 0; i <= dgv_roomright.RowCount - 1; i++)
                {
                    try
                    {
                        // price per night
                        DataTable dt_ppn = helper.getTable($"select * from tbl_room inner join tbl_room_type on tbl_room_type.id = tbl_room.id_room_type where tbl_room.id = {dgv_roomright.Rows[i].Cells["ID_room"].Value}");
                        int total_price = 0;
                        if (dt_ppn.Rows.Count > 0)
                        {
                            DataRow row = dt_ppn.Rows[0];
                            total_price = int.Parse(row["room_price"].ToString()) * int.Parse(numericUpDown_nights.Value.ToString());
                            total = total_price;
                        }

                        // get id_reservation
                        DataTable dt = helper.getTable("select * from tbl_reservation order by id desc");
                        if (dt.Rows.Count > 0)
                        {
                            DataRow row = dt.Rows[0];
                            id_reservation = int.Parse(row["id"].ToString());
                        }

                        string query = $"Insert into tbl_reservation_room values(" +
                            $"'{id_reservation}'," +
                            $"'{dgv_roomright.Rows[i].Cells["ID_room"].Value}'," +
                            $"@startDate," +
                            $"'{numericUpDown_nights.Value}'," +
                            $"'{total_price}'," +
                            $"''," +
                            $"''," +
                            $"'reserved')";
                        SqlCommand cmd = new SqlCommand(query);
                        cmd.Parameters.AddWithValue("@startDate", dateTimePicker_date.Value);
                        var res = helper.insertCmd(cmd);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                // Note: Pembuatan untuk Request Item
                for (int i = 0; i <= dgv_item.RowCount - 1; i++)
                {
                    try
                    {
                        // get id_item
                        id_request = int.Parse(dgv_item.Rows[i].Cells["id_item"].Value.ToString());

                        // get qty item and total price
                        int qty = int.Parse(dgv_item.Rows[i].Cells["qty_item"].Value.ToString());

                        int total_price = 0;
                        int price = 0;
                        DataTable dt_tp = helper.getTable($"select * from tbl_item where id = {id_request}");
                        if (dt_tp.Rows.Count > 0)
                        {
                            DataRow row = dt_tp.Rows[0];
                            price = int.Parse(row["request_price"].ToString());
                        }
                        total_price = qty * price;
                        total = total + total_price;


                        // get id_reservation_room
                        DataTable dt = helper.getTable("select * from tbl_reservation_room order by id desc");
                        if (dt.Rows.Count > 0)
                        {
                            DataRow row = dt.Rows[0];
                            id_reservation_room = int.Parse(row["id"].ToString());
                        }

                        string query = $"insert into tbl_reservation_request_item values(" +
                        $"'{id_reservation_room}'," +
                        $"'{id_request}'," +
                        $"'{qty}'," +
                        $"'{total_price}')";
                        var res = helper.insert(query);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                MessageBox.Show($"Total : {total}");
                loadDgv();
                dgv_item.Rows.Clear();
                dgv_roomright.Rows.Clear();
            }
        }

        private void button_test_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= dgv_costumer.RowCount - 1; i++)
            {
                if (Convert.ToBoolean(dgv_costumer.Rows[i].Cells["Choose"].Value) == true)
                {
                    MessageBox.Show(dgv_costumer.Rows[i].Cells["ID"].Value.ToString());
                }
            }
        }

        private void dgv_costumer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Note: choose dapat dipilih 1 saja
            if (e.ColumnIndex == 0)
            {
                if (Convert.ToBoolean(dgv_costumer.Rows[e.RowIndex].Cells["Choose"].Value) == false)
                {
                    for (int i = 0; i <= dgv_costumer.Rows.Count - 1; i++)
                    {
                        dgv_costumer.Rows[i].Cells["Choose"].Value = false;
                    }
                }
            }
        }

        private void radioButton_add_new_CheckedChanged(object sender, EventArgs e)
        {
            panelsearch.Hide();
            labelsearch.Hide();
            dgv_costumer.Hide();
            dgv_costumer.DataSource = null;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Note: Menghapus data dari dgv2
            if(dgv_roomright.RowCount > 1)
            {
                this.dgv_roomright.Rows.RemoveAt(int.Parse(dgv_roomright.CurrentCell.RowIndex.ToString()));
            }
            else if(dgv_roomright.RowCount == 1)
            {
                this.dgv_roomright.Rows.Clear();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Note: Memindahkan dari dgv1 ke dgv2
            foreach (DataGridViewRow row in dgv_roomleft.SelectedRows)
            {
                object[] rowData = new object[row.Cells.Count];
                for (int i = 0; i < rowData.Length; i++)
                {
                    rowData[i] = row.Cells[i].Value;
                }
                this.dgv_roomright.Rows.Add(rowData);
            }
        }


    }
}
