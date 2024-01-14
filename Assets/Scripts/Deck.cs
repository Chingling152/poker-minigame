using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Card Deck", menuName = "Deck", order = 1)]
public class Deck : ScriptableObject
{
    [SerializeField]
    private Suit suit;
    public Suit Suit => this.suit;

    [SerializeField]
    private List<Card> cards;
    public List<Card> Cards => this.cards;
}