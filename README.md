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
<h3 align="center">1 - Abstract Design Pattern</h3>

### 📖 Tanım  
**Abstract Design Pattern**, bir nesnenin hangi sınıftan türetileceğini tam olarak bilmeden, soyut (**abstract class** veya **interface**) bir yapı üzerinden nesne üretmeyi sağlar.  
Yani ortak bir çatı tanımlanır, farklı sınıflar bu çatıyı uygular.

---

### 🎯 Neden Kullanılır?  
- Kodun **esnek** ve **genişletilebilir** olması için  
- Farklı ürün/senaryolarda aynı çatı üzerinden farklı nesneler oluşturabilmek için  
- **Bağımlılıkları azaltmak** için  

---

### ⚙️ Nasıl Kullanılır?  
1. Bir **abstract class** veya **interface** tanımlanır  
2. Ortak davranışlar burada belirlenir  
3. Farklı sınıflar bu soyut yapıyı **inherit** (kalıtım) ederek kendi özel davranışlarını yazar  
4. Kullanıcı kodu sadece **abstract yapıyı bilir**, hangi sınıfın çağrıldığıyla uğraşmaz  

---

### 🌍 Günlük Hayat Örneği  
Bir **içecek makinesi** düşün:  

- Makine sadece `IçecekHazırla()` soyut metodunu bilir  
- **Kahve sınıfı** bu metodu kahveye göre uygular  
- **Çay sınıfı** bu metodu çaya göre uygular  
- Kullanıcı “içecek hazırla” der → arkada çay mı kahve mi hazırlandığını bilmek zorunda değildir  

---
### ✅ Özet 

Abstract Design Pattern → Ortak bir şablon üzerinden farklı nesneler üretmeyi sağlar.
Avantajı → Esneklik, bağımlılığı azaltma, genişletilebilirlik.


<p align="center">
  <img src="https://github.com/user-attachments/assets/9e999a68-6dee-4f2f-a505-75a9d3449262" 
       alt="Abstract Design Pattern Diagram" 
       width="70%" />
</p>

---
<h3 align="center">2 - Adapter Design Pattern</h3>

### 📖 Tanım  
**Adapter Design Pattern**, uyumsuz iki sınıfı veya sistemi birbirine uyumlu hale getirmek için kullanılan yapısal bir tasarım desenidir.  
Bir çeşit **çevirmen / dönüştürücü** görevi görür.  

---

### 🎯 Neden Kullanılır?  
- Farklı **arayüzlere (interface)** sahip sınıfları birlikte çalıştırabilmek için  
- Eski kodları **değiştirmeden** yeni sisteme entegre etmek için  
- Kod tekrarını ve **karmaşıklığı azaltmak** için  

---

### ⚙️ Nasıl Kullanılır?  
1. Bir **hedef arayüz (Target Interface)** tanımlanır  
2. Bu arayüze uymayan bir mevcut sınıf (**Adaptee**) vardır  
3. **Adapter sınıfı**, bu mevcut sınıfı hedef arayüze uydurur  
4. Kullanıcı sadece **hedef arayüzü** kullanır, uyumsuzluğu fark etmez  

---

### 🌍 Günlük Hayat Örneği  
Bir **priz adaptörü** düşün:  

- Telefon şarj aletin **ABD fişine** göre tasarlanmış olabilir  
- Türkiye’deki priz ise uyumlu değildir  
- Bir **priz adaptörü** kullanarak cihazını şarj edebilirsin  
➡️ Burada:  
- **Priz = Sistem**  
- **Cihaz = Sınıf**  
- **Adaptör = Adapter Pattern**  
---
### ✅ Özet 
Adapter Design Pattern → Uyumsuz yapıları uyumlu hale getirir.
Avantajı → Eski ve yeni sistemleri birlikte çalıştırmak, kodu tekrar yazmadan entegre etmek.

<p align="center">
<img width="741" height="623" alt="image" src="https://github.com/user-attachments/assets/58e14418-f5e6-428e-8238-eef5dfa948a6" />
</p>

---
<h3 align="center">3 - Bridge Design Pattern</h3>

### 📖 Tanım  
**Bridge Design Pattern**, soyutlama (**Abstraction**) ile uygulama (**Implementation**) kısımlarını birbirinden ayırarak,  
ikisinin de bağımsız şekilde geliştirilebilmesini sağlayan yapısal bir tasarım desenidir.  

---

### 🎯 Neden Kullanılır?  
- Soyutlama ile uygulamanın birbirine **sıkı sıkıya bağlı olmasını engellemek** için  
- Hem soyutlamayı hem de uygulamayı **ayrı ayrı genişletebilmek** için  
- **Kod tekrarını azaltmak** ve **esnekliği artırmak** için  

---

### ⚙️ Nasıl Kullanılır?  
1. Bir **Abstraction (Soyutlama sınıfı)** tanımlanır → kullanıcı bu sınıf üzerinden sistemi görür  
2. Bir **Implementor (Uygulama arayüzü)** tanımlanır → detayların nasıl yapılacağını belirler  
3. **ConcreteImplementor** sınıfları bu arayüzü uygular  
4. **Abstraction** sınıfı, **implementasyonu** kullanarak işlemleri gerçekleştirir  

---

### 🌍 Günlük Hayat Örneği  
Bir **uzaktan kumanda** düşün:  

- **Abstraction** → Kumanda (kullanıcı sadece “aç/kapat” düğmesine basar)  
- **Implementor** → Elektronik cihaz arayüzü (TV, Radyo, Klima gibi)  
- **ConcreteImplementor** → TV sınıfı, Radyo sınıfı, Klima sınıfı  

➡️ Kullanıcı aynı kumanda ile farklı cihazları yönetebilir.  
Kumanda değişmeden cihaz türü değişebilir.  

---

### ✅ Özet  
- **Bridge Design Pattern** → Soyutlama ve uygulamayı birbirinden ayırarak esnek ve bağımsız geliştirme sağlar  
- **Avantajı** → Hem soyutlamanın hem de uygulamanın ayrı ayrı genişletilmesine izin verir, tekrar eden kodu azaltır  


<p align="center">
<img width=800" height="550" alt="image" src="https://github.com/user-attachments/assets/bc68ee25-5c30-4159-bc62-8f7437b953c3" />
</p>

---
<h3 align="center">4 - Builder Design Pattern</h3>

### 📖 Tanım  
**Builder Design Pattern**, karmaşık nesnelerin adım adım (**step by step**) oluşturulmasını sağlayan bir **yapılandırma (creational)** tasarım desenidir.  
Nesnenin **nasıl oluşturulacağı** ile **hangi parçalarının olacağı** birbirinden ayrılır.  

---

### 🎯 Neden Kullanılır?  
- Karmaşık nesneleri **yönetilebilir** şekilde kurmak için  
- Aynı nesnenin farklı tiplerini (**farklı kombinasyonlarla**) oluşturabilmek için  
- Kodun **okunabilirliğini** ve **bakımını kolaylaştırmak** için  

---

### ⚙️ Nasıl Kullanılır?  
1. **Product** (Ürün sınıfı) tanımlanır → oluşturulacak nesne  
2. Bir **Builder arayüzü** oluşturulur → hangi adımların olacağını belirtir  
3. **Concrete Builder** sınıfları → bu adımları farklı şekillerde uygular  
4. **Director** sınıfı → adımların sırasını yönetir  
5. Sonuç → farklı kombinasyonlarla aynı tipte ürünler üretilebilir  

---

### 🌍 Günlük Hayat Örneği  
Bir **hamburgerci** düşün:  

- **Product** → Hamburger  
- **Builder** → Hamburgerin adımları: ekmek seç, köfte ekle, sos ekle, içecek ekle  
- **Concrete Builder** → McDonald’s Burger Builder, Burger King Burger Builder (farklı içerikler)  
- **Director** → Kasadaki görevli “BigMac yap” dediğinde adımları sırasıyla uygular  

➡️ Sonuç: Aynı süreçle farklı türde hamburgerler hazırlanabilir  

---

### ✅ Özet  
- **Builder Design Pattern** → Karmaşık nesneleri adım adım inşa etmeyi sağlar  
- **Avantajı** → Farklı türde ürünleri aynı süreçle oluşturabilme, esneklik ve düzenli kod yapısı  


<p align="center">
<img width="778" height="723" alt="image" src="https://github.com/user-attachments/assets/6a1a71d9-5512-4a3b-9bf0-c996a3d99311" />
</p>

---
<h3 align="center">5 - Chain of Responsibility Design Pattern</h3>

### 📖 Tanım  
**Chain of Responsibility Design Pattern**, bir isteğin (**request**) birden fazla nesne tarafından **sırayla işlenmesini** sağlayan bir **davranışsal (behavioral)** tasarım desenidir.  
Hangi nesnenin isteği işleyeceği, çalışma zamanında zincir üzerinde belirlenir.  

---

### 🎯 Neden Kullanılır?  
- İsteği kimin ele alacağını **kodda sabitlememek** için  
- İstek farklı koşullara göre farklı nesneler tarafından işlenebilsin diye  
- **Sorumlulukları nesneler arasında paylaştırmak** ve bağımlılığı azaltmak için  

---

### ⚙️ Nasıl Kullanılır?  
1. Bir **Handler (işleyici) arayüzü** tanımlanır  
2. Her bir **ConcreteHandler**, bu arayüzü uygular  
   - İsteği işler ya da zincirdeki bir sonraki nesneye aktarır  
3. İstek **zincirin başına** gönderilir → uygun olan handler isteği işler  

---

### 🌍 Günlük Hayat Örneği  
Bir **şirket izin onayı süreci** düşün:  

- Çalışan **10 gün izin** istedi  
- **Handler 1 (Takım Lideri)** → 3 güne kadar izin onaylayabilir. 10 günse → üstüne yollar  
- **Handler 2 (Müdür)** → 7 güne kadar izin onaylayabilir. 10 günse → üstüne yollar  
- **Handler 3 (Genel Müdür)** → Daha uzun izinleri onaylar  

➡️ Çalışan sadece “izin isteği” gönderir.  
Kim onaylayacaksa zincir üzerinde karar verilir.  

---

### ✅ Özet  
- **Chain of Responsibility Pattern** → Bir isteği sırayla farklı nesnelerin ele almasına olanak tanır  
- **Avantajı** → İsteğin kim tarafından işleneceğini bilmeye gerek yoktur, zincir **dinamik** ve **esnektir**  


<p align="center">
<img width="800" height="560" alt="image" src="https://github.com/user-attachments/assets/d22154f9-8bba-44cb-95a2-4b4585b0666a" />

</p>
---
<h3 align="center">6 - Command Design Pattern</h3>

### 📖 Tanım  
**Command Design Pattern**, bir isteği (**işlemi**) nesneye dönüştüren **davranışsal (behavioral)** bir tasarım desenidir.  
Böylece işlemler **parametre gibi saklanabilir, kuyruklanabilir veya geri alınabilir (undo)**.  

---

### 🎯 Neden Kullanılır?  
- İstekleri **metot çağrısı yerine nesne** olarak temsil etmek için  
- İşlemleri **kuyruklamak, loglamak veya geri almak (undo/redo)** için  
- **Çağıran (Invoker)** ile **işlemi yapan (Receiver)** sınıflarını birbirinden ayırmak için  

---

### ⚙️ Nasıl Kullanılır?  
1. Bir **Command arayüzü** tanımlanır → `Execute()` metodu içerir  
2. **ConcreteCommand** sınıfları → belirli bir işlemi (**Receiver** üzerinde) tanımlar  
3. **Receiver** → asıl işi yapan sınıftır  
4. **Invoker** → komutu çağırır ama nasıl yapıldığını bilmez  
5. **Client** → hangi komutun kullanılacağını belirler  

---

### 🌍 Günlük Hayat Örneği  
Bir **akıllı ev kumandası** düşün:  

- **Command** → `ICommand` arayüzü (`Execute`)  
- **ConcreteCommand** → “Lambayı Aç Komutu”, “Televizyonu Kapat Komutu”  
- **Receiver** → Lamba, Televizyon (gerçek cihaz)  
- **Invoker** → Kumanda (hangi tuşa basıldığını bilir ama arkada hangi cihazın çalıştığını bilmez)  
- **Kullanıcı** → “1’e bas” der → kumanda lambayı açar  

---

### ✅ Özet  
- **Command Pattern** → İstekleri nesneye çevirerek parametre gibi saklanmasını, kuyruklanmasını, loglanmasını veya geri alınmasını sağlar  
- **Avantajı** → Esneklik, gevşek bağlılık, undo/redo desteği  

---

<p align="center">
 <img width="788" height="658" alt="image" src="https://github.com/user-attachments/assets/c1c0c68c-263e-465e-8a7d-654cbc31c48d" />
</p>


-----
<h3 align="center">7 - Composite Design Pattern</h3>

### 📖 Tanım  
**Composite Design Pattern**, ağaç yapısındaki nesneleri (**bütün–parça ilişkisini**) aynı şekilde kullanmayı sağlayan bir **yapısal (structural)** tasarım desenidir.  
Yani tek bir nesne ile bir grup nesne **aynı arayüz üzerinden** yönetilir.  

---

### 🎯 Neden Kullanılır?  
- **Bireysel nesneler** ile **grup nesnelerini** aynı şekilde işlemek için  
- **Hiyerarşik (ağaç) yapılarda** kodu basitleştirmek için  
- “**Tekil–Grup farkı**” olmadan işlemler yapabilmek için  

---

### ⚙️ Nasıl Kullanılır?  
1. Bir **Component (bileşen arayüzü)** tanımlanır  
2. **Leaf (yaprak sınıf)** → Alt elemanı olmayan sınıf (ör. ürün)  
3. **Composite (bileşik sınıf)** → Alt elemanları tutar ve yönetir (ör. kategori)  
4. **Client** → Hem **Leaf** hem de **Composite** nesneleri aynı arayüz üzerinden kullanır  

---

### 🌍 Günlük Hayat Örneği  
Bir **dosya sistemi** düşün:  

- **Leaf** → Dosya (altı yoktur)  
- **Composite** → Klasör (içinde dosya veya başka klasör olabilir)  
- **Kullanıcı** → “Boyut hesapla” dediğinde;  
  - Tek bir dosyanın boyutunu alabilir  
  - Bir klasörün içindeki tüm dosyaların toplam boyutunu da alabilir  

---

### ✅ Özet  
- **Composite Pattern** → Tekil nesneler ile grup nesnelerini aynı şekilde yönetmeyi sağlar  
- **Avantajı** → Hiyerarşik yapıları sadeleştirir, kod tekrarını azaltır  

---

<p align="center">
<img width="850" height="734" alt="image" src="https://github.com/user-attachments/assets/940e3bf7-8373-4394-9881-7e0822d51768" />
</p>

---

<h3 align="center">8 - CQRS (Command Query Responsibility Segregation)</h3>

### 📖 Tanım  
**CQRS (Command Query Responsibility Segregation)** bir **tasarım yaklaşımıdır**.  
Okuma (**Query**) ve Yazma (**Command**) işlemlerinin farklı mantıklarla ele alınmasını sağlar.  

---

### 🎯 Neden Kullanılır?  
- Veri **okuma** ve **yazma** işlemlerinin ihtiyaçları farklıdır → ayrı yönetilirse **performans ve esneklik artar**  
- Büyük sistemlerde **karmaşayı azaltmak** için  
- **Sorgular (read)** → hızlı ve optimize olmalı  
- **Komutlar (write)** → iş kurallarına uymalıdır  

---

### ⚙️ Nasıl Kullanılır?  
1. **Command** → Sistemde değişiklik yapan işlemler (insert, update, delete)  
2. **Query** → Sistemde sadece veri getiren işlemler  
3. Bu ikisi farklı **handler sınıflarında** yazılır  
4. Ortak bir **Mediator** veya benzer yapı (örn. MediatR) üzerinden çağrılır  

---

### 🌍 Günlük Hayat Örneği  
Bir **restoran** düşün:  

- **Command (Yazma)** → Garsona sipariş vermek (sistemde değişiklik olur, mutfağa bilgi gider)  
- **Query (Okuma)** → Garsona “Siparişim hazır mı?” diye sormak (sadece bilgi gelir, sistemde değişiklik olmaz)  

➡️ Sipariş vermek ile siparişi sorgulamak farklı süreçlerdir, ama aynı sistem üzerinden yönetilir.  

---

### ✅ Özet  
- **CQRS Pattern** → Okuma ve yazma işlemlerini ayırarak kodu sadeleştirir ve ölçeklenebilir hale getirir  
- **Avantajı** → Performans artışı, okunabilir kod, karmaşanın azalması  

---

<p align="center">
<img width="807" height="734" alt="image" src="https://github.com/user-attachments/assets/1d05a521-753d-40ba-a0e8-9e3146a996dd" />

</p>

--



<h3 align="center">9 - Decorator Design Pattern</h3>

### 📖 Tanım  
**Decorator Design Pattern**, bir nesnenin davranışlarını **değiştirmek** veya **genişletmek** için kullanılan bir **yapısal (structural)** tasarım desenidir.  
Bunu **kalıtım yerine dinamik olarak sarmalama (wrapping)** ile yapar.  

---

### 🎯 Neden Kullanılır?  
- Mevcut sınıfı **değiştirmeden yeni özellikler eklemek** için  
- **Kod tekrarını önlemek** için  
- Farklı kombinasyonlarla **esnek özellikler** oluşturabilmek için  

---

### ⚙️ Nasıl Kullanılır?  
1. Bir **Component** arayüzü tanımlanır  
2. **ConcreteComponent** → Bu arayüzü uygular (temel sınıf)  
3. **Decorator** → Component arayüzünü uygular ama içinde başka bir Component referansı tutar  
4. **ConcreteDecorator** sınıfları → Temel sınıfa yeni davranış ekler  

---

### 🌍 Günlük Hayat Örneği  
Bir **kahve siparişi** düşün:  

- **Component** → Sade Kahve  
- **ConcreteDecorator 1** → Süt eklenmiş kahve  
- **ConcreteDecorator 2** → Çikolata eklenmiş kahve  
- İstediğin kadar dekoratör eklersin → **Sütlü + Çikolatalı + Kremalı kahve**  

➡️ Temel kahve değişmez, sadece **üzerine özellikler eklenir**  

---

### ✅ Özet  
- **Decorator Pattern** → Bir nesneye dinamik olarak yeni özellikler ekler  
- **Avantajı** → Esneklik, kod tekrarını azaltma, kalıtım kullanmadan genişletme  

---

<p align="center">
 <img width="779" height="713" alt="image" src="https://github.com/user-attachments/assets/e7f83dda-e7d9-41a3-8ae5-2ae83d74f02e" />
</p
  
---
<h3 align="center">10 - Facade Design Pattern</h3>

### 📖 Tanım  
**Facade Design Pattern**, karmaşık bir sistemi **tek bir basit arayüz** ile kullanmayı sağlayan bir **yapısal (structural)** tasarım desenidir.  
Yani birçok sınıfın karmaşık işlemleri, kullanıcıya sade bir **kapı (facade)** üzerinden sunulur.  

---

### 🎯 Neden Kullanılır?  
- Kullanıcıyı sistemin **karmaşasından korumak** için  
- Alt sistemlere doğrudan erişimi engelleyip, **tek noktadan yönetim** sağlamak için  
- Kodun **okunabilirliğini** ve **bakımını kolaylaştırmak** için  

---

### ⚙️ Nasıl Kullanılır?  
1. Sistemde birçok **karmaşık sınıf** vardır (**Subsystems**)  
2. Bir **Facade sınıfı**, bu sınıfları içinde barındırır  
3. Kullanıcı sadece **Facade** üzerinden işlem yapar, detayları bilmek zorunda kalmaz  

---

### 🌍 Günlük Hayat Örneği  
Bir **otel resepsiyonu** düşün:  

- **Müşteri** sadece resepsiyon görevlisi ile konuşur  
- **İşlemler**: Oda ayarlamak, restoran rezervasyonu yapmak, temizlik istemek → resepsiyon ilgili birimlere iletir  
- **Müşteri** otelin tüm detaylarını bilmez, sadece resepsiyon ile iletişim kurar  

➡️ Burada:  
- **Resepsiyon → Facade**  
- **Arka plandaki otel birimleri → Subsystem’ler**  

---

### ✅ Özet  
- **Facade Pattern** → Karmaşık sistemlere basit bir giriş noktası sağlar  
- **Avantajı** → Kullanıcıya kolaylık, sisteme düzen, bağımlılıkların azalması  


<p align="center">
  <img width="816" height="528" alt="image" src="https://github.com/user-attachments/assets/380001d2-1f27-41bc-aced-c8bff2387c85" />
</p>

---
<h3 align="center">11 - Factory Design Pattern</h3>

### 📖 Tanım  
**Factory Design Pattern**, nesne oluşturma işini doğrudan `new` ile yapmak yerine,  
tek bir **fabrika (factory)** sınıfı üzerinden gerçekleştiren bir **oluşturucu (creational)** tasarım desenidir.  

---

### 🎯 Neden Kullanılır?  
- Nesne oluşturma sürecini **merkezileştirmek** için  
- **Kod tekrarını azaltmak** için  
- Hangi sınıfın oluşturulacağını **çalışma zamanında belirlemek** için  

---

### ⚙️ Nasıl Kullanılır?  
1. Bir **Product arayüzü** tanımlanır  
2. Farklı sınıflar (**Concrete Products**) bu arayüzü uygular  
3. Bir **Factory sınıfı**, hangi product’ın üretileceğine karar verir  
4. **Client (kullanıcı)** → Sadece Factory’i çağırır, hangi sınıfın döneceğini bilmez  

---

### 🌍 Günlük Hayat Örneği  
Bir **araç kiralama ofisi** düşün:  

- **Product** → Araç arayüzü (**IAraç**)  
- **Concrete Products** → Araba, Motosiklet, Minibüs  
- **Factory** → Müşterinin ihtiyacına göre uygun aracı üretir  
- **Kullanıcı** → “Bana bir araç lazım” der → hangi sınıfın verileceğini bilmez, **Factory karar verir**  

---

### ✅ Özet  
- **Factory Pattern** → Nesne oluşturma sürecini merkezi bir fabrika sınıfına devreder  
- **Avantajı** → Gevşek bağlılık, kolay genişletilebilirlik, kod tekrarının azalması  

---

<p align="center">
<img width="871" height="692" alt="image" src="https://github.com/user-attachments/assets/a1873dde-7151-46b9-959d-3c98938b0c8f" />
</p
  
---
<h3 align="center">12 - Flyweight Design Pattern</h3>

### 📖 Tanım  
**Flyweight Design Pattern**, çok sayıda benzer nesnenin hafızada tekrar tekrar oluşturulmasını engelleyip,  
ortak verileri paylaşarak **bellek kullanımını optimize eden** bir **yapısal (structural)** tasarım desenidir.  

---

### 🎯 Neden Kullanılır?  
- **Bellek tüketimini azaltmak** için  
- Aynı özelliklere sahip nesnelerin tekrar tekrar oluşturulmasını engellemek için  
- Büyük ölçekli sistemlerde **performansı artırmak** için  

---

### ⚙️ Nasıl Kullanılır?  
1. Nesnenin **içsel (intrinsic)** verileri tanımlanır → paylaşılabilir, ortak özellikler  
2. **Dışsal (extrinsic)** veriler çalışma sırasında dışarıdan gönderilir → her nesneye özel bilgiler  
3. Bir **Flyweight Factory** sınıfı nesneleri üretir ve paylaşır  

---

### 🌍 Günlük Hayat Örneği  
Bir **oyun** düşün:  

- Oyunda **10.000 ağaç** var  
- Her ağacın türü, rengi, dokusu aslında aynı olabilir → bu bilgiler **intrinsic (ortak)** olarak saklanır  
- Ama her ağacın **konumu farklıdır** → bu bilgi **extrinsic (dışarıdan verilen)** olur  
- ➡️ Böylece 10.000 nesne yerine ortak birkaç nesne hafızada tutulur, **RAM dolmaz**  

---

### ✅ Özet  
- **Flyweight Pattern** → Ortak verileri paylaşarak bellek kullanımını azaltır  
- **Avantajı** → Hafıza optimizasyonu, performans artışı, tekrar eden nesnelerden kaçınma  

---

<p align="center">
  <img width="807" height="546" alt="image" src="https://github.com/user-attachments/assets/6c576dbd-1e43-4f8c-a0b9-cf8660784038" />
</p>
