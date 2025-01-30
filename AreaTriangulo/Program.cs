namespace AreaTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================");
            Console.WriteLine("Cálcular a Área do Triângulo.");
            Console.WriteLine("===========================");
            Console.WriteLine();

            Console.WriteLine("Digite a base do Triângulo: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite a altura do Triângulo: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            area (b, a);

        }

        static void area(double bas, double altura)
        {
            double ar = (bas * altura) / 2;
            Console.WriteLine($"A área do triângulo de {bas} x {altura} é de {ar:F2}m²");
        }
    }
}
