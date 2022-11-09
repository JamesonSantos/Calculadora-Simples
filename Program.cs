using System;

namespace CalculadoraPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("         M E N U         ");
            Console.WriteLine("");
            Console.WriteLine("[1] Soma");
            Console.WriteLine("[2] Subtração");
            Console.WriteLine("[3] Divisão");
            Console.WriteLine("[4] Multiplicação");
            Console.WriteLine("[5] Sair");

            Console.WriteLine("-------------------------");
            Console.WriteLine("Selecione uma opção: ");
            short escolha = short.Parse(Console.ReadLine()); //Short é o menor tipo numérico.

            switch(escolha)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break; //Para sair do sietama. A função Exit() sempre pede um paramêtro de saída e o 0 significa que saiu com sucesso.
                default: Menu(); break;

            }

        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Informe um número: ");
            float numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe um número: ");
            float numero2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = (numero1 + numero2);
            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.ReadKey(); //Para o programa não sair da tela quando execultado.
            Menu(); //Ao final da função, chama o Menu novamente.

        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Informe um número: ");
            float numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe um número: ");
            float numero2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = (numero1 - numero2);
            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey(); //Para o programa não sair da tela quando execultado.
            Menu(); //Ao final da função, chama o Menu novamente.

        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Informe um número: ");
            float numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe um número: ");
            float numero2 =  float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = (numero1 / numero2);
            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.ReadKey(); //Para o programa não sair da tela quando execultado.
            Menu(); //Ao final da função, chama o Menu novamente.

        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Informe um número: ");
            float numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe um número: ");
            float numero2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = (numero1 * numero2);
            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            Console.ReadKey(); //Para o programa não sair da tela quando execultado.
            Menu(); //Ao final da função, chama o Menu novamente.

        }

    }
}