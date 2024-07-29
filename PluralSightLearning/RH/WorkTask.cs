using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralSightLearning.RH
{
    internal struct WorkTask
    {
        public string descricao;
        public int horas;

        public void Trabalhar()
        {
            Console.WriteLine($"Tarefa {descricao} de {horas} horas foi realizada");
        }
    }
}
