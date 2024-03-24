using CardMiniGame.Core.Decks;
using System.Collections;
using UnityEngine;

namespace CardMiniGame.Core.Dealers.Commands
{
    public class DealerController : MonoBehaviour
    {
        [SerializeField]
        private DealerCommandHandler handler;

        [SerializeField]
        private DeckFactory deckManager;

        [SerializeField]
        private DeckController deckController;

        [SerializeField]
        private GameObject table;

        private void Start()
        {
            deckController = deckManager.CreateDeck(transform);
            StartCoroutine(DistributeAsync());
        }

        private IEnumerator DistributeAsync()
        {
            var x = 0;
            var y = 0;
            while (!deckController.IsEmpty)
            {
                var size = deckController.SpriteSize;
                var target = table.transform.position + new Vector3(size.x * x, size.y * y, 0);
                handler.AddCommand(
                    new DealerDistributeCommand(this, deckController, target)
                );
                x++;
                if (x > 12)//TODO: remove this code
                {
                    y++;
                    x = 0;
                }
                yield return new WaitForEndOfFrame();
            }
        }
    }
}