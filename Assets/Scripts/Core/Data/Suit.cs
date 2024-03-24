using System;
using UnityEngine;

namespace CardMiniGame.Core.Data
{
    [Serializable]
    public struct Suit
    {
        [SerializeField]
        private string displayName;
        public readonly string DisplayName => displayName;

        [SerializeField]
        private int value;
        public readonly int Value => value;

        public Suit(string displayName, int value)
        {
            this.displayName = displayName;
            this.value = value;
        }
    }
}