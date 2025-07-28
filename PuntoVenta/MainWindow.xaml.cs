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

namespace PuntoVenta
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Venta_Click(object sender, RoutedEventArgs e)
        {
            // Mostrar el TextBox y darle foco automáticamente
            CodigoTextBox.Visibility = Visibility.Visible;
            CodigoTextBox.Focus();
            CodigoTextBox.Text = string.Empty;
        }
    }
}
