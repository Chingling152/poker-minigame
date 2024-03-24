using UnityEngine;

public class DeckManager : MonoBehaviour
{
    [SerializeField]
    private Deck deck;

    [SerializeField]
    private DeckController deckPrefab;

    public DeckController CreateDeck(Transform transform)
    {
        var deckController = Instantiate(deckPrefab);

        deckController.transform.position = transform.position;
        deckController.Create(this.deck);
        deckController.Shuffle();

        return deckController;
    }
}