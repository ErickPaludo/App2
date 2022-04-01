using System;
using System.Globalization;

namespace App_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char verificador = 'Y';

            while(verificador == 'Y') { 
            Console.Write("Qual valor deseja sacar? R$");
            int x = int.Parse(Console.ReadLine());
            int D = 0;
            int S = 0;

                if (x >= 100 || x <= 100)
                {
                    D = x / 100;
                    S = x % 100;

                    Console.WriteLine(D + " notas de 100");

                    if (S >= 50)
                    {
                        D = S / 50;
                        S = S % 50;
                        Console.WriteLine(D + " notas de 50");
                    }
                    if (S >= 20)
                    {
                        D = S / 20;
                        S = S % 20;
                        Console.WriteLine(D + " notas de 20");
                    }
                    if (S >= 10)
                    {
                        D = S / 10;
                        S = S % 10;
                        Console.WriteLine(D + " notas de 10");
                    }
                    if (S >= 5)
                    {
                        D = S / 5;
                        S = S % 5;
                        Console.WriteLine(D + " notas de 5");
                    }
                    if (S >= 2)
                    {
                        D = S / 2;
                        S = S % 2;
                        Console.WriteLine(D + " notas de 2");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Caso queira realizar outro saque, digite Y, caso contrário, digite N: ");
                    char verificador_1 = char.Parse(Console.ReadLine());

                    if(verificador_1 == 'N')
                    {
                        verificador = 'N';
                    }
                    else if (verificador_1 == 'Y')
                    {
                        Console.Clear();
                    }
                }
            }
        }
    }
}


