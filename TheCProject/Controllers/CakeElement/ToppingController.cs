using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheCProject.Controllers;
using TheCProject.Dal.Interfaces;
using TheCProject.ViewModels;
using TheCProject.Web.Helpers;

namespace TheCProject.Web.Controllers.CakeElement
{
    public class ToppingController : BaseController
    {
        private IToppingRepository _toppingRepository;

        public ToppingController(IHttpContextAccessor accessor, IToppingRepository toppingRepository) : base(accessor)
        {
            _toppingRepository = toppingRepository;
        }


        // GET: ToppingController
        public ActionResult Index()
        {
            List<ToppingViewModel> Toppings = DatabaseHelper.Toppings(_toppingRepository);
            return View(Toppings);
        }

        // GET: ToppingController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ToppingController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ToppingController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: ToppingController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ToppingController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: ToppingController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ToppingController/Delete/5
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
