using ShopQuanAo.Common;
using ShopQuanAo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopQuanAo.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserLogin();
                var result = dao.Login(model.Email, Encryptor.GetHash(model.Password));
                if (result == 1)
                {
                    var user = dao.getItem(model.Email);
                    var sessoion = new NhanVienLogin();
                    sessoion.Email = user.Email;
                    sessoion.UserID = user.MaNV;
                    sessoion.UserName = user.TenNV;
                    Session.Add(chung_Func.User_Session, sessoion);
                    return RedirectToAction("Index", "Home");
                }
                else if (result == 0)
                {
                    ModelState.AddModelError("", "Tai khoan dang chua kich hoat");
                }
                else if (result == -1)
                {
                    ModelState.AddModelError("", "sai mat khau, vui long nhap lai mat khau");
                }
                else if (result == -2)
                {
                    ModelState.AddModelError("", "email khong ton tai");
                }

            }
            return View("Index");
        }
    }
}   