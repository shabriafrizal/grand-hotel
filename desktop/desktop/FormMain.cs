using desktop.MasterRoomType;
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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void setColor()
        {
            button_reservation.BackColor = Color.MidnightBlue;
            button_reservation.ForeColor = Color.MintCream;
            button_checkin.BackColor = Color.MidnightBlue;
            button_checkin.ForeColor = Color.MintCream;
            button_request_additional.BackColor = Color.MidnightBlue;
            button_request_additional.ForeColor = Color.MintCream;
            button_request_additional.BackColor = Color.MidnightBlue;
            button_checkout.BackColor = Color.MidnightBlue;
            button_checkout.ForeColor = Color.MintCream;
            button_room_type.BackColor = Color.MidnightBlue;
            button_room_type.ForeColor = Color.MintCream;
            button_room.BackColor = Color.MidnightBlue;
            button_room.ForeColor = Color.MintCream;
            button_item.BackColor = Color.MidnightBlue;
            button_item.ForeColor = Color.MintCream;
        }

        private void openForm(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel_main.Controls.Add(form);
            panel_main.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if(Session_login.id == 2)
            {
                button_reservation.Show();
                button_checkin.Show();
                button_request_additional.Show();
                button_checkout.Show();
                button_room.Show();
                button_room_type.Show();
                button_item.Show();
                button_reservation_Click(sender, e);
                setColor();
            }
            if (Session_login.id == 1)
            {
                button4.Show();
                button4_Click(sender, e);
            }
            label3.Text = Session_login.name;
            label4.Text = Session_login.job;
        }

        private void button_reservation_Click(object sender, EventArgs e)
        {
            openForm(new FormReservation());
            setColor();
            button_reservation.BackColor = Color.MintCream;
            button_reservation.ForeColor = Color.MidnightBlue;
        }

        private void button_checkin_Click(object sender, EventArgs e)
        {
            openForm(new FormCheckin());
            setColor();
            button_checkin.BackColor = Color.MintCream;
            button_checkin.ForeColor = Color.MidnightBlue;
        }

        private void button_request_additional_Click(object sender, EventArgs e)
        {
            openForm(new FormRequestAdditionalItem());
            setColor();
            button_request_additional.BackColor = Color.MintCream;
            button_request_additional.ForeColor = Color.MidnightBlue;
        }

        private void button_checkout_Click(object sender, EventArgs e)
        {
            openForm(new FormCheckOut());
            setColor();
            button_checkout.BackColor = Color.MintCream;
            button_checkout.ForeColor = Color.MidnightBlue;
        }

        private void button_room_type_Click(object sender, EventArgs e)
        {
            openForm(new FormMasterRoomType());
            setColor();
            button_room_type.BackColor = Color.MintCream;
            button_room_type.ForeColor = Color.MidnightBlue;
        }

        private void button_room_Click(object sender, EventArgs e)
        {
            openForm(new FormMasterRoom());
            setColor();
            button_room.BackColor = Color.MintCream;
            button_room.ForeColor = Color.MidnightBlue;
        }

        private void button_item_Click(object sender, EventArgs e)
        {
            openForm(new FormMasterItem());
            setColor();
            button_item.BackColor = Color.MintCream;
            button_item.ForeColor = Color.MidnightBlue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin obj = new FormLogin();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openForm(new FormMasterEmployee());
            setColor();
        }
    }
}
