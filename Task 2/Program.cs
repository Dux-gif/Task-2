using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Ронжин Алексей Николаевич";
            int age = 21;
            string email = "aleksejronzin9@gmail.com";
            double code = 4.35;
            double math = 4.67;
            double phys = 3.59;
            string pattern = "Ф.И.О.: {0} \nВозраст: {1} \nEmail: {2} \nБаллы по программированию: {3} \nБаллы по математике: {4} \nБаллы по физике: {5}";
            Console.WriteLine(pattern,
                fullName,
                age,
                email,
                code,
                math,
                phys);
            Console.ReadKey();
            double sum = code + math + phys;
            double avg = sum/3;
            string avgFormated = avg.ToString("#.##"); 
            Console.WriteLine("Сумма всех баллов: " + sum + "\nСредний балл: " + avgFormated);
        Console.ReadKey();
        }
    }
}
