using System;
using UnityEngine;

[Serializable]
public class Card
{
    [SerializeField]
    private string display; 
    public string DisplayName => this.display;

    public string FullName => this.display + " of " + this.nipe.DisplayName;

    [SerializeField]
    private int value;
    public int Value => this.value;

    [SerializeField]
    private Sprite sprite;
    public Sprite Sprite => this.sprite;

    [SerializeField]
    private Nipe nipe;
    public Nipe Nipe => this.nipe;

    public Card(string display, int value, Sprite sprite, Nipe nipe)
    {
       this.display = display; 
       this.value = value;
       this.sprite = sprite;
       this.nipe = nipe;
    }
}