using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[Serializable]
public struct Nipe
{
    [SerializeField]
    private string displayName;
    public readonly string DisplayName => this.displayName;

    [SerializeField]
    private int value;
    public readonly int Value => this.value;

    public Nipe(string displayName, int value)
    {
        this.displayName = displayName;
        this.value = value;
    }
}

public class NipeGroup
{ 
    [SerializeField]
    private Nipe nipe;
    public Nipe Nipe => this.nipe;

    [SerializeField]
    private List<Card> cards;
    public List<Card> Cards => this.cards;
}