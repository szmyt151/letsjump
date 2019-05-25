using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generating_Platform : MonoBehaviour
{

    public GameObject thePlatform;
    public Transform generationPoint;
    public float distanceBetween;
    public float distanceBetweenMin;
    public float distanceBetweenMax;

    public ObjectPooler[] theObjectPools;

    private int platformSelector;
    private float platformWidth;

    private float[] platformWidths;

    private float minHeight;
    private float maxHeight;
    public Transform maxHeightPoint;
    public float maxHeightChange;
    private float heightChange;

    private StarsGenerator theStarsGenerator;

    public float chanceToSpawnStars;

    // Use this for initialization
    void Start()
    {
        platformWidths = new float[theObjectPools.Length];
        for (int i = 0; i < theObjectPools.Length; i++)
            platformWidths[i] = theObjectPools[i].pooledObject.GetComponent<BoxCollider2D>().size.x;

        minHeight = transform.position.y;
        maxHeight = maxHeightPoint.position.y;

        theStarsGenerator = FindObjectOfType<StarsGenerator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < generationPoint.position.x)
        {

            distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);

            platformSelector = Random.Range(0, theObjectPools.Length);

            heightChange = transform.position.y + Random.Range(maxHeightChange, -maxHeightChange);

            if (heightChange > maxHeight)
                heightChange = maxHeight;
            else if (heightChange < minHeight)
                heightChange = minHeight;


            transform.position = new Vector3(transform.position.x + (platformWidths[platformSelector] / 2) + distanceBetween, heightChange, 0);



            GameObject newPlatform = theObjectPools[platformSelector].GetPooledObject();

            newPlatform.transform.position = transform.position;
            newPlatform.transform.rotation = transform.rotation;
            newPlatform.SetActive(true);

            if (Random.Range(0f, 100f) < chanceToSpawnStars)
                theStarsGenerator.SpawnStars(new Vector3(transform.position.x + 2f, transform.position.y + 1f, transform.position.z));

            transform.position = new Vector3(transform.position.x + (platformWidths[platformSelector] / 2), transform.position.y, 0);

            // Instantiate (/*thePlatform*/ thePlatforms[platformSelector], transform.position, transform.rotation);
        }
    }
}
