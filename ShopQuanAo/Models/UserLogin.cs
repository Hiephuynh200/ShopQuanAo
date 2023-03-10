using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopQuanAo.Models
{
    public class UserLogin
    {
        MyDataDataContext data = new MyDataDataContext();
        public UserLogin()
        {
            data = new MyDataDataContext();
        }
        public  NhanVien getItem(string email)
        {
            return data.NhanViens.FirstOrDefault(x => x.Email == email);
        }
        public List<NhanVien> getList()
        {
            return data.NhanViens.ToList();
        }
        public NhanVien Add(NhanVien nhanVien)
        {
            data.NhanViens.Add(nhanVien);
            data.save
            return nhanVien;
        }

        public NhanVien CapNhat(NhanVien nv)
        {
            var nhanvien = data.NhanViens.FirstOrDefault(x => x.MaNV == nv.MaNV);
            nhanvien.Pass = nv.Pass;
            nhanvien.TenNV = nv.TenNV;
            nhanvien.Email = nv.Email;
            nhanvien.SDT = nv.SDT;
            nhanvien.DiaChi = nv.DiaChi;
            nhanvien.SaveChange();
            return nhanvien;
        }

        public int Login(string email, string Pass)
        {
            var nhanvien = data.NhanViens.FirstOrDefault(x => x.Email == email );
            if(nhanvien == null)
            {
                return -2; //eamail ko ton tai
            }
            else
            {
                if(nhanvien.Status == false)
                {
                    return 0; // vo hieuj hoa
                } else {
                    if(nhanvien.Pass == Pass)
                    {
                        return 1; // dang nhap thanh cong
                    } else
                    {
                        return -1; // sai mat khau
                    }
                }
            }
        }
    }
}