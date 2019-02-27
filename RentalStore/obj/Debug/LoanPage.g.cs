﻿#pragma checksum "..\..\LoanPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D66D0D2605E3F6B8241BD8EA21EFB9CDE87B6788"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using RentalStore;
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


namespace RentalStore {
    
    
    /// <summary>
    /// LoanPage
    /// </summary>
    public partial class LoanPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\LoanPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid loanGrid;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\LoanPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbxStock;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\LoanPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCreate;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\LoanPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnIncrease;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\LoanPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDecrease;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\LoanPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblkDays;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\LoanPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblkDescription;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\LoanPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblkTitle;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\LoanPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/RentalStore;component/loanpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LoanPage.xaml"
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
            
            #line 10 "..\..\LoanPage.xaml"
            ((RentalStore.LoanPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.loanGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.lbxStock = ((System.Windows.Controls.ListBox)(target));
            
            #line 17 "..\..\LoanPage.xaml"
            this.lbxStock.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lbxStock_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnCreate = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\LoanPage.xaml"
            this.btnCreate.Click += new System.Windows.RoutedEventHandler(this.btnCreate_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnIncrease = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\LoanPage.xaml"
            this.btnIncrease.Click += new System.Windows.RoutedEventHandler(this.btnIncrease_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnDecrease = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\LoanPage.xaml"
            this.btnDecrease.Click += new System.Windows.RoutedEventHandler(this.btnDecrease_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.tblkDays = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.tblkDescription = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.tblkTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\LoanPage.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.btnCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

