﻿#pragma checksum "..\..\AvailableBooks.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F576A71D6707B2A69238AD33ADEE9C78CCDE76A3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BookStoreGUI;
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


namespace BookStoreGUI {
    
    
    /// <summary>
    /// AvailableBooks
    /// </summary>
    public partial class AvailableBooks : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\AvailableBooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid AvailableBookView;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\AvailableBooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn titleColumn;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\AvailableBooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn authorColumn;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\AvailableBooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn priceColumn;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AvailableBooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn yearColumn;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\AvailableBooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addButton;
        
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
            System.Uri resourceLocater = new System.Uri("/BookStoreGUI;component/availablebooks.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AvailableBooks.xaml"
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
            this.AvailableBookView = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.titleColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 3:
            this.authorColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 4:
            this.priceColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 5:
            this.yearColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 6:
            this.addButton = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\AvailableBooks.xaml"
            this.addButton.Click += new System.Windows.RoutedEventHandler(this.addToOrder_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

