using PatikaWeek4HaftaKapanıs;
using static System.Runtime.InteropServices.JavaScript.JSType;
int secim = 0;
Console.WriteLine("Merhabalar lütfen üretim yapmak istediğiniz ürünü seçiniz");
Console.WriteLine("Girişinizi seçmek istediğiniz ürününe ait sayı üzerinden yapınız. Örn 1");
bool exit = false;
do
{
    Console.WriteLine("1-)Telefon\n2-)Bilgisayar\n3-)Çıkış");
    bool control = false;
    do
    {
        secim = 0;
        string input = Console.ReadLine();
        if (int.TryParse(input, out secim))
        {

            control = true;

        }
        else
        {
            Console.WriteLine("Geçerli bir sayı giriniz.");
        }
    } while (!control);

    if (secim == 1)
        PhoneCreator();
    else if (secim == 2)
        ComputerCreator();
    else if (secim == 3)
        exit = true;
    else
    {
        Console.WriteLine("Lütfen geçerli bir giriş yapınız");
        exit = false;
    }
} while (!exit);

void PhoneCreator()
{
    bool exit1 = false;
    do
    {
        Phone phone1 = new Phone();
        Console.WriteLine("Lütfen Telefon İsmini Giriniz");
        phone1.Name = Console.ReadLine();
        Console.WriteLine("Lütfen Telefon Seri Numarasını Giriniz");
        phone1.SerialId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Lütfen Telefon İşletim Sistemini Giriniz");
        phone1.System = Console.ReadLine();
        Console.WriteLine("Üretilecek Telefonun Tr Lisansı Varmı ? Evet / Hayır");
        phone1.TrLicence = Console.ReadLine();
                Console.WriteLine("Ürün Başarıyla Üretildi");
        phone1.PrintInformation();
        phone1.GetProductName();
        Console.WriteLine("Başka Bir üretim yapmak isterminiz? evet / hayır");
        string choice = Console.ReadLine();
        if (choice == "evet")
            exit1 = false;
        else
            exit1 = true;
    } while (!exit1);



}

void ComputerCreator()
{
    bool exit2 = false;
    do
    {
        Computer computer1 = new Computer();
        Console.WriteLine("Lütfen Bilgisayar İsmini Giriniz");
        computer1.Name = Console.ReadLine();
        Console.WriteLine("Lütfen Bilgisayar Seri Numarasını Giriniz");
        computer1.SerialId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Lütfen Bilgisayar İşletim Sistemini Giriniz");
        computer1.System = Console.ReadLine();
        Console.WriteLine("Ürünün Usb Port Sayısını Giriniz");
        computer1.UsbPort = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Üretilecek Bilgisayarın Bluetooth Özelliği Varmı ? evet / hayır");
        computer1.Bluetooth=Console.ReadLine();
        Console.WriteLine("Ürün Başarıyla Üretildi");
        computer1.PrintInformation();
        computer1.GetProductName();
        Console.WriteLine("Başka Bir üretim yapmak isterminiz? evet / hayır");
        string choice1 = Console.ReadLine();
        if (choice1 == "evet")
            exit2 = false;
        else
            exit2 = true;
    } while (!exit2);


}