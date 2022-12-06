internal class Program
{
    private static void Main(string[] args)
    {
        //ekrandan girilen sayıya kadar tüm tek sayıları ekrana yansıtır
        Console.WriteLine("Sayı gir");

        int sayac = int.Parse(Console.ReadLine());

        for (int i = 0; i <= sayac; i++)
        {
            if (i % 2 == 1)
                Console.WriteLine(i);

        }

        //1 ile 1000 arasınaki tek ve çift sayıları toplamını ayrı ayrı gosterir
        int tekToplam = 0;
        int ciftToplam = 0;
        for (int i = 1; i <= 1000; i++)
        {
            if (i % 2 == 1)
                tekToplam += i; //tekToplam = tek toplam +i
            else
                ciftToplam += i; //ciftToplam = tek toplam +i

        }
        Console.WriteLine("Tek Toplam:" + tekToplam);
        Console.WriteLine("Çift toplam :" + ciftToplam);


//break kodu if de giridigmiz yer gelince kodu dururur
    for (int i = 0; i < 10; i++)
        {
            if (i == 4)
                break;
            Console.WriteLine(i);
        }

        //continue komutu if de giridigimiz deger gelince orayı es geçer
        for (int i = 0; i < 10; i++)
        {
            if (i == 4)
                continue;
            Console.WriteLine(i);
        }
      
    }
}