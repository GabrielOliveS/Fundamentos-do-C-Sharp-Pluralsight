using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralSightLearning.RH
{
    internal class Desenvolvedor : Funcionario
    {
        private string projetoAtual;

        public string ProjetoAtual
        {
            get { return projetoAtual; }
            set { projetoAtual = value; }
        }
        public Desenvolvedor(string primeiroNome, string sobrenome, string email, DateTime dataNascimento, double valorPorHora, string projeto) : base(primeiroNome, sobrenome, email, dataNascimento, valorPorHora)
        {
            ProjetoAtual = projeto;
        }
        public Desenvolvedor(string primeiroNome, string sobrenome, string email, DateTime dataNascimento, double valorPorHora) : base(primeiroNome, sobrenome, email, dataNascimento, valorPorHora)
        {
        }
        public override void DetalhesFuncionario()
        {
            Console.WriteLine($"\nProjeto atual: \t{ProjetoAtual}\nPrimeiro nome: \t{PrimeiroNome}\nSobrenome: \t{Sobrenome}\nEmail: \t\t{Email}\nNascimento: \t{Nascimento.ToShortDateString()}\nTaxa imposto: \t{ImpostoTaxa}");
        }
    }
}
