using CardMiniGame.Utils.Commands;

namespace CardMiniGame.Core.Dealers.Commands
{
    public abstract class DealerCommand : Command
    {
        protected readonly DealerController controller;

        public bool IsFinished { get; protected set; }

        protected DealerCommand(DealerController controller)
        {
            this.controller = controller;
        }
    }
}