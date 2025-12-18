namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temperaturaCelsjusz = 25;
            Console.WriteLine("Temperatura w stopniach celsjusza: " + temperaturaCelsjusz.ToString("F2"));
            if (temperaturaCelsjusz < 0) Console.WriteLine("Uwaga: temperatura poniżej zera!");

            double temperaturaFahrenheita = temperaturaCelsjusz * 9 / 5 + 32;
            Console.WriteLine("Temperatura w stopniach Fahrenheita po przekonwertowaniu z Celsjusza: " + temperaturaFahrenheita.ToString("F2"));

            temperaturaCelsjusz = (temperaturaFahrenheita - 32) * 5 / 9;
            Console.WriteLine("Temperatura w stopniach Celsjusza po przekonwertowaniu z Fahrenheita: "+ temperaturaCelsjusz.ToString("F2"));
            if (temperaturaCelsjusz < 0) Console.WriteLine("Uwaga: temperatura poniżej zera!");
        }
    }
}
