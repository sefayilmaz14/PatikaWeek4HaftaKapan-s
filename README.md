# Polymorphism,Inheritance,Encapsulation,Abstraction
Bu örnek Telefon -> Üretim Tarihi, Seri Numarası, Ad, Açıklama, İşletim Sistemi, Tr Lisanslı olup olmama durumu özelliklerine sahip.
Bilgisayar -> Üretim Tarihi, Seri Numarası, Ad, Açıklama, İşletim Sistemi, Usb Giriş Sayısı, Bluetooth olup olmama durumu özelliklerini sahip
iki farklı ürünün kullanıcıdan verilerek alınarak üretilmesi ve konsol yardımı ile bilgilendirilmesidir.

*Bu örnekte  bir BaseMakine class'ı oluşturuldu. Ve bu classtan miras alan Phone ve Computer classları oluşturuldu.
*BaseMakine sınıfının özellikleri -> Üretim Tarihi , Seri Numarası , Ad , İşletim Sistemi
*BaseMakine sınıfında bilgileri konsola yazmak için bir method yazıldı. Ve miras alan sınıflarda kullanılması için virtual yapısı işlendi.
*Telefon sınıfı BaseMakine sınıfından alınan polymorphism yapısı tarafından oluşlturulan bilgileri konsola yazdırma methodu methodunu override ederek kullanıcıya konsol bilgi mesajı vermektedir.
*Bilgisayar sınıfı BaseMakine sınıfından alınan polymorphism yapısı tarafından oluşlturulan bilgileri konsola yazdırma methodu methodunu override ederek kullanıcıya konsol bilgi mesajı vermektedir.Kullanıcdan alınan usb port sayısı verisi 2 veya 4 değil ise -1 değeri atanmaktadır.
.

## Teknolojisi

C# 102 ile yazıldı
