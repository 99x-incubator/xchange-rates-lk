using AngularMVC.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularMVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        private SqlConnection myConnection;
        public ActionResult Index()
        {
            //asigning the lowestRate object in the qureies to the current instance
            LowestRate USD = Queries.queries.lowestUSD();

            ViewBag.USDBR = USD.BuyingRate;
            ViewBag.USDSR = USD.SellingRate;
            ViewBag.USDBank = USD.BankName;
            ViewBag.USDLogo = USD.BankLogo;

            LowestRate AD = Queries.queries.lowestAD();

            ViewBag.ADBR = AD.BuyingRate;
            ViewBag.ADSR = AD.SellingRate;
            ViewBag.ADBank = AD.BankName;
            ViewBag.ADLogo = AD.BankLogo;

            LowestRate ER = Queries.queries.lowestEuro();

            ViewBag.ERBR = ER.BuyingRate;
            ViewBag.ERSR = ER.SellingRate;
            ViewBag.ERBank = ER.BankName;
            ViewBag.ERLogo = ER.BankLogo;

            LowestRate NOR = Queries.queries.lowestNOR();

            ViewBag.NORBR = NOR.BuyingRate;
            ViewBag.NORSR = NOR.SellingRate;
            ViewBag.NORBank = NOR.BankName; 
            ViewBag.NORLogo = NOR.BankLogo;

            //all data table

            List<tableData> list = new List<tableData>();

            //using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDbConn"].ToString()))
            //{
            //    connection.Open();

            //Server = OBHASHA\\SQLEXPRESS; Database = currency; User Id = sa; Password = intel@123;

            myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDbConn"].ConnectionString);
            myConnection.Open();
            Debug.WriteLine("Connection "+myConnection.ConnectionString);
            using (SqlCommand command = new SqlCommand("SELECT *  FROM [currency].[dbo].[exchangeRates]", myConnection))
                {
                

                    SqlDataReader rdr = command.ExecuteReader();
                    

                    while (rdr.Read())
                    {
                        var data = new tableData();
                        data.BankName = rdr.GetString(2);
                        data.ADBR = rdr.GetDouble(3);
                        data.ADSR = rdr.GetDouble(4);
                        data.USBR = rdr.GetDouble(9);
                        data.USSR = rdr.GetDouble(10);
                        data.EUBR = rdr.GetDouble(5);
                        data.EUSR = rdr.GetDouble(6);
                        data.NORBR = rdr.GetDouble(7);
                        data.NORSR = rdr.GetDouble(8);
                        data.siteUpdated = rdr.GetString(0);

                        list.Add(data);


                    }
            }


            

            return View(list);


        }
    }
}

//public JsonResult GetRates(){
//    var db = new TestEntities();

//    var rates = db.exchangeRates.ToList();
//   return Json(rates, JsonRequestBehavior.AllowGet);
//}

//[HttpPost]
//public JsonResult AddProduct(string newProduct){
//    //Console.WriteLine("aaaa");
//    var db = new ProductsDBEntities();
//    db.Products.Add(new Product() { ProductName = newProduct });
//    db.SaveChanges();

//    var products = db.Products.ToList();
//    return Json(products, JsonRequestBehavior.AllowGet);

//}

//[HttpPost]
//public JsonResult DeleteProduct(Product delProduct) {
//    var db = new ProductsDBEntities();
//    var product = db.Products.Find(delProduct.Id);
//    db.Products.Remove(product);
//    db.SaveChanges();

//    var products = db.Products.ToList();
//    return Json(products, JsonRequestBehavior.AllowGet);        
//}


//my methods 

