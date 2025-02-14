
namespace desktop
{
    partial class FormRequestAdditionalItem
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
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.numericUpDown_qty = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.comboBox_item = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_reservation_room = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_item = new System.Windows.Forms.DataGridView();
            this.id_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remove_item = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel_view.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_qty)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_view
            // 
            this.panel_view.BackColor = System.Drawing.SystemColors.Control;
            this.panel_view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_view.Controls.Add(this.dgv_item);
            this.panel_view.Controls.Add(this.label10);
            this.panel_view.Controls.Add(this.button2);
            this.panel_view.Controls.Add(this.button5);
            this.panel_view.Controls.Add(this.label9);
            this.panel_view.Controls.Add(this.panel7);
            this.panel_view.Controls.Add(this.label8);
            this.panel_view.Controls.Add(this.panel6);
            this.panel_view.Controls.Add(this.label3);
            this.panel_view.Controls.Add(this.panel2);
            this.panel_view.Controls.Add(this.label1);
            this.panel_view.Location = new System.Drawing.Point(16, 15);
            this.panel_view.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_view.Name = "panel_view";
            this.panel_view.Size = new System.Drawing.Size(1174, 556);
            this.panel_view.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(662, 399);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(343, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "Total Charge :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(695, 423);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 49);
            this.button2.TabIndex = 20;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MidnightBlue;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(179, 380);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 41);
            this.button5.TabIndex = 32;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(61, 292);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "Qty";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.numericUpDown_qty);
            this.panel7.Location = new System.Drawing.Point(60, 315);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(390, 40);
            this.panel7.TabIndex = 23;
            // 
            // numericUpDown_qty
            // 
            this.numericUpDown_qty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown_qty.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_qty.Location = new System.Drawing.Point(9, 6);
            this.numericUpDown_qty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown_qty.Name = "numericUpDown_qty";
            this.numericUpDown_qty.Size = new System.Drawing.Size(375, 25);
            this.numericUpDown_qty.TabIndex = 19;
            this.numericUpDown_qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(61, 203);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "Item";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.comboBox_item);
            this.panel6.Location = new System.Drawing.Point(60, 227);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(390, 40);
            this.panel6.TabIndex = 21;
            // 
            // comboBox_item
            // 
            this.comboBox_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_item.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_item.FormattingEnabled = true;
            this.comboBox_item.Location = new System.Drawing.Point(4, 4);
            this.comboBox_item.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_item.Name = "comboBox_item";
            this.comboBox_item.Size = new System.Drawing.Size(379, 30);
            this.comboBox_item.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Reservation Room";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboBox_reservation_room);
            this.panel2.Location = new System.Drawing.Point(59, 146);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 40);
            this.panel2.TabIndex = 7;
            // 
            // comboBox_reservation_room
            // 
            this.comboBox_reservation_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_reservation_room.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_reservation_room.FormattingEnabled = true;
            this.comboBox_reservation_room.Location = new System.Drawing.Point(4, 4);
            this.comboBox_reservation_room.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_reservation_room.Name = "comboBox_reservation_room";
            this.comboBox_reservation_room.Size = new System.Drawing.Size(379, 30);
            this.comboBox_reservation_room.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 52);
            this.label1.TabIndex = 5;
            this.label1.Text = "Request Additional Item";
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
            this.dgv_item.Location = new System.Drawing.Point(501, 123);
            this.dgv_item.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_item.MultiSelect = false;
            this.dgv_item.Name = "dgv_item";
            this.dgv_item.ReadOnly = true;
            this.dgv_item.RowHeadersVisible = false;
            this.dgv_item.RowHeadersWidth = 51;
            this.dgv_item.Size = new System.Drawing.Size(614, 232);
            this.dgv_item.TabIndex = 36;
            this.dgv_item.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_item_CellContentClick);
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
            // FormRequestAdditionalItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1264, 816);
            this.Controls.Add(this.panel_view);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormRequestAdditionalItem";
            this.Text = "FormRequestAdditionalItem";
            this.Load += new System.EventHandler(this.FormRequestAdditionalItem_Load);
            this.panel_view.ResumeLayout(false);
            this.panel_view.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_qty)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_view;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_reservation_room;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox comboBox_item;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.NumericUpDown numericUpDown_qty;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgv_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty_item;
        private System.Windows.Forms.DataGridViewButtonColumn remove_item;
    }
}