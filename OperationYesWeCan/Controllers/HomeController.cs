using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using OperationYesWeCan.Models;
using IronBarCode;
using Hid.Net;
using HidLibrary;
using HidSharp;


namespace OperationYesWeCan.Controllers
{
    public class HomeController : Controller
    {

        private OperationYesWeCanEntities db = new OperationYesWeCanEntities();
        public BarcodeViewModel barcodeView = new BarcodeViewModel();

        public ActionResult Index()
        {

            //List<Barcode> barcodes = db.Barcodes.ToList();

            //HidLibrary.HidDevices.Enumerate();

            //return View(barcodes);
            return View();
        }

        [HttpPost]
        public ActionResult generateBarcode()
        {
            Barcode barcode = new Barcode();
            barcode.Date = DateTime.Now;

            db.Barcodes.Add(barcode);
            db.SaveChanges();

            return RedirectToAction("Index");

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}