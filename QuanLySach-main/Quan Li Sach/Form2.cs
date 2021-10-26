using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quan_Li_Sach.Model;
using Quan_Li_Sach.DataBase;
using System.Windows.Forms;

namespace Quan_Li_Sach
{
    public partial class Form2 : Form
    {
        Database database = new Database();
        public Form2()
        {
            InitializeComponent();
            inDS();
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            database.insert(new Sach(0, textBox_tenSach.Text.ToString(), textBox_tacGia.Text, textBox_theLoai.Text, float.Parse(textBox_donGia.Text.ToString()), int.Parse(numericUpDown_soLuong.Value.ToString())));
            inDS();
            chuyenGiaTriVeNull();
        }

        private void inDS()
        {
            dataGridView_bangSach.DataSource = null;
            dataGridView_bangSach.DataSource = database.select();
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            database.delete(int.Parse(textBox_maSach.Text));
            inDS();
            chuyenGiaTriVeNull();
        }


        private void chuyenGiaTriVeNull()
        {
            textBox_maSach.Text = "";
            textBox_tenSach.Text = "";
            textBox_tacGia.Text = "";
            textBox_theLoai.Text = "";
            textBox_donGia.Text = "";
            numericUpDown_soLuong.Value = 0;
        }

        private void dataGridView_bangSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_maSach.Text = dataGridView_bangSach.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            textBox_tenSach.Text = dataGridView_bangSach.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            textBox_tacGia.Text = dataGridView_bangSach.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
            textBox_theLoai.Text = dataGridView_bangSach.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
            textBox_donGia.Text = dataGridView_bangSach.Rows[e.RowIndex].Cells[4].Value.ToString().Trim();
            numericUpDown_soLuong.Value = decimal.Parse(dataGridView_bangSach.Rows[e.RowIndex].Cells[5].Value.ToString());
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            database.update(new Sach(int.Parse(textBox_maSach.Text), textBox_tenSach.Text.ToString(), textBox_tacGia.Text, textBox_theLoai.Text, float.Parse(textBox_donGia.Text.ToString()), int.Parse(numericUpDown_soLuong.Value.ToString())));
            inDS();
            chuyenGiaTriVeNull();
        }

        private void button_logOut_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn muốn đăng xuất?", "Thông báo!!!", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dl != DialogResult.No)
            {
                this.Close();
            }


        }
    }
}
