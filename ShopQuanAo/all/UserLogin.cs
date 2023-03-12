
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopQuanAo.all
{
    [Serializable]
    public class UserLogin
    {
       
        public int UserID { set; get; }
         public string USerName { set; get; }
        public string Email { set; get; }
        public string FullName { set; get; }
       
    }
}