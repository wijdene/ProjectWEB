using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MoviesRepository.Data.Repositories;
using MoviesRepository.Models;
using System.Collections.Generic;
using System.Linq;

namespace MoviesRepository.Controllers
{
    public class HomeController : BaseController
    {
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Message = "Movies report.";
            var categories = GetCategoriesDropDownListSource();
            MoviesReportModel model = new MoviesReportModel()
            {
                FromYear = 2000,
                ToYear = 2010,
                Limit = 3,
                Categories = categories
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(MoviesReportModel model)
        {
            ViewBag.Message = "Movies report.";
            model.Categories = GetCategoriesDropDownListSource();
            MovieReport report = new MovieReport(Connection);
            int[] categories = null;
            if (model.CategoryId.HasValue)
            {
                categories = new int[] { model.CategoryId.Value };
            }

            model.SearchResults = report.Get(model.Limit, model.FromYear, model.ToYear, categories);
            return View(model);
        }

        private List<SelectListItem> GetCategoriesDropDownListSource()
        {
            return new CategoryRepository(Connection).FindAll()
                            .Select(item => new SelectListItem() { Value = item.Id.ToString(), Text = item.Name })
                            .ToList();
        }
    }
}