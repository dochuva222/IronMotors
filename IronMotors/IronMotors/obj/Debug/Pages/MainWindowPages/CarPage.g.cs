﻿#pragma checksum "..\..\..\..\Pages\MainWindowPages\CarPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D34479D71D5F078BE84BA2EE7E5FAD4F8609AFD2A21CC39F45D826741E3F614B"
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
    /// CarPage
    /// </summary>
    public partial class CarPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\Pages\MainWindowPages\CarPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBBrands;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Pages\MainWindowPages\CarPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBYears;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Pages\MainWindowPages\CarPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BSave;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Pages\MainWindowPages\CarPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BCancel;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Pages\MainWindowPages\CarPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel DPPhotos;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\Pages\MainWindowPages\CarPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BAddPhoto;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\Pages\MainWindowPages\CarPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BRemovePhoto;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\Pages\MainWindowPages\CarPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LVCarImages;
        
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
            System.Uri resourceLocater = new System.Uri("/IronMotors;component/pages/mainwindowpages/carpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\MainWindowPages\CarPage.xaml"
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
            this.CBBrands = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.CBYears = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            
            #line 36 "..\..\..\..\Pages\MainWindowPages\CarPage.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TBMileage_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BSave = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\Pages\MainWindowPages\CarPage.xaml"
            this.BSave.Click += new System.Windows.RoutedEventHandler(this.BSave_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BCancel = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\..\Pages\MainWindowPages\CarPage.xaml"
            this.BCancel.Click += new System.Windows.RoutedEventHandler(this.BCancel_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DPPhotos = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 7:
            this.BAddPhoto = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\..\Pages\MainWindowPages\CarPage.xaml"
            this.BAddPhoto.Click += new System.Windows.RoutedEventHandler(this.BAddPhoto_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BRemovePhoto = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\..\Pages\MainWindowPages\CarPage.xaml"
            this.BRemovePhoto.Click += new System.Windows.RoutedEventHandler(this.BRemovePhoto_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.LVCarImages = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

