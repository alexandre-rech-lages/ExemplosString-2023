namespace ExemplosString.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string mensagemBoasVindas = "Fala Galera da Academia do Programador 2023";

            char primeiraLetraDaMensagem = mensagemBoasVindas[0];

            char ultimaLetraDaMensagem = mensagemBoasVindas[mensagemBoasVindas.Length - 1];

            Console.WriteLine(mensagemBoasVindas);

            for (int i = 0; i < mensagemBoasVindas.Length; i++)
            {
                Console.Write(mensagemBoasVindas[i]);
                Console.Write(" ");
            }

            Console.WriteLine();

            Console.Clear();

            string primeirasPalavras = mensagemBoasVindas.Substring(5, 6);

            string[] palavrasSeparadas = mensagemBoasVindas.Split(" ");

            for (int i = 0; i < palavrasSeparadas.Length; i++)
            {
                Console.Write(palavrasSeparadas[i] + " - ");
            }

            Console.WriteLine(primeirasPalavras);

            string mensagemEmMaiusculo = mensagemBoasVindas.ToUpper();

            Console.WriteLine(mensagemEmMaiusculo);

            string mensagemEmMinusculo = mensagemBoasVindas.ToLower();

            Console.WriteLine(mensagemEmMinusculo);

            Console.Clear();

            if (mensagemEmMinusculo.StartsWith("Fala", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Inicia com Fala ");
            }

            if (mensagemEmMinusculo.EndsWith("2023"))
            {
                Console.WriteLine("Termina com 2023");
            }

            if (mensagemBoasVindas.Contains("academia", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Contém a palavra Academia");
            }

            int posicaoDaLetra = mensagemBoasVindas.IndexOf("z");

            string[] frutas = new string[] { "Maça", "Banana", "Laranja" };

            string frutasNumaString = "";

            for (int i = 0; i < frutas.Length; i++)
            {
                frutasNumaString += frutas[i] + " ";
            }

            Console.Clear();

            string mensagemComEspacosNoInicioEhFim = "    Academia do Programador   ";

            Console.WriteLine(mensagemComEspacosNoInicioEhFim.Trim());

            Console.WriteLine(mensagemBoasVindas.Replace(" ", "-"));


            string resultadoRemocao = mensagemBoasVindas.Remove(0, 4);


            Console.Clear();

            Console.WriteLine(mensagemBoasVindas.PadLeft(50, '#'));

            Console.WriteLine(mensagemBoasVindas.PadRight(50, '#'));


            /* Funções da Classe String
             * 
             * SubString
             * Replace
             * IndexOf
             * Trim
             * ToUpper
             * Remove
             * Split
             * StartsWith
             * EndsWith
             * PadLeft
             * PadRight
             * Contains
             * Index[]
             */

            //Leitura do arquivo de municipios
            string municipios = File.ReadAllText(@"C:\Users\Alexandre Rech\Desktop\cidades.csv");

            Console.ReadLine();
        }
    }
}