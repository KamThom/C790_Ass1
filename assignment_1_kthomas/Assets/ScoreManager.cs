using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;
    public TextMeshProUGUI scoreText;

    void Update()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
        else
        {
            Debug.LogError("ScoreText is not assigned.");
        }
    }

    public static void AddScore(int points)
    {
        score += points;
    }
}
