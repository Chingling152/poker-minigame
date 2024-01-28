using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DeckController : MonoBehaviour
{
    [SerializeField]
    private Deck deck;

    [SerializeField]
    private Queue<Card> cards;

    public bool IsEmpty => this.cards.Count == 0;

    public void Create(Deck deck)
    {
        this.deck = deck;
        this.GetComponent<SpriteRenderer>().sprite = deck.BackSprite;
    }

    public void Shuffle()
    {
        this.cards = new Queue<Card>(this.deck.Cards.OrderBy(x => Random.Range(0.0f ,10.0f)));
    }

    public Card GetCard()
    {
        var card = this.cards.Dequeue();

        if(this.IsEmpty)
        {
            this.GetComponent<SpriteRenderer>().sprite = null;
        }

        return card;
    }
}