using System.Web.Mvc;
using proj1.TwoArgumentsCalculators;
using SelectListItem = System.Web.WebPages.Html.SelectListItem;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem()
                {
                    Value = "Multiply", Text ="Multiply"
                },
                new SelectListItem()
                {
                    Value = "Plus", Text ="Plus"
                },
                new SelectListItem()
                {
                    Value = "Minus", Text ="Minus"
                },
                new SelectListItem()
                {
                    Value = "Divide", Text ="Divide"
                }
            };
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Index(double firstNumber, double secondNumber, string operation)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(operation);
            double result = calculator.Calculate(firstNumber, secondNumber);
            ViewBag.Result = result;
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem()
                {
                    Value = "Multiply", Text ="Multiply"
                },
                new SelectListItem()
                {
                    Value = "Plus", Text ="Plus"
                },
                new SelectListItem()
                {
                    Value = "Minus", Text ="Minus"
                },
                new SelectListItem()
                {
                    Value = "Divide", Text ="Divide"
                }
            };
            return View();
        }
    }
}