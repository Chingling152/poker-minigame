using System;
using System.Collections.Generic;
using UnityEngine;

public class DealerController : MonoBehaviour
{
    [SerializeField]
    private CardManager cardManager;

    [SerializeField]
    private List<CardController> cards;

    [SerializeField]
    private GameObject table;

    [Obsolete("Useless method")]
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

    public void Distribute(DeckController deck)
    {
        var x = 0;
        var y = 0;
        while (!deck.IsEmpty)
        {
            var card = deck.GetCard();

            var cardController = this.cardManager.CreateCard(card, table.transform);
            var size = cardController.Size;

            cardController.transform.position = table.transform.position + new Vector3((size.x * x), (size.y * y), 0);
            cards.Add(cardController);

            x++;
            if (x > 12)//TODO: remove this code
            {
                y++;
                x = 0;
            }
        }
    }
}