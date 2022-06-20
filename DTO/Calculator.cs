using DSD601CalculatorASP.Operations;

using System.ComponentModel.DataAnnotations;
namespace DSD601CalculatorASP.DTO
{
    public class Calculator
    {
        [Display(Name = "First Number")]
        public double NumberA { get; set; }
        [Display(Name = "Second Number")]
        public double NumberB { get; set; }

        [Display(Name = "Result")]
        public double Result { get; set; }

        [Display(Name = "Operation")]
        public EnumOperationType OperationType { get; set; }
    }
}
