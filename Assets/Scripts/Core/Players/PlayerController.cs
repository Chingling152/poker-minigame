using CardMiniGame.Core.Cards;
using CardMiniGame.Core.Data;
using System;
using UnityEngine;

namespace CardMiniGame.Core.Players
{
    public class PlayerController : MonoBehaviour
    {
        private PlayerDeck deck;

        public Card[] Cards => this.deck?.Cards;

        public event Action<PlayerDeck> OnChangeDeck;

        private void Awake()
        {
            this.deck = new PlayerDeck();
            CardSelectController.OnSelectCard += OnSelectCard;
            CardSelectController.OnDeselectCard += OnDeselectCard;
        }

        private void OnSelectCard(Card card)
        {
            this.deck.Add(card);
            this.OnChangeDeck?.Invoke(this.deck);
        }

        private void OnDeselectCard(Card card)
        {
            this.deck.Remove(card);
            this.OnChangeDeck?.Invoke(this.deck);
        }
    }
}
