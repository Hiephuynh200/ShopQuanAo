using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopQuanAo.Models.DataTier;
namespace ShopQuanAo.Models.DataTier
{
    public class UserData
    {
        MyDataContextDB data = null;
        public UserData()
        {
            data = new MyDataContextDB();
        }

        public KhachHang getItems(string email)
        {
            return data.KhachHang.FirstOrDefault(x => x.Email == email);
        }

        public List<KhachHang> getListKhachHang ()
        {
            return data.KhachHang.ToList();
        }

        public KhachHang Add(KhachHang user)
        {
            data.KhachHang.Add(user);
            data.SaveChanges();
            return user;
        }
        public KhachHang Update(KhachHang user)
        {
            var kh = data.KhachHang.FirstOrDefault(x => x.MaKH == user.MaKH);
            kh.PassKH = user.PassKH;
            kh.TenKH = user.TenKH;
            kh.Email = user.Email;
            kh.SDT = user.SDT;
            kh.DiaChi = user.DiaChi;
            data.SaveChanges();
            return kh;
        }
        public int Login(string email, string PassWord)
        {
            var LoginKH = data.KhachHang.FirstOrDefault(x => x.Email == email);
            if(LoginKH == null) // email ko ton tai
            {
                return -2;
            } else
            {
                if(LoginKH.PassKH == PassWord)
                {
                    return 1; // dang nhap thanh cong
                } else
                {
                    return -1; //sai mk
                }
            }
        }
    }
}