using DesignPattern.Mediator.MediatorPatternn.Results;
using MediatR;

namespace DesignPattern.Mediator.MediatorPatternn.Queries
{
    public class GetAllProductQuery:IRequest<List<GetAllProductQueryResult>>
    {
        //Bu sınıf bir istek(Request).
        //Ben çalıştırıldığımda sonucum List<GetAllProductQueryResult> tipinde olacak” demek
    }
}
