using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExInterface.Entidades.Servicos
{
    class ServicoPaypal : IServicoPagamentoOnline
    {
        
        public double Juros(double quantia, int meses)
        {

            double porcentagem = 0.01 * quantia;

            double juros = quantia + (porcentagem * meses);

            return juros;

        }
        public double TaxaPagamento(double quantia)
        {
            return  quantia + ((double) 2 / 100 * quantia);
        }
    }
}
