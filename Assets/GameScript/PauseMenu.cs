using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


public class PauseMenu : MonoBehaviour
{

    public string playGameLevel;
    public string storeLevel;
    public string menuLevel;

    public Text starsText;
    public GameObject pauseMenu;

    void Start()
    {
        if (PlayerPrefs.HasKey("Stars"))
            starsText.text = "Stars: " + PlayerPrefs.GetInt("Stars");
    }

    public void PlayGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(playGameLevel);
    }

    public void QuitGame()
    {
        Time.timeScale = 1f;
        Application.Quit();
    }

    public void Store()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(storeLevel);
    }

    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(menuLevel);
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
}
