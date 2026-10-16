namespace BankszamlaFeladat
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Banki Rendszer");
                Console.WriteLine("--------------------------");
                Folyoszamla fsz = new Folyoszamla("Zavarkó Zénó", "00120102-03451234-00000000", 5000, 10000);
                Console.WriteLine($"Számlatulajdonos: {fsz.Tulajdonos}");
                Console.WriteLine($"Számlaszám: {fsz.Szamlaszam}");
                Console.WriteLine($"Folyószámla egyenlege: {fsz.Egyenleg} Ft");
                fsz.Befizetes(2000);
                Console.WriteLine($"Befizetés utáni egyenleg: {fsz.Egyenleg} Ft");
                fsz.Kifizetes(12000);
                Console.WriteLine($"Kifizetés utáni egyenleg: {fsz.Egyenleg} Ft");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Hiba történt: {ex.Message}");
            }

            Console.WriteLine("-----------------------------");

            try
            {
                MegtakaritasiSzamla msz = new MegtakaritasiSzamla("Zavarkó Máté", "12345678-12345678-12345678", 10000);
                Console.WriteLine($"Számlatulajdonos: {msz.Tulajdonos}");
                Console.WriteLine($"Számlaszám: {msz.Szamlaszam}");
                Console.WriteLine($"Megtakarítási számla egyenlege: {msz.Egyenleg} Ft");
                msz.Kifizetes(15000);
                Console.WriteLine($"Kifizetés utáni egyenleg: {msz.Egyenleg} Ft");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Hiba történt: {ex.Message}");
            }
        }
    }
}
