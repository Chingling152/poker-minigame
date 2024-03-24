using CardMiniGame.Core.Cards;
using CardMiniGame.Core.Data;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace CardMiniGame.Core.Decks
{
    public class DeckController : MonoBehaviour
    {
        [SerializeField]
        private Deck deck;

        [SerializeField]
        private Queue<Card> cards;

        [SerializeField]
        private CardFactory cardManager;

        [System.Obsolete("Find for a better place to put it")]
        public Vector3 SpriteSize
        {
            get;
            private set;
        }

        public bool IsEmpty => cards.Count == 0;

        public void Create(Deck deck)
        {
            this.deck = deck;
            GetComponent<SpriteRenderer>().sprite = deck.BackSprite;
            cards = new Queue<Card>(deck.Cards);

            SpriteSize = GetComponent<SpriteRenderer>().bounds.size;
        }

        public void Shuffle()
        {
            cards = new Queue<Card>(deck.Cards.OrderBy(x => Random.Range(0.0f, 10.0f)));
        }

        public CardController GetCard()
        {
            if (!cards.TryDequeue(out var card))
            {
                return default;
            }

            if (IsEmpty)
            {
                GetComponent<SpriteRenderer>().sprite = null;
            }

            return cardManager.CreateCard(card, transform);
        }
    }
}