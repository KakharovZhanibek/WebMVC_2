using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC_2.WebMVC_Code2;

namespace WebMVC_2.Controllers
{
    public class SaleController : Controller
    {
        // GET: Sale
        
        [HttpPost]
        public string FormPost(string year, string month, string day)
        {
            string res = Request.Form[0].ToString();
            res = Request.Form[1].ToString();
            res = Request.Form["day"].ToString();
            res = Request.Form[3].ToString();
            Data.Repo.Add(
                new ItemData
                {
                    Year = Int32.Parse(Request.Form["year"].ToString()),
                    Month = Int32.Parse(Request.Form["month"].ToString()),
                    Day = Int32.Parse(Request.Form["day"].ToString())
                });

            return Data.Repo.Count.ToString();
        }
        [HttpGet]
        public ActionResult FormPost()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ListDataAll()
        {
            //ViewBag.data = Data.Repo;
            Response.Write(string.Join("|", RouteData.Values));
            switch (RouteData.Values.Count)
            {
                case 3:
                    {
                        return View("ListDataAll", Data.Repo.Where(w => w.Year == Convert.ToInt32(RouteData.Values["Year"])));
                    }
                case 4:
                    {
                        return View("ListDataAll", Data.Repo.Where(w => w.Year == Convert.ToInt32(RouteData.Values["Year"]) && w.Month == Convert.ToInt32(RouteData.Values["Month"])));
                    }
                case 5:
                    {
                        return View("ListDataAll", Data.Repo.Where(w => w.Year == Convert.ToInt32(RouteData.Values["Year"]) && w.Month == Convert.ToInt32(RouteData.Values["Month"]) && w.Month == Convert.ToInt32(RouteData.Values["Month"])));
                    }
                default:
                    return View(Data.Repo);
                    
            }

        }
        public ActionResult ListDataAll_Old()
        {
            ViewBag.data = Data.Repo;
            return View();
        }

        //public ActionResult ListDataYear(int year)
        //{
        //    Response.Write(string.Join(",", RouteData.Values));
        //    return View("ListDataAll", Data.Repo.Where(w => w.Year == year));
        //}
        //public ActionResult ListDataYearMonth(int month, int year)
        //{
        //    Response.Write(string.Join(",", RouteData.Values));
        //    return View("ListDataAll", Data.Repo.Where(w => w.Year == year && w.Month == month));
        //}

        //public ActionResult ListDataYearMonthDay(int day, int year, int month)
        //{
        //    Response.Write(string.Join(",", RouteData.Values));
        //    return View("ListDataAll", Data.Repo.Where(w => w.Year == year && w.Month == month && w.Day == day));
        //}
    }
}