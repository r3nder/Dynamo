﻿#pragma checksum "Views\Core\NoteView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E2AB90534C279EA51452164E49362AB7F5726AF4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Dynamo.Wpf.Properties;
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


namespace Dynamo.Nodes {
    
    
    /// <summary>
    /// NoteView
    /// </summary>
    public partial class NoteView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "Views\Core\NoteView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid BaseGrid;
        
        #line default
        #line hidden
        
        
        #line 19 "Views\Core\NoteView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem deleteItem;
        
        #line default
        #line hidden
        
        
        #line 20 "Views\Core\NoteView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem editItem;
        
        #line default
        #line hidden
        
        
        #line 21 "Views\Core\NoteView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem createGroup_cm;
        
        #line default
        #line hidden
        
        
        #line 24 "Views\Core\NoteView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem addtoGroup;
        
        #line default
        #line hidden
        
        
        #line 27 "Views\Core\NoteView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem unGroup_cm;
        
        #line default
        #line hidden
        
        
        #line 72 "Views\Core\NoteView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock noteText;
        
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
            System.Uri resourceLocater = new System.Uri("/DynamoCoreWpf;component/views/core/noteview.xaml", System.UriKind.Relative);
            
            #line 1 "Views\Core\NoteView.xaml"
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
            
            #line 14 "Views\Core\NoteView.xaml"
            ((Dynamo.Nodes.NoteView)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnNoteMouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BaseGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.deleteItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 19 "Views\Core\NoteView.xaml"
            this.deleteItem.Click += new System.Windows.RoutedEventHandler(this.OnDeleteItemClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.editItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 20 "Views\Core\NoteView.xaml"
            this.editItem.Click += new System.Windows.RoutedEventHandler(this.OnEditItemClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.createGroup_cm = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 6:
            this.addtoGroup = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 7:
            this.unGroup_cm = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 8:
            this.noteText = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
