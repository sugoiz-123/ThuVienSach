using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVienSach
{
    internal class ThuVien
    {
        private List<Sach> danhSach;

        public ThuVien()
        {
            danhSach = new List<Sach>();
        }

        public void ThemSach(string maSach, string tenSach, string tacGia)
        {
            Sach sach = new Sach(maSach, tenSach, tacGia);
            danhSach.Add(sach);
        }

        public void XoaSach(string maSach)
        {
            Sach sachCanXoa = danhSach.Find(sach => sach.maSach == maSach);
            if (sachCanXoa != null)
            {
                danhSach.Remove(sachCanXoa);
                Console.WriteLine($"Đã xoá sách có mã sách {maSach}");
            }
            else
            {
                Console.WriteLine($"Không tìm thấy sách có mã sách {maSach}");
            }
        }

        public void HienThi()
        {
            Console.WriteLine("Danh sach sach trong thu vien:");
            foreach (Sach sach in danhSach)
            {
                Console.WriteLine($"Ma Sach: {sach.maSach}, Ten Sach: {sach.tenSach}, Tac gia: {sach.tacGia}");
            }
        }
    }
}
