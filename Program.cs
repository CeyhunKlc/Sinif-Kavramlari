using System;

namespace sinif_kavrami
{
    class program
    {
        

        static void Main(string[] args)
        {
            //Söz Dizimi
            //Class SinifAdi
            //{
            //    [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
            //    [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi(Parametre Listesi)
            //    }  
            //      // Metot Komutları
            //    }
            //}

            Calisan calisan1 = new Calisan();
            calisan1.ad = "Ayşe";
            calisan1.soyad = "Kara";
            calisan1.No= 23425634;
            calisan1.Departman ="İnsan Kaynakları";

            calisan1.CalısanBilgileri();

            Calisan calisan2 = new Calisan();
            calisan2.ad = "Deniz";
            calisan2.soyad = "Arda";
            calisan2.No = 25646789; 
            calisan2.Departman = "Satın Alma";

            calisan2.CalısanBilgileri();



        }
    }




    class Calisan
    {

        public string ad;
        public string soyad;
        public int No;
        public string Departman;

        public void CalısanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı{0}", ad);
            Console.WriteLine("Çalışanın Soyadı{0}", soyad);
            Console.WriteLine("Çalışanın Numarası{0}", No);
            Console.WriteLine("Çalışanın Departmanı{0}", Departman);
        }
        

    }
}