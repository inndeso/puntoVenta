using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace PuntoVenta
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CargarProductosPapeleria();
        }

        private BitmapImage CargarImagen(string rutaRelativa)
        {
            var imagen = new BitmapImage();
            imagen.BeginInit();
            imagen.UriSource = new Uri(rutaRelativa, UriKind.RelativeOrAbsolute);
            imagen.DecodePixelWidth = 96; // Ajusta según necesidad
            imagen.CacheOption = BitmapCacheOption.OnLoad;
            imagen.CreateOptions = BitmapCacheOption.None;
            imagen.EndInit();
            imagen.Freeze(); // Opcional pero recomendado para mejor rendimiento
            return imagen;
        }

        private void CargarProductosPapeleria()
        {
            var productos = new List<Producto>
            {
                new Producto {
                    Nombre = "Lápiz HB",
                    Precio = 5.50m,
                    Codigo = "PAP-1001",
                    Imagen = CargarImagen("pack://application:,,,/Resources/tijeras.png")
                },
                new Producto {
                    Nombre = "Borrador Blanco",
                    Precio = 8.00m,
                    Codigo = "PAP-1002",
                    Imagen = CargarImagen("pack://application:,,,/Resources/borrador.png")
                },
                new Producto {
                    Nombre = "Cuaderno Profesional",
                    Precio = 45.90m,
                    Codigo = "PAP-1003",
                    Imagen = CargarImagen("pack://application:,,,/Resources/cuaderno.png")
                },
                new Producto {
                    Nombre = "Bolígrafo Azul",
                    Precio = 12.00m,
                    Codigo = "PAP-1004",
                    Imagen = CargarImagen("pack://application:,,,/Resources/boligrafo.png")
                },
                new Producto {
                    Nombre = "Resaltador Amarillo",
                    Precio = 15.75m,
                    Codigo = "PAP-1005",
                    Imagen = CargarImagen("pack://application:,,,/Resources/tijeras.png")
                },
                new Producto {
                    Nombre = "Tijeras Escolares",
                    Precio = 25.50m,
                    Codigo = "PAP-1006",
                    Imagen = CargarImagen("pack://application:,,,/Resources/tijeras.png")
                }
            };

            ListaProductos.ItemsSource = productos;
        }

        private void Venta_Click(object sender, RoutedEventArgs e)
        {
            VistaEscaneo.Visibility = Visibility.Visible;
            VistaProductos.Visibility = Visibility.Collapsed;
            CodigoTextBox.Focus();
        }

        private void Productos_Click(object sender, RoutedEventArgs e)
        {
            VistaEscaneo.Visibility = Visibility.Collapsed;
            VistaProductos.Visibility = Visibility.Visible;
        }

        private void CloseWindow(object sender, RoutedEventArgs e) => Close();
        private void MinimizeWindow(object sender, RoutedEventArgs e) => WindowState = WindowState.Minimized;

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }
    }
}