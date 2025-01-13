namespace TesteTargetSistemas.Controllers
{
    public class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número para verificar se pertence à sequência de Fibonacci: ");
            if (!int.TryParse(Console.ReadLine(), out int numero))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
                return;
            }

            string resultado = VerificarFibonacci(numero);
            Console.WriteLine(resultado);
        }

        static string VerificarFibonacci(int numero)
        {
            if (PertenceAoFibonacci(numero))
            {
                return $"O número {numero} pertence à sequência de Fibonacci.";
            }
            else
            {
                return $"O número {numero} NÃO pertence à sequência de Fibonacci.";
            }
        }

        static bool PertenceAoFibonacci(int numero)
        {
            if (numero < 0) return false;

            int a = 0, b = 1;

            while (a <= numero)
            {
                if (a == numero) return true;

                int temp = a;
                a = b;
                b = temp + b;
            }

            return false;
        }
    }
}
