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



<p align="center">
<img width="668" height="654" alt="image" src="https://github.com/user-attachments/assets/3e66a66e-a241-4a03-be78-c7d8598208f3" />
</p>

