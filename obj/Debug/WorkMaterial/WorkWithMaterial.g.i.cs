﻿#pragma checksum "..\..\..\WorkMaterial\WorkWithMaterial.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7DFCB18BAC1CC67FBEB3BBE3F80CD0FBAFA8792DF83613FFBD59FDD2600C55CB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using OrderFurniture.WorkMaterial;
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


namespace OrderFurniture.WorkMaterial {
    
    
    /// <summary>
    /// WorkWithMaterial
    /// </summary>
    public partial class WorkWithMaterial : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\WorkMaterial\WorkWithMaterial.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGridMaterial;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\WorkMaterial\WorkWithMaterial.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\WorkMaterial\WorkWithMaterial.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Remove;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\WorkMaterial\WorkWithMaterial.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Change;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\WorkMaterial\WorkWithMaterial.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxSearch;
        
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
            System.Uri resourceLocater = new System.Uri("/OrderFurniture;component/workmaterial/workwithmaterial.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WorkMaterial\WorkWithMaterial.xaml"
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
            
            #line 8 "..\..\..\WorkMaterial\WorkWithMaterial.xaml"
            ((OrderFurniture.WorkMaterial.WorkWithMaterial)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Window_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DGridMaterial = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            
            #line 21 "..\..\..\WorkMaterial\WorkWithMaterial.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BackButton);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Add = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\WorkMaterial\WorkWithMaterial.xaml"
            this.Add.Click += new System.Windows.RoutedEventHandler(this.AddMaterial);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Remove = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\WorkMaterial\WorkWithMaterial.xaml"
            this.Remove.Click += new System.Windows.RoutedEventHandler(this.BtnRemove);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Change = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\WorkMaterial\WorkWithMaterial.xaml"
            this.Change.Click += new System.Windows.RoutedEventHandler(this.BtnChange);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TBoxSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\..\WorkMaterial\WorkWithMaterial.xaml"
            this.TBoxSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 29 "..\..\..\WorkMaterial\WorkWithMaterial.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ExitProgramm);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 32 "..\..\..\WorkMaterial\WorkWithMaterial.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SverProgramm);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

