using UnityEngine;

public class CardManager : MonoBehaviour
{
    [SerializeField]
    private CardController cardPrefab;

    public CardController CreateCard(Card card, Transform transform)
    {
        var cardController = Instantiate(cardPrefab);

        cardController.name = $"Card ({card.FullName})";
        cardController.Card = card;
        cardController.transform.SetParent(transform);

        return cardController;
    }
}
