
namespace desktop
{
    partial class FormCheckOut
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_view = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.numericUpDown_qty = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboBox_item = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_success = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_item = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_reservation_room = new System.Windows.Forms.ComboBox();
            this.id_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_charge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remove_item = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel_view.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_qty)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel_success.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_view
            // 
            this.panel_view.BackColor = System.Drawing.SystemColors.Control;
            this.panel_view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_view.Controls.Add(this.label3);
            this.panel_view.Controls.Add(this.panel2);
            this.panel_view.Controls.Add(this.dgv_item);
            this.panel_view.Controls.Add(this.label2);
            this.panel_view.Controls.Add(this.button5);
            this.panel_view.Controls.Add(this.label4);
            this.panel_view.Controls.Add(this.label11);
            this.panel_view.Controls.Add(this.panel1);
            this.panel_view.Controls.Add(this.panel6);
            this.panel_view.Controls.Add(this.label10);
            this.panel_view.Controls.Add(this.panel5);
            this.panel_view.Controls.Add(this.button3);
            this.panel_view.Controls.Add(this.label1);
            this.panel_view.Location = new System.Drawing.Point(16, 15);
            this.panel_view.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_view.Name = "panel_view";
            this.panel_view.Size = new System.Drawing.Size(1174, 591);
            this.panel_view.TabIndex = 18;
            this.panel_view.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_view_Paint);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(844, 480);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Total Charge : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MidnightBlue;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(691, 216);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 41);
            this.button5.TabIndex = 36;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(397, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Item Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(301, 195);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 19);
            this.label11.TabIndex = 35;
            this.label11.Text = "Qty";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox_status);
            this.panel1.Location = new System.Drawing.Point(396, 218);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 40);
            this.panel1.TabIndex = 21;
            // 
            // comboBox_status
            // 
            this.comboBox_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_status.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Location = new System.Drawing.Point(7, 4);
            this.comboBox_status.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(272, 30);
            this.comboBox_status.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.numericUpDown_qty);
            this.panel6.Location = new System.Drawing.Point(300, 218);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(79, 40);
            this.panel6.TabIndex = 34;
            // 
            // numericUpDown_qty
            // 
            this.numericUpDown_qty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown_qty.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_qty.Location = new System.Drawing.Point(9, 6);
            this.numericUpDown_qty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown_qty.Name = "numericUpDown_qty";
            this.numericUpDown_qty.Size = new System.Drawing.Size(64, 25);
            this.numericUpDown_qty.TabIndex = 19;
            this.numericUpDown_qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(49, 195);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 19);
            this.label10.TabIndex = 33;
            this.label10.Text = "Item";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.comboBox_item);
            this.panel5.Location = new System.Drawing.Point(48, 218);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(233, 40);
            this.panel5.TabIndex = 32;
            // 
            // comboBox_item
            // 
            this.comboBox_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_item.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_item.FormattingEnabled = true;
            this.comboBox_item.Location = new System.Drawing.Point(7, 4);
            this.comboBox_item.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_item.Name = "comboBox_item";
            this.comboBox_item.Size = new System.Drawing.Size(219, 30);
            this.comboBox_item.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MidnightBlue;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(886, 503);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 49);
            this.button3.TabIndex = 10;
            this.button3.Text = "Check-Out";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 52);
            this.label1.TabIndex = 5;
            this.label1.Text = "Check-Out";
            // 
            // panel_success
            // 
            this.panel_success.BackColor = System.Drawing.SystemColors.Control;
            this.panel_success.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_success.Controls.Add(this.label5);
            this.panel_success.Controls.Add(this.button1);
            this.panel_success.Controls.Add(this.label6);
            this.panel_success.Location = new System.Drawing.Point(1227, 15);
            this.panel_success.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_success.Name = "panel_success";
            this.panel_success.Size = new System.Drawing.Size(1174, 384);
            this.panel_success.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(157, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(803, 70);
            this.label5.TabIndex = 14;
            this.label5.Text = "Successfully Checked-Out!";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(445, 265);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 49);
            this.button1.TabIndex = 13;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(21, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 52);
            this.label6.TabIndex = 13;
            this.label6.Text = "Check-Out";
            // 
            // dgv_item
            // 
            this.dgv_item.AllowUserToAddRows = false;
            this.dgv_item.AllowUserToDeleteRows = false;
            this.dgv_item.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_item.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_item.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_item.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_item.ColumnHeadersHeight = 45;
            this.dgv_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_item.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_item,
            this.name_item,
            this.qty_item,
            this.total_charge,
            this.remove_item});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_item.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_item.EnableHeadersVisualStyles = false;
            this.dgv_item.GridColor = System.Drawing.Color.Black;
            this.dgv_item.Location = new System.Drawing.Point(48, 268);
            this.dgv_item.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_item.MultiSelect = false;
            this.dgv_item.Name = "dgv_item";
            this.dgv_item.ReadOnly = true;
            this.dgv_item.RowHeadersVisible = false;
            this.dgv_item.RowHeadersWidth = 51;
            this.dgv_item.Size = new System.Drawing.Size(1071, 193);
            this.dgv_item.TabIndex = 39;
            this.dgv_item.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_item_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 19);
            this.label3.TabIndex = 41;
            this.label3.Text = "Reservation Room";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboBox_reservation_room);
            this.panel2.Location = new System.Drawing.Point(47, 139);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 40);
            this.panel2.TabIndex = 40;
            // 
            // comboBox_reservation_room
            // 
            this.comboBox_reservation_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_reservation_room.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_reservation_room.FormattingEnabled = true;
            this.comboBox_reservation_room.Location = new System.Drawing.Point(4, 4);
            this.comboBox_reservation_room.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_reservation_room.Name = "comboBox_reservation_room";
            this.comboBox_reservation_room.Size = new System.Drawing.Size(379, 30);
            this.comboBox_reservation_room.TabIndex = 1;
            // 
            // id_item
            // 
            this.id_item.HeaderText = "ID";
            this.id_item.MinimumWidth = 6;
            this.id_item.Name = "id_item";
            this.id_item.ReadOnly = true;
            // 
            // name_item
            // 
            this.name_item.HeaderText = "Item";
            this.name_item.MinimumWidth = 6;
            this.name_item.Name = "name_item";
            this.name_item.ReadOnly = true;
            // 
            // qty_item
            // 
            this.qty_item.HeaderText = "Qty";
            this.qty_item.MinimumWidth = 6;
            this.qty_item.Name = "qty_item";
            this.qty_item.ReadOnly = true;
            // 
            // total_charge
            // 
            this.total_charge.HeaderText = "Charge";
            this.total_charge.MinimumWidth = 6;
            this.total_charge.Name = "total_charge";
            this.total_charge.ReadOnly = true;
            // 
            // remove_item
            // 
            this.remove_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_item.HeaderText = "Remove";
            this.remove_item.MinimumWidth = 6;
            this.remove_item.Name = "remove_item";
            this.remove_item.ReadOnly = true;
            this.remove_item.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.remove_item.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.remove_item.Text = "Remove";
            this.remove_item.UseColumnTextForButtonValue = true;
            // 
            // FormCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1942, 816);
            this.Controls.Add(this.panel_success);
            this.Controls.Add(this.panel_view);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCheckOut";
            this.Text = "FormCheckOut";
            this.Load += new System.EventHandler(this.FormCheckOut_Load);
            this.panel_view.ResumeLayout(false);
            this.panel_view.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_qty)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel_success.ResumeLayout(false);
            this.panel_success.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_view;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_success;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown numericUpDown_qty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox comboBox_item;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_item;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox_reservation_room;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_charge;
        private System.Windows.Forms.DataGridViewButtonColumn remove_item;
    }
}