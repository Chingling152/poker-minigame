using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    [SerializeField]
    private Deck deck;

    [SerializeField]
    private List<CardController> cards;

    [SerializeField]
    private CardController cardPrefab;

    private void Start()
    {

    }
}
