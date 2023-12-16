using System;
using System.Threading;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
              void startApp()
            {
                tituloApp("Calculadora");
                Console.WriteLine("Qual Operação deseja fazer:");
                Console.WriteLine("1- Adição");
                Console.WriteLine("2- Subtração");
                Console.WriteLine("3- Multiplicação");
                Console.WriteLine("4- Divisão \n");

                int operacao = int.Parse(Console.ReadLine());
                Thread.Sleep(1000);
                Console.Clear();

                Console.WriteLine("Digite o primeiro número: ");
                int num1 = int.Parse(Console.ReadLine());
                Thread.Sleep(1000);
                Console.Clear();

                Console.WriteLine("Digite o segundo número: ");
                int num2 = int.Parse(Console.ReadLine());
                Thread.Sleep(1000);
                Console.Clear();

                int resultado = 0;
                string tipoOperação = "";

                switch (operacao)
                {
                    case 1:
                        {
                            resultado = adicao(num1, num2);
                            tipoOperação = "+";
                            break;
                        }
                    case 2:
                        {
                            resultado = subtracao(num1, num2);
                            tipoOperação = "-";
                            break;
                        }
                    case 3:
                        {
                            resultado = multiplicacao(num1, num2);
                            tipoOperação = "*";
                            break;
                        }
                    case 4:
                        {
                            resultado = divisao(num1, num2);
                            tipoOperação = "/";
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nOperação inválida, digite uma operação válida!");
                            tipoOperação = "operação inválida";
                            break;
                        }
                }


                Loading();
                Console.WriteLine($"O resultado da operação {num1} {tipoOperação} {num2} é: {resultado}");
                Thread.Sleep(4000);
                Console.Clear();
                Console.Write("Deseja realizar uma nova operação? Y/N: ");
                string userResponse = Console.ReadLine();

                if(userResponse.ToLower() == "y")
                {
                    Loading();
                    startApp();
                }
                else 
                {
                    Loading();
                    Encerrando();
                }
            }
            
            startApp();

        }

        public static int adicao(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }

        public static int subtracao(int num1, int num2)
        {
            int resultado = num1 - num2;
            return resultado;
        }

        public static int multiplicacao(int num1, int num2)
        {
            int resultado = num1 * num2;
            return resultado;
        }

        public static int divisao(int num1, int num2)
        {
            int resultado = num1 / num2;
            return resultado;
        }

        public static void tituloApp(string titulo)
        {
            int qtdCaracteres = titulo.Length;
            string asteriscos = string.Empty.PadLeft(qtdCaracteres, '*');
            Console.WriteLine(asteriscos);
            Console.WriteLine(titulo);
            Console.WriteLine(asteriscos + "\n\n");
        }

        public static void Loading()
        {
            Console.Write("Loading");
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Clear();
        }
        
        public static void Encerrando()
        {
            Console.WriteLine("Encerrando a aplicação!");
            Thread.Sleep(2000);
        }


    }

}

