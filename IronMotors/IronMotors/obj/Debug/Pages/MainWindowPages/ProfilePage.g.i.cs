﻿#pragma checksum "..\..\..\..\Pages\MainWindowPages\ProfilePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "83DB981BC7554ECA5FA1F3CDEE838FD2C4AF35D64BA03020F68A5CA2A096EB98"
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
    /// ProfilePage
    /// </summary>
    public partial class ProfilePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\Pages\MainWindowPages\ProfilePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BMyProfile;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Pages\MainWindowPages\ProfilePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BCalendar;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Pages\MainWindowPages\ProfilePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BMessages;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Pages\MainWindowPages\ProfilePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame ProfileFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/IronMotors;component/pages/mainwindowpages/profilepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\MainWindowPages\ProfilePage.xaml"
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
            this.BMyProfile = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\Pages\MainWindowPages\ProfilePage.xaml"
            this.BMyProfile.Click += new System.Windows.RoutedEventHandler(this.BMyProfile_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BCalendar = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\Pages\MainWindowPages\ProfilePage.xaml"
            this.BCalendar.Click += new System.Windows.RoutedEventHandler(this.BCalendar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BMessages = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\Pages\MainWindowPages\ProfilePage.xaml"
            this.BMessages.Click += new System.Windows.RoutedEventHandler(this.BMessages_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ProfileFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

