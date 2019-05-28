using Indimaret.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Indimaret.Model;

namespace Indimaret.Web.Controllers
{
    public class BrgController : Controller
    {
        // GET: Brg
        public ActionResult Index()
        {
            return View(RepoBrg.GetAll());
        }

        public ActionResult Create()
        {
            return PartialView("_Create");
        }

        public ActionResult Save(MBarang barang)
        {
            if (RepoBrg.CreateBrg(barang))
            {
                return Json(new { Simpan = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Simpan = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
            return View();
        }

        public ActionResult DelItem(int id)
        {
            if (RepoBrg.DeleteBrg(id))
            {
                return Json(new { DelItm = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { DelItm = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
            return View();
        }

        public ActionResult EditItem(int ID)
        {
            return PartialView("_EditItem", RepoBrg.GetID(ID));
        }

        public ActionResult Edit(int id)
        {
            if (RepoBrg.EditBrg(id))
            {
                return Json(new { EdtItm = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { EdtItm = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
            return View();
        }
    }
}