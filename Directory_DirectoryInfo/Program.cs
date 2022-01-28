namespace Directory_DirectoryInfo;
internal class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\Udemy\Csharp_ProgramacaoOrientadaObjeto\files\MyFolder";

        try
        {
            var folders =  Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
            Console.WriteLine("FOLDERS: ");
            foreach (string item in folders)
            {
                Console.WriteLine(item);
            }

            var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
            Console.WriteLine("FILES: ");
            foreach (string item in files)
            {
                Console.WriteLine(item);
            }

            Directory.CreateDirectory(path + @"\NewFolder");

        }
        catch (IOException ex)
        {
            Console.WriteLine("An error ocurred");
            Console.WriteLine(ex.Message);
        }
    }
}
