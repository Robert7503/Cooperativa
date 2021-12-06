using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooperativa.Modelos.Entidades
{
    public class Movimiento 
    {
        public int IdCliente { get; set; }
        public string Transaccion { get; set; }
        public string Moneda { get; set; }
        public decimal ValorTransaccion { get; set; }



    }
}
