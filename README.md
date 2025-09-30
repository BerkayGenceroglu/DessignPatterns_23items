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
<img width="690" height="694" alt="image" src="https://github.com/user-attachments/assets/31bbeb8d-1bcc-4f8b-bf37-0b78a0819ba5" />
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
 <img width="953" height="733" alt="image" src="https://github.com/user-attachments/assets/dad3b586-ae3e-41e1-b1cc-eb3a9285d4b7" />
</p>
---
<h3 align="center">13 - Iterator Design Pattern</h3>

### 📖 Tanım  
**Iterator Design Pattern**, bir koleksiyonun (liste, dizi, ağaç vb.) içindeki elemanlara,  
koleksiyonun iç yapısını bilmeden **sırayla erişmeyi** sağlayan bir **davranışsal (behavioral)** tasarım desenidir.  

---

### 🎯 Neden Kullanılır?  
- Koleksiyonun nasıl saklandığını bilmeden **elemanlarına erişmek** için  
- Aynı koleksiyon üzerinde farklı **dolaşma (iteration) yöntemleri** tanımlayabilmek için  
- Kodun **okunabilirliğini artırmak** için  

---

### ⚙️ Nasıl Kullanılır?  
1. Bir **Iterator arayüzü** tanımlanır → `HasNext()`, `Next()` metotlarını içerir  
2. **ConcreteIterator** → Koleksiyondaki elemanlara erişimi gerçekleştirir  
3. **Aggregate (Collection) arayüzü** → `CreateIterator()` metodunu sağlar  
4. **ConcreteAggregate** → Iterator’u döndürür  
5. **Client** → Sadece iterator üzerinden elemanlara erişir  

---

### 🌍 Günlük Hayat Örneği  
Bir **kitaplık** düşün:  

- Kitaplıkta çok sayıda kitap var  
- **Iterator** → “Sonraki kitabı getir”, “Başka kitap var mı?” sorularını yönetir  
- Kullanıcı kitaplığın iç yapısını (**kitaplar liste mi, raflarda mı, alfabetik mi?**) bilmeden sırayla kitaplara erişebilir  

---

### ✅ Özet  
- **Iterator Pattern** → Koleksiyon elemanlarına sırayla erişmeyi sağlar, iç yapıyı gizler  
- **Avantajı** → Esneklik, **kapsülleme (encapsulation)**, farklı dolaşma yöntemlerine imkan tanıma  

---

<p align="center">
<img width="762" height="750" alt="image" src="https://github.com/user-attachments/assets/3ea73fbd-a7e9-4f76-848e-1d6cf86afd16" />
</p>
---

<h3 align="center">14 - Mediator Design Pattern</h3>

### 📖 Tanım  
**Mediator Design Pattern**, nesneler arasındaki **doğrudan iletişimi engelleyip**,  
onların bir **aracı (mediator)** üzerinden haberleşmesini sağlayan bir **davranışsal (behavioral)** tasarım desenidir.  

---

### 🎯 Neden Kullanılır?  
- Nesneler arasındaki **bağımlılığı azaltmak** için  
- Karmaşık iletişim ağını **tek bir merkezden yönetmek** için  
- Kodun **okunabilirliğini** ve **bakımını kolaylaştırmak** için  

---

### ⚙️ Nasıl Kullanılır?  
1. Bir **Mediator arayüzü** tanımlanır → iletişimi yöneten metotları içerir  
2. **ConcreteMediator** → Nesneler arasındaki etkileşimi koordine eder  
3. **Colleague (katılımcılar)** → Sadece **mediator** ile konuşur, birbirleriyle doğrudan konuşmaz  

---

### 🌍 Günlük Hayat Örneği  
Bir **hava trafik kontrol kulesi** düşün:  

- **Uçaklar (Colleague)** → Doğrudan birbirleriyle konuşmaz  
- **Kontrol Kulesi (Mediator)** → Uçaklarla iletişim kurar  
- **Görev** → İniş–kalkış sırasını ayarlamak, çarpışmaları önlemek  

➡️ Böylece **karmaşa engellenir**, iletişim düzenli olur  

---

### ✅ Özet  
- **Mediator Pattern** → Nesneler arasındaki iletişimi merkezi bir aracı üzerinden yönetir  
- **Avantajı** → Bağımlılıkları azaltır, karmaşık ilişkileri sadeleştirir, bakımı kolaylaştırır  

---

<p align="center">
 <img width="949" height="733" alt="image" src="https://github.com/user-attachments/assets/83f69410-1999-470d-ba75-cb5d712426f6" />
</p>
---
<h3 align="center">15 - Memento Design Pattern</h3>

### 📖 Tanım  
**Memento Design Pattern**, bir nesnenin geçmiş durumunu kaydedip gerektiğinde bu duruma geri dönmesini sağlayan bir **davranışsal (behavioral)** tasarım desenidir.  

---

### 🎯 Neden Kullanılır?  
- Nesnenin **durumunu (state) saklamak** için  
- **Undo (geri al)** veya **rollback** gibi özellikleri uygulamak için  
- Nesnenin iç yapısını dışarıya açmadan **geçmişe dönmesini sağlamak** için  

---

### ⚙️ Nasıl Kullanılır?  
1. **Originator** → Durumu oluşturan ve değiştiren sınıf  
2. **Memento** → Originator’un durumunu saklayan sınıf (genellikle `private`)  
3. **Caretaker** → Memento nesnesini saklar ama içeriğini bilmez. Gerekirse geri yükler  

---

### 🌍 Günlük Hayat Örneği  
Bir **metin editörü (Word, Notepad)** düşün:  

- **Originator** → Editör (yazı yazıyorsun)  
- **Memento** → Kaydedilmiş sürüm (**Ctrl + S**)  
- **Caretaker** → Geri al / ileri al (**Undo / Redo**) özelliği  

➡️ Kullanıcı yanlışlıkla bir satırı sildiğinde → “Undo” yapar, eski sürüme döner  

---

### ✅ Özet  
- **Memento Pattern** → Nesnenin geçmiş durumlarını kaydedip geri yüklemeye imkan tanır  
- **Avantajı** → Undo/redo, sürüm yönetimi, veri kaybını önleme  

<p align="center">
 <img width="752" height="720" alt="image" src="https://github.com/user-attachments/assets/1c44a3ab-0453-4572-94e0-f6d5245ad85a" />
</p>---

<h3 align="center">16 - Observer Design Pattern</h3>

### 📖 Tanım  
**Observer Design Pattern**, bir nesnede (**Subject**) olan değişikliğin,  
ona bağlı diğer nesnelere (**Observers**) **otomatik olarak bildirilmesini** sağlayan bir  
**davranışsal (behavioral)** tasarım desenidir.  

---

### 🎯 Neden Kullanılır?  
- Nesneler arasındaki **bağımlılığı azaltmak** için  
- Bir nesnede değişiklik olduğunda bağlı olanların **otomatik güncellenmesi** için  
- **Olay–dinleyici (event-listener)** mantığını uygulamak için  

---

### ⚙️ Nasıl Kullanılır?  
1. **Subject** → Gözlemlenen nesne, observer listesini tutar  
2. **Observer arayüzü** → `Update()` metodu içerir  
3. **ConcreteObserver** → Subject’teki değişikliklere tepki verir  
4. Subject değiştiğinde → Tüm observer’lara haber gönderilir  

---

### 🌍 Günlük Hayat Örneği  
Bir **YouTube kanalı** düşün:  

- **Subject** → Kanal  
- **Observers** → Aboneler  
- Kanal yeni video yüklediğinde (**durum değişir**) → Tüm abonelere bildirim gider  
- Aboneler videoyu izleyip kendi aksiyonlarını alır  

---

### ✅ Özet  
- **Observer Pattern** → Bir nesnedeki değişikliklerin otomatik olarak diğer nesnelere duyurulmasını sağlar  
- **Avantajı** → Olay tabanlı sistem kurma, gevşek bağlılık, kolay genişletilebilirlik  

---

<p align="center">
 <img width="852" height="764" alt="image" src="https://github.com/user-attachments/assets/76949351-f5aa-44ea-a69d-05f0e353ce6b" />
</p>
<h3 align="center">17 - Prototype Design Pattern</h3>

### 📖 Tanım  
**Prototype Design Pattern**, mevcut bir nesnenin **kopyalanarak (clone edilerek)**  
yeni bir nesne oluşturulmasını sağlayan bir **oluşturucu (creational)** tasarım desenidir.  

---

### 🎯 Neden Kullanılır?  
- Nesne oluşturma **maliyetli** (çok zaman alan ya da pahalı) olduğunda  
- Bir nesneyi baştan üretmek yerine **var olanın kopyasını** almak için  
- Nesnenin **başlangıç ayarlarını tekrar tekrar yazmamak** için  

---

### ⚙️ Nasıl Kullanılır?  
1. Bir **Prototype arayüzü** tanımlanır → `Clone()` metodu içerir  
2. **ConcretePrototype** sınıfları, kendilerini kopyalayacak şekilde `Clone()` metodunu uygular  
3. **Client**, `new` ile değil → `Clone()` ile yeni nesne elde eder  

---

### 🌍 Günlük Hayat Örneği  
Bir **fotokopi makinesi** düşün:  

- Elinde bir belge (**orijinal nesne**) var  
- **Fotokopi çekince** → aynı içeriğe sahip bir kopya elde edersin  
- Orijinal belgedeki bilgileri tekrar yazmana gerek kalmaz  

---

### ✅ Özet  
- **Prototype Pattern** → Nesneleri `new` ile sıfırdan üretmek yerine, mevcut nesneyi **kopyalayarak** oluşturur  
- **Avantajı** → Hız, performans, tekrar eden ayarları engelleme  

---

<p align="center">
  <img width="834" height="762" alt="image" src="https://github.com/user-attachments/assets/f6e6f6d4-126e-47b6-98d5-c2f5831b624e" />
</p>

---
<h3 align="center">18 - Proxy Design Pattern</h3>

### 📖 Tanım  
**Proxy Design Pattern**, başka bir nesneye **erişimi kontrol etmek** için kullanılan bir **yapısal (structural)** tasarım desenidir.  
Proxy, gerçek nesnenin yerine geçer ama asıl işi gerekirse **Real Subject**’e yönlendirir.  

---

### 🎯 Neden Kullanılır?  
- Nesneye **doğrudan erişimi sınırlandırmak** için  
- Nesneye erişmeden önce **güvenlik, önbellekleme (cache), loglama** gibi ek işlemler yapmak için  
- **Ağ üzerinden**, uzaktaki nesnelerle çalışırken (**Remote Proxy**)  

---

### ⚙️ Nasıl Kullanılır?  
1. Bir **Subject arayüzü** tanımlanır  
2. **RealSubject** → Asıl işi yapan sınıf  
3. **Proxy** → Subject arayüzünü uygular ama isteği önce kendinde işler, gerekirse **RealSubject**’e yönlendirir  
4. **Client** → Proxy üzerinden **RealSubject**’e ulaşır  

---

### 🌍 Günlük Hayat Örneği  
Bir **güvenlikli bina** düşün:  

- **RealSubject** → Patronun odası  
- **Proxy** → Güvenlik görevlisi  
- **Çalışan** → Doğrudan patronun odasına giremez → önce güvenliğe gelir  
- **Güvenlik (Proxy)** → Kimlik kontrolü yapar, uygun görürse patrona yönlendirir  

---

### ✅ Özet  
- **Proxy Pattern** → Nesneye erişim kontrolü sağlar  
- **Avantajı** → Güvenlik, performans (cache), uzaktan erişim kolaylığı  

---

<p align="center">
  <img width="759" height="471" alt="image" src="https://github.com/user-attachments/assets/dddb5f9e-a608-4a28-bd38-1c5a12ae7570" />
</p>

---

<h3 align="center">19 - Repository Pattern</h3>

### 📖 Tanım  
**Repository Pattern**, uygulamada kullanılan veriye erişim (**CRUD**) işlemlerini tek bir yerde toplayarak,  
iş mantığı ile veritabanı arasına bir **aracı katman** koyan bir tasarım desenidir.  

---

### 🎯 Neden Kullanılır?  
- Veritabanı sorgularını **tekrarlamamak** için  
- İş katmanını (**service/controller**) veritabanı bağımlılıklarından **ayırmak** için  
- **Test edilebilirliği** ve **bakımı kolaylaştırmak** için  

---

### ⚙️ Nasıl Kullanılır?  
1. Bir **`IRepository<T>` arayüzü** yazılır → `GetAll()`, `GetById()`, `Add()`, `Update()`, `Delete()` gibi metotlar içerir  
2. **Concrete Repository** sınıfı, bu arayüzü uygular ve **EF Core / Dapper / ADO.NET** gibi teknolojilerle gerçek sorguları çalıştırır  
3. **Service katmanı** → Repository üzerinden veriye erişir  
4. **Controller** → Servisi çağırır, veritabanı detaylarını bilmez  

---

### 🌍 Günlük Hayat Örneği  
Bir **alışveriş sitesi** düşün:  

- **Database** → Depo (ürünler orada saklanıyor)  
- **Repository** → Depo görevlisi  
- **Service** → Satış görevlisi  
- **Müşteri (Controller)** → “Bana ürün getir” der, ama deponun nasıl düzenlendiğini bilmez.  
  Depo görevlisi (**Repository**) ürünü bulur ve satış görevlisine verir.  

---

### ✅ Özet  
- **Repository Pattern** → Veritabanı ile iş katmanı arasına soyutlama katmanı koyar  
- **Avantajı** → Kod tekrarını azaltır, bağımlılığı düşürür, test etmeyi kolaylaştırır  

---

<p align="center">
<img width="886" height="674" alt="image" src="https://github.com/user-attachments/assets/ec94217b-06ee-4fc8-b459-31773c7f65dd" />
</p
 
---
<h3 align="center">20 - Singleton Design Pattern</h3>

### 📖 Tanım  
**Singleton Design Pattern**, bir sınıfın yalnızca **tek bir örneğinin (instance)** oluşturulmasını  
ve bu örneğe **global erişim** sağlanmasını garanti eden bir **oluşturucu (creational)** tasarım desenidir.  

---

### 🎯 Neden Kullanılır?  
- Uygulama genelinde ortak kullanılacak bir nesne gerektiğinde (**Logger, Cache, Config**)  
- Gereksiz **bellek tüketimini engellemek** için  
- **Merkezi yönetim** ve kontrol sağlamak için  

---

### ⚙️ Nasıl Kullanılır?  
1. Sınıfın **constructor’ı private** yapılır → dışarıdan `new`’lenemez  
2. Sınıf içinde **static bir instance** tutulur  
3. `GetInstance()` metodu ile bu tek örneğe erişilir  
4. Her çağrıda **aynı nesne** döndürülür  

---

### 🌍 Günlük Hayat Örneği  
Bir **ülkenin cumhurbaşkanı** düşün:  

- Her ülkede aynı anda **tek bir cumhurbaşkanı** vardır  
- Halk veya kurumlar ona erişmek isterse → **aynı kişiye** ulaşır  
- Yeni seçim olana kadar başka bir **“new” yapılamaz**  

---

### ✅ Özet  
- **Singleton Pattern** → Bir sınıfın sadece tek bir örneği olmasını sağlar  
- **Avantajı** → Global erişim, kaynak tasarrufu, merkezi kontrol  

---

<p align="center">
<img width="751" height="676" alt="image" src="https://github.com/user-attachments/assets/17d5e0db-6d8c-4790-9a63-a8f0a006fb45" />
</p

 ---
 <h3 align="center">21 - State Design Pattern</h3>

### 📖 Tanım  
**State Design Pattern**, bir nesnenin **iç durumuna göre davranışlarını dinamik olarak değiştirmesini** sağlayan bir  
**davranışsal (behavioral)** tasarım desenidir.  
Yani nesne, sanki farklı sınıflara aitmiş gibi farklı şekillerde davranır.  

---

### 🎯 Neden Kullanılır?  
- Nesnenin davranışlarının **durumuna bağlı** olarak değişmesi gerektiğinde  
- `if-else` veya `switch` gibi karmaşık kontrol bloklarından **kurtulmak** için  
- Durum değişimlerini daha **okunabilir** ve **yönetilebilir** hale getirmek için  

---

### ⚙️ Nasıl Kullanılır?  
1. Bir **State arayüzü** tanımlanır → her durumda yapılacak davranışlar burada yer alır  
2. **ConcreteState** sınıfları → Bu arayüzü uygular ve kendi özel davranışlarını yazar  
3. **Context sınıfı** → Mevcut durumu (**state**) tutar ve davranışları ona devreder  
4. Durum değiştikçe → context nesnenin davranışı da değişir  

---

### 🌍 Günlük Hayat Örneği  
Bir **trafik ışığı** düşün:  

- **State arayüzü** → `Handle()` (ışığın duruma göre davranışı)  
- **Concrete States** → Kırmızı, Sarı, Yeşil  
- **Context** → Trafik lambası  
- Lambanın rengi değiştikçe → sürücülere verilen mesaj da değişir  

---

### ✅ Özet  
- **State Pattern** → Nesnenin durumuna göre davranışlarını değiştirmesini sağlar  
- **Avantajı** → Karmaşık `if-else` yapılarından kurtarır, kodu daha okunabilir ve esnek hale getirir  

---

<p align="center">
 <img width="749" height="722" alt="image" src="https://github.com/user-attachments/assets/6f4d296c-9a1b-4d93-8f6b-43c3f0df3d4f" />
</p>

---
<h3 align="center">22 - Strategy Design Pattern</h3>

### 📖 Tanım  
**Strategy Design Pattern**, birbirinin yerine kullanılabilen farklı algoritmaları tanımlayıp,  
bunları **çalışma zamanında seçmeye** imkân veren bir **davranışsal (behavioral)** tasarım desenidir.  

---

### 🎯 Neden Kullanılır?  
- Farklı algoritmalar arasında **kolayca geçiş** yapmak için  
- `if-else` yığınına girmeden **esnek bir yapı** kurmak için  
- **Kod tekrarını azaltmak** ve genişletilebilirliği artırmak için  

---

### ⚙️ Nasıl Kullanılır?  
1. Bir **Strategy arayüzü** tanımlanır → ortak metotları içerir  
2. **ConcreteStrategy** sınıfları → Farklı algoritmaları uygular  
3. **Context** → Hangi stratejinin kullanılacağını belirler ve çalıştırır  
4. **Runtime (çalışma zamanı)** → Algoritma kolayca değiştirilebilir  

---

### 🌍 Günlük Hayat Örneği  
Bir **navigasyon uygulaması** düşün:  

- **Strategy** → `IRotaCiz` arayüzü  
- **ConcreteStrategy** → “En kısa yol”, “En hızlı yol”, “Toll-free yol” gibi farklı rota algoritmaları  
- **Context** → Navigasyon cihazı  
- **Kullanıcı** → “En kısa yol” yerine “En hızlı yol” seçtiğinde algoritma değişir ama sistem aynı kalır  

---

### ✅ Özet  
- **Strategy Pattern** → Algoritmalar arasında kolayca seçim yapmayı sağlar  
- **Avantajı** → Esneklik, kod tekrarını azaltma, çalışma zamanında algoritma değiştirme  

---

<p align="center">
  <img src="https://github.com/user-attachments/assets/xxxxx-strategy-pattern-diagram" 
       alt="Strategy Design Pattern Diagram" 
       width="70%" />
</p>
<h3 align="center">22 - Strategy Design Pattern</h3>

### 📖 Tanım  
**Strategy Design Pattern**, birbirinin yerine kullanılabilen farklı algoritmaları tanımlayıp,  
bunları **çalışma zamanında seçmeye** imkân veren bir **davranışsal (behavioral)** tasarım desenidir.  

---

### 🎯 Neden Kullanılır?  
- Farklı algoritmalar arasında **kolayca geçiş** yapmak için  
- `if-else` yığınına girmeden **esnek bir yapı** kurmak için  
- **Kod tekrarını azaltmak** ve genişletilebilirliği artırmak için  

---

### ⚙️ Nasıl Kullanılır?  
1. Bir **Strategy arayüzü** tanımlanır → ortak metotları içerir  
2. **ConcreteStrategy** sınıfları → Farklı algoritmaları uygular  
3. **Context** → Hangi stratejinin kullanılacağını belirler ve çalıştırır  
4. **Runtime (çalışma zamanı)** → Algoritma kolayca değiştirilebilir  

---

### 🌍 Günlük Hayat Örneği  
Bir **navigasyon uygulaması** düşün:  

- **Strategy** → `IRotaCiz` arayüzü  
- **ConcreteStrategy** → “En kısa yol”, “En hızlı yol”, “Toll-free yol” gibi farklı rota algoritmaları  
- **Context** → Navigasyon cihazı  
- **Kullanıcı** → “En kısa yol” yerine “En hızlı yol” seçtiğinde algoritma değişir ama sistem aynı kalır  

---

### ✅ Özet  
- **Strategy Pattern** → Algoritmalar arasında kolayca seçim yapmayı sağlar  
- **Avantajı** → Esneklik, kod tekrarını azaltma, çalışma zamanında algoritma değiştirme  

---

<p align="center">
<img width="757" height="762" alt="image" src="https://github.com/user-attachments/assets/4f1712d3-85d2-4835-8ba0-37e3bfe5c6bc" />
</p>

<h3 align="center">23 - Template Method Design Pattern</h3>

### 📖 Tanım  
**Template Method Design Pattern**, bir algoritmanın **iskeletini (şablonunu)** bir **abstract sınıfta** tanımlayıp,  
bazı adımların alt sınıflar tarafından **özelleştirilmesine izin veren** bir **davranışsal (behavioral)** tasarım desenidir.  

---

### 🎯 Neden Kullanılır?  
- Ortak bir algoritmayı tekrar tekrar yazmadan, alt sınıflara **özelleştirme** imkânı vermek için  
- **Kod tekrarını azaltmak** için  
- Algoritmanın adımlarını **sabit tutarken**, bazı adımların **değişebilir** olmasını sağlamak için  

---

### ⚙️ Nasıl Kullanılır?  
1. Bir **abstract sınıf** oluşturulur → algoritmanın adımları `TemplateMethod()` içinde sıralanır  
2. Bazı adımlar **abstract** olarak bırakılır → alt sınıflar bunları kendine göre uygular  
3. **Concrete sınıflar** → abstract metotları doldurur  
4. **Client** → sadece `TemplateMethod()` çağırır, algoritma adım adım çalışır  

---

### 🌍 Günlük Hayat Örneği  
Bir **yemek tarifi** düşün:  

- **Template Method** → “Yemek Yap” adımları: *Malzemeleri hazırla → Pişir → Servis et*  
- **ConcreteClass 1** → Makarna tarifi (malzemeler ve pişirme farklı)  
- **ConcreteClass 2** → Pilav tarifi  

➡️ İskelet aynı (**hazırla, pişir, servis et**) ama detaylar farklıdır  

---

### ✅ Özet  
- **Template Method Pattern** → Algoritmanın iskeletini sabitler, bazı adımların alt sınıflarda özelleştirilmesine izin verir  
- **Avantajı** → Kod tekrarını azaltır, iskeleti korur, esneklik sağlar  

---

<p align="center">
<img width="755" height="759" alt="image" src="https://github.com/user-attachments/assets/61704fdc-d7e6-4621-8ed9-cf49d0234d3e" />
</p>
<h3 align="center">24 - Unit of Work Design Pattern</h3>

### 📖 Tanım  
**Unit of Work Design Pattern**, birden fazla repository üzerinde yapılan işlemleri tek bir **iş birimi (transaction)** içinde toplayan  
ve hep birlikte kaydedilmesini sağlayan bir **davranışsal / altyapısal (transactional)** tasarım desenidir.  

---

### 🎯 Neden Kullanılır?  
- Aynı anda birden fazla tabloya işlem yapılırken **tutarlılığı sağlamak** için  
- `SaveChanges()` gibi metotların her yerde dağınık kullanılmasını **engellemek** için  
- **Transaction yönetimini merkezileştirmek** için  

---

### ⚙️ Nasıl Kullanılır?  
1. Bir **UnitOfWork arayüzü** tanımlanır → `Commit()`, `Rollback()` gibi metotlar içerir  
2. Her repository, **UnitOfWork** üzerinden yönetilir  
3. İşlemler yapılır → en sonunda `Commit()` çağrılır  
4. Eğer hata olursa → `Rollback()` yapılır, tüm değişiklikler geri alınır  

---

### 🌍 Günlük Hayat Örneği  
Bir **banka transferi** düşün:  

- Ali’nin hesabından **100₺ çekiliyor**, Veli’nin hesabına **yatırılıyor**  
- Eğer çekme başarılı, yatırma başarısız olursa → **para kaybolur**  
- **Unit of Work** → “İki işlem bir bütün” olarak yönetilir  
- Ya ikisi **birlikte başarılı olur**, ya da ikisi **birlikte iptal edilir**  

---

### ✅ Özet  
- **Unit of Work Pattern** → Birden fazla işlemi tek transaction altında toplar  
- **Avantajı** → Veri tutarlılığı, transaction yönetimi, kodun düzenli olması  

---

<p align="center">
<img width="744" height="569" alt="image" src="https://github.com/user-attachments/assets/33426003-05f2-4af7-b4c1-c5c8786d60ee" />
</p>
