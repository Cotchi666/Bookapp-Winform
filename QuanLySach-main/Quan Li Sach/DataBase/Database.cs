using Quan_Li_Sach.Model;
using System.Data;
using System.Data.SqlClient;


namespace Quan_Li_Sach.DataBase
{
    class Database
    {
        SqlConnection sql = new SqlConnection(Properties.Settings.Default.Database);
        SqlCommand sqlCommand;1.

        public void insert(Sach sach)
        {
            sql.Open();
            sqlCommand = new SqlCommand("INSERT INTO [dbo].[sach] ([tenSach], [tacGia], [theLoai], [donGia], [soLuong]) VALUES ('" + sach.tenSach + "', '" + sach.tacGia + "', '" + sach.theLoai + "','" + sach.donGia + "','" + sach.soLuong + "')", sql);
            sqlCommand.ExecuteNonQuery();
            sql.Close();
        }
        public void delete(int maSach)
        {
            sql.Open();
            sqlCommand = new SqlCommand("DELETE FROM [dbo].[sach] WHERE maSach =" + maSach, sql);
            sqlCommand.ExecuteNonQuery();
            sql.Close();
        }
        public void update(Sach sach)
        {
            sql.Open();
            sqlCommand = new SqlCommand("UPDATE [dbo].[sach] SET[tenSach] = '" + sach.tenSach + "',[tacGia] = '" + sach.tacGia + "',[theLoai] = '" + sach.theLoai + "',[donGia] = '" + sach.donGia + "',[soLuong] = '" + sach.soLuong + "' WHERE maSach =" + sach.maSach, sql);
            sqlCommand.ExecuteNonQuery();
            sql.Close();
        }
        public DataTable select()
        {
            DataTable data = new DataTable();
            sql.Open();
            sqlCommand = new SqlCommand("SELECT [maSach] as 'Mã sách',[tenSach] as 'Tên sách',[tacGia] as 'Tác giả',[theLoai] as 'Thể loại',[donGia] as 'Đơn giá',[soLuong] as 'Số lượng' FROM[dbo].[sach]", sql);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(data);
            sql.Close();
            return data;
        }
        
    }
}

