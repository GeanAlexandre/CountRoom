using System.Threading.Tasks;
using CountRoom.Core.Commands;

namespace CountRoom.Core.CommandHandlers
{
    public interface ICommandHandler<TCommand>
        where TCommand : ICommand
    {
        Task HandleAsync(ICommand command);
    }
}