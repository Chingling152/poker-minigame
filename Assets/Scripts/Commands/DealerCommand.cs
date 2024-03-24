using System.Collections;
using UnityEngine;

public abstract class DealerCommand : Command
{
    protected readonly DealerController controller;

    public bool IsFinished { get; protected set; }

    protected DealerCommand(DealerController controller)
    {
        this.controller = controller;
    }
}

public class DealerDistributeCommand : DealerCommand
{
    private readonly DeckController deckController;
    private readonly Vector3 start;
    private readonly Vector3 target;

    public DealerDistributeCommand(DealerController dealer, DeckController deckController, Vector3 target) : base(dealer)
    {
        this.deckController = deckController;
        this.start = dealer.transform.position;
        this.target = target;
    }

    public override void Execute()
    {
        deckController.StartCoroutine(ExecuteCoroutine());
    }

    private IEnumerator ExecuteCoroutine()
    {
        this.IsFinished = false;
        var cardController = this.deckController.GetCard();
        
        yield return cardController.MoveTo(start, target);
        this.IsFinished = true;
    }
}