﻿#pragma checksum "..\..\Pandemic1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "510EC7B7ACBA8EEEA9E4B60514B02DB64FE4C0BFC86D0D6A9BD1CCD8DA77782D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using RusticSimulators;
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


namespace RusticSimulators {
    
    
    /// <summary>
    /// Pandemic1
    /// </summary>
    public partial class Pandemic1 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\Pandemic1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image virus;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\Pandemic1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image bacteria;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\Pandemic1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image hongo;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\Pandemic1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textNombre;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\Pandemic1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lbl1;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\Pandemic1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton aire;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\Pandemic1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton contacto;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\Pandemic1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton animales;
        
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
            System.Uri resourceLocater = new System.Uri("/RusticSimulators;component/pandemic1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Pandemic1.xaml"
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
            
            #line 35 "..\..\Pandemic1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.virus = ((System.Windows.Controls.Image)(target));
            
            #line 38 "..\..\Pandemic1.xaml"
            this.virus.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.virus_MouseLeftButtonDown_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.bacteria = ((System.Windows.Controls.Image)(target));
            
            #line 51 "..\..\Pandemic1.xaml"
            this.bacteria.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.bacteria_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.hongo = ((System.Windows.Controls.Image)(target));
            
            #line 64 "..\..\Pandemic1.xaml"
            this.hongo.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.hongo_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.textNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.lbl1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.aire = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 8:
            this.contacto = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 9:
            this.animales = ((System.Windows.Controls.RadioButton)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

