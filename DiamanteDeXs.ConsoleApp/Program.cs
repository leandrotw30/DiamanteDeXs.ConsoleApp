namespace DiamanteDeXs.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diamante de X's\n");

            Console.Write("Digite um número ímpar e inteiro: ");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if (numeroDigitado % 2 == 0)
            {
                Console.WriteLine("Número informado não é ímpar. Tente novamente!");
            }
            else
            {
                int quantidadeXs = 1;
                int quantidadeEspacos = numeroDigitado / 2;

                for (int i = 0; i < (numeroDigitado / 2) + 1; i++)
                {
                    Console.Write(new string(' ', quantidadeEspacos)); // new string = consiste no caractere de espaço ' ' repetido pelo número de vezes especificado pela variável quantidadeEspacos.
                    Console.WriteLine(new string('X', quantidadeXs)); //new string = consiste no caractere de X 'X' repetido pelo número de vezes especificado pela variável quantidadeXs.
                    quantidadeEspacos--;
                    quantidadeXs += 2;
                }

                quantidadeXs = numeroDigitado - 2;
                quantidadeEspacos = 1;

                for (int i = (numeroDigitado / 2); i > 0; i--)
                {
                    Console.Write(new string(' ', quantidadeEspacos));
                    Console.WriteLine(new string('X', quantidadeXs));
                    quantidadeEspacos++;
                    quantidadeXs -= 2;
                }

                quantidadeXs = 1;
                quantidadeEspacos = numeroDigitado / 2;

                for (int i = 0; i > (numeroDigitado / 2) - 1; i--)
                {
                    Console.Write(new string(' ', quantidadeEspacos));
                    Console.WriteLine(new string('X', quantidadeXs));
                    quantidadeEspacos++;
                    quantidadeXs -= 2;
                }
                Console.ReadKey();
            }
            //cada linha vai aumentando 2 quantidade de x na parte de cima
            //cada linha vai diminuindo 1 quantidade de x na parte de cima nos espaços brancos
            //cada linha vai diminuindo 2 quantidade de x na parte de baixo
            //cada linha vai aumentando 1 quantidade de x na parte de baixo nos espaços brancos
            //valor inicial da quantidade de espaços númeroDigitado / 2
            //valor inicial da quantidade de X é 1

            //variaveis: quantidade de X, quantidade de espaço

            //diamante de três

            //parte de cima
            //Console.Write(" ");
            //Console.Write("X");
            //Console.Write("\n");

            //parte do meio
            //Console.Write("X");
            //Console.Write("X");
            //Console.Write("X\n");

            //parte de baixo
            //Console.Write(" ");
            //Console.Write("X");
            //Console.Write("\n");
        }
    }
}
