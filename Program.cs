using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Bytelar : Byte değişkeni 0 ile 255 arasında pozitif değer depolar

            byte b = 6;   //Bellekte 1 byte yer kaplar
            sbyte c = 6;  // 1 byte yer kaplar -128 ile 127 arasında değer depolar
            short s = 6;  // 2 byte (16 bitlik) yer kaplar -32.768 ile 32.767 arasında değer alır

            //integer değişkeni

            Int16 i16 = 3;   //Bellekte 2 byte yer kaplar.
            int i = 3;       // 4 byte yer kaplar
            Int32 i32 = 3;   // 4 byte yer kaplar
            Int64 i64 = 3;   // 8 byte yer kaplar
            uint ui = 3;     // 4 byte işaretsiz tam sayı veri depolarlar 0 ile 4.294.967.295 arasında pozitif değer depolayabilmektedir.

            //long türü değişkeni
            
            long l = 5;      // 8 byte yer kaplar Hesaplamalarda, karmaşık işlemlerde kullanabilir
            ulong ul = 5;    // 8 byte

            //reel sayılar

            float tamSayi = 6;   // 4 byte Float değişkenine yaptığımız tam sayı atamalarında sonuna ekleme yapmamıza gerek yok
            float ondalikSayi = 6.2f; // 4 bytelık veri float değişkeninde ondalıklı sayı atadığımızda sonuna f ya a F koymamız gerekli
            double d = 6;   //8 byte
            decimal de = 6;    //16 byte

            //string ifadeler

            char ch = '3'; // 2 byte Tek karakter tutmak için
            string str = "Pınar";   // sınırsız

            //Boolean ifadeler

            bool b1 = true ;
            bool b2 = false ;

            //DateTime

            DateTime dt = DateTime.Now ;//Tarih ve saati  belirtir

            //Objeler

            Object o1 = "3"; //string tut
            Object o2 = 'y'; //char tut
            Object o3 = 4 ; //integer tut
            Object o4 = 4.3; //decimal tut

            //string ifadeler

            string stri = string.Empty;
            stri = "Pınar Özel";
            string ad = "Pınar";
            string soyad = "Özel";
            string tamadı = ad + " " + soyad ;
           // Console.WriteLine(tamadı); = Pınar Özel

           //integer tanımlama örneği
           int integer1 = 6;
           int integer2 = 5;
           int integer3 = integer1 * integer2 ;
           // Console.WriteLine(integer3); = 30

           //boolean ifade
           bool bool1 = 18>9 ; //true
           bool bool2 = 18<9 ; //false

           //Değişken Dönüşümleri
            string str55 = "55";
            int int55 = 55;
            string yeniDeger = str55 + int55.ToString();
            //Console.WriteLine(yeniDeger); = 5555

           //int int56 = int55 + Convert.ToInt32(str55);
           //Console.WriteLine(int56); = 110

            int int56 = int56 + int.Porse(str55);
            // Console.WriteLine(int56); = 110
            

            //DateTime
            string DateTime = DateTime.Now.ToString("dd.mm.yyyy");
            //Console.WriteLine(DateTime); = 27.08.2021

            string hour = DateTime.Now.ToString("hh:mm");
            Console.WriteLine(hour); //= 16:02

            
        }
    }
}
