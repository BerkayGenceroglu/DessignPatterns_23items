using DesignPattern.ChainOfResponsibility.ChainOfResponsibility;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public abstract class Employee
    {
        protected Employee NextApprover;
        public void SetNextApprover(Employee nextApprover)
        {
            this.NextApprover = nextApprover;
        }
        public abstract void ProcessRequest(CustomerProcessViewModel request);
    }
}
//Kısaca: abstract → “Bu sınıf/üyeden doğrudan nesne üretilmez, miras alanlar kendi davranışını yazmak zorunda.”
//abstract class Employee → Ortak bir çalışan şablonu. Tek başına kullanılmaz, sadece miras alınır.
//protected Employee NextApprover; → Bu çalışandan sonra sırada gelecek çalışanı (yani zincirdeki bir sonraki kişiyi) saklıyor.
//SetNextApprover(...) → Zinciri kurmaya yarıyor. “Benden sonra şu kişi gelsin” demek.
//abstract void ProcessRequest(...) → Gelen isteği işleme metodu. Ama içi boş → her alt sınıf (Memur, Şef, Müdür gibi) bu metodu kendi kuralına göre doldurmak zorunda.