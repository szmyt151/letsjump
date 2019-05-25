using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsGenerator : MonoBehaviour {

    public ObjectPooler starsPool;

    public float distanceBetweenStars;


    public void SpawnStars(Vector3 startPosition)
    {
        GameObject star1 = starsPool.GetPooledObject();
        star1.transform.position = startPosition;
        star1.gameObject.SetActive(true);
        /*
        GameObject star2 = starsPool.GetPooledObject();
        star2.transform.position = new Vector3(startPosition.x - distanceBetweenStars, startPosition.y, startPosition.z);
        star2.gameObject.SetActive(true);

        
        GameObject star3 = starsPool.GetPooledObject();
        star3.transform.position = new Vector3(startPosition.x + distanceBetweenStars, startPosition.y, startPosition.z);
        star3.gameObject.SetActive(true);
        */
    }
}
