﻿#pragma checksum "..\..\..\..\..\Pages\MainWindowPages\DirectorPages\AdministratorPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E01BE4C9E3A0D673D72E6197E91FB43636365BB6ACD0697BDEAEE9C6BC1B8BFD"
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
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
    /// AdministratorPage
    /// </summary>
    public partial class AdministratorPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 49 "..\..\..\..\..\Pages\MainWindowPages\DirectorPages\AdministratorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BRegistration;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\..\Pages\MainWindowPages\DirectorPages\AdministratorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/IronMotors;component/pages/mainwindowpages/directorpages/administratorpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Pages\MainWindowPages\DirectorPages\AdministratorPage.xaml"
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
            
            #line 24 "..\..\..\..\..\Pages\MainWindowPages\DirectorPages\AdministratorPage.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.FullNameTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 30 "..\..\..\..\..\Pages\MainWindowPages\DirectorPages\AdministratorPage.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.FullNameTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 36 "..\..\..\..\..\Pages\MainWindowPages\DirectorPages\AdministratorPage.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.FullNameTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BRegistration = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\..\..\Pages\MainWindowPages\DirectorPages\AdministratorPage.xaml"
            this.BRegistration.Click += new System.Windows.RoutedEventHandler(this.BRegistration_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BCancel = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\..\..\Pages\MainWindowPages\DirectorPages\AdministratorPage.xaml"
            this.BCancel.Click += new System.Windows.RoutedEventHandler(this.BCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

