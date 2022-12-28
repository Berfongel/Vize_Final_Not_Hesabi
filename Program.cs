// See https://aka.ms/new-console-template for more information
double vizeNot;
double finalNot;
double ortalama;
//ekrana vize ve final notlarını girmek için 
Console.WriteLine("Vize notunuzu giriniz.");
vizeNot = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Final notunuzu giriniz.");
finalNot = Convert.ToDouble(Console.ReadLine());
//ortalama hesaplama formülü
ortalama = Convert.ToDouble(((vizeNot*30)/100)+((finalNot*70/100)));
Console.WriteLine("Sınav ortalamanız = " +ortalama);
Console.WriteLine();
if (ortalama >= 50) 
{
    Console.WriteLine("Tebrikler! " + ortalama + " ile dersi geçtin");
 }
else
{
    Console.WriteLine("Üzgünüm! " + ortalama + " ile dersten kaldın");

}

