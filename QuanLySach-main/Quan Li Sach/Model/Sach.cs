using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Sach.Model
{
    class Sach
    {
        public int maSach { get; set; }
        public string tenSach { get; set; }
        public string tacGia { get; set; }
        public string theLoai { get; set; }
        public float donGia { get; set; }
        public int soLuong { get; set; }

        public Sach(int maSach, string tenSach, string tacGia, string theLoai, float donGia, int soLuong)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.tacGia = tacGia;
            this.theLoai = theLoai;
            this.donGia = donGia;
            this.soLuong = soLuong;
        }
    }
}
