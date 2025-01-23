namespace Ex016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string genero;

            Console.Write("Digite o Gênero: ");
            genero = Console.ReadLine().ToUpper();

            while (genero != "F" && genero != "M")
            {
                Console.Write("Digite o Gênero: ");
                genero = Console.ReadLine().ToUpper();
            }

            Console.WriteLine("Bem-vindos e bem-vindas ao curso de C#!");
        }
    }
}
