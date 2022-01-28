using System.Globalization;

namespace ExercicioProposto_TrabalhandoComArquivos;
internal class Program
{
    static void Main(string[] args)
    {
        //    Fazer um programa para ler o caminho de um arquivo (.csv) contendo os dados
        //de  items  vendidos.  Cada  item  possui  um  Nome, Preco unitario e Quantidade,
        //separados pos virgula. Você deve gerar um novo  arquivo  chamado  "summary.csv",
        //localizado em uma subpasta chamada "out" a partir da pasta original  do  arquivo
        //de  origem,  contendo  apenas  o  nome  e  o valor total para aquele item (preço
        //unitário multiplicado pela quantidade), conforme exemplo.

        string path = @"C:\Udemy\Csharp_ProgramacaoOrientadaObjeto\Udemy_Csharp_Completo_OOP_Nelio_Intermediario\ExercicioProposto_TrabalhandoComArquivos\exercicio\venda.csv";
        string pathWithoutFile = Path.GetDirectoryName(path);
        string outPath = @"C:\Udemy\Csharp_ProgramacaoOrientadaObjeto\Udemy_Csharp_Completo_OOP_Nelio_Intermediario\ExercicioProposto_TrabalhandoComArquivos\exercicio\out\summary.csv";

        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                Directory.CreateDirectory(pathWithoutFile + @"\out");
                using (StreamWriter sw = File.AppendText(outPath))
                {
                    sw.WriteLine("Produto;Valor Total");

                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(";");
                        string produto = line[0];
                        double preco = double.Parse(line[1], CultureInfo.InvariantCulture);
                        int quantidade = int.Parse(line[2]);

                        double vlrTotal = preco * quantidade;

                        sw.WriteLine(produto + ";" + vlrTotal.ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error ocurrend");
            Console.WriteLine(ex.Message);
        }
    }
}
