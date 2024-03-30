using UnityEngine;

namespace CardMiniGame.Core.Cards
{
    [RequireComponent(typeof(CardController), typeof(SpriteRenderer))]
    public class CardSelectController : MonoBehaviour
    {
        [SerializeField]
        [Range(0.00f,1.00f)]
        private float increaseSize;

        private void OnMouseEnter()
        {
            gameObject.transform.localScale *= (1 + increaseSize);
        }

        private void OnMouseUpAsButton()
        {
            Debug.Log("Click");
        }

        private void OnMouseExit()
        {
            gameObject.transform.localScale /= (1 + increaseSize);
        }
    }
}