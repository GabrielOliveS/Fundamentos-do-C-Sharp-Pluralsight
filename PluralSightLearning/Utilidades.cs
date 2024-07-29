using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralSightLearning
{
    internal class Utilidades
    {
        public static void PartsingStrings()
        {
            Console.WriteLine("Coloque o valor: ");
            string ?valor = Console.ReadLine();

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
    }
}
