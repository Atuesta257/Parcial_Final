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
using Parcial_Practica.Interfaces;
using Parcial_Practica.Classes.Player;
using Parcial_Practica.Classes.Equipment;

namespace Parcial_Practica.Pages
{
    /// <summary>
    /// Lógica de interacción para Inicio.xaml
    /// </summary>
    public partial class Inicio : Page
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Menú());



            IDescribable i = new Knight();
        }
    }
}
