internal class Program
{
    private static void Main(string[] args)
    {
        int mount = DateTime.Now.Month;

        //Expression
        switch (mount)
        {
            case 1:
                Console.WriteLine("Ocak Ayındasınız");
                break;
            case 2:
                Console.WriteLine("Şubat Ayındasınız");
                break;
            case 4:
                Console.WriteLine("Nisan Ayındasın");
                break;
            case 3:
                Console.WriteLine("Mart Ayındasın");
                break;
            case 12:
                Console.Write("Aralık Ayındasın!");
                break;
            
              
            
            default:
               Console.WriteLine("Yanlış Veri Girişi");
            break;
        }
        
        switch (mount)
        {
            case 12:
            case 1:
            case 2:
                Console.WriteLine("Kış Mevsimindesin");
                break;

            case 3:
            case 4:
            case 5:
                Console.WriteLine("İlkbahar Mevsimindesin");
                break;

            case 6:
            case 7:
            case 8:
                Console.WriteLine("Yaz Mevsimindesin");
                break;
            case 9:
            case 10:
            case 11:
                Console.WriteLine("Sonbahar Mevsimindesin");
                break;
        

            
            default:
            break;
        }
    }
}