using System;
using UnityEngine;

namespace CardMiniGame.Core.Data
{
    [Serializable]
    public class Card
    {
        [SerializeField]
        private string display;
        public string DisplayName => display;

        public string FullName => display + " of " + suit.DisplayName;

        [SerializeField]
        private int value;
        public int Value => value;

        [SerializeField]
        private Sprite sprite;
        public Sprite Sprite => sprite;

        [SerializeField]
        private Suit suit;
        public Suit Suit => suit;

        public Card(string display, int value, Sprite sprite, Suit suit)
        {
            this.display = display;
            this.value = value;
            this.sprite = sprite;
            this.suit = suit;
        }
    }
}