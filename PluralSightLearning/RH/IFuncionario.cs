using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralSightLearning.RH
{
    internal interface IFuncionario
    {
        double ReceberRemuneracao(bool resetHoras = true);
        void DarBonus();
        void Trabalhar();
        void Trabalhar(int numeroDeHoras);
        void DetalhesFuncionario();
    }
}
