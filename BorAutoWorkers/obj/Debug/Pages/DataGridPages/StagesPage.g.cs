﻿#pragma checksum "..\..\..\..\Pages\DataGridPages\StagesPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FC2EE198C30F25A9890B45BB2D8491BD7520E179207CFC238AE299D52424883B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using BorAutoWorkers.Pages.DataGridPages;
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


namespace BorAutoWorkers.Pages.DataGridPages {
    
    
    /// <summary>
    /// StagesPage
    /// </summary>
    public partial class StagesPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 16 "..\..\..\..\Pages\DataGridPages\StagesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid stagesDG;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Pages\DataGridPages\StagesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Add;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Pages\DataGridPages\StagesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Ref;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Pages\DataGridPages\StagesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Del;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Pages\DataGridPages\StagesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox typeOfSearch;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Pages\DataGridPages\StagesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Pages\DataGridPages\StagesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Back;
        
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
            System.Uri resourceLocater = new System.Uri("/BorAutoWorkers;component/pages/datagridpages/stagespage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\DataGridPages\StagesPage.xaml"
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
            
            #line 9 "..\..\..\..\Pages\DataGridPages\StagesPage.xaml"
            ((BorAutoWorkers.Pages.DataGridPages.StagesPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.stagesDG = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.Btn_Add = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\Pages\DataGridPages\StagesPage.xaml"
            this.Btn_Add.Click += new System.Windows.RoutedEventHandler(this.Btn_Add_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Btn_Ref = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\Pages\DataGridPages\StagesPage.xaml"
            this.Btn_Ref.Click += new System.Windows.RoutedEventHandler(this.Btn_Ref_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Btn_Del = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\Pages\DataGridPages\StagesPage.xaml"
            this.Btn_Del.Click += new System.Windows.RoutedEventHandler(this.Btn_Del_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.typeOfSearch = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.searchBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\..\..\Pages\DataGridPages\StagesPage.xaml"
            this.searchBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Btn_Back = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\Pages\DataGridPages\StagesPage.xaml"
            this.Btn_Back.Click += new System.Windows.RoutedEventHandler(this.Btn_Back_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 3:
            
            #line 24 "..\..\..\..\Pages\DataGridPages\StagesPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Btn_Edit_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

