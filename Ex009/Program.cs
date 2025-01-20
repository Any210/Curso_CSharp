namespace Ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n;

            Console.WriteLine("Digite um número:");
            n = Convert.ToDouble(Console.ReadLine());

            if (n % 2 == 0)
            {

                Console.WriteLine("Número par.");
            }
            else
            {
                Console.WriteLine("Número impar.");
            }
        }
    }
}
