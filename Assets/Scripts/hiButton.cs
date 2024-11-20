using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiButton : MonoBehaviour
{
    public GameObject[] cardsInDeck;
    public int randomNum;

    public void dealHiCard()
    {
        compareCards.guessingHigh = true;
        randomNum = Random.Range(2, 15);
        cardsInDeck[randomNum].SetActive(true);
        compareCards.newCardNumber = randomNum;
    }
}
