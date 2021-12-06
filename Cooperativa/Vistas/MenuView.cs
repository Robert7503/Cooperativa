using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cooperativa.Vistas
{
    public partial class MenuView : Syncfusion.Windows.Forms.Office2010Form
    {
        public MenuView()
        {
            InitializeComponent();
        }

        UsuariosView VistaUsuarios;
        TransaccionesClientesView VistaTransaccion;
        Detalles VistaDetalles;

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void VistaTransaccion_FormClosed(object sender, FormClosedEventArgs e)
        {
            VistaTransaccion = null;
        }

        private void toolStripTabItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

       

        private void UsuariostoolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (VistaUsuarios==null)
            {
                VistaUsuarios = new UsuariosView();
                VistaUsuarios.MdiParent = this;
                VistaUsuarios.FormClosed += Vista_FormClosed;             
                VistaUsuarios.Show();
            }
            else
            {
                VistaUsuarios.Activate();
            }
            
        }

        private void Vista_FormClosed(object sender, FormClosedEventArgs e)
        {
            VistaUsuarios = null;
        }

        private void MovimientotoolStripButton1_Click(object sender, EventArgs e)
        {
            if (VistaTransaccion == null)
            {
                VistaTransaccion = new TransaccionesClientesView();
                VistaTransaccion.MdiParent = this;
                VistaTransaccion.FormClosed += VistaTransaccion_FormClosed;
                VistaTransaccion.Show();
            }
            else
            {
                VistaTransaccion.Activate();
            }
        }

        private void DetallestoolStripButton1_Click(object sender, EventArgs e)
        {
            if (VistaDetalles == null)
            {
                VistaDetalles = new Detalles();
                VistaDetalles.MdiParent = this;
                VistaDetalles.FormClosed += VistaDetalles_FormClosed;
                VistaDetalles.Show();
            }
            else
            {
                VistaDetalles.Activate();
            }

        }

        private void VistaDetalles_FormClosed(object sender, FormClosedEventArgs e)
        {
            VistaDetalles = null;
        }
    }
}
