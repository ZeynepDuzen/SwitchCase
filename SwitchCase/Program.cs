using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Plaka degeri girildiginde ilgili plakanın temsil ettigi sehri yazdıran switch case yapısı ;

            
            byte plaka;

            Console.WriteLine("Lütfen bir plaka degeri girin : ");
            plaka = Convert.ToByte(Console.ReadLine());

            switch (plaka)
            {
                case 1: Console.WriteLine("Adana"); break;
                case 2: Console.WriteLine("Adıyaman"); break;
                case 3: Console.WriteLine("Afyon"); break;
                case 4: Console.WriteLine("Agrı"); break;
                case 5: Console.WriteLine("Amasya"); break;
                case 6: Console.WriteLine("Ankara"); break;
                case 7: Console.WriteLine("Antalya"); break;
                case 8: Console.WriteLine("Artvin"); break;
                case 9: Console.WriteLine("Aydın"); break;
                case 10: Console.WriteLine("Balıkesir"); break;
                case 11: Console.WriteLine("Bilecik"); break;
                case 12: Console.WriteLine("Bingöl"); break;
                case 13: Console.WriteLine("Bitlis"); break;
                case 14: Console.WriteLine("Bolu"); break;
                case 15: Console.WriteLine("Burdur"); break;
                case 16: Console.WriteLine("Bursa"); break;
                case 17: Console.WriteLine("Canakkale"); break;
                case 18: Console.WriteLine("Cankırı"); break;
                case 19: Console.WriteLine("Corum"); break;
                case 20: Console.WriteLine("Denizli"); break;
                case 21: Console.WriteLine("Diyarbakır"); break;
                case 22: Console.WriteLine("Edirne"); break;
                case 23: Console.WriteLine("Elazıg"); break;
                case 24: Console.WriteLine("Erzincan"); break;
                case 25: Console.WriteLine("Erzurum"); break;
                case 26: Console.WriteLine("Eskisehir"); break;
                case 27: Console.WriteLine("Gaziantep"); break;
                case 28: Console.WriteLine("Giresun"); break;
                case 29: Console.WriteLine("Gumushane"); break;
                case 30: Console.WriteLine("Hakkari"); break;
                case 31: Console.WriteLine("Hatay"); break;
                case 32: Console.WriteLine("Isparta"); break;
                case 33: Console.WriteLine("Icel"); break;
                case 34: Console.WriteLine("Istanbul"); break;
                case 35: Console.WriteLine("Izmir"); break;
                case 36: Console.WriteLine("Kars"); break;
                case 37: Console.WriteLine("Kastamonu"); break;
                case 38: Console.WriteLine("Kayseri"); break;
                case 39: Console.WriteLine("Kırlareli"); break;
                case 40: Console.WriteLine("Kırsehir"); break;

                default: Console.WriteLine("Girdiginiz plaka degerine ait sehir bulunamadı"); break;
            }

            Console.Read();
        }
    }
}
