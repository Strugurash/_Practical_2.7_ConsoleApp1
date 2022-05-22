using System;

namespace _Practical_2._7_ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Fullname = "Игнатов Геннадий Владимирович";
            int age = 44;
            string email = "strugurash@gmail.com";
            double PointsInf = 4.2; // средний балл информатика
            double PointsMath = 4.5; // средний балл математика
            double Pointsphy = 3.7; // средний балл физика
            string pattern = " ФИО : {0}\n Возраст : {1}\n email : {2}\n Информатика : {3}\n Математика : {4}\n Физика : {5}";
            Console.WriteLine(pattern, Fullname, age, email, PointsInf, PointsMath, Pointsphy);
            double Tpoints = PointsInf + PointsMath + Pointsphy;
            double GPA = Tpoints / 3;
            string newpattern = "Сумма баллов : {0}\n Средний балл : {1}";
            Console.ReadKey();
            Console.WriteLine(newpattern, Tpoints, GPA);
        }
    }
}
