using System.Net.Http.Headers;

namespace Lab5_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            System.IO.StreamWriter sw = null;
            try
            {
                sw = new System.IO.StreamWriter(@"C:\test\test.txt");
                sw.WriteLine("Hello");
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (System.IO.IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                sw.Close();
            }
            Console.WriteLine("Done");
        }
    }
}