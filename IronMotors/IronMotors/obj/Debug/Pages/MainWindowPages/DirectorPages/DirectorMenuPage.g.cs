﻿#pragma checksum "..\..\..\..\..\Pages\MainWindowPages\DirectorPages\DirectorMenuPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ED9628EB3802E8CA501AA098FD341614EA28D8EBB018BC919D5A86E5BDAC4E8D"
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


namespace IronMotors.Pages.MainWindowPages.DirectorPages {
    
    
    /// <summary>
    /// DirectorMenuPage
    /// </summary>
    public partial class DirectorMenuPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\..\Pages\MainWindowPages\DirectorPages\DirectorMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BCarServices;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\Pages\MainWindowPages\DirectorPages\DirectorMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BServices;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\Pages\MainWindowPages\DirectorPages\DirectorMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BClients;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\..\Pages\MainWindowPages\DirectorPages\DirectorMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BLogout;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\..\Pages\MainWindowPages\DirectorPages\DirectorMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame MenuFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/IronMotors;component/pages/mainwindowpages/directorpages/directormenupage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Pages\MainWindowPages\DirectorPages\DirectorMenuPage.xaml"
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
            this.BCarServices = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\..\Pages\MainWindowPages\DirectorPages\DirectorMenuPage.xaml"
            this.BCarServices.Click += new System.Windows.RoutedEventHandler(this.BCarServices_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BServices = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\..\Pages\MainWindowPages\DirectorPages\DirectorMenuPage.xaml"
            this.BServices.Click += new System.Windows.RoutedEventHandler(this.BServices_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BClients = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\..\..\Pages\MainWindowPages\DirectorPages\DirectorMenuPage.xaml"
            this.BClients.Click += new System.Windows.RoutedEventHandler(this.BClients_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BLogout = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\..\..\Pages\MainWindowPages\DirectorPages\DirectorMenuPage.xaml"
            this.BLogout.Click += new System.Windows.RoutedEventHandler(this.BLogout_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MenuFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

