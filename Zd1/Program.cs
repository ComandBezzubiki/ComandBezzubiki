using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Zd1.Student;

namespace Zd1
{
    internal class Program
    {

   
        static void Main(string[] args)
        {
            Console.WriteLine("Введите nrow и ncolumn: ");
            string input = Console.ReadLine();
            string[] parts = input.Split(',', ' ');
            int nrow = int.Parse(parts[0]);
            int ncolumn = int.Parse(parts[1]);
            int totalElements = nrow * ncolumn;
            Person[] oneDimArray = new Person[totalElements];

            for (int i = 0; i < totalElements; i++)
                oneDimArray[i] = new Person();

            int start = Environment.TickCount;
            for (int i = 0; i < totalElements; i++)
                oneDimArray[i].Name = "Обновленное имя";

            int end = Environment.TickCount;
            Console.WriteLine($"Одномерный массив: {end - start} ");
            Person[,] twoDimArray = new Person[nrow, ncolumn];

            for (int i = 0; i < nrow; i++)
                for (int j = 0; j < ncolumn; j++)
                    twoDimArray[i, j] = new Person();

            start = Environment.TickCount;
            for (int i = 0; i < nrow; i++)
                for (int j = 0; j < ncolumn; j++)
                    twoDimArray[i, j].Name = "Обновленное имя";

            end = Environment.TickCount;
            Console.WriteLine($"Двумерный массив: {end - start} ");
            Person[][] jaggedArray = new Person[nrow][];

            for (int i = 0; i < nrow; i++)
            {
                jaggedArray[i] = new Person[ncolumn];
                for (int j = 0; j < ncolumn; j++)
                    jaggedArray[i][j] = new Person();
            }

            start = Environment.TickCount;
            for (int i = 0; i < nrow; i++)
                for (int j = 0; j < ncolumn; j++)
                    jaggedArray[i][j].Name = "Обновленное имя";

            end = Environment.TickCount;
            Console.WriteLine($"Прямоугольный: {end - start} ");
            
            DateTime ghj = DateTime.Now;
            Person person = new Person("mama", "dfsa", ghj);
            Student leha = new Student(person, Student.Education.Specialist, 297);

            
            Console.WriteLine(leha.ToString());

            Console.WriteLine("\nИндексатор для Education:");
            Console.WriteLine($"Education.Specialist: {leha[Student.Education.Specialist]}");
            Console.WriteLine($"Education.Bachelor: {leha[Student.Education.Bachelor]}");
            Console.WriteLine($"Education.SecondEducation: {leha[Student.Education.SecondEducation]}");

            leha.group = 202;

            leha.AddExams(
                new Exam("Math", 95, DateTime.Now),
                new Exam("Physics", 90, DateTime.Now)
            );

            Console.WriteLine("\nToString output after assigning all properties:");
            Console.WriteLine(leha.ToString());


            leha.AddExams(
     new Exam("Math", 95, DateTime.Now),
     new Exam("Physics", 90, DateTime.Now)
 );

            Console.WriteLine("\nToString output after assigning all properties:");
            Console.WriteLine(leha.ToString()); // Вызываем ToString() для объекта leha



        }
    }
}
