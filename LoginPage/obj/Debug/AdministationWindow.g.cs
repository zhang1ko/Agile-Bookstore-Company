﻿#pragma checksum "..\..\AdministationWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3963E337F784D5A41572FCF5334E866C7A94D16E"
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
    /// AdministrationWindow
    /// </summary>
    public partial class AdministrationWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\AdministationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl tabControl;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\AdministationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Category;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\AdministationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox categoriesComboBox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\AdministationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AdministationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ProductsDataGrid;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\AdministationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn ISBNColumn;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\AdministationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn titleColumn;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\AdministationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn authorColumn;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\AdministationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn priceColumn;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\AdministationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn qtyColumn;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\AdministationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn yearColumn;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\AdministationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn EditionColumn;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\AdministationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn PublisherColumn;
        
        #line default
        #line hidden
        
        
        #line 183 "..\..\AdministationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addButton;
        
        #line default
        #line hidden
        
        
        #line 185 "..\..\AdministationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editButton;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\AdministationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button removeButton;
        
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
            System.Uri resourceLocater = new System.Uri("/BookStoreGUI;component/administationwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdministationWindow.xaml"
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
            
            #line 8 "..\..\AdministationWindow.xaml"
            ((BookStoreGUI.AdministrationWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tabControl = ((System.Windows.Controls.TabControl)(target));
            return;
            case 3:
            this.Category = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.categoriesComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.LayoutRoot = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.ProductsDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 35 "..\..\AdministationWindow.xaml"
            this.ProductsDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ProductsDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ISBNColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 8:
            this.titleColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 9:
            this.authorColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 10:
            this.priceColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 11:
            this.qtyColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 12:
            this.yearColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 13:
            this.EditionColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 14:
            this.PublisherColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 15:
            this.addButton = ((System.Windows.Controls.Button)(target));
            
            #line 184 "..\..\AdministationWindow.xaml"
            this.addButton.Click += new System.Windows.RoutedEventHandler(this.addButton_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.editButton = ((System.Windows.Controls.Button)(target));
            
            #line 186 "..\..\AdministationWindow.xaml"
            this.editButton.Click += new System.Windows.RoutedEventHandler(this.editButton_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.removeButton = ((System.Windows.Controls.Button)(target));
            
            #line 188 "..\..\AdministationWindow.xaml"
            this.removeButton.Click += new System.Windows.RoutedEventHandler(this.removeButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

