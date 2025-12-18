namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 25;
            int b = 4;

            Console.WriteLine("liczba a: "+a+", liczba b: "+b);
            Console.WriteLine("suma: " + (a + b));
            Console.WriteLine("roznica: " + (a - b));
            Console.WriteLine("iloczyn: " + (a * b));
            Console.WriteLine("iloraz: " + (a / b));
            Console.WriteLine("reszta z dzielenia: " + (a % b));
        }
    }
}
