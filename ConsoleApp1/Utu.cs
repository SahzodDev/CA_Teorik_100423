using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Utu
    {
        // Boş bir constructor.
        public Utu() 
        {
            Console.WriteLine("Hello Utu!!!");
        }


        // Parametreli Constructor
        public Utu(string marka, string renk, int sicaklik, bool kazanliMi)
        {
            Marka = marka;
            Renk = renk;
            Sicaklik = sicaklik;
            KazanliMi = kazanliMi;

            string utuBilgileri = $"Ütü nesnesi aşağıdaki bilgiler ile oluşturuldu\n" + $"Marka : {Marka}\n" + $"Renk : {Renk}\n" + $"Sıcaklık : {Sicaklik}\n" + $"Kazanlı mı? : {(KazanliMi ? "Var" : "Yok")}";

            Console.WriteLine(utuBilgileri);
        }

        public Utu(string marka)
        {
            Marka = marka;
            string utuBilgileri = $"Ütü nesnesi aşağıdaki bilgiler ile oluşturuldu\n" + $"Marka : {marka}";
            Console.WriteLine(utuBilgileri);
        }

        public void Isin(int derece)
        {
            Sicaklik += derece;
            Console.WriteLine($"Ütünün sıcaklığı arttı. Şu an ki sıcaklık : {Sicaklik}");
        }

        // Property oluşturmak için prop yazıp TAB tuşuna iki kere basılır.
        public string Marka {  get; set; } // => Property (Özellik) 

        public string Renk { get; set; }

        public int Sicaklik { get; set; }

        public bool KazanliMi { get; set; }


    }
}
