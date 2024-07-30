using Newtonsoft.Json;

namespace PluralSightLearning.RH
{
    public class Funcionario: IFuncionario
    {
        private string primeiroNome;
        private string sobrenome;
        private string email;

        private int horasTrabalhadas;
        private double remuneracao;
        private double valorPorHora;

        private DateTime nascimento;
        private const int minimoHorasTrabalhadasUnidade = 1;
        private Endereco endereco;
        
        private static double impostoTaxa = 0.15;
        //---[Encapsulamento]---
        public string PrimeiroNome
        {
            get { return primeiroNome; }
            set { primeiroNome = value; }
        }
        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int HorasTrabalhadas
        {
            get { return horasTrabalhadas; } //get, permite que o valor seja consultado normalmente.
            protected set { horasTrabalhadas = value; } //private, impede que o valor seja alterado por fora da classe.
        }
        public double Remuneracao
        {
            get { return remuneracao; }
            private set { remuneracao = value; }
        }
        public double ValorPorHora
        {
            get { return valorPorHora; }
            set
            {
                if (valorPorHora < 0) //valor precisa ser maior que zero.
                { valorPorHora = 0; }
                else
                { valorPorHora = value; }
            }
        }
        public DateTime Nascimento
        {
            get { return nascimento; }
            set { nascimento = value; }
        }
        public static double ImpostoTaxa
        {
            get { return impostoTaxa; }
            set { impostoTaxa = value; }
        }
        public Endereco Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        //Construtores Funcionario...
        public Funcionario(string primeiroNome, string sobrenome, string email, DateTime dataNascimento) : this(primeiroNome, sobrenome, email, dataNascimento, 0)
        {
        }
        public Funcionario(string primeiroNome, string sobrenome, string email, DateTime dataNascimento, double valorPorHora)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
            Email = email;
            Nascimento = dataNascimento;
            ValorPorHora = valorPorHora;
        }
        public Funcionario(string primeiroNome, string sobrenome, string email, DateTime dataNascimento, double valorPorHora, string rua, string numeroCasa, string cep, string cidade)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
            Email = email;
            Nascimento = dataNascimento;
            ValorPorHora = valorPorHora;

            Endereco = new Endereco(rua, numeroCasa, cep, cidade);
        }

        public void Trabalhar()
        {
            Trabalhar(minimoHorasTrabalhadasUnidade);
            //horasTrabalhadas++;
            //Console.WriteLine($"{primeiroNome} {sobrenome} trabalhou por {horasTrabalhadas} hora(s)!");
        }

        public void Trabalhar(int horas)
        {
            HorasTrabalhadas += horas;
            Console.WriteLine($"{PrimeiroNome} {Sobrenome} trabalhou por {horas} hora(s)!");
        }

        public double ReceberRemuneracao(bool resetHoras = true)
        {
            double remuneracaoAntesImposto = HorasTrabalhadas * ValorPorHora;
            double impostoQuantia = remuneracaoAntesImposto * ImpostoTaxa;

            Remuneracao = remuneracaoAntesImposto - impostoQuantia;

            Console.WriteLine($"{PrimeiroNome} {Sobrenome} recebeu uma remuneração de {Remuneracao} por {HorasTrabalhadas} hora(s) de trabalho.");
            if (resetHoras)
                HorasTrabalhadas = 0;
            return Remuneracao;
        }

        public int CalcularBonus(int bonus)
        {
            if (HorasTrabalhadas > 10)
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

        public virtual void DetalhesFuncionario()
        {
            Console.WriteLine($"\nPrimeiro nome: \t{PrimeiroNome}\nSobrenome: \t{Sobrenome}\nEmail: \t\t{Email}\nNascimento: \t{Nascimento.ToShortDateString()}\nTaxa imposto: \t{ImpostoTaxa}");
        }
        public int CalcularBonusImposto(int bonus, out int bonusImposto)
        {
            bonusImposto = 0;
            if (HorasTrabalhadas > 10)
                bonus *= 2;
            if (bonus >= 200)
            {
                bonusImposto = bonus / 10;
                bonus -= bonusImposto;
            }

            Console.WriteLine($"O funcionário consegui um bonus de {bonus} e o imposto do bonus é {bonusImposto}");
            return bonus;
        }
        public virtual void DarBonus()
        {
            Console.WriteLine($"{PrimeiroNome} {Sobrenome} recebeu um bonus comum de 100!");
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
