﻿// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace XamarinTrainingProject
{
    [Register ("CountryListViewController")]
    partial class CountryListViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UINavigationItem NavigationController { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (NavigationController != null) {
                NavigationController.Dispose ();
                NavigationController = null;
            }
        }
    }
}