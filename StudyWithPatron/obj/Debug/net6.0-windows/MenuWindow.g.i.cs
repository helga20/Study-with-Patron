﻿#pragma checksum "..\..\..\MenuWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D9594997F4E06548C0156AAFB6E3EA8020ECEB7B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using StudyWithPatron;
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


namespace StudyWithPatron {
    
    
    /// <summary>
    /// MenuWindow
    /// </summary>
    public partial class MenuWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sum_diff;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button mul_div;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saper;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exit_menu;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\..\MenuWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/StudyWithPatron;V1.0.0.0;component/menuwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MenuWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.sum_diff = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\MenuWindow.xaml"
            this.sum_diff.Click += new System.Windows.RoutedEventHandler(this.Sum_Diff_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.mul_div = ((System.Windows.Controls.Button)(target));
            
            #line 88 "..\..\..\MenuWindow.xaml"
            this.mul_div.Click += new System.Windows.RoutedEventHandler(this.Mul_Div_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.saper = ((System.Windows.Controls.Button)(target));
            
            #line 126 "..\..\..\MenuWindow.xaml"
            this.saper.Click += new System.Windows.RoutedEventHandler(this.Saper_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.exit_menu = ((System.Windows.Controls.Button)(target));
            
            #line 161 "..\..\..\MenuWindow.xaml"
            this.exit_menu.Click += new System.Windows.RoutedEventHandler(this.Exit_Menu_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.back = ((System.Windows.Controls.Button)(target));
            
            #line 197 "..\..\..\MenuWindow.xaml"
            this.back.Click += new System.Windows.RoutedEventHandler(this.Back_Menu_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

