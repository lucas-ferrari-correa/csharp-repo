using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteCsharp.Classes
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(int agencia, int numeroDaConta) : base(agencia, numeroDaConta) { }

        public override void AumentarLimites()
        {
            throw new NotImplementedException();
        }

        public override void ImplementacaoPix()
        {
            throw new NotImplementedException();
        }
    }
}
