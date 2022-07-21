using System;
namespace MauiCalc;

public partial class MainPage : ContentPage
{
	double firstNumber = 0, secondNumber = 0;
	string operand = null;
	bool operationalState = false;

	public MainPage()
	{
		InitializeComponent();
	}

    void OnClear(System.Object sender, System.EventArgs e)
    {
		result.Text = "0";
		firstNumber = 0;
		secondNumber = 0;
		operand = null;
		operationalState = false;
    }

	void OnNumberClicked(System.Object sender, System.EventArgs e)
    {
		Button button = (Button)sender;
		string btnText = button.Text;
		if (result.Text == "0" || operationalState)
		{
			result.Text = btnText;
		}
		else
		{
			result.Text += btnText;
		}
    }

	void OnOperandClicked(System.Object sender, System.EventArgs e)
    {
		//string result = null;
		Button button = (Button)sender;
		firstNumber = Double.Parse(result.Text);
		operand = button.Text;
		operationalState = true;
		//result.Text = "0";
    }

	void OnCommaClicked(System.Object sender, System.EventArgs e)
    {
		if(!result.Text.Contains('.'))
        {
			result.Text += ".";
        }
    }

	void OnResult(System.Object sender, System.EventArgs e)
    {
		Button button = (Button)sender;
		secondNumber = Double.Parse(result.Text);
		result.Text = Service.Calculation.PerformCalculation(firstNumber, secondNumber, operand); 
    }

}


