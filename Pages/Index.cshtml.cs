using DSD601CalculatorASP.Operations;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.ComponentModel.DataAnnotations;

namespace DSD601CalculatorASP.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty(SupportsGet = true)]

        [Display(Name = "First Number")]
        public double NumberA { get; set; }

        [BindProperty(SupportsGet = true)]
        [Display(Name = "Second Number")]
        public double NumberB { get; set; }

        [BindProperty(SupportsGet = true)]
        [Display(Name = "Result")]
        public double Result { get; set; }

        [BindProperty(SupportsGet = true)]
        [Display(Name = "Operation")]
        public OperationType OperationType { get; set; }




        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }


        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                if (OperationType == OperationType.Addition)
                    Result = NumberA + NumberB;
                if (OperationType == OperationType.Division)
                    Result = NumberA / NumberB;
                if (OperationType == OperationType.Subtraction)
                    Result = NumberA - NumberB;
                if (OperationType == OperationType.Multiplication)
                    Result = NumberA * NumberB;
            }
            return Page();
        }
        public void OnGet()
        {
        }
    }
}