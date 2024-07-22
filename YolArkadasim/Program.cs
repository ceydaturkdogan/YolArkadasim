string[] location = { "bodrum", "marmaris", "cesme" };

int firstPrice =4000;
int secondPrice =3000;
int thirdPrice =5000;


int person = 0;
int prices = 0;

Console.Write("Lütfen gitmek istediğiniz lokasyonu yazınız.(Lütfen Türkçe karakter kullanmayınız) : ");
string userLocation = Console.ReadLine().ToLower();

for (int i = 0; i <= location.Length; i++)
{

    switch (userLocation)
    {
        case "bodrum":
            Console.Write("Kaç kişi tatil planlıyorsunuz? ");
            person = Convert.ToInt32(Console.ReadLine());
            prices = firstPrice;
            i=location.Length;
            break;
        case "marmaris":
            Console.Write("Kaç kişi tatil planlıyorsunuz? ");
            person = Convert.ToInt32(Console.ReadLine());
            prices = secondPrice;
            i = location.Length;
            break;
        case "cesme":
            Console.Write("Kaç kişi tatil planlıyorsunuz? ");
            person = Convert.ToInt32(Console.ReadLine());
            prices = thirdPrice;
            i = location.Length;
            break;
        default:
            Console.Write("Hatalı lokasyon girdiniz lütfen yeniden lokasyon girişi yapınız \n Girebileceğiniz lokasyonlar : Bodrum Marmaris Cesme -->");
            userLocation = Console.ReadLine().ToLower();
            i++;
            break;


    }
}

Console.WriteLine($"\n\nGitmek istediğiniz lokasyon {userLocation}'dır.\nBurada denize girebilir aynı zamanda şehrin doğal güzelliklerini görüp gezebilirsiniz. \nKişi başı paket başlangıç fiyatı ise {prices}'dır. ");

Console.Write("Tatile hangi ulaşım şekli ile gitmek istersiniz? \n Kara yolu --> Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL'dir. \n Hava yolu  --> Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL'dir. Eğer Kara yolu ise 1 Hava yolunu tercih ettiyseniz 2 yazınız");
int transportation = Convert.ToInt32(Console.ReadLine());
int transportPrice = 0;
int highway = 1500;
int airline = 4000;

while (transportPrice == 0) { //burada while döngüsüne sokma sebebim ulaşım şeklini kaç kez yanlış gireceğini bilmemem
if(transportation == 1)
{
    transportPrice = highway * person;
    Console.WriteLine(transportPrice);
}
else if(transportation == 2)
{
     transportPrice=airline * person;
    Console.WriteLine(transportPrice);
}
else
{
    Console.Write("Lütfen geçerli bir numara giriniz");
    transportation = Convert.ToInt32(Console.ReadLine());

}
}


int totalPrices = (person * prices) + transportPrice;
Console.WriteLine($"Toplam tatil harcamanız {totalPrices}'dır");


