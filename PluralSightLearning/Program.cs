using PluralSightLearning; //Utilizar o Using!
using System;
using System.Text;

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
            //Console.WriteLine("Criando um novo funcionario");
            //Console.WriteLine("-----------------------\n");

            //var gabriel = new Employee("Gabriel", "De Olivera", "gabriel.oliv.silva@hotmail.com", new DateTime(2001, 09, 19), 25.25);

            //gabriel.DetalhesFuncionario();

            //gabriel.Trabalhar(5);
            //gabriel.Trabalhar();

            //double receberRemuneracaoGabriel = gabriel.ReceberRemuneracao(true);
            //Console.WriteLine($"Remuneração recebida: {receberRemuneracaoGabriel}");

            //var miguel = new Employee("Miguel", "De Oliveira", "miguel.oliv.silva@hotmail.com", new DateTime(2006, 3, 28), 10.75, TipoFuncionarios.Gerencia);

            //miguel.DetalhesFuncionario();
            //miguel.Trabalhar(3);
            //miguel.Trabalhar();

            //var receberRemuneracaoMiguel = miguel.ReceberRemuneracao(true);
            //Console.WriteLine($"Remuneração recebida: {receberRemuneracaoMiguel}");
            // Criando Classes e Objetos, utilizando construtores para criar objetos e em seguida manipular diversos objetos.
            //-------------------------------------------------------------------------------------------------------------
            //int a = 42;
            //int aCopy = a;
            //Console.WriteLine($"Valor do \"a\" cópia: {aCopy} Valor do \"a\": {a}");
            //aCopy = 100;
            //Console.WriteLine($"Valor do \"a\" cópia: {aCopy} Valor do \"a\": {a}");
            //Employee testEmployee = miguel; --->//ambos apontando pro mesmo item, tipo de referencia, diferente o teste a cima.
            //testEmployee.primeiroNome = "Rafael";
            //testEmployee.DetalhesFuncionario(); 
            //miguel.DetalhesFuncionario();
            //----------------------------------------------------------------------------------------------------------------
            //miguel.Trabalhar(25);

            //int bonusMinimo = 100;
            //int bonusRecebido = miguel.CalcularBonus(bonusMinimo);
            //Console.WriteLine($"O bonus minimo é {bonusMinimo} e {miguel.primeiroNome} recebeu um bonus de {bonusRecebido}");

            //int bonusMinimo = 100;
            //int bonusImposto;  //---> Utilizando ref para altera o valor no metodo, em vez de valor que apenas faz uma cópia do método.
            //int receberBonus = miguel.CalcularBonusImposto(bonusMinimo, out bonusImposto);
            //Console.WriteLine($"O bonus minimo é {bonusMinimo}, o imposto é {bonusImposto} e {miguel.primeiroNome} recebeu um bonus de {receberBonus}");

            //string nome = "Gabriel";
            //string outroNome = nome; //<------ String é do tipo de refrência e imutavel.
            //nome += " Oliveira";
            //Console.WriteLine($"Nome: {nome} \tOutro nome: {outroNome}");

            //string maiusculoNome = nome.ToUpper();

            //Console.WriteLine("Nome: " + nome);
            //Console.WriteLine("Nome Maiusculo: " + maiusculoNome);

            //string indexs = string.Empty;

            //for (int i = 0; i < 2500; i++) 
            //{
            //    indexs += i.ToString();
            //}

            //string primeiroNome = "Gabriel";
            //string segundoNome = "Oliveira";

            //StringBuilder builder = new StringBuilder();

            //builder.Append("Segundo nome: ");
            //builder.AppendLine(segundoNome);
            //builder.Append("Primeiro nome: ");
            //builder.AppendLine(primeiroNome);
            //string result = builder.ToString();

            //StringBuilder builder2 = new StringBuilder();

            //for (int i = 0; i <= 2500; i++) 
            //{
            //    builder2.Append(i);
            //    builder2.Append(" ");
            //}
            //string lista = builder2.ToString();

            //Console.WriteLine(lista);
            //Console.WriteLine(result);
            // ---> Usando strings e o construtor de string do C# para manipular strings.

            //string miguelJson = miguel.ConverterJson();
            //Console.WriteLine(miguelJson); <--- Convertendo em Json usando um pacote criado por usuarios.
            //miguel.ReceberRemuneracao();

            //WorkTask tarefa; <--- criado a partir de um "struct".
            //tarefa.descricao = "Limpando escritório"; 
            //tarefa.horas = 3;
            //tarefa.Trabalhar();
        }   //----------------[Acima. Aprendendo a diferença das variaveis dos tipos de "referência" e "valor", Usando o construtor de Strings, trabalhando com tipos customizáveis, Criando enumerations e Structs.]------------------------------ 
    }
}
