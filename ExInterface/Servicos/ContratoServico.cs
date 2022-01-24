using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExInterface.Entidades.Servicos
{
    class ContratoServico 
    {
        private IServicoPagamentoOnline _servicoPagamentoOnline;

        public ContratoServico(IServicoPagamentoOnline servicoPagamentoOnline)
        {
            _servicoPagamentoOnline = servicoPagamentoOnline;
        }

        public void ProcessarContrato(Contrato contrato, int meses)
        {
            contrato.Parcelas = new List<Parcelas>();

            //divisão do valor total pela quantidade de parcelas
            var valorParcela = contrato.ValorTotal / meses;

            for (int i = 1; i <= meses; i++)
            {
                //adicionando (i) mês em relação a data inicial.
                DateTime data = contrato.Data.AddMonths(i);

                var semTaxa = _servicoPagamentoOnline.Juros(valorParcela, i);

                var taxa = _servicoPagamentoOnline.TaxaPagamento(semTaxa);

                contrato.Parcelas.Add(new Parcelas(data, taxa));

            }
        }
    }
}

        