using System;
using UnityEngine;

[Serializable]
public class Card
{
    [SerializeField]
    private string display; 
    public string DisplayName => this.display;

    public string FullName => this.display + " of " + this.suit.DisplayName;

    [SerializeField]
    private int value;
    public int Value => this.value;

    [SerializeField]
    private Sprite sprite;
    public Sprite Sprite => this.sprite;

    [SerializeField]
    private Suit suit;
    public Suit Suit => this.suit;

    public Card(string display, int value, Sprite sprite, Suit suit)
    {
       this.display = display; 
       this.value = value;
       this.sprite = sprite;
       this.suit = suit;
    }
}