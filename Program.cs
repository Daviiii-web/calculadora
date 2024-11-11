namespace Calculadora { 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora";
            Console.WriteLine("==========CALCULADORA==========");

            double valor1 = 0, valor2 = 0, resultado, numero;
            string operador, valorDigitado;
            bool isNumeroInteiro;



            Console.Write("Digite o primeiro valor: ");
            valorDigitado = Console.ReadLine();
            isNumeroInteiro = double.TryParse(valorDigitado, out valor1);
            if (isNumeroInteiro)
            {
                valor1 = Math.Round(double.Parse(valorDigitado), 4);
            }
            else
            {
                Console.WriteLine("Digite um número valido");
            }

            Console.WriteLine("Digite a operação (' / | + | * | - | %(MOD)')");
            operador = Console.ReadLine();
            Console.Write("Digite o segundo valor: ");
            valorDigitado = Console.ReadLine();
            isNumeroInteiro = double.TryParse(valorDigitado, out numero);

            if (isNumeroInteiro)
            {
                valor2 = Math.Round(double.Parse(valorDigitado), 4);
            }
            else
            {
                Console.WriteLine("Digite um número válido"); 
            }
             switch (operador)
            {
                case "+":
                    resultado = Math.Round(valor1 + valor2, 4);
                    Console.WriteLine($"{ valor1 } {'+'} { valor2 } = {resultado}");
                    break;
                case "-":
                    resultado = Math.Round(valor1 - valor2, 4);
                    Console.WriteLine($"{ valor1 } {'-'} { valor2 } = {resultado}");
                    break;
                case "*":
                    resultado = Math.Round(valor1 * valor2, 4);
                    Console.WriteLine($"{ valor1 } {'*'} { valor2 } = {resultado}");
                    break;
                case "/":
                    resultado = Math.Round(valor1 / valor2, 4);
                    Console.WriteLine($"{ valor1 } {'/'} { valor2 } = {resultado}");
                    break;
                case "%":
                    resultado = Math.Round(valor1 % valor2, 4);
                    Console.WriteLine($"{ valor1 } {'%'} { valor2 } = {resultado}");
                    break;
                default:
                    Console.WriteLine("Digite uma operação válida");
                    break;
            }

            Console.ReadKey();
        }
    }
}