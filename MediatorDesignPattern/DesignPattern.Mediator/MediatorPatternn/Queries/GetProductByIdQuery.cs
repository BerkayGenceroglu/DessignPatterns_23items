using DesignPattern.Mediator.MediatorPatternn.Results;
using MediatR;

namespace DesignPattern.Mediator.MediatorPatternn.Queries
{
    public class GetProductByIdQuery:IRequest<GetProductByIdQueryResult>
    {
        public GetProductByIdQuery(int ıd)
        {
            Id = ıd;
        }
        public int Id { get; set; }
    }
}
