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
    public class UsuarioController
    {
        UsuariosView vista;
        String operacion = string.Empty;

        UsuarioDAO userDAO = new UsuarioDAO();
        Usuario user = new Usuario();
        public UsuarioController(UsuariosView view)
        {
            vista = view;
            vista.btnNuevoUsuario.Click += new EventHandler(Nuevo);
            vista.btnGuardarUsuario.Click += new EventHandler(Guardar);
            vista.Load += new EventHandler(Load);
            vista.btnUsuarioModificar.Click += new EventHandler(Modificar);
            vista.btnEliminarUsuario.Click += new EventHandler(Eliminar);

        }

        private void Nuevo(object serder, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }

        private void Modificar(object serder, EventArgs e)
        {
            operacion = "Modificar";

            if (vista.UsuariodataGridView1.SelectedRows.Count > 0)
            {
                vista.txtUsuarioID.Text = vista.UsuariodataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                vista.txtUsuarioNombre.Text = vista.UsuariodataGridView1.CurrentRow.Cells["NOMBRE"].Value.ToString();
                vista.txtUsuarioEMAIL.Text = vista.UsuariodataGridView1.CurrentRow.Cells["EMAIL"].Value.ToString();
                vista.txtUsuarioCLAVE.Text = vista.UsuariodataGridView1.CurrentRow.Cells["CLAVE"].Value.ToString();
                vista.cboxAdmin.Checked = Convert.ToBoolean(vista.UsuariodataGridView1.CurrentRow.Cells["ESADMINISTRADOR"].Value);
                HabilitarControles();

            }
        }

        private void Eliminar(object serder, EventArgs e)
        {
            if (vista.UsuariodataGridView1.SelectedRows.Count > 0)
            {
                bool elimino = userDAO.EliminarUsuario(Convert.ToInt32(vista.UsuariodataGridView1.CurrentRow.Cells[0].Value.ToString()));
                if (elimino)
                {
                    DeshabilitarControles();
                    LimpiarControles();

                    MessageBox.Show("Usuario Eliminado", "Atencion", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ListarUsuarios();
                }
                
            }
        }

        private void Load(object serder, EventArgs e)
        {
            ListarUsuarios();
        }

        private void Guardar(object serder, EventArgs e)
        {
            if(vista.txtUsuarioNombre.Text == "")
            {
                vista.errorProvider1.SetError(vista.txtUsuarioNombre, "Ingrese un Nombre.");
                vista.txtUsuarioNombre.Focus();
                return;
            }
            if (vista.txtUsuarioEMAIL.Text == "")
            {
                vista.errorProvider1.SetError(vista.txtUsuarioEMAIL, "Ingrese un Email");
                vista.txtUsuarioEMAIL.Focus();
                return;
            }
            if (vista.txtUsuarioCLAVE.Text == "")
            {
                vista.errorProvider1.SetError(vista.txtUsuarioCLAVE, "Ingrese una Clave");
                vista.txtUsuarioCLAVE.Focus();
                return;
            }

            
            user.Nombre = vista.txtUsuarioNombre.Text;
            user.Email = vista.txtUsuarioEMAIL.Text;
            user.Clave = vista.txtUsuarioCLAVE.Text;
            user.EsAdministrador = vista.cboxAdmin.Checked;

            if (operacion=="Nuevo")
            {
                bool inserto = userDAO.InsertarNuevoUsuario(user);

                if (inserto)
                {
                    DeshabilitarControles();
                    LimpiarControles();

                    MessageBox.Show("Usuario Ingresado Correctamente", "Atencion", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ListarUsuarios();

                }
                else
                {
                    MessageBox.Show("Error de Ingreso", "Atencion", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }
            else if (operacion=="Modificar")
            {
                user.Id = Convert.ToInt32(vista.txtUsuarioID.Text);
                bool modifico = userDAO.ActualizarUsuario(user);
                if (modifico)
                {
                    MessageBox.Show("Usuario Modificado", "Atencion", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("Error de Ingreso", "Atencion", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
               
            }
            

            

        }

        private void ListarUsuarios()
        {
            vista.UsuariodataGridView1.DataSource = userDAO.GetUsuarios();
        }

        private void LimpiarControles()
        {
            vista.txtUsuarioID.Clear();
            vista.txtUsuarioNombre.Clear();
            vista.txtUsuarioEMAIL.Clear();
            vista.txtUsuarioCLAVE.Clear();
            vista.cboxAdmin.Enabled = false;
        }

        private void HabilitarControles()
        {
            vista.txtUsuarioID.Enabled = true;
            vista.txtUsuarioNombre.Enabled = true;
            vista.txtUsuarioEMAIL.Enabled = true;  
            vista.txtUsuarioCLAVE.Enabled = true;
            vista.cboxAdmin.Enabled = true;

            vista.btnGuardarUsuario.Enabled = true;
            vista.btnUsuarioCancelar.Enabled = true;
            vista.btnUsuarioModificar.Enabled = false;
            vista.btnNuevoUsuario.Enabled = false;

        }


        private void DeshabilitarControles()
        {
            vista.txtUsuarioID.Enabled = false;
            vista.txtUsuarioNombre.Enabled = false;
            vista.txtUsuarioEMAIL.Enabled = false;
            vista.txtUsuarioCLAVE.Enabled = false;
            vista.cboxAdmin.Enabled = false;

            vista.btnGuardarUsuario.Enabled = false;
            vista.btnUsuarioCancelar.Enabled = false;
            vista.btnUsuarioModificar.Enabled = true;
            vista.btnNuevoUsuario.Enabled = true;

        }
    }
}
