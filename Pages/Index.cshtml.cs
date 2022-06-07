using DSD601CalculatorASP.Operations;

namespace DSD601CalculatorASP.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {


        [Display(Name = "First Number")]
        public double NumberA { get; set; }


        [Display(Name = "Second Number")]
        public double NumberB { get; set; }


        [Display(Name = "Result")]
        public double Result { get; set; }


        [Display(Name = "Operation")]
        public EnumOperationType OperationType { get; set; }




        public IndexModel()
        {

        }


        public void OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                if (OperationType == EnumOperationType.Addition)
                    Result = NumberA + NumberB;
                if (OperationType == EnumOperationType.Division)
                    Result = NumberA / NumberB;
                if (OperationType == EnumOperationType.Subtraction)
                    Result = NumberA - NumberB;
                if (OperationType == EnumOperationType.Multiplication)
                    Result = NumberA * NumberB;
            }

        }
        public void OnGet()
        {


        }
    }
}