﻿#pragma checksum "..\..\..\..\..\Pages\MainWindowPages\CarServicePages\MaintenancesPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "82053CEF9524C2312B805BA7A7AEB714C364C34D02005A0FA1D317E210B6B92C"
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
        
        
        #line 27 "..\..\..\..\..\Pages\MainWindowPages\CarServicePages\MaintenancesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DPFromDate;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\..\Pages\MainWindowPages\CarServicePages\MaintenancesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DPToDate;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\..\Pages\MainWindowPages\CarServicePages\MaintenancesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BClear;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\..\Pages\MainWindowPages\CarServicePages\MaintenancesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LVMaintenances;
        
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
            this.DPFromDate = ((System.Windows.Controls.DatePicker)(target));
            
            #line 28 "..\..\..\..\..\Pages\MainWindowPages\CarServicePages\MaintenancesPage.xaml"
            this.DPFromDate.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.DPFromDate_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DPToDate = ((System.Windows.Controls.DatePicker)(target));
            
            #line 36 "..\..\..\..\..\Pages\MainWindowPages\CarServicePages\MaintenancesPage.xaml"
            this.DPToDate.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.DPToDate_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BClear = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\..\Pages\MainWindowPages\CarServicePages\MaintenancesPage.xaml"
            this.BClear.Click += new System.Windows.RoutedEventHandler(this.BClear_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.LVMaintenances = ((System.Windows.Controls.ListView)(target));
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
            case 7:
            
            #line 62 "..\..\..\..\..\Pages\MainWindowPages\CarServicePages\MaintenancesPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BAbout_Click);
            
            #line default
            #line hidden
            break;
            case 8:
            
            #line 66 "..\..\..\..\..\Pages\MainWindowPages\CarServicePages\MaintenancesPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BPrintCheck_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

