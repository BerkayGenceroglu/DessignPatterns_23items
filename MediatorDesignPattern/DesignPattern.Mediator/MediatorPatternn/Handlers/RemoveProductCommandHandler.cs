using DesignPattern.Mediator.DAL;
using DesignPattern.Mediator.MediatorPatternn.Commands;
using MediatR;
using NuGet.Protocol.Plugins;

namespace DesignPattern.Mediator.MediatorPatternn.Handlers
{
    public class RemoveProductCommandHandler : IRequestHandler<RemoveProductCommand>
    {
        private readonly Context _context;

        public RemoveProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(RemoveProductCommand request, CancellationToken cancellationToken)
        {
            var value = _context.Products.Find(request.Id);
            _context.Products.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
