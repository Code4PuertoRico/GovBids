﻿#pragma checksum "C:\Users\Harold\Documents\Visual Studio 2012\Projects\GovBids\GovBids\Pages\BidDetailPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "16BC0ADEFD83EB43734E36A3569D919E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace GovBids.Pages {
    
    
    public partial class BidDetailPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock Title;
        
        internal System.Windows.Controls.TextBlock Agency;
        
        internal System.Windows.Controls.TextBlock Category;
        
        internal System.Windows.Controls.TextBlock Location;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/GovBids;component/Pages/BidDetailPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.Title = ((System.Windows.Controls.TextBlock)(this.FindName("Title")));
            this.Agency = ((System.Windows.Controls.TextBlock)(this.FindName("Agency")));
            this.Category = ((System.Windows.Controls.TextBlock)(this.FindName("Category")));
            this.Location = ((System.Windows.Controls.TextBlock)(this.FindName("Location")));
        }
    }
}
