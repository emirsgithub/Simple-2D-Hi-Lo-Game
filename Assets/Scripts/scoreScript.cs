using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreScript : MonoBehaviour
{
    public static int score = 0;
    public int highScore = 0;
    public GameObject scoreText;
    public GameObject highScoreText;
    public TextMeshProUGUI scoreTextComponent;
    public TextMeshProUGUI highScoreTextComponent;

    void Update()
    {
        scoreTextComponent = scoreText.GetComponent<TextMeshProUGUI>();
        highScoreTextComponent = highScoreText.GetComponent<TextMeshProUGUI>();
        scoreTextComponent.text = $"Score: {score}";
        highScoreTextComponent.text = $"Best Score: {highScore}";


        if (score > highScore)
        {
            highScore = score;
        }
    }

}