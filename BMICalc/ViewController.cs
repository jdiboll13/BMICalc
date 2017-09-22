using System;

using UIKit;

namespace BMICalc
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            calculateButton.TouchUpInside+= CalculateButton_TouchUpInside;
        }

        void CalculateButton_TouchUpInside(object sender, EventArgs e)
        {
            double height = double.Parse(heightTextField.Text);
            double weight = double.Parse(weightTextField.Text);

            var kgweight = weight * 0.45359237;
            var mtrheight = height * 0.0254;

            var bmi = (kgweight / (mtrheight * mtrheight));

            bmiTextField.Text = bmi.ToString();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public override void TouchesBegan(Foundation.NSSet touches, UIEvent evt)
        {
            base.TouchesBegan(touches, evt);
            this.View.EndEditing(true);
        }
    }
}
