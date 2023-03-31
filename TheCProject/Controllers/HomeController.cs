using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TheCProject.Dal.Interfaces;
using TheCProject.ViewModels;
using TheCProject.Web.Helpers;

namespace TheCProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICakeRepository _cakeRepository;
        private readonly IDecorationRepository _decorationRepository;
        private readonly IFillingRepository _fillingRepository;
        private readonly IIngredientRepository _ingredientRepository;
        private readonly IToppingRepository _toppingRepository;
        private readonly IWeightRepository _weightRepository;

        public HomeController(ILogger<HomeController> logger, ICakeRepository cakeRepository, 
            IDecorationRepository decorationRepository, IFillingRepository fillingRepository,
            IIngredientRepository ingredientRepository, IToppingRepository toppingRepository,
            IWeightRepository weightRepository)
        {
            _logger = logger;
            _cakeRepository = cakeRepository;
            _decorationRepository = decorationRepository;
            _fillingRepository = fillingRepository;
            _ingredientRepository= ingredientRepository;
            _toppingRepository= toppingRepository;
            _weightRepository= weightRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contacts()
        {
            return View();
        }
        public IActionResult Factory()
        {
            List <CakeViewModel> cakes = DatabaseHelper.Cakes(_cakeRepository);
            ViewBag.Output = cakes;
            return View();
        }
        public IActionResult Order()
        {
            OrderViewModel orderViewModel = DatabaseHelper.OrderViewModel(_decorationRepository,
                _fillingRepository, _ingredientRepository, _toppingRepository, _weightRepository);
            ViewBag.Output = orderViewModel;
            OrderFormViewModel orderForm = new OrderFormViewModel();
            return View(orderForm);
        }

        [HttpPost]

        public IActionResult OrderConfirmation(OrderFormViewModel orderForm)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(Order));
            }

            OrderConfirmationViewModel orderConfirmation = DatabaseHelper.OrderConfirmationViewModel(_decorationRepository,
                _fillingRepository, _ingredientRepository, _toppingRepository, _weightRepository, orderForm);

            return View(orderConfirmation);

        }


        [HttpPost]

        public IActionResult OrderConfirmationSuccess(OrderConfirmationViewModel orderForm)
        {
            return View();

        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}