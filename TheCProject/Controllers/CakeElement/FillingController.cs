using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheCProject.Controllers;
using TheCProject.Dal.Interfaces;
using TheCProject.ViewModels;
using TheCProject.Web.Helpers;

namespace TheCProject.Web.Controllers.CakeElement
{
    public class FillingController : BaseController
    {

        private IFillingRepository _fillingRepository;

        public FillingController(IHttpContextAccessor accessor, IFillingRepository fillingRepository) : base(accessor)
        {
            _fillingRepository = fillingRepository;
        }


        // GET: FillingController
        public ActionResult Index()
        {
            List<FillingViewModel> Fillings = DatabaseHelper.Fillings(_fillingRepository);
            return View(Fillings);
        }

        // GET: FillingController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FillingController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FillingController/Create
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

        // GET: FillingController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FillingController/Edit/5
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

        // GET: FillingController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FillingController/Delete/5
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
