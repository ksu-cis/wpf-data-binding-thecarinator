﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UniversityRegistry.UI
{
    /// <summary>
    /// Interaction logic for RegistryList.xaml
    /// </summary>
    public partial class PersonList : UserControl
    {
        public event SelectionChangedEventHandler SelectionChanged;
        public PersonList()
        {
            InitializeComponent();
        }
        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectionChanged?.Invoke(this, e);
        }
    }
}
