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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Udemy_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

           // resultLabel.Content = "14321";
        }

        private void sevenButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "7";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}7";
            }
        }

        private void acButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void negativeButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void percentButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void divideButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void eightButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void nineButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void fourButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void fiveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sixButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void subtractButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void oneButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void twoButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void threeButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void zeroButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void periodButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void equalsButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
