using DSD601CalculatorASP.DTO;

namespace DSD601CalculatorASP.Operations
{
    public class Calculations
    {
        public void Calculation(Calculator calculator)
        {
            if (calculator.OperationType == EnumOperationType.Addition)
                calculator.Result = calculator.NumberA + calculator.NumberB;
            if (calculator.OperationType == EnumOperationType.Division)
                calculator.Result = calculator.NumberA / calculator.NumberB;
            if (calculator.OperationType == EnumOperationType.Subtraction)
                calculator.Result = calculator.NumberA - calculator.NumberB;
            if (calculator.OperationType == EnumOperationType.Multiplication)
                calculator.Result = calculator.NumberA * calculator.NumberB;
        }
    }
}
