namespace Ex008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double velocidade, valor_multa;
            string multa;
            

            Console.WriteLine("Digite a velocidade do carro: ");
            velocidade = Convert.ToDouble(Console.ReadLine());

            valor_multa = (velocidade - 80) * 7;

            if (velocidade > 80) {

                Console.WriteLine("Você foi multado! Deve ser pagp o valor de {0} referente aos km exedidos: ", valor_multa);
            }
            else
            {
                Console.WriteLine("Dirija com prudencia!! ");
            }

        }
    }
}
