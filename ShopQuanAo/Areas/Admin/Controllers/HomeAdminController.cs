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
        //public string ProcessUpload(HttpPostedFileBase file)
        //{
        //    if (file == null)
        //    {
        //        return "";
        //    }
        //    file.SaveAs(Server.MapPath("~/Content/images/" + file.FileName));
        //    return "/Content/images/" + file.FileName;
        //}

        public ActionResult listSP()
        {
            var all_Sp = from ss in data.SanPham select ss;
            return View(all_Sp);
        }


        public ActionResult Detail(int id)
        {
            var D_sp =  data.SanPham.Where(m => m.MaSP == id).First(); 
            return View(D_sp);
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
            var D_sach = data.SanPham.First(m => m.MaSP== id);
            return View(D_sach);
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var D_sach = data.SanPham.Where(m => m.MaSP == id).First();
            data.SanPham.Remove(D_sach);
            data.SaveChanges();
            return RedirectToAction("listSP", "HomeAdmin");
        }

    }
}