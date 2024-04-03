using LocalShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Data;

namespace WebApplication1.Pages.Companies
{
    public class IndexModel (ApplicationDbContext _db): PageModel
    {
        [BindProperty]
        public List<Company> Companies { get; set; }
        public void OnGet()
        {
            Companies = _db.
        }
    }
}
