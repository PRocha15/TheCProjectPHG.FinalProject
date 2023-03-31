using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheCProject.Controllers;
using TheCProject.Dal.Implementations;
using TheCProject.Dal.Interfaces;
using TheCProject.ViewModels;
using TheCProject.Web.Helpers;

namespace TheCProject.Web.Controllers.CakeElement
{
    public class DecorationController : BaseController
    {
        private IDecorationRepository _decorationRepository;

        public DecorationController(IHttpContextAccessor accessor, IDecorationRepository decorationRepository) : base(accessor)
        {
            _decorationRepository = decorationRepository;
        }


        // GET: DecorationController
        public ActionResult Index()
        {
            List<DecorationViewModel> decorations = DatabaseHelper.Decorations(_decorationRepository);
            return View(decorations);
        }

        // GET: DecorationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DecorationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DecorationController/Create
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

        // GET: DecorationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DecorationController/Edit/5
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

        // GET: DecorationController/Delete/5
        public ActionResult Delete(string id)
        {
            DatabaseHelper.DeleteDecoration(_decorationRepository, id);
            return RedirectToAction(nameof(Index));
        }

        // POST: DecorationController/Delete/5
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
