// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace UberClone
{
    [Register ("LoginViewController")]
    partial class LoginViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView SignUpViewController { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (SignUpViewController != null) {
                SignUpViewController.Dispose ();
                SignUpViewController = null;
            }
        }
    }
}