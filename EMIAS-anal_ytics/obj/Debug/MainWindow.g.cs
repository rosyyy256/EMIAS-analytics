﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0CAC387EEFF85A03050AEF5530687494D379D7F34E854B1B88512449444CC7BB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using EMIAS_anal_ytics;
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


namespace EMIAS_anal_ytics {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 126 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FilePath;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OverviewButton;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StartButton;
        
        #line default
        #line hidden
        
        
        #line 171 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PreviousDateButton;
        
        #line default
        #line hidden
        
        
        #line 180 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Date;
        
        #line default
        #line hidden
        
        
        #line 188 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NextDateButton;
        
        #line default
        #line hidden
        
        
        #line 199 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox SemdList;
        
        #line default
        #line hidden
        
        
        #line 214 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackButton;
        
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
            System.Uri resourceLocater = new System.Uri("/EMIAS_anal_ytics;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.FilePath = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.OverviewButton = ((System.Windows.Controls.Button)(target));
            
            #line 141 "..\..\MainWindow.xaml"
            this.OverviewButton.Click += new System.Windows.RoutedEventHandler(this.OverviewButtonClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.StartButton = ((System.Windows.Controls.Button)(target));
            
            #line 152 "..\..\MainWindow.xaml"
            this.StartButton.Click += new System.Windows.RoutedEventHandler(this.StartButtonClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PreviousDateButton = ((System.Windows.Controls.Button)(target));
            
            #line 172 "..\..\MainWindow.xaml"
            this.PreviousDateButton.Click += new System.Windows.RoutedEventHandler(this.SwitchToPreviousDate);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Date = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.NextDateButton = ((System.Windows.Controls.Button)(target));
            
            #line 189 "..\..\MainWindow.xaml"
            this.NextDateButton.Click += new System.Windows.RoutedEventHandler(this.SwitchToNextDate);
            
            #line default
            #line hidden
            return;
            case 7:
            this.SemdList = ((System.Windows.Controls.ListBox)(target));
            
            #line 203 "..\..\MainWindow.xaml"
            this.SemdList.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.PrintDoctorsList);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BackButton = ((System.Windows.Controls.Button)(target));
            
            #line 215 "..\..\MainWindow.xaml"
            this.BackButton.Click += new System.Windows.RoutedEventHandler(this.Back);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

