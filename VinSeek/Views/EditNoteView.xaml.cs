﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace VinSeek.Views
{
    /// <summary>
    /// Interaction logic for EditNoteView.xaml
    /// </summary>
    public partial class EditNoteView : Window
    {
        public EditNoteView()
        {
            InitializeComponent();
        }
        public EditNoteView(string text, string info, string title)
        {
            InitializeComponent();

            InfoLabel.Content = info;
            TextEditor.AppendText(text);
            Title = title;
        }

        public new string ShowDialog()
        {
            base.ShowDialog();

            return new TextRange(TextEditor.Document.ContentStart, TextEditor.Document.ContentEnd).Text;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
