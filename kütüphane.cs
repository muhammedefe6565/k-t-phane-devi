// See https://aka.ms/new-console-template for more information

List<string> kütüphane = new List<string>();

kütüphane.Add("çalıkuşu");
kütüphane.Add("acımak");
kütüphane.Add("dava");

int calikusu = 10;
int acimak = 10;
int dava = 10;

Console.WriteLine("gelen kitabın ismini giriniz.");
string isim = Convert.ToString(Console.ReadLine());

Console.WriteLine("kitap kaç adet gelmiştir?");
int miktar1 = Convert.ToInt32(Console.ReadLine());

while (true)
{
    if (isim =="çalıkuşu")
    {
        int adet = calikusu + miktar1;
        Console.WriteLine("bu kitap kütüphanede mevcuttur.güncel çalıkuşu kitabı stok sayısı=" + adet);
        break;
        
    }
    else if (isim =="acımak")
    {
       int adet =acimak+miktar1;
        Console.WriteLine("bu kitap kütüphanede mevcuttur.güncel acımak kitabı stok sayısı="+adet);
       

        break;  
       
    }
    else if (isim =="dava")
    {
       int adet = dava+miktar1;
        Console.WriteLine("bu kitap kütüphanede mevcuttur.güncel dava kitabı stok sayısı="+adet);
        
        break;  
        
    }
    else
    {
        Console.WriteLine("kitabın yazarı kimdir?");
        string yazar = Convert.ToString(Console.ReadLine());
        Console.WriteLine("kitaabın yayın yılı kaçtır?");
        int yayin_yili = Convert.ToInt32(Console.ReadLine());
        break;


    }
    kütüphane.Add(isim);
}

string[] kitaplar = { "acımak", "dava", "çalıkuşu", isim };

Console.WriteLine("mevcut kitapların listesi:");
Console.WriteLine(kitaplar[0]);
Console.WriteLine(kitaplar[1]); 
Console.WriteLine(kitaplar[2]);
Console.WriteLine(kitaplar[3]);

Console.WriteLine("lütfen kiralamak istediğiniz kitabı seçiniz");
string secim = Convert.ToString(Console.ReadLine());

Console.WriteLine("kaç gün kiralamak istiyorsunuz?");
int gün_sayisi = Convert.ToInt32(Console.ReadLine());

int ödeme = gün_sayisi * 5;
Console.WriteLine("tutar="+ödeme);

Console.WriteLine("bütceniz ne kadar?");
int bütce = Convert.ToInt32(Console.ReadLine());

if ( bütce<ödeme)
{
    Console.WriteLine("bütceniz yetersizdir.lütfen gün sayısını azaltın.");
}
else if (bütce>ödeme)
{
    if (secim=="çalıkuşu")
    {
        int stok = calikusu - 1;
        Console.WriteLine("işlem başarıyla gerçekleşmiştir.");
        Console.WriteLine("kalan çalıkuşu kitabı=" + stok);

    }
    else if (secim=="acımak")
    {
        int stok = acimak - 1;
        Console.WriteLine("işlem başarıyla gerçekleşmiştir.");
        Console.WriteLine("kalan acımak kitabı=" + stok);
    }
    else if (secim=="dava")
    {
        int stok = dava - 1;
        Console.WriteLine("işlem başarıyla gerçekleşmiştir.");
        Console.WriteLine("kalan dava kitabı=" + stok);
    }
    else if (secim==isim)
    {
        int stok = miktar1-1;
        Console.WriteLine("işlem başarıyla gerçekleşmiştir.");
        Console.WriteLine("kalan"+isim+"kitabı="+stok);

    }
}








