namespace Quan_Li_Sach
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_bangSach = new System.Windows.Forms.DataGridView();
            this.button_logOut = new System.Windows.Forms.Button();
            this.button_sua = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_maSach = new System.Windows.Forms.TextBox();
            this.textBox_tenSach = new System.Windows.Forms.TextBox();
            this.textBox_tacGia = new System.Windows.Forms.TextBox();
            this.textBox_theLoai = new System.Windows.Forms.TextBox();
            this.textBox_donGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_soLuong = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bangSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_soLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_bangSach);
            this.panel1.Location = new System.Drawing.Point(12, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 165);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView_bangSach
            // 
            this.dataGridView_bangSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_bangSach.Location = new System.Drawing.Point(49, 3);
            this.dataGridView_bangSach.Name = "dataGridView_bangSach";
            this.dataGridView_bangSach.Size = new System.Drawing.Size(640, 159);
            this.dataGridView_bangSach.TabIndex = 0;
            this.dataGridView_bangSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_bangSach_CellContentClick);
            // 
            // button_logOut
            // 
            this.button_logOut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_logOut.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logOut.Image = global::Quan_Li_Sach.Properties.Resources.ic_logout;
            this.button_logOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_logOut.Location = new System.Drawing.Point(677, 190);
            this.button_logOut.Name = "button_logOut";
            this.button_logOut.Size = new System.Drawing.Size(105, 35);
            this.button_logOut.TabIndex = 4;
            this.button_logOut.Text = "Đăng xuất";
            this.button_logOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_logOut.UseVisualStyleBackColor = false;
            this.button_logOut.Click += new System.EventHandler(this.button_logOut_Click);
            // 
            // button_sua
            // 
            this.button_sua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_sua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sua.Image = global::Quan_Li_Sach.Properties.Resources.ic_sua;
            this.button_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sua.Location = new System.Drawing.Point(454, 190);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(80, 35);
            this.button_sua.TabIndex = 3;
            this.button_sua.Text = "Sửa";
            this.button_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_sua.UseVisualStyleBackColor = false;
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // button_xoa
            // 
            this.button_xoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_xoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xoa.Image = global::Quan_Li_Sach.Properties.Resources.ic_remove;
            this.button_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_xoa.Location = new System.Drawing.Point(229, 190);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(80, 35);
            this.button_xoa.TabIndex = 2;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_xoa.UseVisualStyleBackColor = false;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_them
            // 
            this.button_them.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_them.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them.Image = global::Quan_Li_Sach.Properties.Resources.ic_add;
            this.button_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_them.Location = new System.Drawing.Point(12, 190);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(80, 35);
            this.button_them.TabIndex = 1;
            this.button_them.Text = "Thêm";
            this.button_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_them.UseVisualStyleBackColor = false;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Thể loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tác giả";
            // 
            // textBox_maSach
            // 
            this.textBox_maSach.Enabled = false;
            this.textBox_maSach.Location = new System.Drawing.Point(71, 81);
            this.textBox_maSach.Name = "textBox_maSach";
            this.textBox_maSach.Size = new System.Drawing.Size(134, 20);
            this.textBox_maSach.TabIndex = 10;
            // 
            // textBox_tenSach
            // 
            this.textBox_tenSach.Location = new System.Drawing.Point(71, 130);
            this.textBox_tenSach.Name = "textBox_tenSach";
            this.textBox_tenSach.Size = new System.Drawing.Size(134, 20);
            this.textBox_tenSach.TabIndex = 11;
            // 
            // textBox_tacGia
            // 
            this.textBox_tacGia.Location = new System.Drawing.Point(360, 81);
            this.textBox_tacGia.Name = "textBox_tacGia";
            this.textBox_tacGia.Size = new System.Drawing.Size(134, 20);
            this.textBox_tacGia.TabIndex = 12;
            // 
            // textBox_theLoai
            // 
            this.textBox_theLoai.Location = new System.Drawing.Point(360, 130);
            this.textBox_theLoai.Name = "textBox_theLoai";
            this.textBox_theLoai.Size = new System.Drawing.Size(134, 20);
            this.textBox_theLoai.TabIndex = 13;
            // 
            // textBox_donGia
            // 
            this.textBox_donGia.Location = new System.Drawing.Point(656, 81);
            this.textBox_donGia.Name = "textBox_donGia";
            this.textBox_donGia.Size = new System.Drawing.Size(108, 20);
            this.textBox_donGia.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(598, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Đơn giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(593, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Số lượng";
            // 
            // numericUpDown_soLuong
            // 
            this.numericUpDown_soLuong.Location = new System.Drawing.Point(656, 135);
            this.numericUpDown_soLuong.Name = "numericUpDown_soLuong";
            this.numericUpDown_soLuong.Size = new System.Drawing.Size(108, 20);
            this.numericUpDown_soLuong.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(305, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 31);
            this.label8.TabIndex = 19;
            this.label8.Text = "Quản lí sách";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown_soLuong);
            this.Controls.Add(this.textBox_donGia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_theLoai);
            this.Controls.Add(this.textBox_tacGia);
            this.Controls.Add(this.textBox_tenSach);
            this.Controls.Add(this.textBox_maSach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_logOut);
            this.Controls.Add(this.button_sua);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(816, 488);
            this.MinimumSize = new System.Drawing.Size(816, 488);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bangSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_soLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_bangSach;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.Button button_logOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_maSach;
        private System.Windows.Forms.TextBox textBox_tenSach;
        private System.Windows.Forms.TextBox textBox_tacGia;
        private System.Windows.Forms.TextBox textBox_theLoai;
        private System.Windows.Forms.TextBox textBox_donGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown_soLuong;
        private System.Windows.Forms.Label label8;
    }
}