using PluralSightLearning; //Utilizar o Using!
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int age = 23;

            //bool a = age == 23;
            //Console.WriteLine($"Age is 23? {a}");

            //bool b = age > 23;
            //Console.WriteLine($"Age is greater than 23? {b}");

            //bool c = age >= 18 && age <= 65;
            //Console.WriteLine("Age is between 18 and 65? " + c);
            // Trabalhando com "bools" e entendendo seu funcionamento acima.
            //----------------------------------------------------------------------------------

            //Console.WriteLine("Qual a sua idade?");
            //int idadeUser = int.Parse(Console.ReadLine());
            //if (idadeUser < 18)
            //{
            //    Console.WriteLine("Candidato muito novo!");
            //}
            //else if (idadeUser >= 65)
            //{
            //    Console.WriteLine("Desculpe, idade máxima exedida.");
            //}
            //else
            //{
            //    Console.WriteLine("Candiato valido");
            //}
            //Console.WriteLine("Agora para uma segunda confirmação. Qual a sua idade?");
            //int idadeSwitch = int.Parse(Console.ReadLine());
            //switch (idadeSwitch) 
            //{
            //    case >= 18 and <65:
            //        Console.WriteLine("Candiato valido");
            //        break;
            //    default:
            //        Console.WriteLine("Desculpe, idade inválida");
            //        break;
            //} Conhecendo "if" e "switch" e seus usos básicos acima.
            //-----------------------------------------------------------
            //Console.WriteLine("Insirira um valor numérico:");
            //int num = int.Parse(Console.ReadLine());
            //int i = 0;
            //while (i <= num)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //Console.WriteLine("Loop finalizado!");
            //Descobrindo o uso do while e criando um loop.
            //-----------------------------------------------------------------------
            //int i = 1;
            //do 
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i <= 10);
            //for (i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //} 
            //Vendo o basico de "do while" e "for".
            //-------------------------------------------------------------------
            //Console.WriteLine("O que vamos fazer hoje: ");
            //Console.WriteLine("1. Adicionar Funcionário");
            //Console.WriteLine("2. Atualizar Funcionário");
            //Console.WriteLine("3. Deletar Funcionário");
            //Console.WriteLine("99. Sair da aplicação.");
            //string ?userAction = Console.ReadLine();

            //while (userAction != "99")
            //{
            //    switch (userAction) 
            //    {
            //        case "1":
            //            Console.WriteLine("Adicionando Funcionário...");
            //            break;

            //        case "2":
            //            Console.WriteLine("Atulizando Funcionário...");
            //                break;
            //        case "3":
            //            Console.WriteLine("Deletando Funcionário...");
            //            break;
            //        default:
            //            Console.WriteLine("Valor invalido.");
            //                break;

            //    }
            //    userAction = Console.ReadLine();
            //}
            // Usando while e switch para montar um seletor de opção para seguir a aplicação.
            //----------------------------------------------------------------------------------------------------------
            //int amount = 1234;
            //int months = 12;
            //int bonus = 77;
            //int yearlyWage = Utilities.CalculateYearWage(amount, months, bonus);
            //Console.WriteLine($"Yearly wage: {yearlyWage}");
            //Utilizando metodos e evocando de outro arquivo.
            //----------------------------------------------------------------------------------------------------------
            //Utilities.ManipulatingStrings();
            //Utilities.UsingEscapeCharacters();
            //Utilities.UsingStringEquality();
            //Utilities.PartsingStrings();
            //Aprendendo a construir metodos e utilar strings e conversões
            //----------------------------------------------------------------------------------------------------------
            Console.WriteLine("Criando um novo funcionario");
            Console.WriteLine("-----------------------\n");

            var gabriel = new Employee("Gabriel", "De Olivera", "gabriel.oliv.silva@hotmail.com", new DateTime(2001, 09, 19), 25.25);

            gabriel.DetalhesFuncionario();

            gabriel.Trabalhar(5);
            gabriel.Trabalhar();

            double receberRemuneracaoGabriel = gabriel.ReceberRemuneracao(true);
            Console.WriteLine($"Remuneração recebida: {receberRemuneracaoGabriel}");

            var miguel = new Employee("Miguel", "De Oliveira", "miguel.oliv.silva@hotmail.com", new DateTime(2006, 3, 28), 10.75);

            miguel.DetalhesFuncionario();
            miguel.Trabalhar(3);
            miguel.Trabalhar();

            var receberRemuneracaoMiguel = miguel.ReceberRemuneracao(true);
            Console.WriteLine($"Remuneração recebida: {receberRemuneracaoMiguel}");

        }
    }
}
