using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExInterface.Entidades
{
    class Parcelas
    {
        public DateTime DataVencimento { get; set; }
        public double Quantia { get; set; }

        public Parcelas(DateTime dataVencimento, double quantia)
        {
            DataVencimento = dataVencimento;
            Quantia = quantia;
        }
        public override string ToString()
        {
            return DataVencimento.ToString("d") + " - " + Quantia.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
