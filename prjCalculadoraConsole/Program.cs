namespace prjCalculadoraConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = Somar(10, 10);   
            Console.WriteLine("10 + 10 é igual a: ");
            Console.WriteLine(result);
        }
        static double Somar(double x, double y)
        {
            
            return x + y;
        }
    }
}
