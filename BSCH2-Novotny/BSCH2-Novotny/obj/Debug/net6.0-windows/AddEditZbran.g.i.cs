﻿#pragma checksum "..\..\..\AddEditZbran.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5B7CEF22DD1825B0E8FE99B2601D9DA09617AC27"
//------------------------------------------------------------------------------
// <auto-generated>
//     Tento kód byl generován nástrojem.
//     Verze modulu runtime:4.0.30319.42000
//
//     Změny tohoto souboru mohou způsobit nesprávné chování a budou ztraceny,
//     dojde-li k novému generování kódu.
// </auto-generated>
//------------------------------------------------------------------------------

using BSCH2_Novotny;
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


namespace BSCH2_Novotny {
    
    
    /// <summary>
    /// AddEditZbran
    /// </summary>
    public partial class AddEditZbran : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\AddEditZbran.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tb_nazev;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\AddEditZbran.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Cb_vojak;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\AddEditZbran.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Cb_zbran;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\AddEditZbran.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Cb_munice;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\AddEditZbran.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_storno;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\AddEditZbran.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_OK;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BSCH2-Novotny;V1.0.0.0;component/addeditzbran.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddEditZbran.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Tb_nazev = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Cb_vojak = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.Cb_zbran = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.Cb_munice = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.Btn_storno = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\AddEditZbran.xaml"
            this.Btn_storno.Click += new System.Windows.RoutedEventHandler(this.Btn_storno_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Btn_OK = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\AddEditZbran.xaml"
            this.Btn_OK.Click += new System.Windows.RoutedEventHandler(this.Btn_OK_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

