using System;
namespace calc02
{
    class calc02
    {
        static void Main()
        {
            MENU();
        }
        static void MENU()
        {
            Console.Clear();
            Console.WriteLine("QUAL OPERAÇÃO DESEJA REALIZAR ?");
            Console.WriteLine("DIGITE O VALOR REFERENTE A OPRAÇÃO NO MENU A ABAIXO:");
            Console.WriteLine("1 = SOMA");
            Console.WriteLine("2 = SUBTRAÇÃO");
            Console.WriteLine("3 = MULTIPLICAÇÃO");
            Console.WriteLine("4 = DIVISÃO");
            Console.WriteLine("0 = FINALIZAR");
            short val = short.Parse(Console.ReadLine());

            switch (val)
            {
                case 1: SOMA(); break;
                case 2: SUB(); break;
                case 3: MULT(); break;
                case 4: DIV(); break;
                case 0: Console.WriteLine("obrigado por utilizar nossa aplicação ate logo !!"); Console.ReadKey(); System.Environment.Exit(0); break; //sair da aplicação
                default: MENU(); break;
            }
        }

        static void SOMA()//função soma
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float res = v1 + v2;
            Console.WriteLine(" o Resultado da Soma de " + v1 + " + " + v2 + " é " + res);
            Console.ReadKey();
            MENU();

        }
        static void SUB()//função subitração
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float res = v1 - v2;
            Console.WriteLine(" o Resultado da Subitração de " + v1 + " - " + v2 + " é " + res);
            Console.ReadKey();
            MENU();

        }
        static void MULT()//função multiplicação
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float res = v1 * v2;
            Console.WriteLine(" o Resultado da Multiplicação entre " + v1 + " x " + v2 + " é " + res);
            Console.ReadKey();
            MENU();

        }
        static void DIV()//função divisão
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float res = v1 / v2;
            Console.WriteLine(" o Resultado da Soma de " + v1 + " / " + v2 + " é " + res);
            Console.ReadKey();
            MENU();

        }




    }



}