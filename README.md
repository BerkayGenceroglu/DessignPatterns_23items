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
