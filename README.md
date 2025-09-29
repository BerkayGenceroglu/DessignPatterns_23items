<h1 align="center">Design Patterns (Tasarım Desenleri-23 Tane)</h1>

Bu repo, yazılım geliştirme sürecinde sıklıkla kullanılan **Tasarım Desenleri (Design Patterns)** üzerine hazırlanmıştır.  
Her bir tasarım deseni için:

- **Tanım**
- **Avantajlar ve kullanım alanları**  
- **Günlük hayattan benzetmeler**  
- **C# ile örnek kod uygulamaları**  

ayrıntılı olarak ele alınmıştır.  

📌 Amaç, tasarım desenlerinin yalnızca teorik bilgilerini değil, aynı zamanda pratik örnekler ve gerçek hayat analojileri ile öğrenilmesini kolaylaştırmaktır.  

---

<h2 align="center">İçindekiler</h2>

Bu projede toplam **23 farklı Design Pattern** bulunmaktadır:

- Creational Patterns (Yaratımsal)  
- Structural Patterns (Yapısal)  
- Behavioral Patterns (Davranışsal)  

Her desen ayrı klasör ve örnekler halinde sunulmuştur.  

---

<h2 align="center">Şimdi Tek Tek Özet Geçelim</h2>
<h3 align="center">1-Abstract Design Pattern</h2>
Tanım:
Abstract Design Pattern, bir nesnenin hangi sınıftan türetileceğini tam olarak bilmeden, soyut (abstract) bir yapı üzerinden nesne üretmeyi sağlayan tasarım desenidir. Yani ortak bir çatı (abstract class veya interface) tanımlanır, farklı sınıflar bu çatıyı uygular.

Neden Kullanılır?

Kodun esnek ve genişletilebilir olması için.

Değişen durumlarda (farklı ürün, farklı senaryo) aynı çatı üzerinden farklı nesneler oluşturabilmek için.

Bağımlılıkları azaltmak için.

Nasıl Kullanılır?

Önce bir abstract class veya interface tanımlanır.

Ortak davranışlar burada belirlenir.

Farklı sınıflar bu soyut yapıyı inherit (kalıtım) ederek kendi özel davranışlarını yazar.

Kullanıcı kodu ise sadece abstract yapıyı bilir, hangi sınıfın çağrıldığıyla uğraşmaz.

Günlük Hayat Örneği:
Bir içecek makinesi düşün:

Makine sadece "IçecekHazırla()" soyut metodunu bilir.

Kahve sınıfı bu metodu kahveye göre, çay sınıfı ise çaya göre uygular.

Kullanıcı “içecek hazırla” der, ama arkada çay mı kahve mi hazırlandığını bilmek zorunda değildir.
https://sdmntprcentralus.oaiusercontent.com/files/00000000-392c-61f5-a87c-338e55aa849d/raw?se=2025-09-29T14%3A29%3A58Z&sp=r&sv=2024-08-04&sr=b&scid=576df916-7e2d-54f8-9a36-3e9ca3b805b6&skoid=f28c0102-4d9d-4950-baf0-4a8e5f6cf9d4&sktid=a48cca56-e6da-484e-a814-9c849652bcb3&skt=2025-09-29T02%3A30%3A03Z&ske=2025-09-30T02%3A30%3A03Z&sks=b&skv=2024-08-04&sig=aiVxtM4oHlIsEgb7T01UYTZtdhVwyQt/xrx1cBDjO84%3D
