﻿#pragma checksum "..\..\..\HomePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5E95DC619A03A69F7509B200285C5FEC54B97E3F"
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
using WPFnotes;


namespace WPFnotes {
    
    
    /// <summary>
    /// HomePage
    /// </summary>
    public partial class HomePage : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgNotes;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateNote;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgPrompts;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreatePrompt;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgTags;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateTags;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPFnotes;component/homepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\HomePage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\HomePage.xaml"
            ((WPFnotes.HomePage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dgNotes = ((System.Windows.Controls.DataGrid)(target));
            
            #line 12 "..\..\..\HomePage.xaml"
            this.dgNotes.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgNotes_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CreateNote = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\HomePage.xaml"
            this.CreateNote.Click += new System.Windows.RoutedEventHandler(this.CreateNote_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dgPrompts = ((System.Windows.Controls.DataGrid)(target));
            
            #line 36 "..\..\..\HomePage.xaml"
            this.dgPrompts.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgPrompt_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CreatePrompt = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\HomePage.xaml"
            this.CreatePrompt.Click += new System.Windows.RoutedEventHandler(this.CreatePrompt_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.dgTags = ((System.Windows.Controls.DataGrid)(target));
            
            #line 55 "..\..\..\HomePage.xaml"
            this.dgTags.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgTags_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CreateTags = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\HomePage.xaml"
            this.CreateTags.Click += new System.Windows.RoutedEventHandler(this.CreateTags_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

