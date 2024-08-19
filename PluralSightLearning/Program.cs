using PluralSightLearning.RH;

namespace PluralSightLearning
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
            //----------------[Acima. Aprendendo a diferença das variaveis dos tipos de "referência" e "valor", Usando o construtor de Strings, trabalhando com tipos customizáveis, Criando enumerations e Structs.]------------------------------
            //PluralSightLearning.Contas.Cliente cliente = new PluralSightLearning.Contas.Cliente(); <--- Quando não se usa o "Using" é preciso declarar a classe com namespace completamente.

            #region Usando region para falicitar a visibildiade do códgio.
            //var miguel = new Funcionario("Miguel", "De Oliveira", "miguel.oliv.silva@hotmail.com", new DateTime(2006, 3, 28), 10.75, TipoFuncionarios.Gerencia);

            //miguel.DetalhesFuncionario();
            //miguel.Trabalhar(3);
            //miguel.Trabalhar(11);
            //miguel.ReceberRemuneracao();

            //Funcionario.impostoTaxa = 0.02; <-- Para alterar um valor statico declarado na classe, é preciso acessar a classe diretamente.

            //miguel.DetalhesFuncionario();
            //miguel.Trabalhar(3);
            //miguel.Trabalhar(11);
            //miguel.ReceberRemuneracao();
            #endregion

            //Conta conta = new Conta("123444");
            // conta.NumeroConta = "2"; <--- Valores de Record não podem ser alterados depois de inicizalizados.
            //---[Acima. Entendendo o funcionamento de Namespaces, classes staticas e usando a classe "record".]-----------------------------------------------------------------------------------------------------------------------------------

            //int[] amostraArrey = new int[5];
            //int[] amostraArrey2 = new int[] {1, 2, 3, 4, 5};
            ////int[] amostraArrey3 = new int[6] {1, 2, 3, 4, 5};
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            // Console.WriteLine("Quantos IDs de funcionários você quer registrar?");

            // int tamanho = int.Parse(Console.ReadLine());

            // int[] funcionariosIds = new int[tamanho];

            // var testeId = funcionariosIds[0];
            // //var erroId = funcionariosIds[tamanho]; <--- arrays começam por 0, então o numero de elementos vai gerar comflito.
            // for (int i = 0; i < tamanho; i++)
            // {
            //     Console.WriteLine("Escreva o ID do funcionário: ");
            //     int id = int.Parse(Console.ReadLine());
            //     funcionariosIds[i] = id; 
            // }

            // for (int i = 0; i < funcionariosIds.Length; i++)
            //{
            //    Console.WriteLine($"ID {i + 1}: \t{funcionariosIds[i]}");
            //}

            // Array.Sort(funcionariosIds);
            // Console.WriteLine("Após organizar por ordem numérica: ");
            // for (int i = 0; i < funcionariosIds.Length; i++)
            // {
            //     Console.WriteLine($"ID {i + 1}: \t{funcionariosIds[i]}");
            // }

            // int[] funcionarioIdCopia = new int[tamanho];

            // funcionariosIds.CopyTo(funcionarioIdCopia, 0);

            // Array.Reverse(funcionariosIds);

            // Console.WriteLine("Após inverter arrey original: ");
            // for (int i = 0; i < funcionariosIds.Length; i++)
            // {
            //     Console.WriteLine($"ID {i + 1}: \t{funcionariosIds[i]}");
            // }

            // Console.WriteLine("Arrey cópia: ");

            // for (int i = 0; i < funcionarioIdCopia.Length; i++)
            // {
            //     Console.WriteLine($"ID {i + 1}: \t{funcionarioIdCopia[i]}");
            // }
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //Funcionario miguel = new Funcionario("Miguel", "De Oliveira", "miguel.oliv.silva@hotmail.com", new DateTime(2006, 3, 28), 10.75, TipoFuncionarios.Gerencia);
            //var gabriel = new Funcionario("Gabriel", "De Oliveira", "gabriel.oliv.silva@hotmail.com", new DateTime(2001, 09, 19), 20, TipoFuncionarios.Gerencia);
            //var rafael = new Funcionario("Rafael", "De Oliveira", "rafael.oliv.silva@hotmail.com", new DateTime(2001, 05, 02), 25, TipoFuncionarios.Gerencia);

            //Funcionario[] funcionarios = new Funcionario[3];
            //funcionarios[0] = miguel;
            //funcionarios[1] = gabriel;
            //funcionarios[2] = rafael;

            //foreach (Funcionario e in funcionarios)
            //{
            //    e.DetalhesFuncionario();
            //    var numeroDeHorasTrabalhadas = new Random().Next(25);
            //    e.Trabalhar(numeroDeHorasTrabalhadas);
            //    e.ReceberRemuneracao();
            //}
            //List<int> funcionariosId = new List<int>();

            //funcionariosId.Add(new Random().Next(25));
            //funcionariosId.Add(new Random().Next(25));
            //funcionariosId.Add(new Random().Next(25));
            //funcionariosId.Add(new Random().Next(25));

            //funcionariosId.Add("teste"); <-- lista ja foi especificada como int.

            //Console.WriteLine($"Quantia de funcionário: {funcionariosId.Count}");
            //Console.WriteLine("Quantos funcionários você quer registra?");

            //int tamanho = int.Parse(Console.ReadLine());

            // for (int i = 0; i < tamanho; i++)
            // {
            //     Console.WriteLine($"Escreva o ID do usuário: ");
            //    int id = int.Parse(Console.ReadLine());
            //    funcionariosId.Add(id);
            // }

            //Funcionario miguel = new Funcionario("Miguel", "De Oliveira", "miguel.oliv.silva@hotmail.com", new DateTime(2006, 3, 28), 10.75, TipoFuncionarios.Gerencia);
            //var gabriel = new Gerente("Gabriel", "De Oliveira", "gabriel.oliv.silva@hotmail.com", new DateTime(2001, 09, 19), 20);
            //var rafael = new Funcionario("Rafael", "De Oliveira", "rafael.oliv.silva@hotmail.com", new DateTime(2001, 05, 02), 25, TipoFuncionarios.Gerencia);

            //List<Funcionario> funcionariosLista = new List<Funcionario>();
            //funcionariosLista.Add(miguel);
            //funcionariosLista.Insert(0, gabriel);
            //funcionariosLista.Add(rafael);

            //foreach ( Funcionario item in funcionariosLista)
            //{
            //   item.DetalhesFuncionario();
            //}
            //---[Acima. Entendendo e trabalhando com Arrays, entendendo listas e coleções em seguida aplicando na prática.]
            //var gabriel = new Gerente("Gabriel", "De Oliveira", "gabriel.oliv.silva@hotmail.com", new DateTime(2001, 09, 19), 30);
            //gabriel.DetalhesFuncionario();
            //gabriel.Trabalhar(27);
            //gabriel.ReceberRemuneracao();
            //gabriel.ParticiparReuniaoGerente();
            //gabriel.Trabalhar(8);
            //gabriel.ReceberRemuneracao();
            //gabriel.ParticiparReuniaoGerente(2);
            //gabriel.Trabalhar();
            //gabriel.ReceberRemuneracao();
            //var miguel = new Desenvolvedor("Miguel", "De Oliveira", "miguel.oliv.silva@hotmail.com", new DateTime(2006, 3, 28), 10.75, "Aprediz");
            //miguel.DetalhesFuncionario();

            //IFuncionario junior = new Funcionario("Junior", "Da Silva", "junior@gmail.com", new DateTime(2006, 3, 28), 20.15, "Rua tupi", "260", "09848-380", "São Paulo");
            //string nomeRua = junior.Endereco.Rua;
            //Console.WriteLine(nomeRua);
            //---[Acima. Entendendo os princípios da linguagem orientada a objetos, Encapsulando variáveis, trabalhando com heranças, polimorfismo e interfaces.]---
            List<Funcionario> funcionarios = new List<Funcionario>();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("*****************************");
            Console.WriteLine("* Aprendizagem PluralSight! *");
            Console.WriteLine("*****************************");
            Console.ForegroundColor= ConsoleColor.White;

            string opcaoUsuario;
            Utilidades.VerificarPorArquivoFuncionariosExistente();

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Carreagado {funcionarios.Count} Funcionário(s)\n\n");
                Console.ResetColor();

                Console.WriteLine("***********************");
                Console.WriteLine("* Selecione uma opção *");
                Console.WriteLine("***********************");
                Console.WriteLine("1: Registrar um funcionário");
                Console.WriteLine("2: Mostrar todos funcionários");
                Console.WriteLine("3: Salvar dados");
                Console.WriteLine("4: Carregar funcionário especifico");
                Console.WriteLine("5: Carregar dados");
                Console.WriteLine("0: Sair da aplicação");

                opcaoUsuario = Console.ReadLine();

                switch (opcaoUsuario)
                {
                    case "1" or "registrar":
                        Utilidades.RegistrarFuncionario(funcionarios);
                        break;
                    case "2" or "mostrar":
                        Utilidades.MostarTodosFuncionarios(funcionarios);
                        break;
                    case "3" or "salvar":
                        Utilidades.SalvarFuncionarios(funcionarios);
                        break;
                    case "4":
                        Utilidades.CarregarFuncionadoPorId(funcionarios);
                        break;
                    case "5" or "carregar":
                        Utilidades.CarregarFuncionarios(funcionarios);
                        break;
                    case "0" or null: break;

                    default:
                        Console.WriteLine("Opção inválida! Por favor, tente novamente.");
                        break;

                }
            }
            while (opcaoUsuario != "0");
            Console.WriteLine("Obrigado por usar nossa aplicação em teste!");
            //Programa totalmente funcional.
        }
    }
}
