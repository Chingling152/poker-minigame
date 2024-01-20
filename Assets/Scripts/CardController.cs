using UnityEngine;

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
                this.card = value;
                this.GetComponent<SpriteRenderer>().sprite = value.Sprite;
            }
        }
    }

    public void Awake()
    {
        this.card = null;
    }
}