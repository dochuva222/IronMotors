﻿#pragma checksum "..\..\..\..\..\Pages\MainWindowPages\CarServicePages\MaintenancesPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9E9501C10ED391F69F0879CBF8B4382FA493D483732FF742EA327C94766B287A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using IronMotors.Pages.MainWindowPages.CarServicePages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
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


namespace IronMotors.Pages.MainWindowPages.CarServicePages {
    
    
    /// <summary>
    /// MaintenancesPage
    /// </summary>
    public partial class MaintenancesPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 16 "..\..\..\..\..\Pages\MainWindowPages\CarServicePages\MaintenancesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BCreateMaintenance;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\Pages\MainWindowPages\CarServicePages\MaintenancesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LVMaintenances;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\Pages\MainWindowPages\CarServicePages\MaintenancesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MIAbout;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\..\Pages\MainWindowPages\CarServicePages\MaintenancesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MIWorkers;
        
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
            System.Uri resourceLocater = new System.Uri("/IronMotors;component/pages/mainwindowpages/carservicepages/maintenancespage.xaml" +
                    "", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Pages\MainWindowPages\CarServicePages\MaintenancesPage.xaml"
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
            
            #line 12 "..\..\..\..\..\Pages\MainWindowPages\CarServicePages\MaintenancesPage.xaml"
            ((IronMotors.Pages.MainWindowPages.CarServicePages.MaintenancesPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BCreateMaintenance = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\..\..\Pages\MainWindowPages\CarServicePages\MaintenancesPage.xaml"
            this.BCreateMaintenance.Click += new System.Windows.RoutedEventHandler(this.BCreateMaintenance_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LVMaintenances = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.MIAbout = ((System.Windows.Controls.MenuItem)(target));
            
            #line 33 "..\..\..\..\..\Pages\MainWindowPages\CarServicePages\MaintenancesPage.xaml"
            this.MIAbout.Click += new System.Windows.RoutedEventHandler(this.MIAbout_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MIWorkers = ((System.Windows.Controls.MenuItem)(target));
            
            #line 36 "..\..\..\..\..\Pages\MainWindowPages\CarServicePages\MaintenancesPage.xaml"
            this.MIWorkers.Click += new System.Windows.RoutedEventHandler(this.MIWorkers_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 6:
            
            #line 82 "..\..\..\..\..\Pages\MainWindowPages\CarServicePages\MaintenancesPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BFinish_Click);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 116 "..\..\..\..\..\Pages\MainWindowPages\CarServicePages\MaintenancesPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BCancel_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
