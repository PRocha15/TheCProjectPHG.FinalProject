using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheCProject.Controllers;
using TheCProject.Dal.Interfaces;
using TheCProject.ViewModels;
using TheCProject.Web.Helpers;

namespace TheCProject.Web.Controllers.CakeElement
{
    public class WeightController : BaseController
    {
        private IWeightRepository _weightRepository;

        public WeightController(IHttpContextAccessor accessor, IWeightRepository weightRepository) : base(accessor)
        {
            _weightRepository = weightRepository;
        }


        // GET: WeightController
        public ActionResult Index()
        {
            List<WeightViewModel> Weights = DatabaseHelper.Weights(_weightRepository);
            return View(Weights);
        }
        // GET: WeightController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WeightController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WeightController/Create
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

        // GET: WeightController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WeightController/Edit/5
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

        // GET: WeightController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WeightController/Delete/5
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
