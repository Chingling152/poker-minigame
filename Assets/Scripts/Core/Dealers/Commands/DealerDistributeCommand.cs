using CardMiniGame.Core.Decks;
using System.Collections;
using UnityEngine;

namespace CardMiniGame.Core.Dealers.Commands
{
    public class DealerDistributeCommand : DealerCommand
    {
        private readonly DeckController deckController;
        private readonly Vector3 start;
        private readonly Vector3 target;

        public DealerDistributeCommand(DealerController dealer, DeckController deckController, Vector3 target) : base(dealer)
        {
            this.deckController = deckController;
            start = dealer.transform.position;
            this.target = target;
        }

        public override void Execute()
        {
            deckController.StartCoroutine(ExecuteCoroutine());
        }

        private IEnumerator ExecuteCoroutine()
        {
            IsFinished = false;
            var cardController = deckController.GetCard();
            if(cardController == null)
            {
                IsFinished = true;
                yield break;
            }

            yield return cardController.MoveTo(start, target);
            IsFinished = true;
        }
    }
}