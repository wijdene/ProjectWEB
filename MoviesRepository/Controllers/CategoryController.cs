using Microsoft.AspNetCore.Mvc;
using MoviesRepository.Data.Models;
using MoviesRepository.Data.Repositories;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRepository.Controllers
{
    public class CategoryController : BaseController
    {

        protected ICategoryRepository repository;

        public CategoryController(ICategoryRepository repository)
        {
            this.repository = repository;
        }

    [HttpGet]

        public IActionResult Index()
        {
            return View( repository.FindAll());
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
       
        public async Task<IActionResult> Save(Category oneDetail)
        {
          
            if (ModelState.IsValid)
            {


                //if (!repository.FindByName(oneDetail.Name))
                {
                    repository.Save(oneDetail);
                    return RedirectToAction("Index");
                }
                


            }
            else
            {

                var errors = ModelState.Values.SelectMany(v => v.Errors);
                //return View(instanceIClDetailsApp.GetAll());

                return RedirectToAction("Index");
            }

        }



    }
}
