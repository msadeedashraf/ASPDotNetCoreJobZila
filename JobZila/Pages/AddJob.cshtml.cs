using JobZila.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobZila.Pages
{
    public class AddJobModel : PageModel
    {
        
        [BindProperty]
        public string Title { get; set; }
        [BindProperty]
        public string Company { get; set; }
        [BindProperty]
        public string Description { get; set; }
        [BindProperty]
        public string City { get; set; }


        private ApplicationDBContext _context;
        public AddJobModel(ApplicationDBContext context)
        {

            _context = context;

        }


        //[BindProperty]
        // public Jobs jobs { get; set; }





        public void OnGet()
        {
            

            
        }

        public IActionResult OnPost()
        {
           // string myValues = $"{Title} - {Company} - {Description} - {City}";

            //string myValues = $"{jobs.title} - {jobs.company} - {jobs.description} - {jobs.city}";


            if (!ModelState.IsValid)
            {


                return Page();
            }


            var job = new Jobs()
            {
            title = Title,
            company = Company,
            description = Description,
            city = City

            };
            
            _context.jobs.Add(job);
            _context.SaveChanges();
            
            
            return Redirect("JobListing");

            
        }

       
    }
}
