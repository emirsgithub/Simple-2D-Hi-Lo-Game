using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loButton : MonoBehaviour
{
    public GameObject[] cardsInDeck;
    public int randomNum;

    public void dealLoCard()
    {
        compareCards.guessingLow = true;
        randomNum = Random.Range(2, 15);
        cardsInDeck[randomNum].SetActive(true);
        compareCards.newCardNumber = randomNum;
    }
}
