using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DeckController : MonoBehaviour
{
    [SerializeField]
    private Deck deck;

    [SerializeField]
    private Queue<Card> cards;

    [SerializeField]
    private CardManager cardManager;

    [System.Obsolete("Find for a better place to put it")]
    public Vector3 SpriteSize
    {
        get;
        private set;
    }

    public bool IsEmpty => this.cards.Count == 0;

    public void Create(Deck deck)
    {
        this.deck = deck;
        this.GetComponent<SpriteRenderer>().sprite = deck.BackSprite;
        this.cards = new Queue<Card>(deck.Cards);

        this.SpriteSize = this.GetComponent<SpriteRenderer>().bounds.size;
    }

    public void Shuffle()
    {
        this.cards = new Queue<Card>(this.deck.Cards.OrderBy(x => Random.Range(0.0f ,10.0f)));
    }

    public CardController GetCard()
    {
        if (!this.cards.TryDequeue(out var card))
        {
            return default;
        }

        if (this.IsEmpty)
        {
            this.GetComponent<SpriteRenderer>().sprite = null;
        }

        return this.cardManager.CreateCard(card, transform);
    }
}