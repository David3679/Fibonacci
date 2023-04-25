using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero do Fibonacci para o calculo:");
        int num = int.Parse(Console.ReadLine());
        int a = 0, b = 1, c = 0;
        bool encontrado = false;

        while (c < num)
        {
            c = a + b;
            a = b;
            b = c;
            Console.WriteLine(c);
        }

        if (c == num)
        {
            encontrado = true;
        }

        if (encontrado)
        {
            Console.WriteLine($"{num} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"{num} não pertence à sequência de Fibonacci.");
        }
    }
}
