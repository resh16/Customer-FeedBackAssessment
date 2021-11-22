using Feedback_MVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Feedback_MVC.Controllers
{
    public class FeedbackController : Controller
    {

        private readonly CustomerFeedbackContext _db;

        public FeedbackController(CustomerFeedbackContext db)
        {
            this._db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddFeedback()
        {
            IEnumerable<SelectListItem> listOfCategory = _db.Categories.Select(x => new SelectListItem
            {
                Text = x.Category1,
                Value = x.Id.ToString()
            });

            IEnumerable<SelectListItem> listOfProducts = _db.Products.Select(x => new SelectListItem
            {
                Text = x.Product1,
                Value = x.Id.ToString()
            });

            ViewBag.products = listOfProducts;
            ViewBag.category = listOfCategory;


            return View();
        }


    }
}
