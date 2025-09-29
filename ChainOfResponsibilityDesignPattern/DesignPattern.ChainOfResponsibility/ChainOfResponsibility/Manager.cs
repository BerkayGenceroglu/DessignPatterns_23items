using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class Manager : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            Context db = new Context();
            if (request.Amount < 200000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Şube Müdürü - Sinem Engin";
                customerProcess.Description = $"Para Çekme İşlemi Onaylandı.Müşterinin Talep Ettiği {request.Amount} Başarılı Bir Şekilde Teslim Edildi";
                db.CustomerProcesses.Add(customerProcess);
                db.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Şube Müdürü - Sinem Engin";
                customerProcess.Description = " Para Çekme İşlemi Limiti Aştığı için Onaylanamadı.İşlem Bölge Müdürüne Yönlendirildi.";
                db.CustomerProcesses.Add(customerProcess);
                db.SaveChanges();
                NextApprover.ProcessRequest(request);
            }
        }
    }
}
