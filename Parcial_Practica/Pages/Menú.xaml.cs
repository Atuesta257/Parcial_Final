using System;
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
using Parcial_Practica.Pages;

namespace Parcial_Practica.Pages
{
    /// <summary>
    /// Lógica de interacción para Menú.xaml
    /// </summary>
    public partial class Menú : Page
    {
        public Menú()
        {
            InitializeComponent();

            txtDescripcion.Text = "El más fuerte y resistente, capáz de hacer gran daño en combate cuerpo a cuerpo.";
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Inicio());
        }
        
        private void btnRight_Click(object sender, RoutedEventArgs e)
        {
            if (txtPersonaje.Content == "Clerigo")
            {
                    txtPersonaje.Content = "Guerrero";
                imgClase.Visibility = Visibility.Visible;
                imgClase2.Visibility = Visibility.Hidden;
                txtDescripcion.Text = "El más fuerte y resistente, capáz de hacer gran daño en combate cuerpo a cuerpo.";
            }
            else 
            {
                txtPersonaje.Content = "Mago";
                imgClase1.Visibility = Visibility.Visible;
                imgClase.Visibility = Visibility.Hidden;
                txtDescripcion.Text = "Experto en las artes místicas más poderosas para destruir a sus enemigos desde la lejania ";
            }
        }

        private void btnLeft_Click(object sender, RoutedEventArgs e)
        {
            if (txtPersonaje.Content == "Mago")
            {
                txtPersonaje.Content = "Guerrero";
                imgClase.Visibility = Visibility.Visible;
                imgClase1.Visibility = Visibility.Hidden;
                txtDescripcion.Text = "El más fuerte y resistente, capáz de hacer gran daño en combate cuerpo a cuerpo.";

            }
            else
            {
                txtPersonaje.Content = "Clerigo";
                imgClase2.Visibility = Visibility.Visible;
                imgClase.Visibility = Visibility.Hidden;
                txtDescripcion.Text = "Habíl en el uso de magias y capáz de atacar cuerpo a cuero, es el guerrero definitivo";
            }
        }
    }
}
