
internal class Program
{
    private static void Main(string[] args)
    {
        int time = DateTime.Now.Hour;

        if (time >= 6 && time < 11)
        Console.WriteLine("günaydın");

        else if (time <= 18)
            Console.WriteLine("İyi günler");
        else
        {
            Console.WriteLine("İyi aksamlar");
        }
       // if else yazmadan yazmas
        string sonuc = time <= 18 ? "İyi Günler" : "İyi Aksamlar";

        sonuc = time >= 6 && time < 11 ? "Gunaydın" : time <= 18 ? "İyi Günler!" : "İyi Geceler";

        Console.WriteLine(sonuc);
    }
}