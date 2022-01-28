namespace BlockUsing;
internal class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\Udemy\Csharp_ProgramacaoOrientadaObjeto\files\File1.txt";
        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
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