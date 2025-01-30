namespace impressao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            escreva("Kauany Victoria Santos");
            Console.WriteLine();
            escreva("Curso C#");
            Console.WriteLine();
            escreva("Olá");
            Console.WriteLine();
        }

        static void escreva(string texto)
        {
            // escreve o texto centralizado em uma linha com o caracter informado

            char caracter = '='; // Caracter que seera impresso
            int tamanho = texto.Length + 4; //tamanho da linha
            string linha = new string(caracter, tamanho); // cria uma linha com o caracter informado
            string texto_centralizado  = texto.PadLeft(2 + texto.Length).PadRight(tamanho); //centraliza o texto
            Console.WriteLine(linha);
            Console.WriteLine(texto_centralizado);
            Console.WriteLine(linha);
        }
    }
}
