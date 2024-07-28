Baslangic:                                      //Uygulama başlangıç etiketi
Console.WriteLine("Yol arkadaşım tatil uygulamasına Hoş Geldin :) ");  //Uygulama Kullanıcı Karşılama Ekranı (App User Welcome Screen)
Console.WriteLine("3 adet lokasyonumuz var:");
Console.WriteLine("1 - Bodrum (Paket başlangıç fiyatı 4000 TL)"); Console.WriteLine("2 - Marmaris (Paket başlangıç fiyatı 3000 TL)"); Console.WriteLine("3 - Çeşme (Paket başlangıç fiyatı 5000 TL)");
string city1 = "bodrum";
string city2 = "marmaris";
string city3 = "çeşme";    //değişken tanımlama aşaması
int city1Price = 4000;
int city2Price = 3000;
int city3Price = 5000;

Console.WriteLine("Size iletilen seçeneklerden gitmek istediniz lokasyonu seçebilir misiniz?");
string city = Console.ReadLine().ToLower();

while (true)
{
    if (city != city1 && city != city2 && city != city3)                              //yanlış seçim olması halinde döngüye alıyoruz.
    {
        Console.WriteLine("Yanlış bir seçim yaptınız.\n Seçim yapabileceğiniz lokasyonlar -->Bodrum,Marmaris,Çeşme");
        city = Console.ReadLine().ToLower();
        continue;
    }
    else
    {
        Console.WriteLine("Seçtiğiniz lokasyona göre işlemler devam ediyor.");
        break;
    }
}
Console.Write("Kaç kişi için tatil planlıyorsunuz ? --> ");
int person = Convert.ToInt32(Console.ReadLine());

switch (city)
{
    case "bodrum":
        Console.WriteLine("Bodrum'a geldiysen eğer Zeki Müren'in evine gitmelisin.");
        break;                                                      //seçilen lokasyona göre tanıtıcı bilgi metni gösterimi.
    case "marmaris":
        Console.WriteLine("Marmaris'e geldiysen eğer Marmaris Milli Parkı'na gitmelisin.)");
        break;
    default:
        Console.WriteLine("Çeşme'ye geldiysen eğer Çeşme Kalesi'ne gitmelisin.");
        break;
}

Console.WriteLine("Tatiline hangi ulaşım yolu ile gitmek istersin ?");
Console.WriteLine("1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )");
Console.WriteLine("2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
Console.Write("Lütfen yukarıdaki seçeneklerden bir tanesini seçiniz.1 ya da 2 seçeneği ile cevap verebilirsiniz.");
int choiceWay = Convert.ToInt32(Console.ReadLine());
while (true)
{
    if (choiceWay != 1 && choiceWay != 2)
    {
        Console.WriteLine("Yanlış seçim yaptınız.Tekrar seçiniz");
        choiceWay = Convert.ToInt32(Console.ReadLine());
        continue;
    }
    else
    {
        Console.WriteLine("Seçtiğiniz ulaşım yoluna göre hesaplamalar devam ediyor...");
        break;
    }

}
int totalWayPrice = 0;
if (choiceWay == 1)          //ulaşım ücreti hesaplama.
    totalWayPrice = 1500;
else
    choiceWay = 4000;

if (city == city1)
{
    Console.WriteLine($"Bodrum için " + person + " kişi  toplam tatil fiyatı -->" + (city1Price + totalWayPrice) * 2);
}
else if (city == city2)                                                                                             //seçilen lokasyon için genel bilgilendirme.
{
    Console.WriteLine($"Marmaris için " + person + " kişi  toplam tatil fiyatı -->" + (city1Price + totalWayPrice) * 2);
}
else
{
    Console.WriteLine($"Çeşme için " + person + " kişi  toplam tatil fiyatı -->" + (city1Price + totalWayPrice) * 2);
}

Console.WriteLine("Seçtiğiniz kriterlere göre tatil fiyatı hesaplandı.Başka bir tatil planlamak ister misiniz ? Evet veya Hayır yazarak işleme devam edebilirsiniz.");
string secim = Console.ReadLine().ToLower();
if (secim == "evet")
{
    goto Baslangic;   //uygulamayı başlangıç noktasına döndürür.
}
else
{
    Console.WriteLine("Uygulama sona erdi.");
}

