using DesignPattern.DataAccessLayer.Abstract;
using DesignPattern.DataAccessLayer.Concrete;
using DesignPattern.DataAccessLayer.Repositories;
using DesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DataAccessLayer.EntityFramework
{
    public class EfCustomerDal : GenericRepository<Customer>, ICustomerDal
    {
        //EfCustomerDal'ın constructor'ı, kendisine gelen veritabanı context'ini doğrudan üst sınıfına paslayarak veritabanı işlemlerinin doğru bir şekilde yürütülmesini sağlıyor.

        //Context nesnesini sen oluşturmuyorsun → DI oluşturuyor.
        public EfCustomerDal(Context context) : base(context)
        {
        }
        //Temel sınıf (GenericRepository) constructor'ında bir Context nesnesi beklediği için, bu sınıftan miras alan türetilmiş sınıf (EfCustomerDal) da kendi constructor'ında bu nesneyi almak ve base anahtar kelimesiyle temel sınıfa ilemek zorunda. Aksi halde kod derlenmez.
    }
}
//Özetle, Startup'ta DI, Context'i oluşturur ve EfCustomerDal'a enjekte eder. EfCustomerDal da bu Context'i alıp, doğrudan mirasını aldığı GenericRepository'ye verir. Bu sayede, tüm veritabanı işlemleri için gerekli olan Context nesnesi, hiyerarşinin en üst seviyesindeki temel sınıfa ulaşmış olur ve işlemler doğru bir şekilde yürütülebilir.