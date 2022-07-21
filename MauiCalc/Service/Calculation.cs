using System;
namespace MauiCalc.Service
{
    public class Calculation
    {
        public static string PerformCalculation(double firstNumber, double secondNumber, string operand)
        {
            string result = "Division with 0 is not allowed";
            switch(operand)
            {
                case "/":
                    if(secondNumber==0)
                    {
                        break;
                    }
                    result = (firstNumber / secondNumber).ToString();
                    break;

                case "x":
                    result = (firstNumber * secondNumber).ToString();
                    break;

                case "-":
                    result = (firstNumber - secondNumber).ToString();
                    break;
                case "+":
                    result = (firstNumber - secondNumber).ToString();
                    break;

                default:
                    break;
            }
            return result;
        }
    }
}

