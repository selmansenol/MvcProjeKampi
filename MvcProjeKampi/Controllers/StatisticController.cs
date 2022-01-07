using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class StatisticController : Controller
    {
        // GET: Statistic
        Context context = new Context();
        public ActionResult Index()
        {
            //Total Category
            var TotalCategoryCount = context.Categories.Count();
            ViewBag.Value1 = TotalCategoryCount;

            //Software Category
            var TotalSoftwareTitle = context.Headings.Count(x => x.CategoryID == 28);
            ViewBag.Value2 = TotalSoftwareTitle;

            //Authors with letter a in their name
            var BetweenCharacter = context.Writers.Count(x => x.WriterName.ToLower().Contains("a"));
            ViewBag.Value3 = BetweenCharacter;

            //Category with the most headings
            var MaxHeadingCount = context.Categories.Where(u => u.CategoryID
             == context.Headings.GroupBy(x => x.CategoryID).OrderByDescending(x => x.Count()).Select(x => x.Key)
            .FirstOrDefault()).Select(x => x.CategoryName).FirstOrDefault();
            ViewBag.Value4 = MaxHeadingCount;
            //Numerical differences in status categories
            var CategoryStatusDifference = (context.Categories.Count(x => x.CategoryStatus == true)
                - context.Categories.Count(x => x.CategoryStatus == false));
            ViewBag.Value5 = CategoryStatusDifference;

            return View();
        }
    }
}