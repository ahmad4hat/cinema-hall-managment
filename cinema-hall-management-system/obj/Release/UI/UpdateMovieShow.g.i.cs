﻿#pragma checksum "..\..\..\UI\UpdateMovieShow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FFFC2432BEB6FB8DFDDBC5DF70395619A8EBC7BF010DE631B9B859487A607778"
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
    /// UpdateMovieShow
    /// </summary>
    public partial class UpdateMovieShow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\UI\UpdateMovieShow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMovieID;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\UI\UpdateMovieShow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCinemHallId;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\UI\UpdateMovieShow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox timeAmPmClock;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\UI\UpdateMovieShow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCapcity;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\UI\UpdateMovieShow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtTime;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\UI\UpdateMovieShow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMovieShow;
        
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
            System.Uri resourceLocater = new System.Uri("/cinema-hall-management-system;component/ui/updatemovieshow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\UpdateMovieShow.xaml"
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
            this.txtMovieID = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\..\UI\UpdateMovieShow.xaml"
            this.txtMovieID.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtMovieID_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtCinemHallId = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\..\UI\UpdateMovieShow.xaml"
            this.txtCinemHallId.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtCinemHallId_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.timeAmPmClock = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\..\UI\UpdateMovieShow.xaml"
            this.timeAmPmClock.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TimeAmPmClock_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtCapcity = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\..\UI\UpdateMovieShow.xaml"
            this.txtCapcity.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtCapcity_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dtTime = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.btnMovieShow = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\UI\UpdateMovieShow.xaml"
            this.btnMovieShow.Click += new System.Windows.RoutedEventHandler(this.BtnMovieShow_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
