using Quan_Li_Sach.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Sach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            load_Data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Chắc chắn bạn muốn thoát?", "Thông báo!", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dr != DialogResult.No)
            {
                Application.Exit();
            }
        }
        private void login()
        {

            if (new TaiKhoan("admin", "123").check(textbox_user.Text.ToString(), textBox_password.Text.ToString()))
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "THÔNG BÁO!!!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textbox_user.Text != "" && textBox_password.Text != "")
            {
                if (checkBox_luu.Checked != false)
                {
                    Properties.Settings.Default.user = textbox_user.Text.ToString();
                    Properties.Settings.Default.pass = textBox_password.Text.ToString();
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Reset();
                }
            }
        }
        private void load_Data()
        {
            textbox_user.Text = Properties.Settings.Default.user;
            textBox_password.Text = Properties.Settings.Default.pass;
            if (Properties.Settings.Default.user != "")
            {
                checkBox_luu.Checked = true;
            }

        }
    }
}
