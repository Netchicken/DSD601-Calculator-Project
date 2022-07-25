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

        //lets refactor the method to a Pure Method - when we get to Unit Testing then it will be ready to be tested.
        public Calculator CalculationPureMethod(Calculator calculator)
        {
            if (calculator.OperationType == EnumOperationType.Addition)
                calculator.Result = calculator.NumberA + calculator.NumberB;
            if (calculator.OperationType == EnumOperationType.Division)
                calculator.Result = calculator.NumberA / calculator.NumberB;
            if (calculator.OperationType == EnumOperationType.Subtraction)
                calculator.Result = calculator.NumberA - calculator.NumberB;
            if (calculator.OperationType == EnumOperationType.Multiplication)
                calculator.Result = calculator.NumberA * calculator.NumberB;
            return calculator;
        }

        //lets use a switch statemnt with the latest tools -- WHEN  https://ochzhen.com/blog/switch-case-when-in-csharp
        public double CalculationPureMethodSwitch(Calculator calculator)
        {

            switch (calculator)
            {
                case Calculator when calculator.OperationType == EnumOperationType.Addition:
                    calculator.Result = calculator.NumberA + calculator.NumberB;
                    break;

                case Calculator when calculator.OperationType == EnumOperationType.Division:
                    calculator.Result = calculator.NumberA / calculator.NumberB;
                    break;

                case Calculator when calculator.OperationType == EnumOperationType.Subtraction:
                    calculator.Result = calculator.NumberA - calculator.NumberB;
                    break;

                case Calculator when calculator.OperationType == EnumOperationType.Multiplication:
                    calculator.Result = calculator.NumberA * calculator.NumberB;
                    break;


            }
            
            return calculator.Result;
        }
    }
}