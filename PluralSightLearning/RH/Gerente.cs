namespace PluralSightLearning.RH
{
    internal class Gerente : Funcionario
    {
        public Gerente(string primeiroNome, string sobrenome, string email, DateTime dataNascimento, double valorPorHora) : base(primeiroNome, sobrenome, email, dataNascimento, valorPorHora)
        {
        }

        public void ParticiparReuniaoGerente()
        {
            Console.WriteLine($"{PrimeiroNome} vai participar de uma reunião. Qual a duração da reunião? (em horas)");
            var duracaoInput = Console.ReadLine();
            int duracao = int.Parse(duracaoInput);
            HorasTrabalhadas += duracao;
            Console.WriteLine($"Gerente {PrimeiroNome} {Sobrenome} está participando de uma reunião com duração prevista de {duracao} hora(s).");
        }
        public void ParticiparReuniaoGerente(int duracao)
        {
            Console.WriteLine($"{PrimeiroNome} vai participar de uma reunião com duração de {duracao} hora(s).");
            HorasTrabalhadas += duracao;
        }
        public override void DarBonus()
        {
            if (HorasTrabalhadas > 5)
            {
                Console.WriteLine($"Gerente {PrimeiroNome} {Sobrenome} recebeu um bonus de 500!");
            }
            else
            {
                Console.WriteLine($"Gerente {PrimeiroNome} {Sobrenome} recebeu um bonus de 250!");
            }
        }
    }
}