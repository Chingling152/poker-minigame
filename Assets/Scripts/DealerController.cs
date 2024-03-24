using System.Collections;
using UnityEngine;

public class DealerController : MonoBehaviour
{
    [SerializeField]
    private DealerCommandHandler handler;

    [SerializeField]
    private DeckManager deckManager;

    [SerializeField]
    private DeckController deckController;

    [SerializeField]
    private GameObject table;

    private void Start()
    {
        this.deckController = this.deckManager.CreateDeck(this.transform);
        this.StartCoroutine(DistributeAsync());
    }

    private IEnumerator DistributeAsync()
    {
        var x = 0;
        var y = 0;
        while (!this.deckController.IsEmpty)
        {
            var size = deckController.SpriteSize;
            var target = table.transform.position + new Vector3((size.x * x), (size.y * y), 0);
            this.handler.AddCommand(
                new DealerDistributeCommand(this, deckController, target)
            );
            x++;
            if (x > 12)//TODO: remove this code
            {
                y++;
                x = 0;
            }
            yield return new WaitForEndOfFrame();
        }
    }
    public void Distribute()
    {
        var x = 0;
        var y = 0;
        while (!this.deckController.IsEmpty)
        {
            var size = deckController.SpriteSize;
            var target = table.transform.position + new Vector3((size.x * x), (size.y * y), 0);
            this.handler.AddCommand(
                new DealerDistributeCommand(this, deckController, target)
            );
            x++;
            if (x > 12)//TODO: remove this code
            {
                y++;
                x = 0;
            }
        }
    }
}