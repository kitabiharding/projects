﻿#pragma checksum "..\..\..\TextNote.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CEC60F3E5BE5C829EF68ED589657E687FCA01925"
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
    /// TextNote
    /// </summary>
    public partial class TextNote : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\TextNote.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbNameNote;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\TextNote.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbCreationDate;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\TextNote.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbTagsNote;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\TextNote.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbTextNote;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\TextNote.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NoteEdit;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\TextNote.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NoteDelete;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\TextNote.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NoteBack;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFnotes;component/textnote.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\TextNote.xaml"
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
            this.tbNameNote = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tbCreationDate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbTagsNote = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbTextNote = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.NoteEdit = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\TextNote.xaml"
            this.NoteEdit.Click += new System.Windows.RoutedEventHandler(this.NoteEdit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.NoteDelete = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\TextNote.xaml"
            this.NoteDelete.Click += new System.Windows.RoutedEventHandler(this.NoteDelete_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.NoteBack = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\TextNote.xaml"
            this.NoteBack.Click += new System.Windows.RoutedEventHandler(this.NoteBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

