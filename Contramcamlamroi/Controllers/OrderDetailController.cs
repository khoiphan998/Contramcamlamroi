using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Contramcamlamroi.Models;

namespace Contramcamlamroi.Controllers
{
    public class OrderDetailController : Controller
    {
        DBSportStoreEntities2 database = new DBSportStoreEntities2();
        public ActionResult GroupByTop5()
        {
            List<OrderDetail> orderD = database.OrderDetails.ToList();
            List<Product> proList = database.Products.ToList();
                var query = from od in orderD join p in proList on od.IDProduct equals p.ProductID into tbl group od by new { idPro = od.IDProduct, namePro = od.Product.NamePro, imagePro = od.Product.ImagePro, price = od.Product.Price } into gr orderby gr.Sum(s => s.Quantity) descending select new ViewModel
                {
                    IDPro = gr.Key.idPro,
                    NamePro = gr.Key.namePro,
                    ImgPro = gr.Key.imagePro,
                    pricePro = (decimal)gr.Key.price,
                    Sum_Quantity = gr.Sum(s => s.Quantity)

                };
            return View(query.Take(5).ToList());
        }
        public ActionResult GroupByTop()
        {
            List<Product> proList = database.Products.ToList();
            var query = from od in proList
                        join p in proList on od.ProductID equals p.ProductID into tbl
                        group od by new
                        {
                            idPro = od.ProductID,
                            namePro = od.NamePro,
                            imagePro = od.ImagePro,
                            price = od.Price
                        } into gr
                        orderby gr.Max(s => s.ProductID) descending
                        select new ViewModel
                        {
                            IDPro = gr.Key.idPro,
                            NamePro = gr.Key.namePro,
                            ImgPro = gr.Key.imagePro,
                            pricePro = (decimal)gr.Key.price,
                            Top5_Quantity = gr.Max(s => s.ProductID)
                        };
            return View(query.Take(5).ToList());
        }
    }
}