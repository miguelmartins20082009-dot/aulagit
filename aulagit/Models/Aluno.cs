using Microsoft.AspNetCore.Mvc;

namespace aulagit.Models
{
    public class Aluno : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Nome()
        {
            return View();
        }

        public IActionResult Idade()
        {
            return View();
        }
    }
}
