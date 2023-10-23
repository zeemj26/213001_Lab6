namespace Lab5_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            double a = 98, b = 0; 
            double result = 0;
            try
            {
                result = SafeDivision(a, b);
                Console.WriteLine($"{a} divided by {b} = {result}");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Attempted divided by Zero");
            }
        }

        private static double SafeDivision(double x, double y)
        {
            if(y == 0)
            throw new DivideByZeroException();
            return x / y;
        }
    }
}