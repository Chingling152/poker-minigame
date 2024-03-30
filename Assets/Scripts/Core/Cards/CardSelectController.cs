using CardMiniGame.Core.Data;
using System;
using UnityEngine;

namespace CardMiniGame.Core.Cards
{
    [RequireComponent(typeof(CardController), typeof(SpriteRenderer))]
    public class CardSelectController : MonoBehaviour
    {
        public static event Action<Card> OnSelectCard;

        public static event Action<Card> OnDeselectCard;

        [SerializeField]
        [Range(0.00f,1.00f)]
        private float increaseSize;

        private bool selected = false;

        private void OnMouseEnter()
        {
            gameObject.transform.localScale *= (1 + increaseSize);
        }

        private void OnMouseExit()
        {
            gameObject.transform.localScale /= (1 + increaseSize);
        }

        private void OnMouseUpAsButton()
        {
            var card = this.gameObject.GetComponent<CardController>().Card;
            var spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
            if (selected)
            {
                OnDeselectCard?.Invoke(card);
                spriteRenderer.color = Color.white;
            }
            else
            {
                OnSelectCard?.Invoke(card);
                spriteRenderer.color = Color.yellow;
            }

            this.selected = !this.selected;
        }
    }
}