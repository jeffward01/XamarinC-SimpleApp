﻿// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace myFirstApp.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel buttonLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textField { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (buttonLabel != null) {
                buttonLabel.Dispose ();
                buttonLabel = null;
            }

            if (textField != null) {
                textField.Dispose ();
                textField = null;
            }
        }
    }
}