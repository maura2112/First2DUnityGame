using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text highScores1Text;
    public Text highScores2Text;
    public Text scoreText;
    public static int score=0;
    public static int highScore1;
    public static int highScore2;

    private void Start()
    {   
        score = PlayerPrefs.GetInt("Score");
    }
    void Update()
    {
        PlayerPrefs.SetInt("Score", score);
        scoreText.text = "Score: " + Mathf.Round(score);
    }

    public void AddScore(int points)
    {
        score += points;
    }
}
