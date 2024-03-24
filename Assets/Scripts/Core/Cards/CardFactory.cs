using CardMiniGame.Core.Data;
using UnityEngine;

namespace CardMiniGame.Core.Cards
{
    public class CardFactory : MonoBehaviour
    {
        [SerializeField]
        private CardController cardPrefab;

        public CardController CreateCard(Card card, Transform transform)
        {
            var cardController = Instantiate(cardPrefab);

            cardController.name = $"Card ({card.FullName})";
            cardController.Card = card;
            cardController.transform.SetParent(transform);

            return cardController;
        }
    }
}