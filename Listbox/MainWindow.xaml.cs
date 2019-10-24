﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Listbox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Color> Colores = new ObservableCollection<Color>();
        public MainWindow()
        {
            InitializeComponent();
            Colores.Add(new Color("Rojo", "#FF0000", "(255,0,0)"));
            Colores.Add(new Color("Verde", "#00FF00", "(0,255,0)"));
            Colores.Add(new Color("Azul", "#0000FF", "(0,0,255)"));
            lstColores.ItemsSource = Colores;

        }

        private void BtnNuevoColor_Click(object sender, RoutedEventArgs e)
        {
           Colores.Add(new Color(txtColor.Text, txtHexa.Text, txtRGB.Text) );
           txtColor.Text="";
            txtHexa.Text = "";
            txtRGB.Text="";

        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if(lstColores.SelectedIndex != -1)
            {
                Colores.RemoveAt(lstColores.SelectedIndex);
            }
        }

        private void LstColores_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtColor_Editar.Text = Colores[lstColores.SelectedIndex].Nombre;
        }

        private void BtnActualizar_Click(object sender, RoutedEventArgs e)
        {
            if(lstColores.SelectedIndex != -1)
            {
               
            }
        }
    }
}
