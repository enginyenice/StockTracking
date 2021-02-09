
# YAZILIM LAB I - II
## TEK DERS PROJESİ
### Stok Takip Programı
Bu projede, bir mağazada bulunan ürünlerin stok takibinin yapılması beklenmektedir. Program iki arayüzden oluşmaktadır. Program açılırken kullanıcının seçimine göre aşağıdaki
arayüzlerin çalışması gerekmektedir.

### 1) Yönetici Arayüzü (Admin) :

#### :heavy_check_mark: Kullanıcı Modülü

Kullanıcı ekle/sil/güncelle işlemlerinin yapılması.

Kullanıcın tanımlanırken istenen bilgiler;

- Ad, soyad, E-mail, telefon, kullanıcı adı ve şifresi.

####  :heavy_check_mark:  Müşteri Modülü

Müşteri ekle/sil/güncelle işlemlerinin yapılması.

Müşteri tanımlanırken istenen bilgiler;

-Müşteri numarası, Müşteri Firma Adı, Ad, soyad, E-mail, telefon.

####  :heavy_check_mark:  Tedarikçi Modülü

Tedarikçi ekle/sil/güncelle işlemlerinin yapılması.

Tedarikçi tanımlanırken istenen bilgiler;

-Tedarikçi numarası, Tedarikçi Firma Adı, E-mail, telefon.

#### :x: Depo Modülü
Depo ekle/sil/güncelle işlemlerinin yapılması.

Depolar arası transfer ( A deposundan B deposuna ürün aktarımı)

Depoda bulunan stok sayısına göre yöneticinin uyarılması.

Örnek: Depoda bulunan bir malın sayısı (Ürün tanımlanırken kritik stok sayısı olarak belirtiyoruz) 20’nin altına düştüğünde yöneticiye stok durumu hk. uyarı vermesi gerekmektedir.

Depo tanımlanırken istenen bilgiler;

-Depo numarası, Depo Adı, Depo Adres, Depo telefon.

#### :x: Rapor Modülü

Gün içerisinde müşterilere satılan ürünler ve fiyat bilgileri, tedarikçilerden alınan ürünler ve fiyat bilgileri ve gün sonundaki günlük bakiye raporda gösterilmesi beklenmektedir.

|Tarih   | İşlem  |  Tedarik/Müşteri Numarası | Stok Kodu | Adet  | Birim Fiyat  | Toplam Fiyat |
|--|--| -- |-- | --| --| -- |
| 10.11.2014 | Satış  | 112 | 101 | 13 | 25,00 TL  | 325,00 TL |
| 10.11.2014 | Alış | 222 | 102 | 42 | 11,00 TL  | 462,00 TL |
| | | | | | **Günlük Bakiye** | -137,00 TL |


### 2) Kullanıcı Arayüzü:
#### :x: Ürün Modülü

Ürün ekle/sil/güncelle işlemlerinin yapılması.

Ürün tanımlanırken istenen bilgiler;

- Stok Kodu, Cinsi, Birimi, Açıklama, Resim, Kritik Stok Sayısı 
- 
#### :x:  Ürün Alış/Satış Modülü

Alış ve satış modülünü iki farklı arayüz olarak tasarlayınız.

- Ürün Alış Modülü
- 
Tedarikçilerden ürün alımının yapılması.

Ürün alışı tanımlanırken istenen bilgiler;

- Tedarikçi numarası, ürün stok kodu, ürün adet, Birim Alış fiyatı,
Toplam Fiyat

Ürün alımı gerçekleştikten sonra Stok hareketleri tablosuna eklenmesi
gerekmektedir. (Örnek : A ürünü tedarikçiden satın alınırken kayıt
edilmesi ve A ürünü için Stok hareketlerine girdi olarak eklenmesi
gerekmektedir.)
#### :x: Ürün Satış Modülü
Müşteriye ürün satılması. Gelir/Gider tablosuna eklenmesi gerekmektedir.
Ürün satışı tanımlanırken istenen bilgiler;

- Müşteri numarası, ürün stok kodu, ürün adet, Birim Satış fiyatı, Toplam
Fiyat
Ürün satışı gerçekleştikten sonra Stok hareketleri ve Gelir/Gider tablosuna
eklenmesi gerekmektedir.

Örnek:

**Stok Hareketleri Tablosu Kayıt Ekleme**
| HareketID  | İşlem Türü | Tedarikçi/Müşteri Numarası | Ürün Stok Kodu | Ürün Adedi  | Birim Alış |  Toplam |
|--|--| -- | --  | -- | -- |-- |
|1| Alış| 222| 101| 10| 25,00| 250,00|
|2| Satış| 112| 102| 5| 11,00| 55,00|


**Not: Her bir alan için validation controller(doğrulama denetleyicisi) yapmanız
gerekmektedir. ( Örnek: Ad bilgisi içerisine sayı girilemez, e-mail kısmında ‘@’olmak
zorundadır vb.)**

**Not2: Projenizi PC’de çalışabilen herhangi bir platformda geliştirebilirsiniz Kullanıcı
arayüzünde pencere ve buttonlar kullanılmalıdır. Konsol arayüz kullanılmayacaktır.**

**Kullanıcı arayüzünü yaygın kullanılan Visual Studio, Netbeans, Eclipse gibi IDE’lerde
geliştirebilirsiniz.**
