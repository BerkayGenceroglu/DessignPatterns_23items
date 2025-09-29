using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class Treasurer : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            Context db = new Context();
            if (request.Amount < 100000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Veznedar - Ayşe Yılmaz";
                customerProcess.Description = $"Para Çekme İşlemi Onaylandı.Müşterinin Talep Ettiği {request.Amount} Başarılı Bir Şekilde Teslim Edildi";
                db.CustomerProcesses.Add(customerProcess);
                db.SaveChanges();
            }
            else if (NextApprover !=null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Veznedar - Ayşe Yılmaz";
                customerProcess.Description = " Para Çekme İşlemi Limiti Aştığı için Onaylanamadı.İşlem Şube Müdür Yardımcısına Yönlendirildi.";
                db.CustomerProcesses.Add(customerProcess);
                db.SaveChanges();
                NextApprover.ProcessRequest(request);
            }
        }
    }
}
