// See https://aka.ms/new-console-template for more information

double vizeNot;
double finalNot;
double ortalama;
//ekrana vize notunu girmek için 
Console.WriteLine("Vize notunuzu giriniz.");
vizeNot = Convert.ToDouble(Console.ReadLine());

//ekrana final notunu girmek için 
Console.WriteLine("Final notunuzu giriniz.");
finalNot = Convert.ToDouble(Console.ReadLine());

//final notu 50 ve üzerindeyse
if (finalNot >= 50)
{
    //sınav ortalaması hesabı yapılır
    ortalama = Convert.ToDouble(((vizeNot * 30) / 100) + ((finalNot * 70 / 100)));
    Console.WriteLine("Sınav ortalamanız = " + ortalama);

    if (ortalama >= 50)
    {
        Console.WriteLine("Tebrikler! " + ortalama + " ile dersi geçtin");
    }

    else
    {
        Console.WriteLine("Üzgünüm! " + ortalama + " ile dersten kaldın");

    }
}

else {
    Console.WriteLine("Final notunuzun 50 ve üzeri olması lazım.");

}
