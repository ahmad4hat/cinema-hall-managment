﻿#pragma checksum "..\..\..\UI\UserResgister.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "960C6ECAC81DFF0F7BA5D5D23CF75B68FC8AEA31"
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
    /// UserResgister
    /// </summary>
    public partial class UserResgister : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\UI\UserResgister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox emailTextbox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\UI\UserResgister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordBox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\UI\UserResgister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameTextbox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\UI\UserResgister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox addressTextbox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\UI\UserResgister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePickerDOB;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\UI\UserResgister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox genderSelector;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\UI\UserResgister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button registerButton;
        
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
            System.Uri resourceLocater = new System.Uri("/cinema-hall-management-system;component/ui/userresgister.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\UserResgister.xaml"
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
            this.emailTextbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\..\UI\UserResgister.xaml"
            this.emailTextbox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.EmailTextbox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.passwordBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.nameTextbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\..\UI\UserResgister.xaml"
            this.nameTextbox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.NameTextbox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.addressTextbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\..\UI\UserResgister.xaml"
            this.addressTextbox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.AddressTextbox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.datePickerDOB = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.genderSelector = ((System.Windows.Controls.ComboBox)(target));
            
            #line 24 "..\..\..\UI\UserResgister.xaml"
            this.genderSelector.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.registerButton = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\UI\UserResgister.xaml"
            this.registerButton.Click += new System.Windows.RoutedEventHandler(this.RegisterButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

