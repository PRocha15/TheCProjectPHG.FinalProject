﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheCProject.Controllers;
using TheCProject.Dal.Interfaces;
using TheCProject.ViewModels;
using TheCProject.Web.Helpers;

namespace TheCProject.Web.Controllers.CakeElement
{
    public class IngredientController : BaseController
    {
        private IIngredientRepository _ingredientRepository;

        public IngredientController(IHttpContextAccessor accessor, IIngredientRepository ingredientRepository) : base(accessor)
        {
            _ingredientRepository = ingredientRepository;
        }


        // GET: IngredientController
        public ActionResult Index()
        {
            List<IngredientViewModel> Ingredients = DatabaseHelper.Ingredients(_ingredientRepository);
            return View(Ingredients);
        }

        // GET: IngredientController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: IngredientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IngredientController/Create
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

        // GET: IngredientController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: IngredientController/Edit/5
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

        // GET: IngredientController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: IngredientController/Delete/5
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
