namespace Ex010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario;
            
            Console.WriteLine("Digite o valor do seu salário: ");
            salario = Convert.ToDouble(Console.ReadLine());

            if (salario > 2500)
            {
                Console.WriteLine("O aumento do seu salário é de 5%, o seu salário atual é: {0}", ((salario * 0.05) + salario));
            }
            else if (salario >  1250)
            {
                Console.WriteLine("O aumento do seu salário é de 10%, o seu salário atual é: {0}", ((salario * 0.10) + salario));
            }
            else
            {
                Console.WriteLine("O aumento do seu salário é de 15%, o seu salário atual é: {0}", ((salario * 0.15) + salario));
            }
        }
    }
}
