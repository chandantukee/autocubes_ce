namespace AutoCubes.Shared.Commands
{
    public interface ICommandDispatcher
    {
        Task DispatchAsync<TCommand>(TCommand command) where TCommand : ICommand;
    }
}
