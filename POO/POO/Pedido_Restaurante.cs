using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Pedido_Restaurante
    {
        public int codigoPedido;
        public string nomeRestaurante;
        public string nomeCliente;
        public List<string> itensSolicitados = new List<string>();
        public List<float> valorItensSolicitados = new List<float>();
    }
}
