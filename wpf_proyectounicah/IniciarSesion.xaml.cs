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

namespace wpf_proyectounicah
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class IniciarSesion : Window
    {
        //Objeto de tipo usuario para implementar su funcionalidad
        private Usuario usuario = new Usuario();
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Implementar la busqueda del usuario  desde la clase Usuario
                Usuario elUsuario = usuario.BuscarUsuario(txtUsername.Text);

                //Verficar si el usuario existe
                if (elUsuario.Username == null)
                {
                    MessageBox.Show("El usuario o la contraseña son incorrectos. Favor verificar");
                }
                else
                {
                    //Verificar que la contraseña ingresada es igual  a la contraseña
                    //almacenada en la base de datos

                    if (elUsuario.Password == pwbPassword.Password)
                    {
                        MessageBox.Show("¡Bienvenido al sistema de reservaciones!");
                    }
                    else 
                    {
                        MessageBox.Show("El usuario o la contraseña son incorrectos. Favor verificar");
                    }
                }
            }
            catch (Exception ex)
            {

                //MessageBox.Show("Ha ocurrido un error la momento de realizar la consulta...");
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }


        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
