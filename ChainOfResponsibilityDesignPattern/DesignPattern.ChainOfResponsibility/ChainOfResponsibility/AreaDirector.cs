using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            Context db = new Context();
            if (request.Amount < 400000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Bölge Direktörü - Işıl Ataman";
                customerProcess.Description = $"Para Çekme İşlemi Onaylandı.Müşterinin Talep Ettiği {request.Amount} Başarılı Bir Şekilde Teslim Edildi";
                db.CustomerProcesses.Add(customerProcess);
                db.SaveChanges();
            }
            else 
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Bölge Direktörü - Işıl Ataman";
                customerProcess.Description = "Para Çekme İşlemi Limiti Aştığı için Onaylanamadı.Müşterinin Günlük Çekebileceği Maximum Tutar 400.000 TL Olup Daha Fazlası İçin Birden Fazla Gün Gelmesi Gereklidir... ";
                db.CustomerProcesses.Add(customerProcess);
                db.SaveChanges();
            }
        }
    }
}
