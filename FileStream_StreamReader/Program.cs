namespace FileStream_StreamReader;
internal class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\Udemy\Csharp_ProgramacaoOrientadaObjeto\files\File1.txt";
        //FileStream fs = null;
        StreamReader sr = null;

        try
        {
            //fs = new FileStream(path, FileMode.Open);
            //sr = new StreamReader(fs);
            sr = File.OpenText(path);

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }

        }
        catch (IOException ex)
        {
            Console.WriteLine("An error ocurrent");
            Console.WriteLine(ex.Message);
        }
        finally
        {
            if (sr != null) sr.Close();
            //if (fs != null) fs.Close();
        }

    }
}
