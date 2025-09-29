namespace DesignPattern.CQRS.CQRSPattern.Querys
{
    public class GetProductUpdateByIdQuery
    {
        public int Id { get; set; }

        public GetProductUpdateByIdQuery(int ıd)
        {
            Id = ıd;
        }
    }
}
