// Updated by XamlIntelliSenseFileGenerator 16.05.2022 1:39:02
#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03B1C70341EEDE146B39F8A71CE936BFC29DD4A3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfApp3;


namespace WpfApp3
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 18 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button B1;

#line default
#line hidden


#line 19 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Text;

#line default
#line hidden


#line 20 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button plus;

#line default
#line hidden


#line 21 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button result;

#line default
#line hidden


#line 22 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button B2;

#line default
#line hidden


#line 23 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button B3;

#line default
#line hidden


#line 24 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button B4;

#line default
#line hidden


#line 25 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button B5;

#line default
#line hidden


#line 26 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button B6;

#line default
#line hidden


#line 27 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button B8;

#line default
#line hidden


#line 28 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button B9;

#line default
#line hidden


#line 29 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button B0;

#line default
#line hidden


#line 30 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button B7;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp3;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.B1 = ((System.Windows.Controls.Button)(target));

#line 18 "..\..\..\MainWindow.xaml"
                    this.B1.Click += new System.Windows.RoutedEventHandler(this.Add_digit);

#line default
#line hidden
                    return;
                case 2:
                    this.Text = ((System.Windows.Controls.Label)(target));
                    return;
                case 3:
                    this.plus = ((System.Windows.Controls.Button)(target));

#line 20 "..\..\..\MainWindow.xaml"
                    this.plus.Click += new System.Windows.RoutedEventHandler(this.sum_click);

#line default
#line hidden
                    return;
                case 4:
                    this.result = ((System.Windows.Controls.Button)(target));

#line 21 "..\..\..\MainWindow.xaml"
                    this.result.Click += new System.Windows.RoutedEventHandler(this.result_click);

#line default
#line hidden
                    return;
                case 5:
                    this.B2 = ((System.Windows.Controls.Button)(target));

#line 22 "..\..\..\MainWindow.xaml"
                    this.B2.Click += new System.Windows.RoutedEventHandler(this.Add_digit);

#line default
#line hidden
                    return;
                case 6:
                    this.B3 = ((System.Windows.Controls.Button)(target));

#line 23 "..\..\..\MainWindow.xaml"
                    this.B3.Click += new System.Windows.RoutedEventHandler(this.Add_digit);

#line default
#line hidden
                    return;
                case 7:
                    this.B4 = ((System.Windows.Controls.Button)(target));

#line 24 "..\..\..\MainWindow.xaml"
                    this.B4.Click += new System.Windows.RoutedEventHandler(this.Add_digit);

#line default
#line hidden
                    return;
                case 8:
                    this.B5 = ((System.Windows.Controls.Button)(target));

#line 25 "..\..\..\MainWindow.xaml"
                    this.B5.Click += new System.Windows.RoutedEventHandler(this.Add_digit);

#line default
#line hidden
                    return;
                case 9:
                    this.B6 = ((System.Windows.Controls.Button)(target));

#line 26 "..\..\..\MainWindow.xaml"
                    this.B6.Click += new System.Windows.RoutedEventHandler(this.Add_digit);

#line default
#line hidden
                    return;
                case 10:
                    this.B8 = ((System.Windows.Controls.Button)(target));

#line 27 "..\..\..\MainWindow.xaml"
                    this.B8.Click += new System.Windows.RoutedEventHandler(this.Add_digit);

#line default
#line hidden
                    return;
                case 11:
                    this.B9 = ((System.Windows.Controls.Button)(target));

#line 28 "..\..\..\MainWindow.xaml"
                    this.B9.Click += new System.Windows.RoutedEventHandler(this.Add_digit);

#line default
#line hidden
                    return;
                case 12:
                    this.B0 = ((System.Windows.Controls.Button)(target));

#line 29 "..\..\..\MainWindow.xaml"
                    this.B0.Click += new System.Windows.RoutedEventHandler(this.Add_digit);

#line default
#line hidden
                    return;
                case 13:
                    this.B7 = ((System.Windows.Controls.Button)(target));

#line 30 "..\..\..\MainWindow.xaml"
                    this.B7.Click += new System.Windows.RoutedEventHandler(this.Add_digit);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Button division;
    }
}
