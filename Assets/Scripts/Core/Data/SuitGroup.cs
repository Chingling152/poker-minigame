using System.Collections.Generic;
using System;
using UnityEngine;

namespace CardMiniGame.Core.Data
{
    [Serializable]
    public class SuitGroup
    {
#if UNITY_EDITOR
        [SerializeField]
        private string name;
#endif

        [SerializeField]
        private Suit suit;
        public Suit Suit => suit;

        [SerializeField]
        private List<Card> cards;
        public List<Card> Cards => cards;
    }
}