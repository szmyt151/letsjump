using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupPoints : MonoBehaviour {

    public int starsToGive;

    private ScoreManager scoreManag;

	// Use this for initialization
	void Start () {
        scoreManag = FindObjectOfType<ScoreManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            scoreManag.addStars(starsToGive);
            gameObject.SetActive(false);
        }
    }
}
