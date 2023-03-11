using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace ShopQuanAo.Models.DataTier
{
    public class UserData
    {
        MyDataContextDB data = null;
        public UserData()
        {
            data = new MyDataContextDB();
        }
        public NhanVien Add(NhanVien nv)
        {
            data.NhanVien.Add(nv);
            data.SaveChanges();
            return nv;
        }
        public NhanVien Update(NhanVien nv)
        {
            var nhanvien = data.NhanVien.FirstOrDefault(x => x.MaNV == nv.MaNV);
            nhanvien.Pass = nv.Pass;
            nhanvien.User = nv.User;
            nhanvien.TenNV = nv.TenNV;
            nhanvien.Email = nv.Email;
            nhanvien.SDT = nv.SDT;
            nhanvien.DiaChi = nv.DiaChi;
            data.SaveChanges();
            return nv; 
        }
        public int Login(string useName, string PassWord)
        {
            int count = data.NhanVien.Where(x => x.User == useName && x.Pass == PassWord).Count();

        }
    }
}