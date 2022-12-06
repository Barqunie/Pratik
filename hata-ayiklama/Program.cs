using System;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
        Console.WriteLine("Sayı giriniz!");
        int sayi = Convert.ToInt32(Console.ReadLine());
        Console.Write("Girmiş oldugunuz sayi: " + sayi);
        }
        catch(Exception ex)
        {
        Console.WriteLine("Hata: " +ex.Message.ToString());
        }

        finally
        {
        Console.WriteLine("İşlem tamamlandı");
        }

        try
        {
            //int a = int.Parse(null);
            //int a = int.Parse("test");
            int a = int.Parse("-10000000000");
        }
        catch (ArgumentNullException ex)
        {
        Console.WriteLine("Yanlış Değer Girdiniz. ");
       Console.WriteLine(ex);
        }
        catch (FormatException ex)
        {
        Console.WriteLine("Veri Tipi yanlış. ");
        Console.WriteLine(ex);
        }
        catch (OverflowException ex)
        {
        Console.WriteLine("Çok büyük yada cok kucuk deger girdin. ");
        Console.WriteLine(ex);
        }
        finally
        {
            Console.WriteLine("islem tamam");
        }
    }
}
