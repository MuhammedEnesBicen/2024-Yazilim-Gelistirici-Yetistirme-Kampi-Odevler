using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();
            //Vatandas vatandas1 = new();
            //Console.WriteLine(vatandas1.Ad);
            //SelamVer(isim: "Orhun");
            //SelamVer(isim: "Engin");
            //SelamVer(isim: "Batuhan");
            //SelamVer();

            //Topla(3, 5);

            //string ogrenci1 = "Orhun";
            //string ogrenci2 = "Kerem";
            //string ogrenci3 = "Burak";
            //string ogrenci4 = "Ali";


            //string[] ogrenciler = new string[3];
            //{
            //    ogrenciler[0] = ogrenci1;
            //    ogrenciler[1] = ogrenci2;
            //    ogrenciler[2] = ogrenci3;
            //}
            //ogrenciler = new string[4];
            //ogrenciler[3] = ogrenci4;

            //for (int i = 0; i < ogrenciler.Length; i++)
            //{
            //    Console.WriteLine(ogrenciler[i]);
            //}

            string[] sehirler = { "Istanbul", "Izmir", "Ankara", "Antalya" };
            foreach (string s in sehirler)
            {
                Console.WriteLine(s);
            }

            Person person1 = new Person();
            person1.FirstName = "Orhun";
            person1.LastName = "Kırkağaçlıoğlu";
            person1.DateOfBirthYear = 1995;
            person1.NationalIdentity = 11111111111;

            Person person2 = new Person();
            person2.FirstName = "Test2";

            List<string> yeniSehirler1 = new List<string> { "Istanbul 1", "Izmir 1", "Ankara 1" };
            yeniSehirler1.Add(item: "Adana 1");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
        }





        static void SelamVer(string isim = "noname")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int x, int y)
        {
            int sonuc = x + y;
            Console.WriteLine("Toplam: " + sonuc);
            return sonuc;
        }

        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000;
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Orhun";
            string soyad = "kirkagac";
            int dogumYili = 1995;
            long tcNo = 12345678910;



            Console.WriteLine(mesaj);

            Console.WriteLine(tutar * 1.18);
        }
    }


    //pascal casing
    public class Vatandas
    {
        public Vatandas()
        {
            Ad = "orhun";
        }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}
