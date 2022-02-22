using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calculadora insira o primeiro número");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("calculadora /insira o primeiro número");
            double b = double.Parse(Console.ReadLine());
            double soma = a + b;
            double sub = a - b;
            double mult = a * b;
            double div = a / b;
            Console.WriteLine(soma.ToString() +" "+ sub.ToString() +" "+ mult.ToString() +" "+ div.ToString());

        }
    }
}
