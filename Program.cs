using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Siparişinizin fiyatını giriniz: ");
           int siparis=Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Siparişinize eklenecek bahşiş tutarını giriniz: ");
           int bahsis=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Siparişinize eklenecek vergi tutarını giriniz: ");
           int vergi=Convert.ToInt32(Console.ReadLine());

           int sonuc1=siparis*bahsis/100;
           int sonuc2=siparis*vergi/100;

           double total=sonuc1+sonuc2+siparis;
           Console.WriteLine("Toplam ödenecek tutar: "+total);
           Console.WriteLine("-----------AFİYET OLSUN--------");


        }
    }
}