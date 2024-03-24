using CardMiniGame.Core.Data;
using UnityEngine;

namespace CardMiniGame.Core.Decks
{
    public class DeckFactory : MonoBehaviour
    {
        [SerializeField]
        private Deck deck;

        [SerializeField]
        private DeckController deckPrefab;

        public DeckController CreateDeck(Transform transform)
        {
            var deckController = Instantiate(deckPrefab);

            deckController.transform.position = transform.position;
            deckController.Create(deck);
            deckController.Shuffle();

            return deckController;
        }
    }
}