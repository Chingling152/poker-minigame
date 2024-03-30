using CardMiniGame.Core.Cards;
using CardMiniGame.Core.Data;
using UnityEngine;

namespace CardMiniGame.Core.Players
{
    public class PlayerController : MonoBehaviour
    {
        private PlayerDeck deck;

        private void Awake()
        {
            this.deck = new PlayerDeck();
            CardSelectController.OnSelectCard += OnSelectCard;
            CardSelectController.OnDeselectCard += OnDeselectCard;
        }

        private void OnSelectCard(Card card)
        {
            this.deck.Add(card);
        }

        private void OnDeselectCard(Card card)
        {
            this.deck.Remove(card);
        }
    }
}
