using System;
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