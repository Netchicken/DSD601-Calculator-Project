using DSD601CalculatorASP.DTO;
using DSD601CalculatorASP.Operations;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DSD601CalculatorASP.Pages
{
    [BindProperties] //this connects the properties in the back end to the Model in the front it Binds the Properties
    public class IndexModel : PageModel
    {
        public Calculator calculator { get; set; }
        public Calculations calculations { get; set; }

        //this runs when you submit the form
        public void OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                calculations.Calculation(calculator);
            }
        }
    }
}

// public List<Calculator> AllCalculations = new List<Calculator>();

//pure method
// calculator = calculations.CalculationPureMethod(calculator);

//add each entry to the static list calculator
//  StaticList.AllCalculations.Add(calculator);

//pass all the data from the static list to the List instantiated here
//  AllCalculations.AddRange(StaticList.AllCalculations);





//  public Calculations calc = new Calculations();
//convert it to a method
//private void Calculation()
//{
//if (OperationType == EnumOperationType.Addition)
//    Result = NumberA + NumberB;
//if (OperationType == EnumOperationType.Division)
//    Result = NumberA / NumberB;
//if (OperationType == EnumOperationType.Subtraction)
//    Result = NumberA - NumberB;
//if (OperationType == EnumOperationType.Multiplication)
//    Result = NumberA * NumberB;
//}



//if (calculator.OperationType == EnumOperationType.Addition)
//    calculator.Result = calculator.NumberA + calculator.NumberB;
//if (calculator.OperationType == EnumOperationType.Division)
//    calculator.Result = calculator.NumberA / calculator.NumberB;
//if (calculator.OperationType == EnumOperationType.Subtraction)
//    calculator.Result = calculator.NumberA - calculator.NumberB;
//if (calculator.OperationType == EnumOperationType.Multiplication)
//    calculator.Result = calculator.NumberA * calculator.NumberB;

//[Display(Name = "First Number")] //these are attributes that you can use to change and control what is seen and done int he front end
//public double NumberA { get; set; }

//[Display(Name = "Second Number")]
//public double NumberB { get; set; }

//[Display(Name = "Result")] //holds the result of the operation
//public double Result { get; set; }

//[Display(Name = "Operation")]
//public EnumOperationType OperationType { get; set; } //this is the Enum with is a handy way to make a list easily.



//public enum EnumOperationType
//{
//    Addition,
//    Multiplication,
//    Division,
//    Subtraction
//}