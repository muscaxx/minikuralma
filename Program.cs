using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsolll
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kurları tanımladık
            float dolar = 9.61f;
            float euro = 11.10f;
            float sterlin = 13.15f;
            //kurlardan ne kadar alınacağını hesaplayacağız
            int al_dolar;
            int al_euro;
            int al_sterlin;
            //Toplam fiyatı tanımlıyoruz
            float toplamfiyat;

            Console.WriteLine("Dolar =" + dolar + "\n" + "Euro =" + euro + "\n" + "Sterlin =" + sterlin);
            Console.WriteLine("Bankaya hoş geldiniz..Dolar,Euro,Sterlinden ne kadar almak istersiniz");
            Console.WriteLine("Dolar = ");
            al_dolar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Euro = ");
            al_euro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sterlin = ");
            al_sterlin = Convert.ToInt32(Console.ReadLine());
            toplamfiyat = al_dolar * dolar + al_euro*euro + al_sterlin*sterlin ;
            Console.WriteLine("\nToplam Ücret = " + toplamfiyat + "TL");
            Console.ReadLine();//kodumuz hemen kapanmasın diye bu komutu kullandık.
        }
    }
}
