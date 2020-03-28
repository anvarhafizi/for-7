using System;

namespace MyApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*System.Console.Write("number:");
            int number=int.Parse(Console.ReadLine());
            for(int i=0; i<=10; i++)
            {
                System.Console.WriteLine($"{number}X{i}={number*i}");
            }*/
            /*DateTime  daytimeAfterseconds=DateTime.Now.AddSeconds(2);
            for(;;)
            {
                Console.Clear();
                System.Console.WriteLine(DateTime.Now);
                if (daytimeAfterseconds==ToString()==daytimeAfterseconds)
                {
                    break;
                }
            }*/
            /*   int iForWhile=0;
            while(iForWhile<10)
            {
                System.Console.WriteLine(iForWhile);
                iForWhile++;
            }*/
            /*int number=5;
            int numberOfTry=3;
            while(numberOfTry!=0)
            {
                System.Console.Write("От гадай чило от 1-10");
                int inputNumber=int.Parse(Console.ReadLine());
                if (inputNumber!=number)
                {
                    numberOfTry--;
                    System.Console.WriteLine($"Попыток осталось:{numberOfTry}")
                }
                else
                {
                    System.Console.WriteLine("ti ugadal!");
                    break;
                }
            }*/
            /*int amount =0;
            do {
                System.Console.WriteLine(amount);
                amount--;
            }
            while(amount>0);*/
            int A=5,B=11,sum=0;
            for (int i=A; i<=B; i++)
                {
                sum+=i;
                }
                Console.WriteLine("Summaashon="+sum);
            Console.ReadKey();
        }
    }
}
