using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralSightLearning.RH
{
    public class Endereco
    {
        private string rua;
        private string numeroCasa;
        private string cep;
        private string cidade;

        public Endereco(string rua, string numeroCasa, string cep, string cidade)
        {
            Rua = rua;
            NumeroCasa = numeroCasa;
            Cep = cep;
            Cidade = cidade;
        }  
        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }
        public string NumeroCasa
        {
            get { return numeroCasa; }
            set { numeroCasa = value; }
        }
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
    }
}
