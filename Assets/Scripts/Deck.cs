using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "Card Deck", menuName = "Deck", order = 1)]
public class Deck : ScriptableObject
{
    [SerializeField]
    private Sprite backSprite;
    public Sprite BackSprite => this.backSprite;

    [SerializeField]
    private List<SuitGroup> suits;
    public List<SuitGroup> Suits => this.suits;

    public IEnumerable<Card> Cards => this.suits.SelectMany(x => x.Cards);
}

[Serializable]
public class SuitGroup
{
#if UNITY_EDITOR
    [SerializeField]
    private string name;
#endif

    [SerializeField]
    private Suit suit;
    public Suit Suit => this.suit;

    [SerializeField]
    private List<Card> cards;
    public List<Card> Cards => this.cards;
}