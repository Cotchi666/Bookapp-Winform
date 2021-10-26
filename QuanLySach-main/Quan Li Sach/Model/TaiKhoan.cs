using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Sach.Model
{
    class TaiKhoan
    {
       public string user { get; set; }
        public string password { get; set; }
        public TaiKhoan(string user,string password)
        {
            this.user = user;
            this.password = password;
        }
        public Boolean check(string user,string pass)
        {
            if (user.Equals(this.user) && pass.Equals(this.password))
            {
                return true;
            }
            return false;
        }

    }
}
