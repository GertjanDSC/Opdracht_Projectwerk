﻿#pragma checksum "..\..\..\..\Voertuig\VoertuigWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5FF4AA6167B68A520FD1CCC7EA460BA83C83D27F"
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
using WpfFleetManagement.Voertuig;


namespace WpfFleetManagement.Voertuig {
    
    
    /// <summary>
    /// VoertuigWindow
    /// </summary>
    public partial class VoertuigWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 79 "..\..\..\..\Voertuig\VoertuigWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FilterButton;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\Voertuig\VoertuigWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem TabVoegToe;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\Voertuig\VoertuigWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxGekozenBestuurder;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\..\Voertuig\VoertuigWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button VoegToeButton;
        
        #line default
        #line hidden
        
        
        #line 179 "..\..\..\..\Voertuig\VoertuigWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button WijzigButton;
        
        #line default
        #line hidden
        
        
        #line 190 "..\..\..\..\Voertuig\VoertuigWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button VerwijderButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.13.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfFleetManagement;V1.0.0.0;component/voertuig/voertuigwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Voertuig\VoertuigWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.13.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.FilterButton = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.TabVoegToe = ((System.Windows.Controls.TabItem)(target));
            return;
            case 3:
            this.TextBoxGekozenBestuurder = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            
            #line 100 "..\..\..\..\Voertuig\VoertuigWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.KiesBestuurderButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.VoegToeButton = ((System.Windows.Controls.Button)(target));
            
            #line 129 "..\..\..\..\Voertuig\VoertuigWindow.xaml"
            this.VoegToeButton.Click += new System.Windows.RoutedEventHandler(this.VoegToeButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.WijzigButton = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.VerwijderButton = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

