﻿#pragma checksum "..\..\CreateAccountView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FC40F503DB7D223A372B0D8D487D059C01C706C1D6FE1B21DE926F5DC589DFFE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
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
using TucanPass;


namespace TucanPass {
    
    
    /// <summary>
    /// CreateAccountView
    /// </summary>
    public partial class CreateAccountView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\CreateAccountView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Gridek;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\CreateAccountView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox loginBox;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\CreateAccountView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox emailBox;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\CreateAccountView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordBox;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\CreateAccountView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox confirmPasswordBox;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\CreateAccountView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox publicKeyBox;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\CreateAccountView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox privateKeyBox;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\CreateAccountView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button registerBTN;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\CreateAccountView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button publicKeyBTN;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\CreateAccountView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button privateKeyBTN;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\CreateAccountView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle tipBackPlate;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\CreateAccountView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox toolTipText;
        
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
            System.Uri resourceLocater = new System.Uri("/TucanPass;component/createaccountview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CreateAccountView.xaml"
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
            this.Gridek = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.loginBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 55 "..\..\CreateAccountView.xaml"
            this.loginBox.LostFocus += new System.Windows.RoutedEventHandler(this.loginBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.emailBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.passwordBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.confirmPasswordBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.publicKeyBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.privateKeyBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.registerBTN = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.publicKeyBTN = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\CreateAccountView.xaml"
            this.publicKeyBTN.Click += new System.Windows.RoutedEventHandler(this.publicKeyBTN_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.privateKeyBTN = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\CreateAccountView.xaml"
            this.privateKeyBTN.Click += new System.Windows.RoutedEventHandler(this.privateKeyBTN_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.tipBackPlate = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 12:
            this.toolTipText = ((System.Windows.Controls.RichTextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

