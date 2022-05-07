using System;

using AppKit;
using Foundation;

namespace CalculatorTest
{
    public partial class ViewController : NSViewController
    {
        double firstNumber = 0, secondNumber = 0, result;
        char action;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            //Make the text field not editable so we don't have to deal
            //with parsing errors
            mainTextField.Editable = false;
            mainTextField.StringValue = "0";
            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        //Set up buttons and actions
        partial void button0(NSObject sender)
        {
            if (mainTextField.StringValue == "0" && mainTextField.StringValue != null)
                mainTextField.StringValue = "0";
            else
                mainTextField.StringValue += "0";
        }

        partial void button1(NSObject sender)
        {
            if (mainTextField.StringValue == "0" && mainTextField.StringValue != null)
                mainTextField.StringValue = "1";
            else
                mainTextField.StringValue += "1";
        }

        partial void button2(NSObject sender)
        {
            if (mainTextField.StringValue == "0" && mainTextField.StringValue != null)
                mainTextField.StringValue = "2";
            else
                mainTextField.StringValue += 2;
        }

        partial void button3(NSObject sender)
        {
            if (mainTextField.StringValue == "0" && mainTextField.StringValue != null)
                mainTextField.StringValue = "3";
            else
                mainTextField.StringValue += "3";
        }

        partial void button4(NSObject sender)
        {
            if (mainTextField.StringValue == "0" && mainTextField.StringValue != null)
                mainTextField.StringValue = "4";
            else
                mainTextField.StringValue += 4;
        }

        partial void button5(NSObject sender)
        {
            if (mainTextField.StringValue == "0" && mainTextField.StringValue != null)
                mainTextField.StringValue = "5";
            else
                mainTextField.StringValue += 5;
        }

        partial void button6(NSObject sender)
        {
            if (mainTextField.StringValue == "0" && mainTextField.StringValue != null)
                mainTextField.StringValue = "6";
            else
                mainTextField.StringValue += "6";
        }

        partial void button7(NSObject sender)
        {
            if (mainTextField.StringValue == "0" && mainTextField.StringValue != null)
                mainTextField.StringValue = "7";
            else
                mainTextField.StringValue += "7";
        }

        partial void button8(NSObject sender)
        {
            if (mainTextField.StringValue == "0" && mainTextField.StringValue != null)
                mainTextField.StringValue = "8";
            else
                mainTextField.StringValue += "8";
        }

        partial void button9(NSObject sender)
        {
            if (mainTextField.StringValue == "0" && mainTextField.StringValue != null)
                mainTextField.StringValue = "9";
            else
                mainTextField.StringValue += "9";
        }

        partial void clearButton(NSObject sender)
        {
            mainTextField.StringValue = "0";
            firstNumber = 0;
            secondNumber = 0;
            result = 0;
        }

        partial void commaButton(NSObject sender)
        {
            if (!mainTextField.StringValue.Contains('.'))
                mainTextField.StringValue += ".";
        }

        partial void divideButton(NSObject sender)
        {
            firstNumber = double.Parse(mainTextField.StringValue);
            mainTextField.StringValue = "0";
            action = '/';
        }

        partial void minusButton(NSObject sender)
        {
            firstNumber = double.Parse(mainTextField.StringValue);
            mainTextField.StringValue = "0";
            action = '-';
        }

        partial void multiplyButton(NSObject sender)
        {
            firstNumber = double.Parse(mainTextField.StringValue);
            mainTextField.StringValue = "0";
            action = '*';
        }

        partial void percentButton(NSObject sender)
        {
            double tempValue = double.Parse(mainTextField.StringValue);
            tempValue /= 100;
            mainTextField.StringValue = Convert.ToString(tempValue);
        }

        partial void plusButton(NSObject sender)
        {
            firstNumber = double.Parse(mainTextField.StringValue);
            mainTextField.StringValue = "0";
            action = '+';
        }

        partial void plusMinusButton(NSObject sender)
        {
            if (mainTextField.StringValue != "0")
            {
                if (!mainTextField.StringValue.Contains('-'))
                    mainTextField.StringValue = "-" + mainTextField.StringValue;
                else
                    mainTextField.StringValue = mainTextField.StringValue.Remove(0, 1);
            }
        }

        partial void resultButton(NSObject sender)
        {
            //Output the result based on the choice
            secondNumber = double.Parse(mainTextField.StringValue);
            if (action == '+')
            {
                result = firstNumber + secondNumber;
                mainTextField.StringValue = Convert.ToString(result);
                ClearAll();
            }
            if (action == '-')
            {
                result = firstNumber - secondNumber;
                mainTextField.StringValue = Convert.ToString(result);
                ClearAll();
            }
            if (action == '*')
            {
                result = firstNumber * secondNumber;
                mainTextField.StringValue = Convert.ToString(result);
                ClearAll();
            }
            if (action == '/')
            {
                //Check if, we are dividing with 0.
                //otherwise - do the calculation
                if (secondNumber == 0)
                    mainTextField.StringValue = "Can't divide with 0";
                else
                {
                    result = firstNumber / secondNumber;
                    mainTextField.StringValue = Convert.ToString(result);
                    ClearAll();
                }
            }

        }
        private void ClearAll()
        {
            //Method for clearing all variables
            firstNumber = 0;
            secondNumber = 0;
            result = 0;
            action = ' ';
        }
    }
}
