using System.Collections.Generic;
using UnityEngine;

public class DealerController : MonoBehaviour
{
    [SerializeField]
    private CardManager cardManager;

    private Deck deck;

    [SerializeField]
    private List<CardController> cards;

    [SerializeField]
    private GameObject table;
    public GameObject Table => this.table;

    public void Start()
    {
        this.deck = this.cardManager.Deck;
        this.Distribute(deck);
    }

    public void Distribute(Deck deck)
    {
        var y = 0;
        foreach (var suit in deck.Suits)
        {
            var x = 0;
            foreach (var card in suit.Cards)
            {
                var cardController = this.cardManager.CreateCard(card, table.transform);
                var size = cardController.Size;

                cardController.transform.position = table.transform.position + new Vector3( (size.x * x), (size.y * y), 0);
                cards.Add(cardController);

                x++;
            }
            y++;
        }
    }
}