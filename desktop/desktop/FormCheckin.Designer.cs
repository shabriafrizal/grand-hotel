
namespace desktop
{
    partial class FormCheckin
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
            this.dgv_checkin = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel_success = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.panel_view.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_checkin)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_success.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_view
            // 
            this.panel_view.BackColor = System.Drawing.SystemColors.Control;
            this.panel_view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_view.Controls.Add(this.label5);
            this.panel_view.Controls.Add(this.panel1);
            this.panel_view.Controls.Add(this.button1);
            this.panel_view.Controls.Add(this.dgv_checkin);
            this.panel_view.Controls.Add(this.button3);
            this.panel_view.Controls.Add(this.label3);
            this.panel_view.Controls.Add(this.panel2);
            this.panel_view.Controls.Add(this.label1);
            this.panel_view.Location = new System.Drawing.Point(12, 12);
            this.panel_view.Name = "panel_view";
            this.panel_view.Size = new System.Drawing.Size(881, 639);
            this.panel_view.TabIndex = 16;
            // 
            // dgv_checkin
            // 
            this.dgv_checkin.AllowUserToAddRows = false;
            this.dgv_checkin.AllowUserToDeleteRows = false;
            this.dgv_checkin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_checkin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_checkin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_checkin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_checkin.ColumnHeadersHeight = 45;
            this.dgv_checkin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_checkin.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_checkin.EnableHeadersVisualStyles = false;
            this.dgv_checkin.GridColor = System.Drawing.Color.Black;
            this.dgv_checkin.Location = new System.Drawing.Point(19, 149);
            this.dgv_checkin.MultiSelect = false;
            this.dgv_checkin.Name = "dgv_checkin";
            this.dgv_checkin.ReadOnly = true;
            this.dgv_checkin.RowHeadersVisible = false;
            this.dgv_checkin.Size = new System.Drawing.Size(844, 376);
            this.dgv_checkin.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MidnightBlue;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(711, 551);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 40);
            this.button3.TabIndex = 10;
            this.button3.Text = "Check-In";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Search Code Reservation";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox_search);
            this.panel2.Location = new System.Drawing.Point(19, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 33);
            this.panel2.TabIndex = 7;
            // 
            // textBox_search
            // 
            this.textBox_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_search.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_search.Location = new System.Drawing.Point(3, 6);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(285, 19);
            this.textBox_search.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Check-In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(16, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 40);
            this.label2.TabIndex = 13;
            this.label2.Text = "Check-In";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MidnightBlue;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(334, 215);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(202, 40);
            this.button4.TabIndex = 13;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel_success
            // 
            this.panel_success.BackColor = System.Drawing.SystemColors.Control;
            this.panel_success.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_success.Controls.Add(this.label4);
            this.panel_success.Controls.Add(this.button4);
            this.panel_success.Controls.Add(this.label2);
            this.panel_success.Location = new System.Drawing.Point(911, 12);
            this.panel_success.Name = "panel_success";
            this.panel_success.Size = new System.Drawing.Size(881, 312);
            this.panel_success.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(605, 56);
            this.label4.TabIndex = 14;
            this.label4.Text = "Successfully Checked-In!";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(318, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 33);
            this.button1.TabIndex = 21;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(409, 535);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Phone";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox_phone);
            this.panel1.Location = new System.Drawing.Point(412, 554);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 33);
            this.panel1.TabIndex = 22;
            // 
            // textBox_phone
            // 
            this.textBox_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_phone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_phone.Location = new System.Drawing.Point(3, 6);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(285, 19);
            this.textBox_phone.TabIndex = 0;
            // 
            // FormCheckin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1838, 663);
            this.Controls.Add(this.panel_view);
            this.Controls.Add(this.panel_success);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCheckin";
            this.Text = "FormCheckin";
            this.Load += new System.EventHandler(this.FormCheckin_Load);
            this.panel_view.ResumeLayout(false);
            this.panel_view.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_checkin)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_success.ResumeLayout(false);
            this.panel_success.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_view;
        private System.Windows.Forms.DataGridView dgv_checkin;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel_success;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_phone;
    }
}