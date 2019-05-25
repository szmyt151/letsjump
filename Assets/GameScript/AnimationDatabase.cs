using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationDatabase : MonoBehaviour {

    public RuntimeAnimatorController[] animationControllers;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public RuntimeAnimatorController getAnim(int t)
    {
        return this.animationControllers[t];
    }
}
