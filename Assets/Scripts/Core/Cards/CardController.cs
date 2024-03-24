using CardMiniGame.Core.Data;
using System.Collections;
using UnityEngine;

namespace CardMiniGame.Core.Cards
{
    public class CardController : MonoBehaviour
    {
        [SerializeField]
        private Card card;

        public Card Card
        {
            get
            {
                return card;
            }
            set
            {
                if (card == null)
                {
                    card = value;
                    GetComponent<SpriteRenderer>().sprite = value.Sprite;
                }
            }
        }

        public void Awake()
        {
            card = null;
        }

        public IEnumerator MoveTo(Vector3 startPosition, Vector3 target)
        {
            float elapsed = 0f;
            while (elapsed < 1f)
            {
                transform.position = Vector3.Lerp(startPosition, target, elapsed * 5);
                elapsed += Time.deltaTime;
                yield return null;
            }

            transform.position = target;
        }
    }
}