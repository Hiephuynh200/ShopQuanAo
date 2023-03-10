using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopQuanAo.Common
{
    [Serializable]
    public class NhanVienLogin
    {
       public int UserID { set; get; }
       public string UserName { set; get; }
        public string Email { set; get; }
        public  string FullName
        {
            set;get;
        }
    }
}