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
    public partial class FormCheckin : Form
    {
        DataTable dt_checkin;
        Helper helper = new Helper();
        public FormCheckin()
        {
            InitializeComponent();
        }

        private void loadDgv()
        {
            dgv_checkin.DataSource = dt_checkin;
            dt_checkin = helper.getTable($"select tbl_reservation_room.id as ID, room_number as [Room Number], room_floor as [Room Floor], start_datetime as [Start Date] from tbl_reservation_room inner join tbl_reservation on tbl_reservation.id = tbl_reservation_room.id_reservation inner join tbl_room on tbl_room.id = tbl_reservation_room.id_room inner join tbl_room_type on tbl_room_type.id = tbl_room.id_room_type where code = '{textBox_search.Text}' and status = 'reserved'");
        }

        private void FormCheckin_Load(object sender, EventArgs e)
        {
            loadDgv();
            panel_success.Hide();
            panel_success.Location = new Point(12, 12);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dt_checkin.Rows[dgv_checkin.CurrentCell.RowIndex][0].ToString());
            if (dgv_checkin.Rows.Count > 0)
            {
                int id = int.Parse(dt_checkin.Rows[dgv_checkin.CurrentCell.RowIndex][0].ToString());
                DataTable dt = helper.getTable($"select phone from tbl_reservation_room inner join tbl_reservation on tbl_reservation.id = tbl_reservation_room.id_reservation inner join tbl_costumer on tbl_costumer.id = tbl_reservation.id_costumer inner join tbl_room on tbl_room.id = tbl_reservation_room.id_room inner join tbl_room_type on tbl_room_type.id = tbl_room.id_room_type where tbl_reservation_room.id = {id}");
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    if (textBox_phone.Text == row["phone"].ToString())
                    {
                        SqlCommand cmd = new SqlCommand($"update tbl_reservation_room set checkin_datetime = @date, status = 'checkin' where id = {id}");
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);
                        var res = helper.insertCmd(cmd);
                        textBox_phone.Text = "";
                        textBox_search.Text = "";
                        panel_view.Hide();
                        panel_success.Show();
                    }
                    else
                    {
                        MessageBox.Show("Data is not match.");
                    }
                    
                }
                
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            panel_success.Hide();
            panel_view.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadDgv();
        }
    }
}
