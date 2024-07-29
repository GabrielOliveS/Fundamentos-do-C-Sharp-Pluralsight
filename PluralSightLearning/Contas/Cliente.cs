using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralSightLearning.Contas
{
    internal class Cliente
    {
        private string ?clienteId;
        private string ?clienteName;

        public string ClienteId { get { return clienteId; } set { clienteId = value; } }
        public string ClienteName { get { return clienteName; } set { clienteName = value; } }
    }
}
