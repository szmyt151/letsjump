using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMangament : MonoBehaviour {

    public Transform platformGenerator;
    private Vector3 platformGenerationStartPoint;

    public PlayerController thePlayer;
    private Vector3 playerStartPoint;

    private PlatformDestroyer[] platformList;

    private ScoreManager scoreManag;
    public DeathMenu theDeathMenu;

	// Use this for initialization
	void Start () {
        platformGenerationStartPoint = platformGenerator.position;
        playerStartPoint = thePlayer.transform.position;

        scoreManag = FindObjectOfType<ScoreManager>();
	}
	
    public void RestartGame()
    {
        scoreManag.scoreIncreasing = false;
        thePlayer.gameObject.SetActive(false);

        theDeathMenu.gameObject.SetActive(true);
        //  StartCoroutine("RestartGameCo");
    }

    public void Reset()
    {
        theDeathMenu.gameObject.SetActive(false);
        platformList = FindObjectsOfType<PlatformDestroyer>();

        for (int i = 0; i < platformList.Length; i++)
        {
            platformList[i].gameObject.SetActive(false);
        }

        thePlayer.transform.position = playerStartPoint;
        platformGenerator.transform.position = platformGenerationStartPoint;
        thePlayer.gameObject.SetActive(true);

        scoreManag.scoreCount = 0;
        scoreManag.scoreIncreasing = true;
    }
    /*
    public IEnumerator RestartGameCo()
    {
        scoreManag.scoreIncreasing = false;
        thePlayer.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        platformList = FindObjectsOfType<PlatformDestroyer>();

        for(int i = 0; i < platformList.Length; i++)
        {
            platformList[i].gameObject.SetActive(false);
        }

        thePlayer.transform.position = playerStartPoint;
        platformGenerator.transform.position = platformGenerationStartPoint;
        thePlayer.gameObject.SetActive(true);

        scoreManag.scoreCount = 0;
        scoreManag.scoreIncreasing = true;

    }  
    */ 
}
