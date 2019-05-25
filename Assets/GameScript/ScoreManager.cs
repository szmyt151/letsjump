using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public Text scoreText;
    public Text hiScoreText;

    public float scoreCount;
    public float hiScoreCount;

    public float pointsPerSeconds;

    public bool scoreIncreasing;

    public int starsCount;

    // Use this for initialization
    void Start()
    {
        if (PlayerPrefs.HasKey("Highscore"))
            hiScoreCount = PlayerPrefs.GetFloat("Highscore");

        if (PlayerPrefs.HasKey("Stars"))
            starsCount = PlayerPrefs.GetInt("Stars");

    }

    // Update is called once per frame
    void Update()
    {
        if (scoreIncreasing)
            scoreCount += pointsPerSeconds * Time.deltaTime;

        if (scoreCount > hiScoreCount)
        {
            hiScoreCount = scoreCount;
            PlayerPrefs.SetFloat("Highscore", hiScoreCount);
        }

        scoreText.text = "Score: " + Mathf.RoundToInt(scoreCount);
        hiScoreText.text = "High Score: " + Mathf.RoundToInt(hiScoreCount);
    }

    public void addStars(int starsToAdd)
    {
        starsCount += starsToAdd;
        PlayerPrefs.SetInt("Stars", starsCount);
    }
}
