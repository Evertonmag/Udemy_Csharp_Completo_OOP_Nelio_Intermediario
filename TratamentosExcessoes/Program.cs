namespace TratamentosExcessoes;
internal class Program
{
    static void Main(string[] args)
    {
        //BlocoTryCatch();
        Finally();
    }

    static void BlocoTryCatch()
    {
        try
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int result = n1 / n2;
            Console.WriteLine(result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Division by zero is not allowed");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Format error! " + ex.Message);
        }
    }

    static void Finally()
    {
        FileStream fs = null;

        try
        {
            fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            if (fs != null)
                fs.Close();
        }
    }
}
