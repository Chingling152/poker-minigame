namespace CardMiniGame.Utils.Commands
{
    public interface ICommandHandler<T> where T : Command
    {
        void AddCommand(T command);
    }
}