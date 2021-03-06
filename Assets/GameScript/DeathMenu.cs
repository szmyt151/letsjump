﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


public class DeathMenu : MonoBehaviour {

    public string playGameLevel;
    public string storeLevel;
    public string menuLevel;

    public Text starsText;
    

    void Start()
    {
        if (PlayerPrefs.HasKey("Stars"))
            starsText.text = "Stars: " + PlayerPrefs.GetInt("Stars");
    }

    public void PlayGame()
    {
       SceneManager.LoadScene(playGameLevel);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Store()
    {
        SceneManager.LoadScene(storeLevel);
    }

    public void Menu()
    {
        SceneManager.LoadScene(menuLevel);
    }
}
