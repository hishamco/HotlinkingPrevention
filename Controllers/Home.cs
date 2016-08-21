using Microsoft.AspNetCore.Mvc;

namespace HotlinkingPrevention
{
    public class HomeController: Controller
    {
        [HttpGet("/")]
        public IActionResult Index() => View();
        
        [HttpGet("/Home/About")]
        public IActionResult About() => View();
    }
}