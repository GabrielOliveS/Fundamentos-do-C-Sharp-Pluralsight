using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralSightLearning
{
    public class Employee
    {
        public string primeiroNome;
        public string sobrenome;
        public string email;

        public int horasTrabalhadas;
        public double remuneracao;
        public double valorPorHora;

        public DateTime nascimento;

        const int minimoHorasTrabalhadasUnidade = 1;

        //Construtores Employee...
        public Employee(string primeiroNom, string sobrenom, string em, DateTime bd) : this(primeiroNom, sobrenom, em, bd, 0)
        {
        }
        public Employee(string primeiroNom, string sobrenom, string em, DateTime bd, double hora) 
        {
            primeiroNome = primeiroNom;
            sobrenome = sobrenom;
            email = em;
            nascimento = bd;
            valorPorHora = hora;
        }

        public void Trabalhar()
        {
            Trabalhar(minimoHorasTrabalhadasUnidade);
            //horasTrabalhadas++;
            //Console.WriteLine($"{primeiroNome} {sobrenome} trabalhou por {horasTrabalhadas} hora(s)!");
        }

        public void Trabalhar(int horas)
        {
            horasTrabalhadas += horas;
            Console.WriteLine($"{primeiroNome} {sobrenome} trabalhou por {horas} hora(s)!");
        }

        public double ReceberRemuneracao(bool resetHoras = true)
        {
            remuneracao = horasTrabalhadas * valorPorHora;
            Console.WriteLine($"{primeiroNome} {sobrenome}  recebeu uma remuneração de {remuneracao} por {horasTrabalhadas} hora(s) de trabalho.");

            if(resetHoras)
                horasTrabalhadas = 0;

            return remuneracao;
        }

        public void DetalhesFuncionario()
        {
            Console.WriteLine($"\nPrimeiro nome: \t{primeiroNome}\nSobrenome: \t{sobrenome}\nEmail: \t\t{email}\nNascimento: \t{nascimento.ToShortDateString()}\n");
        }
    }
}
