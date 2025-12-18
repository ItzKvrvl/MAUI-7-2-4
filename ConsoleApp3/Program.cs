namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imie = "Anna";
            string nazwisko = "Kowalska";
            string wiek = "28";
            string email = "anna.kowalska@example.com";
            string numerTelefonu = "123456789";

            bool imiePoprawne = false;
            bool nazwiskoPoprawne = false;
            bool wiekPoprawny = false;
            bool emailPoprawny = false;
            bool telefonPoprawny = false;

            Console.WriteLine("=== WALIDACJA DANYCH ===\n");

            if (!string.IsNullOrEmpty(imie))
            {
                imiePoprawne = true;
                Console.WriteLine($"Imię ✓ OK");
            }
            else
            {
                Console.WriteLine($"Imię ✗ Błąd: Pole nie może być puste");
            }

            if (!string.IsNullOrEmpty(nazwisko))
            {
                nazwiskoPoprawne = true;
                Console.WriteLine($"Nazwisko ✓ OK");
            }
            else
            {
                Console.WriteLine($"Nazwisko ✗ Błąd: Pole nie może być puste");
            }

            if (int.TryParse(wiek, out int wiekLiczba))
            {
                if (wiekLiczba >= 18 && wiekLiczba <= 100)
                {
                    wiekPoprawny = true;
                    Console.WriteLine($"Wiek ✓ OK");
                }
                else
                {
                    Console.WriteLine($"Wiek ✗ Błąd: Wiek musi być w przedziale 18–100");
                }
            }
            else
            {
                Console.WriteLine($"Wiek ✗ Błąd: Wiek musi być liczbą");
            }

            if (email.Contains("@"))
            {
                emailPoprawny = true;
                Console.WriteLine($"Email ✓ OK");
            }
            else
            {
                Console.WriteLine($"Email ✗ Błąd: Email musi zawierać znak '@'");
            }

            if (numerTelefonu.Length == 9)
            {
                telefonPoprawny = true;
                Console.WriteLine($"Numer telefonu ✓ OK");
            }
            else
            {
                Console.WriteLine($"Numer telefonu ✗ Błąd: Numer musi mieć dokładnie 9 cyfr");
            }

            Console.WriteLine("\n=== PODSUMOWANIE ===");

            if (imiePoprawne && nazwiskoPoprawne && wiekPoprawny && emailPoprawny && telefonPoprawny)
            {
                Console.WriteLine("Wszystkie dane są poprawne. Rejestracja zakończona sukcesem!");
            }
            else
            {
                Console.WriteLine("Formularz zawiera błędy. Popraw dane i spróbuj ponownie.");
            }
        }
    }
}