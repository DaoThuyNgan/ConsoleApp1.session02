using System;
using System.Collections.Generic;
using System.Text;  

namespace ConsoleApp1.session02
{
    internal class Ex01
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your YOB: ");
            int yob = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your height (cm): ");
            float height = Convert.ToSingle(Console.ReadLine());
           
            Console.WriteLine($"Họ và tên: {name}, Tuổi: {age}");
            //Console.WriteLine("họ và tên: {0}, Age: {1}", name, age);

            string greating = "\n\n\tHola \"moi nguoi\"";
            Console.WriteLine(greating);

            Console.ReadKey();
        }
    }
}
