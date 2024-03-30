using UnityEngine;
using UnityEngine.UI;

namespace CardMiniGame.Core.Players.UI
{
    public class PlayerDeckUIController : MonoBehaviour
    {
        [SerializeField]
        private PlayerController player;

        [SerializeField]
        private Image prefab;
        
        [SerializeField]
        private GameObject cardContainer;
        
        [SerializeField]
        private Image[] cardImages;

        private void Start()
        {
            this.CreateCardImages();
            this.player.OnChangeDeck += this.OnChangeDeck;
        }

        private void CreateCardImages()
        {
            cardImages = new Image[5]; 
            
            for (int i = 0; i < 5; i++) {
                cardImages[i] = Instantiate(prefab);
                cardImages[i].transform.SetParent(cardContainer.transform, false);
            }
        }

        private void OnChangeDeck(PlayerDeck newDeck)
        {
            for (int i = 0; i < newDeck.Count; i++)
            {
                cardImages[i].sprite = newDeck.Cards[i]?.Sprite;
            }
        }
    }
}
