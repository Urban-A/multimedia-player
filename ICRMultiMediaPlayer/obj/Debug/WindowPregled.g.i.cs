﻿#pragma checksum "..\..\WindowPregled.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C35631371F0F8D4D35BC05203D7736DD150D264B4E2EDABCC7C667F7B3CE4B99"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ICRMultiMediaPlayer;
using ICRMultiMediaPlayer.Properties;
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


namespace ICRMultiMediaPlayer {
    
    
    /// <summary>
    /// WindowPregled
    /// </summary>
    public partial class WindowPregled : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\WindowPregled.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button shraniMediaBtn;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\WindowPregled.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button zavrniMediaBtn;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\WindowPregled.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider pregledOcena;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\WindowPregled.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox pregledOpis;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\WindowPregled.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker pregledDatum;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\WindowPregled.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button slikaSelect;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\WindowPregled.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image pregledSlika;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\WindowPregled.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox pregledZvrst;
        
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
            System.Uri resourceLocater = new System.Uri("/ICRMultiMediaPlayer;component/windowpregled.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowPregled.xaml"
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
            this.shraniMediaBtn = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\WindowPregled.xaml"
            this.shraniMediaBtn.Click += new System.Windows.RoutedEventHandler(this.shraniMediaBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.zavrniMediaBtn = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\WindowPregled.xaml"
            this.zavrniMediaBtn.Click += new System.Windows.RoutedEventHandler(this.zavrniMediaBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.pregledOcena = ((System.Windows.Controls.Slider)(target));
            return;
            case 4:
            this.pregledOpis = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.pregledDatum = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.slikaSelect = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\WindowPregled.xaml"
            this.slikaSelect.Click += new System.Windows.RoutedEventHandler(this.slikaSelect_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.pregledSlika = ((System.Windows.Controls.Image)(target));
            return;
            case 8:
            this.pregledZvrst = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

