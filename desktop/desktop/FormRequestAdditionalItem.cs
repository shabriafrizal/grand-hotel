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
    public partial class FormRequestAdditionalItem : Form
    {
        Helper helper = new Helper();
        int id_request, id_reservation_room = 0;

        public FormRequestAdditionalItem()
        {
            InitializeComponent();
        }

        private void comboBoxSet()
        {
            DataTable dt_item = helper.getTable("select * from tbl_item");
            comboBox_item.DataSource = dt_item;
            comboBox_item.DisplayMember = "name";
            comboBox_item.ValueMember = "id";

            DataTable dt_reservation_room = helper.getTable("select * from tbl_reservation_room inner join tbl_reservation on tbl_reservation.id = tbl_reservation_room.id_reservation inner join tbl_room on tbl_room.id = tbl_reservation_room.id_room where status = 'checkin'");
            comboBox_reservation_room.DataSource = dt_reservation_room;
            comboBox_reservation_room.DisplayMember = "room_number";
            comboBox_reservation_room.ValueMember = "id";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgv_item.Rows.Add(comboBox_item.SelectedValue, comboBox_item.Text, numericUpDown_qty.Value);
        }

        private void FormRequestAdditionalItem_Load(object sender, EventArgs e)
        {
            comboBoxSet();
        }

        private void dgv_item_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                dgv_item.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgv_item.Rows.Count < 0)
            {
                MessageBox.Show("Data is Empty.");
            }
            else
            {
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


                        // get id_reservation_room
                        id_reservation_room = int.Parse(comboBox_reservation_room.SelectedValue.ToString());

                        string query = $"insert into tbl_reservation_request_item values(" +
                        $"'{id_reservation_room}'," +
                        $"'{id_request}'," +
                        $"'{qty}'," +
                        $"'{total_price}')";
                        var res = helper.insert(query);

                        dgv_item.Rows.Clear();
                        MessageBox.Show("Data Successful Inserted.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
