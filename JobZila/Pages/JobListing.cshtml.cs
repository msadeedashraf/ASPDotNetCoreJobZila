using JobZila.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobZila.Pages
{
    public class JobListingModel : PageModel
    {
        public List<Jobs> Job { get; set; }

        private ApplicationDBContext _context;
        public JobListingModel(ApplicationDBContext context)
        {

            _context = context;

        }

        public void OnGet()
        {
            Job =  _context.jobs.ToList();

        }
    }
}
