using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dealCards : MonoBehaviour
{
    public GameObject[] cardsInDeck;
    public int randomNum;
    public GameObject hiButton;
    public GameObject loButton;
    public GameObject dealButton;
    public static int count = 0;

    public void dealNewCard()
    {
        randomNum = Random.Range(2, 15);
        cardsInDeck[randomNum].SetActive(true);
        hiButton.SetActive(true);
        loButton.SetActive(true);
        dealButton.SetActive(false);
        compareCards.dealtCardNumber = randomNum;
    }
}
