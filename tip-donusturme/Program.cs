

//İmplict Conversation (Bilinçsiz Dönüşüm)

byte a = 5;
sbyte b = 30;
short c = 10;

int d = a+b+c;
Console.WriteLine("d:" + d );

//Explict Conversation (Bilincli dönüşüm)


//ToString Metodu

int xx = 6;
string yy = xx.ToString();
Console.WriteLine("yy:"+yy);

//System.convert
string s1 ="10", s2 = "20";
int sayi1,sayi2;
int toplam;

sayi1 = Convert.ToInt32(s1);
sayi2 = Convert.ToInt32(s2);

toplam = sayi1 + sayi2;
Console.WriteLine("Toplam:" +toplam);



