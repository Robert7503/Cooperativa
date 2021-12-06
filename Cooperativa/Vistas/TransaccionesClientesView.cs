using Cooperativa.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cooperativa.Vistas
{
    public partial class TransaccionesClientesView : Form
    {
        public TransaccionesClientesView()
        {
            InitializeComponent();
            MovimientoController controlador = new MovimientoController(this);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
