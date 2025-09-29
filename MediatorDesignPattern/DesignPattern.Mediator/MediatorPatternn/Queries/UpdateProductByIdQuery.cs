using DesignPattern.Mediator.MediatorPatternn.Results;
using MediatR;

namespace DesignPattern.Mediator.MediatorPatternn.Queries
{
    public class UpdateProductByIdQuery:IRequest<UpdateProductByIdQueryResult>
    {
        public int Id { get; set; }

        public UpdateProductByIdQuery(int id)
        {
            Id = id;
        }
    }
}
