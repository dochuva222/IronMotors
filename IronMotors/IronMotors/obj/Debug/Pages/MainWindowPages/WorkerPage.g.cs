﻿#pragma checksum "..\..\..\..\Pages\MainWindowPages\WorkerPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D0BA309C840EA8ACD25FF8067DAA85C13ED9CE874CDC5E7D5B60CE5C5F54BB03"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using IronMotors.Pages.MainWindowPages;
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


namespace IronMotors.Pages.MainWindowPages {
    
    
    /// <summary>
    /// WorkerPage
    /// </summary>
    public partial class WorkerPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\Pages\MainWindowPages\WorkerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LHeader;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Pages\MainWindowPages\WorkerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BSave;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Pages\MainWindowPages\WorkerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BCancel;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Pages\MainWindowPages\WorkerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image WorkerPhoto;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Pages\MainWindowPages\WorkerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BChangePhoto;
        
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
            System.Uri resourceLocater = new System.Uri("/IronMotors;component/pages/mainwindowpages/workerpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\MainWindowPages\WorkerPage.xaml"
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
            this.LHeader = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            
            #line 28 "..\..\..\..\Pages\MainWindowPages\WorkerPage.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.FullNameTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 34 "..\..\..\..\Pages\MainWindowPages\WorkerPage.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.FullNameTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BSave = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\..\Pages\MainWindowPages\WorkerPage.xaml"
            this.BSave.Click += new System.Windows.RoutedEventHandler(this.BSave_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BCancel = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\..\Pages\MainWindowPages\WorkerPage.xaml"
            this.BCancel.Click += new System.Windows.RoutedEventHandler(this.BCancel_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.WorkerPhoto = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.BChangePhoto = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\..\Pages\MainWindowPages\WorkerPage.xaml"
            this.BChangePhoto.Click += new System.Windows.RoutedEventHandler(this.BChangePhoto_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

