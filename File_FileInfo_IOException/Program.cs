namespace File_FileInfo_IOException;
internal class Program
{
    static void Main(string[] args)
    {
        string sourcePath = @"C:\Udemy\Csharp_ProgramacaoOrientadaObjeto\files\File1.txt";
        string targetPath = @"C:\Udemy\Csharp_ProgramacaoOrientadaObjeto\files\File2.txt";

        try
        {
            FileInfo fileInfo = new FileInfo(sourcePath);
            fileInfo.CopyTo(targetPath);
            string[] lines = File.ReadAllLines(sourcePath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

        }
        catch (IOException ex )
        {
            Console.WriteLine("An error ocurrent");
            Console.WriteLine(ex.Message);
        }
    }
}
