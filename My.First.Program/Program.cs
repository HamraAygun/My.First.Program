using System; // Sistem ana kütüphanesini koda ekliyorum.
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

internal class Program
{
    private static int i;

    private static void Main(string[] args)
    {
        //string name;
        //string nameDesc;

        //string Name;
        //string NameDesc;



        //name = "HAMRA AYGÜN";  // değişgene değer atama işlemi
        //nameDesc = "BENİM ADIM :";

        //Name = "hamra aygün";
        //NameDesc = "benim adım :";



        //Console.WriteLine(nameDesc + name);

        //Console.Write(NameDesc + Name);

        //byte a = 5;
        //byte a1 = 255;
        //int toplam = a + a1;

        //Console.WriteLine("Toplama işleminin sonucu=" + toplam.ToString() );


        //string name;
        //Console.WriteLine("Lütfen adınızı giriniz : ");

        //name = Console.ReadLine(); // String türünden değer girilmesi bekleniyor...

        //Console.WriteLine("Adınız : " + name);

        //Console.ReadKey();



        //// Tür Dönüşüm Örnekleri

        //byte a = 10;

        //short b = 20;

        //sbyte c = 30;

        //int d = a + b + c; // Örnek bir tür dönüşümü (bilinçsiz)

        //string e = "İBB Project 100 KY";

        //char f = 'A';

        //object g = e + f + d; // Farklı tiplerin object tipine atanması.

        //long h = d;

        //float i = h;

        //double j = i;

        //double k = 21.6;

        //Console.WriteLine("1. durum: " + d.ToString());

        //Console.WriteLine("2. durum: " + g.ToString());

        //Console.WriteLine("3. durum: " + h + k);

        //// Bilinçsiz dönüşüm olayında ilginç bir durum

        //char l = 'H';

        //int m = l;

        //Console.WriteLine("4. durum: " + m);

        //Console.WriteLine(""); // bir satır boşluk bırakmak için

        //Console.WriteLine("\n\t"); // bir satır boşluk bırakmak için


        //// Tür dönüşüm örnekleri - bilinçsiz

        //int r = 15;

        //byte s = (byte)r; // int olan r yi byte çevir

        //Console.WriteLine("5. durum :" + (s + r));

        //Console.WriteLine("\n\t");

        //Console.WriteLine("6. durum :" + r.ToString());

        //Console.ReadKey();

        // .........3. Gün..........




        //#region 1. Matematiksel operatörler 

        //// Diğer operatörlere göre daha değişik işlem yapan & operatörü (mod alma)

        //float b = 5 / 2f; // Burada 5 sayısı da float gibi davranmış ve sonuç ondalıklı çıkmıştır.

        //Console.WriteLine(("Sonuç 1.1 : " + b + "\n");

        //#endregion

        //#region 1.2 Ancak durum...

        //float c = 2 / 5 / 2f // Burada sonuç 0 çıkar. Çünkü zaten işlem yapılırken sonuç dh floata (2f) gelmeden sıfırlanmıştı.

        //    Console.WriteLine("Sonuç 1.2 : " + d + "\n");

        //#endregion

        //#region 1.3 Diğer bir durum...

        //float d = 2f / 5 / 2 // Burada ise zincirleme olarak her işlemin sonucu floatlaşmakta ve sonuç ondalıklı çıkmaktadır.

        //    Console.WriteLine("Sonuç 1.3 : " + d + "\n");

        //#endregion

        //#region 1.4 Daha da ilginci...

        //float e = 2f / 5 / 2 / 2 / 4 / 8 / 4 / 5 / 3; // Burada ise zincirleme olarak her işlemin sonucu floatlaşmakta ve sonuç ondalıklı çıkmaktadır.

        //Console.WriteLine("Sonuç 1.4 :" + e + "\n");

        //#endregion



        //  //Değerleri verilen dikdörtgenin alanını ve çevresini hesaplayan kod?

        //    int a, b, c, d;

        //    Console.WriteLine("Dikdörtgenin bir kenar ölçüsünü giriniz:" + "\n");

        //    a = int.Parse(Console.ReadLine());

        //    Console.WriteLine(" ");

        //    Console.WriteLine("Dikdörtgenin diğer kenar ölçüsünü giriniz:" + "\n");

        //    b = int.Parse(Console.ReadLine());

        //    Console.WriteLine(" ");

        //    c = a * b;

        //    Console.WriteLine("Dikdörtgenin alanı: " + c + "\n");

        //    d = 2 * (a + b);

        //    Console.WriteLine("Dikdörtgenin Çevresi: " + d);

        //    Console.ReadKey();






        //    1'den 1000'e(sınırlar dahil) kadar olan sayılar içerisinde 5'e tam bölünen, ancak 7'ye tam bölünemeyen sayıları alt alta listeleyen, bu sayıların kaç tane olduğunu ve toplamını yazan bir program yazınız.



        //    int toplam = 0;
        //    int adet = 0;
        //    for (int i = 1; i <= 1000; i++)
        //    {

        //        if (i % 5 == 0 && i % 7 != 0)
        //        {
        //            Console.WriteLine(i);
        //            toplam = toplam + i;
        //            adet++;
        //        }
        //    }

        //    Console.WriteLine("sayıların toplamı:" + toplam);
        //    Console.WriteLine("sayıların adedi:" + adet);

        //    Console.ReadKey();

        //







        // Konsol ekranına girilen 0 ile 100 (sınırlar dahil) arasındaki 10 notun en büyüğünü, en küçüğünü ve ortalamasını yazan programı yazınız.





        //// while örneği

        //Console.Write("Enter a number");
        //int sayi = Convert.ToInt32(Console.ReadLine());
        //int index = 1;
        //while (index <= sayi)
        //{
        //    Console.WriteLine();
        //    int j = 1;
        //    while (j <= index)
        //    {
        //        Console.Write(j + " ");
        //        j++;

        //    }
        //    index++;
        //}




        ////Bir ders için yapılan iki ara sınav ve bir genel sınav sonucu değerlendirilerek geçme notları hesaplanacaktır. Bu dersin geçme notu 1. ara sınav notunun %20’si, 2. ara sınav notunun %30’u ve genel sınav notunun %50’si toplanarak hesaplanmaktadır. Geçme notunu hesaplayan ve sonucu ekrana yazdıran programı yazın.

        //int a, b, c;

        //Console.WriteLine("İlk ara sınav notunuzu giriniz: " + "\n");

        //a = int.Parse(Console.ReadLine());

        //Console.WriteLine(" ");

        //Console.WriteLine("ikinci ara sınav notunuzu giriniz: " + "\n");

        //b = int.Parse(Console.ReadLine());

        //Console.WriteLine(" ");

        //Console.WriteLine("Genel sınav notunuzu giriniz: " + "\n");

        //c = int.Parse(Console.ReadLine());

        //Console.WriteLine(" ");

        //int toplam = ((a * 20) / 100) + ((b * 30) / 100) + ((c * 50) / 100);

        //Console.WriteLine("Geçme notunuz: " + toplam);

        //Console.ReadKey();









        ////Klavyeden girilen A ve B gibi iki sayıyı,  sadece toplama ve çıkarma işlemlerini kullanarak (direkt çarpma işlemi kullanmadan) çarpma işlemini yapan ve bunun sonucunu ekrana, ekranın geri plan rengi beyaz ve ekrana yazılan mesajın rengi kırmızı olacak şekilde yazan programı yazınız.


        //Console.BackgroundColor = ConsoleColor.White;

        //Console.Clear();

        //Console.ForegroundColor = ConsoleColor.Red;

        //int a, b, carpimSonucu = 0;


        //Console.WriteLine("1. sayıyı giriniz:" + "\n");

        //a = int.Parse(Console.ReadLine());

        //Console.WriteLine(" ");

        //Console.WriteLine("2. sayıyı giriniz:" + "\n");

        //b = int.Parse(Console.ReadLine());

        //Console.WriteLine(" ");

        //for (int i = 1; i <= b; i++)
        //{
        //    carpimSonucu = carpimSonucu + a;
        //}

        //Console.WriteLine("Çarpım Sonucu: " + carpimSonucu);

        //Console.ReadKey();





        //// Girilen 6 basamaklı sayının rakamlarının toplamını yazan programı giriniz.

        //int ob = 0;
        //int yb = 0;
        //int b = 0;
        //int y = 0;
        //int o=0;
        //int bi = 0;

        //Console.WriteLine("6 basamaklı bir sayı giriniz: ");

        //int a = int.Parse(Console.ReadLine());

        //if (a >= 100000 && a <= 999999)
        //{
        //    yb = a / 100000;
        //    ob = (a / 10000)%10;
        //    b = (a / 1000)%10;
        //    y = (a / 100)%10;
        //    o = (a / 10)%10;
        //    bi = a % 10;

        //    int sonuc;
        //    sonuc = (yb + ob + b + y + o + bi);
        //    Console.WriteLine("Rakamların toplamı :" + sonuc);
        //}

        //else
        //{
        //    Console.WriteLine("Lütfen 6 haneli bir sayı giriniz!");
        //}









    }
}
























