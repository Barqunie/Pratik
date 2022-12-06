internal class Program
{
    static void Main(string[] args)
        {
            //out parametreler
            string sayı= "999";

        bool sonuc = int.TryParse(sayı, out int outSayı);

        if(sonuc)
        {
            Console.WriteLine("başarılı");
            Console.WriteLine(outSayı);
        }
        else
        {
            Console.WriteLine("Başarısız");
        }
        
        Metotlar instance = new Metotlar();
        instance.Topla( 4,5, out int toplamsonucu);

        Console.WriteLine(toplamsonucu);

        //metot overloading

        int ifade =313;
        instance.EkranaYazdır(Convert.ToString(ifade));
        instance.EkranaYazdır(ifade);
        instance.EkranaYazdır("Barış","Ayık");

        //Metot imazsı
        //Metot adı + Parametre Sayısı + Parametre

    


        }
           class Metotlar
       {
            public void Topla(int a, int b, out int toplam)
            {
                toplam= a+b;
            }

            public void EkranaYazdır(string veri)
            {
                Console.WriteLine(veri);
            }
            public void EkranaYazdır(int veri)
            {
                Console.WriteLine(veri);
            }
            public void EkranaYazdır(string veri1, string veri2)
            {
                Console.WriteLine(veri1 + veri2);
            }
       }
}