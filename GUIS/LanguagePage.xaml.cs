﻿using System;
using System.Collections.Generic;
using System.Linq;
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

namespace GUIProj1
{
    /// <summary>
    /// Interaction logic for LanguagePage.xaml
    /// </summary>
    public partial class LanguagePage : Page
    {
        public LanguagePage()
        {
            InitializeComponent();
        }

        private void Image_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            CustomizableHome ch = new CustomizableHome();
            this.NavigationService.Navigate(ch);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CustomizableHome ch = new CustomizableHome();
            this.NavigationService.Navigate(ch);
        }
    }
}
