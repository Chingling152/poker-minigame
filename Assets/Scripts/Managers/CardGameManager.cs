using UnityEngine;

public class CardGameManager : MonoBehaviour
{
    [SerializeField]
    private CardManager cardManager;

    [SerializeField]
    private GameObject table;

    [SerializeField]
    private DealerController dealer;

    [SerializeField]
    private DeckController deck;

    private void Start()
    {
        this.StartGame();
    }

    public void StartGame()
    {
        deck.Create(cardManager.Deck);
        deck.Shuffle();
        dealer.Distribute(deck);
    }
}