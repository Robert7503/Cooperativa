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
    public class MovimientoController
    {
        TransaccionesClientesView vista;
        MovimientosDAO movimientoDAO = new MovimientosDAO();
        Movimiento movimiento = new Movimiento();
        string operacion = string.Empty;

        public MovimientoController(TransaccionesClientesView view )
        {
            vista = view;
            vista.btnRealizarT.Click += new EventHandler(Insertar);
            vista.btnNuevoT.Click += new EventHandler(Nuevo);
            vista.btnSalirT.Click += new EventHandler(Salir);

        }

        private void Salir(object sender, EventArgs e)
        {

            vista.Close();
            
            operacion = "Salir";
        }
        private void Nuevo(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }

        private void Insertar(object sender, EventArgs e)
        {
            if (vista.txtTransaccionT.Text == "")
            {
                vista.errorProvider1.SetError(vista.txtTransaccionT, "Ingrese ElTipo de Transaccion a Realizar");
                vista.txtTransaccionT.Focus();
                return;
            }
            if (vista.txtMonedaT.Text != "LPS")
            {
                vista.errorProvider1.SetError(vista.txtMonedaT, "MODENA DE TRANSACCION LPS");
                vista.txtMonedaT.Focus();
                return;
            }
            if (vista.txtCantidadT.Text == "")
            {
                vista.errorProvider1.SetError(vista.txtCantidadT, "Ingrese un Valora Realizar");
                vista.txtCantidadT.Focus();
                return;
            }

            movimiento.IdCliente =Convert.ToInt32(vista.txtClienteIdT.Text);
            movimiento.Transaccion = vista.txtTransaccionT.Text.ToUpper();
            movimiento.Moneda = vista.txtMonedaT.Text.ToUpper();
            movimiento.ValorTransaccion = Convert.ToDecimal(vista.txtCantidadT.Text);
            if (operacion == "Insertar")
            {
                bool inserto = movimientoDAO.InsertarNuevaTransaccion(movimiento);
                if (inserto)
                {
                    MessageBox.Show("Movimiento Realizado","Atencion",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Movimiento Realizado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DeshabilitarControles();
            }
            
            
        }
        private void HabilitarControles()
        {
            vista.txtClienteIdT.Clear();
            vista.txtTransaccionT.Clear();
            vista.txtMonedaT.Clear();
            vista.txtCantidadT.Clear();


            vista.txtClienteIdT.Enabled = true;
            vista.txtTransaccionT.Enabled = true;
            vista.txtCantidadT.Enabled = true;
            vista.txtMonedaT.Enabled = true;

            vista.txtTransaccionT.Focus();

        }
        private void DeshabilitarControles()
        {
            vista.txtClienteIdT.Enabled = false;
            vista.txtTransaccionT.Enabled = false;
            vista.txtCantidadT.Enabled = false;
            vista.txtMonedaT.Enabled = false;

            vista.btnNuevoT.Enabled = true;

        }
    }
}
