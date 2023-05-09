using FIlms.Controller;
using FIlms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FIlms.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public DbController Controller { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            Controller = new DbController();
        }

        public void OnGet()
        {

            ViewData["Films"] = Controller.GetFilms();  

        }
    }
}