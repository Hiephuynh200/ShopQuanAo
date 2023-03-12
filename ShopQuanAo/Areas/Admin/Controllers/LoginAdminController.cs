using ShopQuanAo.all;
using ShopQuanAo.Areas.Admin.Model;
using ShopQuanAo.Models.DataTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopQuanAo.Models.DataTier;

namespace ShopQuanAo.Areas.Admin.Controllers
{
    public class LoginAdminController : Controller
    {
        // GET: Admin/LoginAdmin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(LoginModel loginModel)
        {
            if(ModelState.IsValid)
            {
                var d = new UserData();
                var kq = d.Login(loginModel.Email, loginModel.Pass);
                if(kq == 1 )
                {
                    var user = d.getItems(loginModel.Email);
                    var session = new UserLogin();
                    session.UserID = user.MaKH;
                    session.Email = user.Email;
                    session.USerName = user.UserKH;
                    session.FullName = user.TenKH;
                    Session.Add(All__func.USER_SESSION, session);;
                    return RedirectToAction("Index", "Home");
                }
                else if(kq == 1)
                { 
                    ModelState.AddModelError("","dang nhap thanh cong");
                } else if(kq == -1)
                {
                    ModelState.AddModelError("", "sai mk");
                }
                else if (kq == -2)
                {
                    ModelState.AddModelError("", "tai khoan ko ton tai");
                }                                         

            }
            return View("Index");
        } 
    }
}