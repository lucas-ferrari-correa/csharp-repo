using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteCsharp.Classes
{
    public abstract class ContaBancaria
    {
        public int Agencia { get; }
        public int NumeroDaConta { get; }

        public ContaBancaria(int agencia, int numeroDaConta)
        {
            Agencia = agencia;
            NumeroDaConta = numeroDaConta;
        }

        public abstract void AumentarLimites();

        public abstract void ImplementacaoPix();
    }
}
