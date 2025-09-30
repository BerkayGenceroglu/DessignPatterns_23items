<h1 align="center">Design Patterns (Tasarım Desenleri - 23 Tane)</h1>

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

---

<h3 align="center">1 - Abstract Design Pattern</h3>

📖 **Tanım**  
Soyut (**abstract class** veya **interface**) bir yapı üzerinden nesne üretmeyi sağlar.  

🎯 **Neden Kullanılır?**  
- Esneklik ve genişletilebilirlik  
- Bağımlılıkları azaltma  

🌍 **Günlük Hayat Örneği**  
Bir **içecek makinesi** sadece `Hazırla()` metodunu bilir → çay mı kahve mi hazırlandığını bilmez.  

✅ **Özet**  
Ortak şablon → farklı nesneler. Avantaj → bağımlılığı azaltma.  

<p align="center">
  <img src="https://github.com/user-attachments/assets/9e999a68-6dee-4f2f-a505-75a9d3449262" width="70%" />
</p>

---

<h3 align="center">2 - Adapter Design Pattern</h3>

📖 **Tanım**  
Uyumsuz iki sınıfı birbirine uyumlu hale getirir.  

🎯 **Neden Kullanılır?**  
- Eski kodları yeni sisteme entegre etmek  
- Uyumsuz yapıları dönüştürmek  

🌍 **Günlük Hayat Örneği**  
**Priz adaptörü** → ABD fişi Türkiye prizine uyumlu hale gelir.  

✅ **Özet**  
Uyumsuz yapıları uyumlu hale getirir. Avantaj → entegrasyon kolaylığı.  

<p align="center">
  <img src="https://github.com/user-attachments/assets/58e14418-f5e6-428e-8238-eef5dfa948a6" width="70%" />
</p>

---

<h3 align="center">3 - Bridge Design Pattern</h3>

📖 **Tanım**  
Soyutlama (**Abstraction**) ile uygulama (**Implementation**) birbirinden ayrılır.  

🎯 **Neden Kullanılır?**  
- Soyutlama ile uygulamanın bağımsız geliştirilmesi  
- Kod tekrarını azaltmak  

🌍 **Günlük Hayat Örneği**  
Bir **uzaktan kumanda** → aynı kumanda farklı cihazları (TV, Radyo) kontrol edebilir.  

✅ **Özet**  
Soyutlama ve uygulama bağımsız gelişir. Avantaj → esneklik, kod tekrarı azalır.  

<p align="center">
  <img src="https://github.com/user-attachments/assets/31bbeb8d-1bcc-4f8b-bf37-0b78a0819ba5" width="70%" />
</p>

---

<h3 align="center">4 - Builder Design Pattern</h3>

📖 **Tanım**  
Karmaşık nesneleri **adım adım (step by step)** oluşturmaya yarar.  

🎯 **Neden Kullanılır?**  
- Karmaşık nesneleri yönetmek  
- Aynı süreçle farklı kombinasyonlar oluşturmak  

🌍 **Günlük Hayat Örneği**  
**Hamburger yapımı** → ekmek seç, köfte ekle, sos ekle → farklı kombinasyonlarla farklı hamburgerler yapılır.  

✅ **Özet**  
Adım adım inşa. Avantaj → okunabilirlik, esneklik.  

<p align="center">
  <img src="https://github.com/user-attachments/assets/6a1a71d9-5512-4a3b-9bf0-c996a3d99311" width="70%" />
</p>

---

<h3 align="center">5 - Chain of Responsibility Design Pattern</h3>

📖 **Tanım**  
İstekler zincir üzerinde sırayla işlenir.  

🎯 **Neden Kullanılır?**  
- İsteği kimin ele alacağını sabitlememek  
- Sorumlulukları paylaştırmak  

🌍 **Günlük Hayat Örneği**  
**İzin süreci** → takım lideri → müdür → genel müdür → sırayla kontrol.  

✅ **Özet**  
İstek sırayla nesnelere gider. Avantaj → esneklik, bağımlılık azalması.  

<p align="center">
  <img src="https://github.com/user-attachments/assets/d22154f9-8bba-44cb-95a2-4b4585b0666a" width="70%" />
</p>

---

<h3 align="center">6 - Command Design Pattern</h3>

📖 **Tanım**  
İstekleri nesneye dönüştürür → kuyruklama, loglama, undo/redo yapılabilir.  

🎯 **Neden Kullanılır?**  
- İşlemleri nesne olarak temsil etmek  
- Undo/redo desteği  

🌍 **Günlük Hayat Örneği**  
**Akıllı ev kumandası** → lambayı aç, TV’yi kapat gibi komutlar nesneleştirilir.  

✅ **Özet**  
İstekler nesne olur. Avantaj → esneklik, undo/redo.  

<p align="center">
  <img src="https://github.com/user-attachments/assets/c1c0c68c-263e-465e-8a7d-654cbc31c48d" width="70%" />
</p>

---

<h3 align="center">7 - Composite Design Pattern</h3>

📖 **Tanım**  
Ağaç yapısındaki nesneleri aynı arayüzle yönetmeyi sağlar.  

🎯 **Neden Kullanılır?**  
- Tekil & grup nesnelerini aynı şekilde yönetmek  
- Hiyerarşik yapıları basitleştirmek  

🌍 **Günlük Hayat Örneği**  
**Dosya sistemi** → dosya (leaf), klasör (composite).  

✅ **Özet**  
Bütün–parça aynı arayüzle. Avantaj → sade kod.  

<p align="center">
  <img src="https://github.com/user-attachments/assets/940e3bf7-8373-4394-9881-7e0822d51768" width="70%" />
</p>

---

<h3 align="center">8 - CQRS (Command Query Responsibility Segregation)</h3>

📖 **Tanım**  
Okuma (**Query**) ve yazma (**Command**) işlemleri ayrılır.  

🎯 **Neden Kullanılır?**  
- Performans artırmak  
- Karmaşayı azaltmak  

🌍 **Günlük Hayat Örneği**  
Restoranda → sipariş vermek (command), siparişi sormak (query).  

✅ **Özet**  
Okuma & yazma ayrılır. Avantaj → performans, okunabilirlik.  

<p align="center">
  <img src="https://github.com/user-attachments/assets/1d05a521-753d-40ba-a0e8-9e3146a996dd" width="70%" />
</p>

---

<h3 align="center">9 - Decorator Design Pattern</h3>

📖 **Tanım**  
Bir nesneye dinamik olarak yeni özellikler ekler.  

🎯 **Neden Kullanılır?**  
- Kalıtım olmadan genişletme  
- Kod tekrarını önlemek  

🌍 **Günlük Hayat Örneği**  
**Kahve siparişi** → sade kahveye süt, çikolata, krema eklenebilir.  

✅ **Özet**  
Dinamik genişletme. Avantaj → esneklik.  

<p align="center">
  <img src="https://github.com/user-attachments/assets/e7f83dda-e7d9-41a3-8ae5-2ae83d74f02e" width="70%" />
</p>

---

<h3 align="center">10 - Facade Design Pattern</h3>

📖 **Tanım**  
Karmaşık sistemi tek bir basit arayüzle sunar.  

🎯 **Neden Kullanılır?**  
- Kullanıcıyı karmaşadan korumak  
- Tek noktadan erişim  

🌍 **Günlük Hayat Örneği**  
**Otel resepsiyonu** → müşteri sadece resepsiyonla konuşur, detayları bilmez.  

✅ **Özet**  
Karmaşık sistemlere basit giriş. Avantaj → kullanım kolaylığı.  

<p align="center">
  <img src="https://github.com/user-attachments/assets/380001d2-1f27-41bc-aced-c8bff2387c85" width="70%" />
</p>

---

<h3 align="center">11 - Factory Design Pattern</h3>

📖 **Tanım**  
Nesne oluşturmayı bir **fabrika sınıfına** devreder.  

🎯 **Neden Kullanılır?**  
- Nesne oluşturmayı merkezileştirmek  
- Çalışma zamanında uygun sınıfı seçmek  

🌍 **Günlük Hayat Örneği**  
**Araç kiralama ofisi** → müşteri araç ister, fabrika uygun aracı üretir.  

✅ **Özet**  
Merkezi nesne üretimi. Avantaj → gevşek bağlılık.  

<p align="center">
  <img src="https://github.com/user-attachments/assets/a1873dde-7151-46b9-959d-3c98938b0c8f" width="70%" />
</p>

---

<h3 align="center">12 - Flyweight Design Pattern</h3>

📖 **Tanım**  
Ortak verileri paylaşarak bellek kullanımını azaltır.  

🎯 **Neden Kullanılır?**  
- Çok sayıda benzer nesne olduğunda bellek tasarrufu  
- Performans artırmak  

🌍 **Günlük Hayat Örneği**  
**Oyun** → 10.000 ağaç var ama tür/renk ortak → sadece konum farklı tutulur.  

✅ **Özet**  
Bellek optimizasyonu. Avantaj → performans artışı.  

<p align="center">
  <img src="https://github.com/user-attachments/assets/dad3b586-ae3e-41e1-b1cc-eb3a9285d4b7" width="70%" />
</p>

---

<h3 align="center">13 - Iterator Design Pattern</h3>

📖 **Tanım**  
Koleksiyon elemanlarına iç yapıyı bilmeden sırayla erişmeyi sağlar.  

🎯 **Neden Kullanılır?**  
- Koleksiyon yapısını gizlemek  
- Farklı dolaşma yöntemleri eklemek  

🌍 **Günlük Hayat Örneği**  
**Kitaplık** → iterator ile sırayla kitaplara erişilir.  

✅ **Özet**  
Sırayla erişim. Avantaj → kapsülleme, okunabilirlik.  

<p align="center">
  <img src="https://github.com/user-attachments/assets/3ea73fbd-a7e9-4f76-848e-1d6cf86afd16" width="70%" />
</p>

---

<h3 align="center">14 - Mediator Design Pattern</h3>

📖 **Tanım**  
Nesneler arası iletişimi bir **aracı (mediator)** üzerinden yönetir.  

🎯 **Neden Kullanılır?**  
- Nesneler arası bağımlılığı azaltmak  
- Karmaşık ilişkileri sadeleştirmek  

🌍 **Günlük Hayat Örneği**  
**Hava trafik kontrol kulesi** → uçaklar birbirine değil kuleye bağlanır.  

✅ **Özet**  
Merkezi iletişim. Avantaj → düzenli sistem.  

<p align="center">
  <img src="https://github.com/user-attachments/assets/83f69410-1999-470d-ba75-cb5d712426f6" width="70%" />
</p>

---

<h3 align="center">15 - Memento Design Pattern</h3>

📖 **Tanım**  
Nesnenin geçmiş durumunu saklayıp geri yüklemeyi sağlar.  

🎯 **Neden Kullanılır?**  
- Undo/redo işlemleri  
- Geçmişe dönüş  

🌍 **Günlük Hayat Örneği**  
**Metin editörü** → yazıyı silersen “Ctrl+Z” ile geri alabilirsin.  

✅ **Özet**  
Durum kaydı. Avantaj → veri kaybını önler.  

<p align="center">
  <img src="https://github.com/user-attachments/assets/1c44a3ab-0453-4572-94e0-f6d5245ad85a" width="70%" />
</p>

---

<h3 align="center">16 - Observer Design Pattern</h3>

📖 **Tanım**  
Bir nesnedeki değişiklikleri bağlı nesnelere otomatik bildirir.  

🎯 **Neden Kullanılır?**  
- Olay tabanlı sistem kurmak  
- Nesneler arası bağımlılığı azaltmak  

🌍 **Günlük Hayat Örneği**  
**YouTube kanalı** → yeni video yüklenince abonelere bildirim gider.  

✅ **Özet**  
Otomatik bildirim. Avantaj → gevşek bağlılık.  

<p align="center">
  <img src="https://github.com/user-attachments/assets/76949351-f5aa-44ea-a69d-05f0e353ce6b" width="70%" />
</p>

---

<h3 align="center">17 - Prototype Design Pattern</h3>

📖 **Tanım**  
Mevcut nesnenin kopyalanarak yeni nesne üretilmesini sağlar.  

🎯 **Neden Kullanılır?**  
- Nesne oluşturma maliyetli olduğunda  
- Aynı ayarlarla tekrar tekrar nesne oluşturmak için  

🌍 **Günlük Hayat Örneği**  
**Fotokopi makinesi** → belgenin kopyasını çıkarmak.  

✅ **Özet**  
Kopyalama ile nesne üretimi. Avantaj → hız, verimlilik.  

<p align="center">
  <img src="https://github.com/user-attachments/assets/f6e6f6d4-126e-47b6-98d5-c2f5831b624e" width="70%" />
</p>

---

<h3 align="center">18 - Proxy Design Pattern</h3>

📖 **Tanım**  
Gerçek nesneye erişimi kontrol eden temsilci.  

🎯 **Neden Kullanılır?**  
- Güvenlik, cache, loglama  
- Uzaktan erişim  

🌍 **Günlük Hayat Örneği**  
**Güvenlik görevlisi** → patrona girmeden önce seni kontrol eder.  

✅ **Özet**  
Erişim kontrolü. Avantaj → güvenlik & performans.  

<p align="center">
  <img src="https://github.com/user-attachments/assets/dddb5f9e-a608-4a28-bd38-1c5a12ae7570" width="70%" />
</p>

---

<h3 align="center">19 - Repository Pattern</h3>

📖 **Tanım**  
Veri erişim işlemlerini tek katmanda toplar.  

🎯 **Neden Kullanılır?**  
- CRUD işlemlerini düzenlemek  
- İş katmanı ile DB’yi ayırmak  

🌍 **Günlük Hayat Örneği**  
**Depo görevlisi** → müşteri ürünü nasıl bulacağını bilmez, görevli getirir.  

✅ **Özet**  
Aracı katman. Avantaj → test edilebilirlik, kod düzeni.  

<p align="center">
  <img src="https://github.com/user-attachments/assets/ec94217b-06ee-4fc8-b459-31773c7f65dd" width="70%" />
</p>

---

<h3 align="center">20 - Singleton Design Pattern</h3>

📖 **Tanım**  
Bir sınıfın tek örneğinin olmasını sağlar.  

🎯 **Neden Kullanılır?**  
- Ortak nesne gerektiğinde (Logger, Config)  
- Bellek tasarrufu  

🌍 **Günlük Hayat Örneği**  
**Cumhurbaşkanı** → ülkede aynı anda sadece 1 tane olur.  

✅ **Özet**  
Tek instance. Avantaj → global erişim.  

<p align="center">
  <img src="https://github.com/user-attachments/assets/17d5e0db-6d8c-4790-9a63-a8f0a006fb45" width="70%" />
</p>

---

<h3 align="center">21 - State Design Pattern</h3>

📖 **Tanım**  
Nesnenin davranışı, iç durumuna göre değişir.  

🎯 **Neden Kullanılır?**  
- Karmaşık if-else yapılarından kurtulmak  
- Durum bazlı davranışları düzenlemek  

🌍 **Günlük Hayat Örneği**  
**Trafik ışığı** → kırmızı, sarı, yeşil durumuna göre farklı mesaj verir.  

✅ **Özet**  
Duruma göre davranış. Avantaj → okunabilirlik.  

<p align="center">
  <img src="https://github.com/user-attachments/assets/6f4d296c-9a1b-4d93-8f6b-43c3f0df3d4f" width="70%" />
</p>

---

<h3 align="center">22 - Strategy Design Pattern</h3>

📖 **Tanım**  
Farklı algoritmalar arasında çalışma zamanında geçiş yapılmasını sağlar.  

🎯 **Neden Kullanılır?**  
- If-else kalabalığını azaltmak  
- Algoritmaları esnek seçmek  

🌍 **Günlük Hayat Örneği**  
**Navigasyon uygulaması** → en kısa yol, en hızlı yol, ücretli yol seçenekleri.  

✅ **Özet**  
Seçilebilir algoritmalar. Avantaj → esneklik.  

<p align="center">
  <img src="https://github.com/user-attachments/assets/4f1712d3-85d2-4835-8ba0-37e3bfe5c6bc" width="70%" />
</p>

---

<h3 align="center">23 - Template Method Design Pattern</h3>

📖 **Tanım**  
Algoritmanın iskeletini üst sınıfta tanımlar, alt sınıflar bazı adımları özelleştirir.  

🎯 **Neden Kullanılır?**  
- Kod tekrarını azaltmak  
- Adımları sabitlemek ama detayları değiştirilebilir yapmak  

🌍 **Günlük Hayat Örneği**  
**Yemek tarifi** → malzeme hazırla, pişir, servis et. Her yemek farklı detaylara sahiptir.  

✅ **Özet**  
İskelet sabit, detay özelleştirilebilir. Avantaj → düzenli kod.  

<p align="center">
  <img src="https://github.com/user-attachments/assets/61704fdc-d7e6-4621-8ed9-cf49d0234d3e" width="70%" />
</p>

---

<h3 align="center">24 - Unit of Work Design Pattern</h3>

📖 **Tanım**  
Birden fazla repository işlemini tek bir transaction altında toplar.  

🎯 **Neden Kullanılır?**  
- Veri tutarlılığı sağlamak  
- Transaction yönetimini merkezileştirmek  

🌍 **Günlük Hayat Örneği**  
**Banka transferi** → çekme ve yatırma işlemi ya birlikte başarılı olur ya da birlikte iptal edilir.  

✅ **Özet**  
Toplu işlem kontrolü. Avantaj → güvenli transaction yönetimi.  

<p align="center">
  <img src="https://github.com/user-attachments/assets/33426003-05f2-4af7-b4c1-c5c8786d60ee" width="70%" />
</p>
