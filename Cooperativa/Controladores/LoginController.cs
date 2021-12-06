using Cooperativa.Modelos.DAO_BD;
using Cooperativa.Modelos.Entidades;
using Cooperativa.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cooperativa.Controladores
{
    
    public class LoginController
    {
        LoginView vista;
        public LoginController(LoginView view)
        {
            vista = view;

            vista.btnAceptar.Click += new EventHandler(ValidarUsuario);
        }

        private void ValidarUsuario(object serder, EventArgs e)
        {
            bool esValido = false;

            UsuarioDAO userDao = new UsuarioDAO();

            Usuario user = new Usuario();

            user.Email = vista.txtEmail.Text;
            user.Clave = vista.txtContraseña.Text;

            esValido = userDao.ValidarUsuario(user);

            if (esValido)
            {
                MessageBox.Show("Usuario Correcto");
                MenuView menu = new MenuView();
                vista.Hide();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto");
            }
        }
    }
}
