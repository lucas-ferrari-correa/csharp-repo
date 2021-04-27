using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{
    class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
        internal protected override double GetBonificacao()
        {
            return Salario * 0.5;
        }
    }
}
