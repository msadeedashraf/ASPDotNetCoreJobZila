using JobZila.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobZila.Pages
{
    public class JobModel : PageModel
    {
    
        public Jobs? job { get; set; }


        private ApplicationDBContext _context;
        public JobModel(ApplicationDBContext context)
        {

            _context = context;

        }

        public void OnGet(int id)
        {

            job = _context.jobs.FirstOrDefault(n => n.id == id);
        }
    }
}
