using System;
using Foundation;
using UIKit;

namespace myFirstApp.iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }
        //UIColor.FromRGB(0.1f,0.5f,0.9f); great color blue
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            //Code to make app

            Console.WriteLine("The view did load!!!");

            textField.KeyboardType = UIKeyboardType.Default;


            button.TouchUpInside += Button_TouchUpInside;



        }

        void Button_TouchUpInside(object sender, EventArgs e)
        {
            textView.Text = textField.Text;
            textField.Text = "";
            textField.ResignFirstResponder();

            //Change background color
            var randSeed = new Random();
            var rand1 = (float) randSeed.NextDouble();
            var rand3 = (float) randSeed.NextDouble();
            var rand2 = (float) randSeed.NextDouble();
                                
            View.BackgroundColor = UIColor.FromRGB(rand1,rand2, rand3);
        }


        public override void ViewWillAppear(bool animated)
        {
            Console.WriteLine("View will appear");

            base.ViewWillAppear(animated);
        }


        public override void ViewWillDisappear(bool animated)
        {
            Console.WriteLine("View will disappear!");

            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            Console.WriteLine("View Did disappear! (fires after will)");
            base.ViewDidDisappear(animated);
        }


        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

    }
}