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
    public partial class FormCheckOut : Form
    {
        int charge, total, id_item1 = 0;
        Helper helper = new Helper();
        public FormCheckOut()
        {
            InitializeComponent();
        }

        private void comboBoxSet()
        {
            comboBox_item.DataSource = helper.getTable("select * from tbl_item");
            comboBox_item.DisplayMember = "name";
            comboBox_item.ValueMember = "id";

            comboBox_reservation_room.DataSource = helper.getTable("select * from tbl_reservation_room inner join tbl_reservation on tbl_reservation.id = tbl_reservation_room.id_reservation inner join tbl_room on tbl_room.id = tbl_reservation_room.id_room where status = 'checkin'");
            comboBox_reservation_room.DisplayMember = "room_number";
            comboBox_reservation_room.ValueMember = "id";

            comboBox_status.DataSource = helper.getTable("select * from tbl_item_status");
            comboBox_status.DisplayMember = "name";
            comboBox_status.ValueMember = "id";
        }

        private void panel_view_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(comboBox_reservation_room.Text == "")
                {
                    MessageBox.Show("Please Select Reservation Room.");
                }
                else
                {
                    try
                    {
                        // Item Charge
                        for (int i = 0; i < dgv_item.Rows.Count; i++)
                        {
                            helper.insert($"Insert into tbl_reservation_checkout values(" +
                            $"'{comboBox_reservation_room.SelectedValue}'," +
                            $"'{dgv_item.Rows[i].Cells["id_item"].Value}'," +
                            $"'{comboBox_status.SelectedValue}'," +
                            $"'{dgv_item.Rows[i].Cells["qty_item"].Value}'," +
                            $"'{dgv_item.Rows[i].Cells["total_charge"].Value}'" +
                            $")");
                        }

                        // Checkout Status
                        SqlCommand cmd = new SqlCommand($"update tbl_reservation_room set checkout_datetime = @date, status = 'checkout' where id = {comboBox_reservation_room.SelectedValue}");
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);
                        var res = helper.insertCmd(cmd);

                        panel_success.Show();
                        panel_view.Hide();
                        comboBoxSet();
                        comboBox_reservation_room.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void FormCheckOut_Load(object sender, EventArgs e)
        {
            comboBoxSet();
            panel_success.Hide();
            panel_success.Location = new Point(12, 12);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_view.Show();
            panel_success.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(int.Parse(comboBox_status.SelectedValue.ToString()) == 1)
            {
                try
                {
                    DataTable dt = helper.getTable($"select * from tbl_item where id = {comboBox_item.SelectedValue}");
                    DataRow row = dt.Rows[0];
                    id_item1 = int.Parse(row["id"].ToString());
                    charge = int.Parse(row["compesation_fee"].ToString());
                    total = charge * int.Parse(numericUpDown_qty.Value.ToString());

                    dgv_item.Rows.Add(comboBox_item.SelectedValue, comboBox_item.Text, numericUpDown_qty.Value, total);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {

            }
        }

        private void dgv_item_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                dgv_item.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
