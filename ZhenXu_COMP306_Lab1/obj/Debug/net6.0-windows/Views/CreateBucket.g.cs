﻿#pragma checksum "..\..\..\..\Views\CreateBucket.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48904FC1186619A6F7A386EA9E5D906D11E6CB80"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using ZhenXu_COMP306_Lab1.Views;


namespace ZhenXu_COMP306_Lab1.Views {
    
    
    /// <summary>
    /// CreateBucket
    /// </summary>
    public partial class CreateBucket : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\Views\CreateBucket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBucketName;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Views\CreateBucket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid bucketDataGrid;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Views\CreateBucket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn bucketColumn;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Views\CreateBucket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn dateColumn;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Views\CreateBucket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblWarning;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ZhenXu_COMP306_Lab1;component/views/createbucket.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\CreateBucket.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 7 "..\..\..\..\Views\CreateBucket.xaml"
            ((ZhenXu_COMP306_Lab1.Views.CreateBucket)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtBucketName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 37 "..\..\..\..\Views\CreateBucket.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Create_Bucket);
            
            #line default
            #line hidden
            return;
            case 4:
            this.bucketDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.bucketColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 6:
            this.dateColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 7:
            
            #line 61 "..\..\..\..\Views\CreateBucket.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Back_to_Main);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lblWarning = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

