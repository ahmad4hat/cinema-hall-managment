﻿#pragma checksum "..\..\..\UI\MovieShows.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ECA32C0A0F714F21F5E70F77D88AB1D61FE95A47E27C477587B87C9297E4788F"
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
using cinema_hall_management_system.UI;


namespace cinema_hall_management_system.UI {
    
    
    /// <summary>
    /// MovieShows
    /// </summary>
    public partial class MovieShows : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\UI\MovieShows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView movieShowListList;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\UI\MovieShows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdate;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\UI\MovieShows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddMovieShows;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\UI\MovieShows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\UI\MovieShows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdated;
        
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
            System.Uri resourceLocater = new System.Uri("/cinema-hall-management-system;component/ui/movieshows.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\MovieShows.xaml"
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
            this.movieShowListList = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            this.btnUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\UI\MovieShows.xaml"
            this.btnUpdate.Click += new System.Windows.RoutedEventHandler(this.BtnRefresh_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnAddMovieShows = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\UI\MovieShows.xaml"
            this.btnAddMovieShows.Click += new System.Windows.RoutedEventHandler(this.BtnAddMovieShows_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\UI\MovieShows.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.BtnDelete_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnUpdated = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\UI\MovieShows.xaml"
            this.btnUpdated.Click += new System.Windows.RoutedEventHandler(this.BtnUpdated_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

