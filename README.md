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

abstract Design Pattern → Ortak bir şablon üzerinden farklı nesneler üretmeyi sağlar.
Avantajı → Esneklik, bağımlılığı azaltma, genişletilebilirlik.
<img width="1382" height="918" alt="image" src="https://github.com/user-attachments/assets/9e999a68-6dee-4f2f-a505-75a9d3449262" />
