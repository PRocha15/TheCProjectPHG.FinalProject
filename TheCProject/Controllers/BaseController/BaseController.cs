using Microsoft.AspNetCore.Mvc;
using TheCProject.Dal.Implementations;
using TheCProject.Dal.Interfaces;
using TheCProject.Helpers;
using TheCProject.ViewModels;
using TheCProject.Web.Helpers;

namespace TheCProject.Controllers
{
    public class BaseController : Controller
    {
        private readonly IHttpContextAccessor _contextAccessor;
        
        public BaseController(IHttpContextAccessor accessor)
        {
            _contextAccessor = accessor;
        }
    }
}
