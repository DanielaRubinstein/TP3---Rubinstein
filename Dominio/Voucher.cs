using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Voucher
    {
        public Int64 ID { get; set; }
        public string CodigoVoucher { get; set; }
        public bool Estado { get; set; }
        public Int64 IdCliente { get; set; }
        public Int64 IdProducto { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
