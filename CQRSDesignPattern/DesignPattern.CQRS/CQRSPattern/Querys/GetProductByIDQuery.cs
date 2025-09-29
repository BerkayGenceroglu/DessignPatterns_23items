namespace DesignPattern.CQRS.CQRSPattern.Querys
{
    public class GetProductByIDQuery
    {
        //Ctor koymamızın sebebi, nesneyi oluştururken gerekli veriyi(Id) zorunlu kılmak ve “eksik/boş veriyle sorgu oluşturulmasını engellemek”.
        public GetProductByIDQuery(int ıd)
        {
            Id = ıd;
        }
        public int Id { get; set; }
        //Yani GetProductByIDQuery nesnesi artık “Id = 5” bilgisini taşıyan bir paket olmuş oluyor.
    }
}
