namespace Stream_Writter;
internal class Program
{
    static void Main(string[] args)
    {
        string sourcePath = @"C:\Udemy\Csharp_ProgramacaoOrientadaObjeto\files\File1.txt";
        string targetPath = @"C:\Udemy\Csharp_ProgramacaoOrientadaObjeto\files\File2.txt";

        try
        {
            string[] lines = File.ReadAllLines(sourcePath);

            using (StreamWriter sw = File.AppendText(targetPath))
            {
                foreach (string line in lines)
                {
                    sw.WriteLine(line.ToUpper());
                }
            }

        }
        catch (IOException ex)
        {
            Console.WriteLine("An error ocurrent");
            Console.WriteLine(ex.Message);
        }
    }
}
