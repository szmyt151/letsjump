using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreManager : MonoBehaviour
{

    private ScoreManager theScoreManager;

    private PlayerController thePlayerController;

    public Sprite[] playersToBuy;

    public Text[] butttonText;

    public RuntimeAnimatorController[] animationControllers;

    private AnimatorOverrideController animatorOverrideController;


    public void buyPlayer()
    {
        PlayerPrefs.SetInt("ANIMATOR", 0);
    }

    public void buyPlayer1()
    {
        PlayerPrefs.SetInt("ANIMATOR", 1);
    }


    public void buyPlayer2()
    {
        PlayerPrefs.SetInt("ANIMATOR", 2);
    }


    public void buyPlayer3()
    {
        PlayerPrefs.SetInt("ANIMATOR", 3);
    }


}
