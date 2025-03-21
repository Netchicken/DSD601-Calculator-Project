﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.ComponentModel.DataAnnotations;

namespace DSD601CalculatorASP.Pages
{
    [BindProperties] //this connects the properties in the back end to the Model in the front it Binds the Properties
    public class IndexModel : PageModel
    {
        //  public Calculator calculator { get; set; }
        //  public Calculations calculations { get; set; }

        [Display(Name = "First Number")] //these are attributes that you can use to change and control what is seen and done int he front end
        public double NumberA { get; set; }

        [Display(Name = "Second Number")]
        public double NumberB { get; set; }

        [Display(Name = "Result")] //holds the result of the operation
        public double Result { get; set; }

        [Display(Name = "Operation")]
        public EnumOperationType OperationType { get; set; } //this is the Enum with is a handy way to make a list easily.




        //this runs when you submit the form
        public void OnPostAsync()
        {
            if (ModelState.IsValid)
            {

                //if (OperationType == EnumOperationType.Addition)
                //    Result = NumberA + NumberB;
                //if (OperationType == EnumOperationType.Division)
                //    Result = NumberA / NumberB;
                //if (OperationType == EnumOperationType.Subtraction)
                //    Result = NumberA - NumberB;
                //if (OperationType == EnumOperationType.Multiplication)
                //    Result = NumberA * NumberB;



                //  calculations.Calculation(calculator);




                Result = Calculator(NumberA, NumberB, OperationType);


                //   calculations.Calculation(calculator);
            }
        }


        public Double Calculator(Double NumA, Double NumB, EnumOperationType selectedType)
        {
            if (selectedType == EnumOperationType.Select)
                return 0;

            if (selectedType == EnumOperationType.Addition)
                return NumA + NumB;
            if (selectedType == EnumOperationType.Division)
                return NumA / NumB;
            if (selectedType == EnumOperationType.Subtraction)
                return NumA - NumB;
            if (selectedType == EnumOperationType.Multiplication)
                return NumA * NumB;

            return 0;


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







        public enum EnumOperationType
        {
            Select,
            Addition,
            Multiplication,
            Division,
            Subtraction
        }

    }
}