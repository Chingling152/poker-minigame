using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct Suit
{
    [SerializeField]
    private string displayName;
    public readonly string DisplayName => this.displayName;

    [SerializeField]
    private int value;
    public readonly int Value => this.value;

    public Suit(string displayName, int value)
    {
        this.displayName = displayName;
        this.value = value;
    }
}

public class SuitGroup
{ 
    [SerializeField]
    private Suit suit;
    public Suit Suit => this.suit;

    [SerializeField]
    private List<Card> cards;
    public List<Card> Cards => this.cards;
}