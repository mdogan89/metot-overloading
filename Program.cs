// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string sayi = "999";

bool sonuc = int.TryParse(sayi, out int outSayi);
if (sonuc)
{
    Console.WriteLine("Başarılı" + outSayi);
}
else
{
    Console.WriteLine("Başarısız");
}



Metotlar instance = new Metotlar();
instance.Topla(2, 3, out int toplamSonuc);
Console.WriteLine(toplamSonuc);

int i = 999;

instance.EkranaYazdir(i);

instance.EkranaYazdir("str1","str2");


//Console.ReadLine();





class Metotlar
{
    public void Topla(int a,int b,out int toplam)
    {
        toplam = a + b;
    }

    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }

    public void EkranaYazdir(int a)
    {
        Console.WriteLine(a);
    }

    public void EkranaYazdir(string s1,string s2)
    {
        Console.WriteLine(s1 + s2);
    }

}