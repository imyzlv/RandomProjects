// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace CalculatorTest
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField mainTextField { get; set; }

		[Action ("button0:")]
		partial void button0 (Foundation.NSObject sender);

		[Action ("button1:")]
		partial void button1 (Foundation.NSObject sender);

		[Action ("button2:")]
		partial void button2 (Foundation.NSObject sender);

		[Action ("button3:")]
		partial void button3 (Foundation.NSObject sender);

		[Action ("button4:")]
		partial void button4 (Foundation.NSObject sender);

		[Action ("button5:")]
		partial void button5 (Foundation.NSObject sender);

		[Action ("button6:")]
		partial void button6 (Foundation.NSObject sender);

		[Action ("button7:")]
		partial void button7 (Foundation.NSObject sender);

		[Action ("button8:")]
		partial void button8 (Foundation.NSObject sender);

		[Action ("button9:")]
		partial void button9 (Foundation.NSObject sender);

		[Action ("clearButton:")]
		partial void clearButton (Foundation.NSObject sender);

		[Action ("commaButton:")]
		partial void commaButton (Foundation.NSObject sender);

		[Action ("divideButton:")]
		partial void divideButton (Foundation.NSObject sender);

		[Action ("minusButton:")]
		partial void minusButton (Foundation.NSObject sender);

		[Action ("multiplyButton:")]
		partial void multiplyButton (Foundation.NSObject sender);

		[Action ("percentButton:")]
		partial void percentButton (Foundation.NSObject sender);

		[Action ("plusButton:")]
		partial void plusButton (Foundation.NSObject sender);

		[Action ("plusMinusButton:")]
		partial void plusMinusButton (Foundation.NSObject sender);

		[Action ("resultButton:")]
		partial void resultButton (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (mainTextField != null) {
				mainTextField.Dispose ();
				mainTextField = null;
			}
		}
	}
}
