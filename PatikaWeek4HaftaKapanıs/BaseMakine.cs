using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek4HaftaKapanıs
{
    public abstract class BaseMakine
    {

        //Propetry Tanımlamaları
        public DateTime ProductionDate { get; set; }
        
        public int SerialId { get; set; }
        public string Name { get; set; }
        public string System { get; set; }

        // Üretim tarihini nesne oluşunca üretildiği zamana atayan method
        public BaseMakine()
        {
            ProductionDate = DateTime.Now;
        }
        //Propetryde tanımlanan özellikleri konsola yazılmasını sağlayan method.
        public virtual void PrintInformation()
        {

            
            Console.WriteLine($"Adı:{Name}, Seri Numarası:{SerialId},İşletim sistemi:{System}, Üretim Tarihi:{ProductionDate}");
        }

        //Absract oalrak ürün ismini konsola getirme metodu
        public abstract void GetProductName();
        


    }

    //Telefon Sınıfı
    public class Phone : BaseMakine
    {
        //Propetry tanımlamaları ( Tr Lisansı sorgulaması için)
        public string TrLicence { get; set; }

        //BaseMakine Classından gelen methodu ezerek hem tanımlanan bilgileri hemde lisans sorgulama bilgilerini konsola yazdırıyor.
        public override void PrintInformation()
        {
            base.PrintInformation();
            Console.WriteLine($"Ürünün Tr Lisansı varmı: {TrLicence}");
        }

        // BaseMakine sınıfında tanımlanan method bu sınıfta ezilir.
        public override void GetProductName()
        {
            Console.WriteLine($"Telefonunun adı ->{Name}");
        }

    }
    public class Computer : BaseMakine
    {
        //Field Tanımlamaları
        private int _usbPort;
        //Prppetry Tanımlamaları
        public int UsbPort
        {
            get
            {
                return _usbPort;

            }
            set
            {
                if (value == 2 || value == 4)
                    _usbPort = value;

                else
                    _usbPort = -1;

            }
        }
        public string Bluetooth {  get; set; }// Bluetooth sorgulaması için porpetry tanımlaması

        // BaseMakine sınıfında tanımlanan method bu sınıfta ezilir.
        public override void GetProductName()
        {
            Console.WriteLine($"Bilgisayarın adı ->{Name}");
        }

        //BaseMakine Classından gelen methodu ezerek hem tanımlanan bilgileri hemde usb port sayısı ve bluetooth sorgulamasını konsola yazdırıyor
        public override void PrintInformation()
        {
            base.PrintInformation();
            Console.WriteLine($"Ürünün Usb Port Sayısı:{UsbPort}");
            Console.WriteLine($"Ürünün Bluetooth Özelliği Varmı:{Bluetooth}");
        }
    }
}
    

