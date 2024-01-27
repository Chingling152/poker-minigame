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

    public Vector3 Size
    {
        get
        {
            return this.GetComponent<SpriteRenderer>().bounds.size;
        }
    }

    public void Awake()
    {
        this.card = null;
    }
}