using JobZila.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobZila.Pages
{
    public class JobListingModel : PageModel
    {
        public List<Jobs> Job { get; set; } 

        public void OnGet()
        {
            Job = new List<Jobs>()
            {
            new Jobs()
            {
                jodid = 1,
                title = "Software Developer",
                company = "ABC Inc.",
                city = "New York, NY",
                description = " We are looking for a skilled and experienced Software Developer to\r\n                        join our team. The ideal candidate should have strong programming\r\n                        skills in Java and experience with web development technologies\r\n                        such as HTML, CSS, and JavaScript. Familiarity with databases and\r\n                        version control systems is a plus."

            },
            new Jobs()
            {
                jodid = 2,
                title = "Data Scientist",
                company = "XYZ Corp.",
                city = "San Francisco, CA",
                description = " We are seeking a talented Data Scientist to analyze and interpret\r\n                        complex data sets. The successful candidate should have a strong\r\n                        background in statistical analysis, machine learning, and data\r\n                        visualization. Proficiency in programming languages such as Python\r\n                        and R is required."

            }
            ,
            new Jobs()
            {
                jodid = 3,
                title = "Software Developer",
                company = "PQR Corp.",
                city = "San Francisco, CA",
                description = " We are seeking a talented Data Scientist to analyze and interpret\r\n                        complex data sets. The successful candidate should have a strong\r\n                        background in statistical analysis, machine learning, and data\r\n                        visualization. Proficiency in programming languages such as Python\r\n                        and R is required."

            }
            ,
            new Jobs()
            {
                jodid = 4,
                title = "Software Developer",
                company = "PQR Corp.",
                city = "San Francisco, CA",
                description = " We are seeking a talented Data Scientist to analyze and interpret\r\n                        complex data sets. The successful candidate should have a strong\r\n                        background in statistical analysis, machine learning, and data\r\n                        visualization. Proficiency in programming languages such as Python\r\n                        and R is required."

            }
            ,
            new Jobs()
            {
                jodid = 5,
                title = "Software Engineer",
                company = "XYZ Corp.",
                city = "San Francisco, CA",
                description = " We are seeking a talented Data Scientist to analyze and interpret\r\n                        complex data sets. The successful candidate should have a strong\r\n                        background in statistical analysis, machine learning, and data\r\n                        visualization. Proficiency in programming languages such as Python\r\n                        and R is required."

            }

            };



        }
    }
}
