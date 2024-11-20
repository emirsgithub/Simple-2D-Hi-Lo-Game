using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class compareCards : MonoBehaviour
{
    public static int dealtCardNumber;
    public static int newCardNumber;
    public GameObject correctText;
    public GameObject incorrectText;
    public static bool guessingHigh = false;
    public static bool guessingLow = false;
    public GameObject hiButton;
    public GameObject loButton;
    public GameObject dealButton;
    public GameObject clearButton;
    public GameObject[] cardsInDeck1;
    public GameObject[] cardsInDeck2;
    

    void Update()
    {
        if (guessingHigh == true)
        {
            guessingHigh = false;
            hiButton.SetActive(false);
            loButton.SetActive(false);
            StartCoroutine(guessingHigher());
            StartCoroutine(clearGame());
            
        }
        if (guessingLow == true)
        {
            guessingLow = false;
            hiButton.SetActive(false);
            loButton.SetActive(false);
            StartCoroutine(guessingLower());
            StartCoroutine(clearGame());
        }
    }

    IEnumerator guessingHigher()
    {
        yield return new WaitForSeconds(1);
        if (dealtCardNumber <= newCardNumber)
        {
            correctText.SetActive(true);
            scoreScript.score+=1;
        }
        else
        {
            incorrectText.SetActive(true);
            scoreScript.score = 0;
        }
        
    }

    IEnumerator guessingLower()
    {
        yield return new WaitForSeconds(1);
        if (dealtCardNumber > newCardNumber)
        {
            correctText.SetActive(true);
            scoreScript.score++;
        }
        else
        {
            incorrectText.SetActive(true);
            scoreScript.score = 0;
        }
    }

    IEnumerator clearGame()
    {
        yield return new WaitForSeconds(2);
        correctText.SetActive(false);
        incorrectText.SetActive(false);
        cardsInDeck1[dealtCardNumber].SetActive(false);
        cardsInDeck2[newCardNumber].SetActive(false);
        dealButton.SetActive(true);
    }

}
