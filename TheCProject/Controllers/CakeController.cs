using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheCProject.Controllers;
using TheCProject.Dal.Implementations;
using TheCProject.Dal.Interfaces;
using TheCProject.Database.DbEntities;
using TheCProject.ViewModels;
using TheCProject.Web.Helpers;

namespace TheCProject.Controllers
{   
    
    public class CakeController : BaseController
    {
        private ICakeRepository _cakeRepository;
        public CakeController(IHttpContextAccessor accessor, ICakeRepository cakeRepository):base(accessor)
        {
            _cakeRepository = cakeRepository;
        }
        // GET: CakeController
        public ActionResult Index()
        {
            List<CakeViewModel> cakes = DatabaseHelper.Cakes(_cakeRepository);
            return View(cakes);
        }

        // GET: CakeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CakeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CakeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CakeViewModel viewModel)
        {
            try
            {
                DatabaseHelper.CreateCake(_cakeRepository, viewModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CakeController/Edit/5
        public ActionResult Edit(string id)
        {
            CakeViewModel cake = DatabaseHelper.Cake(_cakeRepository, id);
            return View(cake);
        }

        // POST: CakeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, CakeViewModel cake)
        {
            try
            {
                DatabaseHelper.UpdateCake(_cakeRepository, cake);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return Edit(id);
            }
        }

        // GET: CakeController/Delete/5
        public ActionResult Delete(string id)
        {
            DatabaseHelper.DeleteCake(_cakeRepository, id);
            return RedirectToAction(nameof(Index));
        }

        // POST: CakeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
