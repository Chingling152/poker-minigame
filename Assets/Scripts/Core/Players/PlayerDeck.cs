using CardMiniGame.Core.Data;
using System.Linq;

namespace CardMiniGame.Core.Players
{
    public class PlayerDeck
    {
        private readonly Card[] cards;

        public bool HasSpace => this.cards.Any(x => x == null);

        public PlayerDeck()
        {
            this.cards = new Card[5];
        }

        public PlayerDeck(Card[] cards)
        {
            if (cards.Length < 5)
            {
                var newCard = new Card[5];
                cards.CopyTo(newCard, 0);
                this.cards = newCard;
            }
        }

        public void Add(Card card)
        {
            if (!this.HasSpace)
            {
                throw new System.Exception("Player's deck is full");
            }

            if(this.cards.Any(c => card.Equals(c)))
            {
                throw new System.Exception("Cannot add duplicated card to the deck");
            }

            for (var i = 0; i < this.cards.Length; i++)
            {
                if (this.cards[i] == null)
                {
                    this.cards[i] = card;
                    break;
                }
            }
        }

        public void Remove(Card card)
        {
            for (var i = 0; i < this.cards.Length; i++)
            {
                if (card.Equals(this.cards[i]))
                {
                    this.cards[i] = null;
                    return;
                } 
            }

            throw new System.Exception("Card not found");
        }
    }
}