using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace CardMiniGame.Core.Data
{
    [CreateAssetMenu(fileName = "Card Deck", menuName = "Deck", order = 1)]
    public class Deck : ScriptableObject
    {
        [SerializeField]
        private Sprite backSprite;
        public Sprite BackSprite => backSprite;

        [SerializeField]
        private List<SuitGroup> suits;
        public List<SuitGroup> Suits => suits;

        public IEnumerable<Card> Cards => suits.SelectMany(x => x.Cards);
    }
}