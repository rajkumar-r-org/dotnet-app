using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BPCalculator; // Ensure you have this using directive to reference your models

namespace BPCalculator.Pages
{
    public class BloodPressureModel : PageModel
    {
        [BindProperty] // bound on POST
        public BloodPressure BP { get; set; }

        // This property will hold the health advice
        public string HealthAdvice { get; private set; }

        // setup initial data
        public void OnGet()
        {
            BP = new BloodPressure() { Systolic = 100, Diastolic = 60 };
        }

        // POST, validate
        public IActionResult OnPost()
        {
            // extra validation
            if (!(BP.Systolic > BP.Diastolic))
            {
                ModelState.AddModelError("", "Systolic must be greater than Diastolic");
            }

            // Only calculate health advice if the model state is valid
            if (ModelState.IsValid)
            {
                HealthAdvice = BP.GetHealthAdvice();
            }

            return Page();
        }
    }
}