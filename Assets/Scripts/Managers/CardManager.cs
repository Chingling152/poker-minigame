using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    [SerializeField]
    private Deck deck;

    [SerializeField]
    private List<CardController> cards;

    [SerializeField]
    private CardController cardPrefab;

    private void Start()
    {
        foreach (var suit in this.deck.Suits)
        {
            foreach(var card in suit.Cards)
            {
                var cardController = Instantiate(cardPrefab);
                cardController.Card = card;
                cards.Add(cardController);
            }
        }
    }
}
