using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Card Deck", menuName = "Deck", order = 1)]
public class Deck : ScriptableObject
{
    [SerializeField]
    private Nipe nipe;
    public Nipe Nipe => this.nipe;

    [SerializeField]
    private List<Card> cards;
    public List<Card> Cards => this.cards;
}