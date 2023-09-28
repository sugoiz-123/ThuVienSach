using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVienSach
{
    internal class Sach
    {
        public string maSach { get; set ;}
        public string tenSach { get; set; }
        public string tacGia { get; set; }
    }
    public Sach(string maSach, string tenSach, string tacGia)
    {
        maSach = maSach;
        tenSach = tenSach;
        tacGia = tacGia;
    }
}
