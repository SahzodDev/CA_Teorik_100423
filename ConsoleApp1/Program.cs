


using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        //Utu utu = new Utu();
        //utu.Marka = "Rowenta";
        //utu.Renk = "Beyaz";
        //utu.KazanliMi = true;
        //utu.Sicaklik = 0;

        //string utuBilgileri = $"Ütü nesnesi aşağıdaki bilgiler ile oluşturuldu\n" + $"Marka : {utu.Marka}\n" + $"Renk : {utu.Renk}\n" + $"Sıcaklık : {utu.Sicaklik}\n" + $"Kazanlı mı? : {(utu.KazanliMi ? "Var" : "Yok")}";

        //Console.WriteLine(utuBilgileri);

        //Console.WriteLine(new string('*', 50));

        //Utu newUtu = new Utu("Arçelik", "Kırmızı", 0, true);

        //Console.WriteLine(new string('*', 50));

        //Utu utuMarka = new Utu("Bosch");

        //utuMarka.Renk = "Mavi";
        //utuMarka.Sicaklik = 0;
        //utuMarka.KazanliMi = false;

        //Console.WriteLine(new string('*', 50));

        //Utu utuSicaklik = new Utu("Arzum", "Turuncu", 0, true);

        //utuSicaklik.Isin(200);

        Personel personel1 = new Personel("Şahzod İrgaş", "IT Manager", 80000, 34, 2);

        Console.ReadLine();
    }
}