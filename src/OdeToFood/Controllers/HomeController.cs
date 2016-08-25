using Microsoft.AspNetCore.Mvc;
using OdeToFood.ViewModels;
using OdeToFood.Services;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        private IGreeter _greeter;
        private IRestaurantData _restdata;

        public HomeController(IRestaurantData restData, IGreeter greeter)
        {
            _restdata = restData;
            _greeter = greeter;
        }
        public ViewResult Index()
        {

            var model = new HomePageViewModel();
            model.Restaurants = _restdata.GetAll();
            model.CurrentGreeting = _greeter.GetGreeting();
            return View(model);

        }
    }
}
