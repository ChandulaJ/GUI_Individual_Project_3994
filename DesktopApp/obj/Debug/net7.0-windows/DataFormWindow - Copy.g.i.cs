﻿#pragma checksum "..\..\..\DataFormWindow - Copy.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "387A42B976B7C57566E02CEBA84DB41C111E069C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DesktopApp;
using DesktopApp.MVVM.View;
using DesktopApp.MVVM.ViewModel;
using FontAwesome.WPF;
using FontAwesome.WPF.Converters;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace DesktopApp {
    
    
    /// <summary>
    /// DataFormWindow
    /// </summary>
    public partial class DataFormWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\DataFormWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image MyImage;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\DataFormWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DesktopApp.MVVM.View.MyTextBox idInput;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\DataFormWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DesktopApp.MVVM.View.MyTextBox fnameInput;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\DataFormWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DesktopApp.MVVM.View.MyTextBox lnameInput;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\DataFormWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DesktopApp.MVVM.View.MyTextBox dobInput;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\DataFormWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DesktopApp.MVVM.View.MyTextBox yearInput;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\DataFormWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DesktopApp.MVVM.View.MyTextBox gpaInput;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\DataFormWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UploadButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DesktopApp;component/dataformwindow%20-%20copy.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DataFormWindow - Copy.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MyImage = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            
            #line 48 "..\..\..\DataFormWindow - Copy.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.idInput = ((DesktopApp.MVVM.View.MyTextBox)(target));
            return;
            case 4:
            this.fnameInput = ((DesktopApp.MVVM.View.MyTextBox)(target));
            return;
            case 5:
            this.lnameInput = ((DesktopApp.MVVM.View.MyTextBox)(target));
            return;
            case 6:
            this.dobInput = ((DesktopApp.MVVM.View.MyTextBox)(target));
            return;
            case 7:
            this.yearInput = ((DesktopApp.MVVM.View.MyTextBox)(target));
            return;
            case 8:
            this.gpaInput = ((DesktopApp.MVVM.View.MyTextBox)(target));
            return;
            case 9:
            this.UploadButton = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

