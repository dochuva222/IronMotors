﻿#pragma checksum "..\..\..\..\..\Pages\MainWindowPages\DirectorPages\CarServicesPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3828E8E75BCE0BC9B29EA60EF720FE3653CBAF4864A9BEC80953E68093D18D8F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using IronMotors.Pages.MainWindowPages.DirectorPages;
using Microsoft.Maps.MapControl.WPF;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace IronMotors.Pages.MainWindowPages.DirectorPages {
    
    
    /// <summary>
    /// CarServicesPage
    /// </summary>
    public partial class CarServicesPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\..\Pages\MainWindowPages\DirectorPages\CarServicesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LVCarServices;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\..\Pages\MainWindowPages\DirectorPages\CarServicesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Maps.MapControl.WPF.Map MainMap;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/IronMotors;component/pages/mainwindowpages/directorpages/carservicespage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Pages\MainWindowPages\DirectorPages\CarServicesPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 13 "..\..\..\..\..\Pages\MainWindowPages\DirectorPages\CarServicesPage.xaml"
            ((IronMotors.Pages.MainWindowPages.DirectorPages.CarServicesPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LVCarServices = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            
            #line 32 "..\..\..\..\..\Pages\MainWindowPages\DirectorPages\CarServicesPage.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Workers_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 34 "..\..\..\..\..\Pages\MainWindowPages\DirectorPages\CarServicesPage.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.AdministartorAppoint_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 36 "..\..\..\..\..\Pages\MainWindowPages\DirectorPages\CarServicesPage.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Maintenances_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 38 "..\..\..\..\..\Pages\MainWindowPages\DirectorPages\CarServicesPage.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Statistics_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.MainMap = ((Microsoft.Maps.MapControl.WPF.Map)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

