using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Acesso();

            //Console.ReadKey();


            Program p = new Program();

            double salario ;

            Console.Write("Informe seu salario atual: ");

            double.TryParse(Console.ReadLine(),out salario);

            Console.WriteLine();

            Console.Write("salario: ");

            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write(salario.ToString());

            Console.ResetColor();

                Console.WriteLine();

            Console.Write(" Novo salario: ");

            Console.ForegroundColor = ConsoleColor.Green;

            

            

            Console.Write(p.Novosalario(salario));

            Console.ReadKey();


        }

        private double Novosalario(double salario)
        {
            double resultado = 0;

            if (salario <= 1700)
            {
                resultado = 300 + salario;
            }
            else
            {
                resultado = 200 + salario;

            }
            return resultado;
        }

        //private static void Acesso()
        //{
        //    int idade;

        //    Console.Write("informe sua idade para ter acesso :");

        //    int.TryParse(Console.ReadLine(), out idade);

        //    if (idade >= 18)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Green;
        //        Console.WriteLine("acesso liberado ");
        //    }
        //    else
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine("acesso negado ");
        //    }
        //}



    }
}
