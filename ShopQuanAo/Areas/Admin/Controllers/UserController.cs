using ShopQuanAo.Models;
using ShopQuanAo.Models.DataTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopQuanAo.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        // GET: Admin/User
        MyDataContextDB db = new MyDataContextDB();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(KhachHang kh)
        {
            if (ModelState.IsValid)
            {
                var d = new UserData();
                var user = d.Add(kh);
                if(user != null)
                {
                    return RedirectToAction("Index", "User");
                } else
                {
                    ModelState.AddModelError("", "Them nguoi dung khong thanh cong");
                }
            }
            return View("Index");
        }
    }
}