using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Personel
    {
        public Personel(string adSoyad, string unvan, double maas, int yas, int cocukSayisi)
        {
            

            if (cocukSayisi > 0) 
            {
                maas = maas * (1 + (0.1 * cocukSayisi));
            }

            if (unvan.Contains("Manager"))
            {
                maas = maas * 1.15;
            }
            else if (unvan.Contains("Specialist"))
            {
                maas = maas * 1.05;
            }
            else if (unvan.Contains("Director"))
            {
                maas = maas * 1.25;
            }
            else if (unvan.Contains("Chief"))
            {
                maas = maas * 1.5;
            }

            AdSoyad = adSoyad;
            Unvan = unvan;
            Maas = maas;
            Yas = yas;
            CocukSayisi = cocukSayisi;

            string personelBilgiler = $"Ad Soyad : {AdSoyad}\n" + $"Unvan : {Unvan}\n" + $"Maaş : {Maas}TL\n" + $"Yaş : {Yas}\n" + $"Çocuk Sayısı : {CocukSayisi}";
            Console.WriteLine(personelBilgiler);
        }

        public string AdSoyad { get; set; }
        public string Unvan {  get; set; }
        public double Maas {  get; set; }
        public int Yas { get; set; }

        public int CocukSayisi { get; set; }
    }
}
