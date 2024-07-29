using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PluralSightLearning.RH
{
    public class Funcionario
    {
        public string primeiroNome;
        public string sobrenome;
        public string email;

        public int horasTrabalhadas;
        public double remuneracao;
        public double valorPorHora;

        public DateTime nascimento;

        const int minimoHorasTrabalhadasUnidade = 1;

        public TipoFuncionarios tipoFuncionarios;

        public static double impostoTaxa = 0.15;

        //Construtores Employee...
        public Funcionario(string primeiroNom, string sobrenom, string em, DateTime bd) : this(primeiroNom, sobrenom, em, bd, 0, TipoFuncionarios.Gerencia)
        {
        }
        public Funcionario(string primeiroNom, string sobrenom, string em, DateTime bd, double hora, TipoFuncionarios funcTipo)
        {
            primeiroNome = primeiroNom;
            sobrenome = sobrenom;
            email = em;
            nascimento = bd;
            valorPorHora = hora;
            tipoFuncionarios = funcTipo;
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
            double remuneracaoAntesImposto = 0.0;
            if (tipoFuncionarios == TipoFuncionarios.Gerencia)
            {
                Console.WriteLine($"Um extra foi adicionado ao pagamento porque {primeiroNome} é um gerente");
                remuneracaoAntesImposto = horasTrabalhadas * valorPorHora * 1.25;
            }
            else
            {
                remuneracaoAntesImposto = horasTrabalhadas * valorPorHora;
            }
            
            double quantiaImposto = remuneracaoAntesImposto * impostoTaxa;

            remuneracao = remuneracaoAntesImposto - quantiaImposto;
            
            Console.WriteLine($"{primeiroNome} {sobrenome}  recebeu uma remuneração de {remuneracao} por {horasTrabalhadas} hora(s) de trabalho.");

            if (resetHoras)
                horasTrabalhadas = 0;

            return remuneracao;
        }

        public int CalcularBonus(int bonus)
        {
            if (horasTrabalhadas > 10)
                bonus *= 2;

            Console.WriteLine($"O funcionário consegui um bonus de {bonus}");
            return bonus;
        }

        //public int CalcularBonusImposto (int bonus, ref int bonusImposto)
        //{
        //    if (horasTrabalhadas > 10)
        //        bonus *= 2;
        //    if(bonus >= 200)
        //    {
        //        bonusImposto = bonus / 10;
        //        bonus -= bonusImposto;
        //    }

        //    Console.WriteLine($"O funcionário consegui um bonus de {bonus} e o imposto do bonus é {bonusImposto}");
        //    return bonus;
        //}

        public void DetalhesFuncionario()
        {
            Console.WriteLine($"\nPrimeiro nome: \t{primeiroNome}\nSobrenome: \t{sobrenome}\nEmail: \t\t{email}\nNascimento: \t{nascimento.ToShortDateString()}\nTaxa imposto: \t{impostoTaxa}");
        }
        public int CalcularBonusImposto(int bonus, out int bonusImposto)
        {
            bonusImposto = 0;
            if (horasTrabalhadas > 10)
                bonus *= 2;
            if (bonus >= 200)
            {
                bonusImposto = bonus / 10;
                bonus -= bonusImposto;
            }

            Console.WriteLine($"O funcionário consegui um bonus de {bonus} e o imposto do bonus é {bonusImposto}");
            return bonus;
        }
        //public static void UsandoTipoCustom()
        //{
        //    List<string> list = new List<string>();
        //}

        public string ConverterJson() //Método para converte em Json.
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }
    }
}
