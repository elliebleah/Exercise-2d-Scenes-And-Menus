using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{
    public TextMeshProUGUI highScoreText; // Reference to the TextMeshProUGUI component for displaying the high score

    void Start()
    {
        // Get the high score from PlayerPrefs and display it
        int highScore = PlayerPrefs.GetInt("HighScore");
        highScoreText.text = "Congrats, your high score is: " + highScore;
    }
}
