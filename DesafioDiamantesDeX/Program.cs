using System;

namespace DesafioDiamantesDeX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, metade,referencia;
            string strX, strVazio;
            Console.Write("Digite um número ímpar:");
            n1 = Convert.ToInt32(Console.ReadLine());

            metade = (n1 + 1) / 2;
            strX = "x";
            strVazio = " ";
            int k = 2;

            Console.WriteLine(""); 
            Console.WriteLine("");

            for (int i = 1; i <= n1; i++)
            {
                if(i == 1)
                {
                    for (int j = 1; j <= (metade-i); j++)
                    {
                        Console.Write(strVazio);
                    }
                    Console.WriteLine(strX);
                }else if(i <= metade)
                {
                    strX = strX + "xx";
                    for (int j = 1; j <= (metade - i); j++)
                    {
                        Console.Write(strVazio);
                    }
                    Console.WriteLine(strX);
                }
            }

            for (int i = 1; i <= n1; i++)
            {
                strX = "x";
                int m = metade;
                if (i == n1)
                {   
                    for(; m < n1;m++)
                    {
                        Console.Write(strVazio);
                    }
                    Console.WriteLine(strX);
                }
                else if(i > metade)
                {
                    referencia = i - metade;
                    strX = strX + "xx";
                    for (; referencia > 0; referencia--)
                    {
                        Console.Write(strVazio);
                    }
                    for (int j = 2; j <= (n1 - i); j++)
                    {
                        strX = strX + "xx";
                    }
                    
                    Console.WriteLine(strX);
                }
            }

            Console.ReadLine();
        }
    }
}