using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExInterface.Entidades.Servicos
{
    interface IServicoPagamentoOnline
    {
        double Juros(double quantia, int meses);
        double TaxaPagamento(double quantia);

    }
}
