using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooperativa.Modelos.Entidades
{
    public class Detalles
    {
        public int IdCliente { get; set; }
        public int IdTransaccion{ get; set; }
        public string Tipo_Transaccion { get; set; }
        public decimal SaldoInical { get; set; }
        public decimal SaldoActual { get; set; }
    }
}
