using PluralSightLearning.RH;
using System.Text;

namespace PluralSightLearning
{
    internal class Utilidades
    {
        private static string diretorio = @"C:\PluralSightLearningFiles\";
        private static string nomeArquivo = "funcionarios.txt";

        public static void PartsingStrings()
        {
            Console.WriteLine("Coloque o valor: ");
            string? valor = Console.ReadLine();

            //int valorInt = int.Parse(valor);
            if (int.TryParse(valor, out int valorInt))
                Console.WriteLine("Conversão concluida: " + valorInt);
            else
                Console.WriteLine("Conversão imposivel");

            string dataContrataçãoString = "10/12/2024";
            DateTime dataContratção = DateTime.Parse(dataContrataçãoString);
            Console.WriteLine("Data de contratação = " + dataContratção);

        }

        public static void UsingStringEquality()
        {
            string name1 = "Miguel";
            string name2 = "miguel";

            Console.WriteLine("Os nomes são iguais? " + (name1 == name2));
            Console.WriteLine("O nome é igual a Miguel? " + (name1 == "Miguel"));
            Console.WriteLine("O nome em minusculo é igual a miguel? " + (name1.ToLower() == name2));

        }

        public static void UsingEscapeCharacters()
        {
            string fisrtName = "Gabriel";
            string lastName = "Oliveira";

            string displayName = $"Bem-vindo! \n{fisrtName}\t{lastName}";

            string filePath = "C:\\data\\employeelist.xlsx"; //@"C:\data\employeelist.xlsx";
            Console.WriteLine($"\"Olá\"{displayName}\n{filePath}");
        }

        public static void ManipulatingStrings()
        {
            string firstName = "Bianca";
            string lastName = "Silva";

            string fullName = $"{firstName} {lastName}";
            string employeeId = string.Concat(firstName, lastName);

            string empId = (firstName.ToLower() + "-" + lastName.Trim().ToLower());

            int length = empId.Length;

            if (fullName.Contains("beth") || fullName.Contains("Beth"))
                Console.WriteLine("It's Bethany");

            string subString = fullName.Substring(1, 3);
            Console.WriteLine("Seu nome entre as segunda e quarta letra é :" + subString);


        }

        public static void UsingSimpleStrings()
        {
            string firstName = "Bethany";
            string s;
            s = firstName;
            var userName = "BethanyS";
            userName = userName.ToLower();

            userName = ""; //identico a string.Empety;
        }

        public static int CalculateYearWage(int monthlyWage, int numberOfMonthsWorked)
        {
            //Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
            //return monthlyWage * numberOfMonthsWorked;
            if (numberOfMonthsWorked == 12)
                return monthlyWage * (numberOfMonthsWorked + 1);

            return monthlyWage * numberOfMonthsWorked;
        }
        public static int CalculateYearWage(int monthlyWage, int numberOfMonthsWorked, int bonus = 0)
        {
            return monthlyWage * numberOfMonthsWorked + bonus;
        }
        public static double CalculateYearWage(double monthlyWage, double numberOfMonthsWorked, double bonus)
        {
            return monthlyWage * numberOfMonthsWorked + bonus;
        }
        //Overloads de metodos, metodos com o mesmo nome mas o C# escolhera o meotodo correto a partir dos parametros passados.
        //Métodos da aplicação funcional com armazenagem de arquivos:
        internal static void VerificarPorArquivoFuncionariosExistente()
        {
            string caminho = $"{diretorio}{nomeArquivo}";
            bool arquivoEcontrado = File.Exists(caminho);
            if (arquivoEcontrado)
            {
                Console.WriteLine("Um arquivo de funcionários do sistema foi encontrado.");
            }
            else
            {
                if (!Directory.Exists(diretorio))
                {
                    Directory.CreateDirectory(diretorio);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Um diretório foi criado e está pronto para salvar arquivos.");
                    Console.ResetColor();
                }
            }

        }
        internal static void RegistrarFuncionario(List<Funcionario> funcionarios)
        {
            Console.WriteLine("Criando um funcionário...");
            Console.WriteLine("Qual o tipo de funcionário quer criar?");
            Console.WriteLine("1. Funcionário\n2. Gerente\n3. Desenvolvedor");
            Console.WriteLine("Opção: ");
            string tipoFuncionario = Console.ReadLine();

            if (tipoFuncionario != "1" && tipoFuncionario != "2" && tipoFuncionario != "3")
            {
                Console.WriteLine("Opção inválida! Por favor, selecione uma opção válida.");
                return;
            }
            Console.WriteLine("Insira o primeiro nome: ");
            string primeiroNome = Console.ReadLine();

            Console.WriteLine("Insira o sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.WriteLine("Insira o e-mail: ");
            string email = Console.ReadLine();

            Console.WriteLine("Insira a data de nascimento Ex: \"Dia/Mês/Ano\"");
            DateTime nascimento = DateTime.Parse(Console.ReadLine()); //Ex DD/MM/YYYY

            Console.WriteLine("Insira a remuneração por hora: ");
            string remuneracaoHora = Console.ReadLine();
            double remuneracaoDouble = double.Parse(remuneracaoHora); //Asumindo que usuário vai colocar um valor correto...

            Funcionario funcionario = null;

            switch (tipoFuncionario)
            {
                case "1":
                    funcionario = new Funcionario(primeiroNome, sobrenome, email, nascimento, remuneracaoDouble);
                    break;

                case "2":
                    funcionario = new Gerente(primeiroNome, sobrenome, email, nascimento, remuneracaoDouble);
                    break;
                case "3":
                    funcionario = new Desenvolvedor(primeiroNome, sobrenome, email, nascimento, remuneracaoDouble);
                    break;
            }
            funcionarios.Add(funcionario);

            Console.WriteLine("Funcionário criado com sucesso!\n\n");
        }

        internal static void MostarTodosFuncionarios(List<Funcionario> funcionarios)
        {
            for (int i = 0; i < funcionarios.Count; i++)
            {
                funcionarios[i].DetalhesFuncionario();
            }
        }
        internal static void SalvarFuncionarios(List<Funcionario> funcionarios)
        {
            string caminho = $"{diretorio}{nomeArquivo}";
            StringBuilder sb = new StringBuilder();
            foreach (Funcionario funcionario in funcionarios)
            {
                string tipo = TipoFuncionario(funcionario);
                sb.Append($"primeroNome:{funcionario.PrimeiroNome};");
                sb.Append($"sobrenome:{funcionario.Sobrenome};");
                sb.Append($"email:{funcionario.Email};");
                sb.Append($"nascimento:{funcionario.Nascimento.ToShortDateString()};");
                sb.Append($"remuneracaoHora:{funcionario.ValorPorHora};");
                sb.Append($"tipo:{tipo};");
                sb.Append(Environment.NewLine);
            }
            File.WriteAllText(caminho, sb.ToString());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Funcionários salvos com sucesso!");
            Console.ResetColor();
        }
        private static string TipoFuncionario(Funcionario funcionario)
        {
            if (funcionario is Gerente)
                return "2";
            else if (funcionario is Desenvolvedor)
                return "3";
            else if (funcionario is Funcionario)
                return "1";
            return "0";

        }

        internal static void CarregarFuncionarios(List<Funcionario> funcionarios)
        {
            string caminho = $"{diretorio}{nomeArquivo}";
            try
            {
                if (File.Exists(caminho))
                {
                    funcionarios.Clear(); //Apaga todos items da lista, provavelmente vazia.

                    string[] funcionarioString = File.ReadAllLines(caminho);
                    for (int i = 0; i < funcionarioString.Length; i++)
                    {
                        string[] funcionarioSplit = funcionarioString[i].Split(';');
                        string primeiroNome = funcionarioSplit[0].Substring(funcionarioSplit[0].IndexOf(':') + 1);
                        string lastName = funcionarioSplit[1].Substring(funcionarioSplit[1].IndexOf(':') + 1);
                        string email = funcionarioSplit[2].Substring(funcionarioSplit[2].IndexOf(':') + 1);
                        DateTime nascimento = DateTime.Parse(funcionarioSplit[3].Substring(funcionarioSplit[3].IndexOf(':') + 1));
                        double valorHora = double.Parse(funcionarioSplit[4].Substring(funcionarioSplit[4].IndexOf(':') + 1));
                        string tipoFuncionario = funcionarioSplit[5].Substring(funcionarioSplit[5].IndexOf(':') + 1);

                        Funcionario funcionario = null;

                        switch (tipoFuncionario)
                        {
                            case "1":
                                funcionario = new Funcionario(primeiroNome, lastName, email, nascimento, valorHora);
                                break;
                            case "2":
                                funcionario = new Gerente(primeiroNome, lastName, email, nascimento, valorHora);
                                break;
                            case "3":
                                funcionario = new Desenvolvedor(primeiroNome, lastName, email, nascimento, valorHora);
                                break;
                        }


                        funcionarios.Add(funcionario);

                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Foi carregado um total de {funcionarios.Count} Funcionários!\n\n");
                    //Console.ResetColor();
                }
            }
            catch (FileNotFoundException fnfex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O arquivo não foi encontrado!");
                Console.WriteLine(fnfex.Message);
                Console.WriteLine(fnfex.StackTrace);
                //Console.ResetColor();
            }
            catch (IndexOutOfRangeException iex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Algo deu errado durante a leitura do arquivos, verique a integridade do arquivo.\n\n");
                Console.WriteLine(iex.Message);
                //Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Algo deu errado, verifique a origem do erro.");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                //Console.ResetColor();
            }
            finally 
            {
                Console.ResetColor();
            }
        }

        internal static void CarregarFuncionadoPorId(List<Funcionario> funcionarios)
        {
            try
            {
                Console.WriteLine("Escreva o ID do funcionário que quer vizualizar :");

                int idSelecionado = int.Parse(Console.ReadLine()) -1;
                Funcionario funcionarioSelecionado = funcionarios[idSelecionado];
                funcionarioSelecionado.DetalhesFuncionario();
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Insira um valor de ID correto!\n\n");
                Console.ResetColor();
            }
            catch (ArgumentOutOfRangeException) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ID não encontrado ou inexistente, verifique se existem funcionários carregados!\n\n");
                Console.ResetColor();
            }
        }
    }
}
