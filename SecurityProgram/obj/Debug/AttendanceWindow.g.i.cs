﻿#pragma checksum "..\..\AttendanceWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5F6B7C1351BC4B614D324DC9C437B98D9D9E789E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using SecurityProgram;
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


namespace SecurityProgram {
    
    
    /// <summary>
    /// AttendanceWindow
    /// </summary>
    public partial class AttendanceWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\AttendanceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SecurityProgram.AttendanceWindow attendanceWindow;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\AttendanceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker currentDate;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\AttendanceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataContainer;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\AttendanceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn first;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\AttendanceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridCheckBoxColumn checkBox;
        
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
            System.Uri resourceLocater = new System.Uri("/SecurityProgram;component/attendancewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AttendanceWindow.xaml"
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
            this.attendanceWindow = ((SecurityProgram.AttendanceWindow)(target));
            return;
            case 2:
            this.currentDate = ((System.Windows.Controls.DatePicker)(target));
            
            #line 27 "..\..\AttendanceWindow.xaml"
            this.currentDate.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DataContainer = ((System.Windows.Controls.DataGrid)(target));
            
            #line 28 "..\..\AttendanceWindow.xaml"
            this.DataContainer.CurrentCellChanged += new System.EventHandler<System.EventArgs>(this.DataContainerCurrentCellChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.first = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 5:
            this.checkBox = ((System.Windows.Controls.DataGridCheckBoxColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

