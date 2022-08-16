using System.Collections;
ArrayList Tutucu=new ArrayList();
int first=0;
int even=0;
Console.WriteLine("Lütfen Birinci Pozitif Tam Sayıyı Giriniz:");
first=Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Lütfen İkinci Pozitif Tam Sayıyı Giriniz:");
even=Convert.ToInt16(Console.ReadLine());
int ConserVative = 0;
for(int i=1; i<=first; i++)
{
    Console.WriteLine("Lütfen"+" "+i+" "+".Sayıyı Giriniz:");
    ConserVative=Convert.ToInt16(Console.ReadLine());

    if(ConserVative==even || ConserVative%even==0)
    {
        Tutucu.Add(ConserVative);
    } 
    else if(even % ConserVative==0)  Tutucu.Add(ConserVative);

}
Console.WriteLine("_________________----------_______________");

foreach (var sayi in Tutucu)
{
    Console.WriteLine("Saıyıa Eşit Olan Veya Tam Bölünen Sayılar"+" "+sayi);
}