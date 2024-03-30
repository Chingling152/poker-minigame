using CardMiniGame.Core.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CardMiniGame.Core.Players
{
    public class PlayerDeck : ICollection<Card>
    {
        private readonly Card[] cards;

        public Card[] Cards => this.cards.ToArray();

        public bool HasSpace => this.cards.Any(x => x == null);

        public int Count => this.cards.Length;

        public bool IsReadOnly => throw new System.NotImplementedException();

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

        public bool Remove(Card card)
        {
            for (var i = 0; i < this.cards.Length; i++)
            {
                if (card.Equals(this.cards[i]))
                {
                    this.cards[i] = null;
                    return true;
                } 
            }

            throw new System.Exception("Card not found");
            //TODO: fix return/exception
            return false;
        }

        public void Clear()
        {
            for (int i = 0; i < this.cards.Length; i++)
            {
                this.cards[i] = null;
            }
        }

        public bool Contains(Card item)
        {
            if(item == null)
            {
                throw new System.ArgumentNullException("item cannot be null");
            }

            for (var i = 0; i < this.cards.Length; i++)
            {
                if (item.Equals(this.cards[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public void CopyTo(Card[] array, int arrayIndex)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerator<Card> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}