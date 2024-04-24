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
        public string? Description { get; set; }
        [BindProperty]
        public string City { get; set; }



        //[BindProperty]
        // public Jobs jobs { get; set; }





        public void OnGet()
        {
            

            
        }

        public IActionResult OnPost()
        {
            string myValues = $"{Title} - {Company} - {Description} - {City}";

            //string myValues = $"{jobs.title} - {jobs.company} - {jobs.description} - {jobs.city}";


            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            
            
            
            return Redirect("JobListing");

            
        }

       
    }
}
