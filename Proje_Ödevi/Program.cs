namespace Proje_Ödevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region PROJE ÖDEVİ

            //string[] ogrenciler = { "Safiye", "Eymen", "Safiye", "Bekir", "Rümeysa", "Safiye", "Berat", "Safiye" };

            //Yukarıdaki dizinin içinde bulunan SAFİYE isimlerinin Index değerlerini ekrana bir döngü yardımı ile yazdırınız.

            //Düşününki dizi içinde 1Milyon isim olabilir. Oluşturulan döngü tek tek kontrol ederek 1 Milyon tur atmasın. Kodun başarılı olması en az tur da bütün indexleri yazdırmalısınız.

            string[] ogrenciler = { "Safiye", "Eymen", "Safiye", "Bekir", "Rümeysa", "Safiye", "Berat", "Safiye" };

            string isim = "Safiye";

            int i = Array.IndexOf(ogrenciler, isim);

            while (i == Array.IndexOf(ogrenciler, isim, i))
            {
                if (i == Array.LastIndexOf(ogrenciler, isim))
                {
                    Console.WriteLine(i);
                    break;
                }
                Console.WriteLine(i);
                i = Array.IndexOf(ogrenciler, isim, i + 1);
            }


            #endregion
        }
    }
}
