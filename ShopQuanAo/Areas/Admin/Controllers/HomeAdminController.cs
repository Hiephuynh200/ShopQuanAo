using ShopQuanAo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopQuanAo.Areas.Admin.Controllers
{
    public class HomeAdminController : Controller
    {
        // GET: Admin/HomeAdmin
        MyDataContextDB data = new MyDataContextDB();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(SanPham sp)
        {
            MyDataContextDB data = new MyDataContextDB();
            data.SanPham.AddOrUpdate(sp);
            data.SaveChanges();
            return RedirectToAction("Create");
        }
        public ActionResult Delete(int id)
        {
            var D_SP = data.SanPham.First(m => m.MaSP == id);
            return View(D_SP);
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var D_SP = data.SanPham.Where(m => m.MaSP == id).First();
            data.SanPham.Remove(D_SP);
            data.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}