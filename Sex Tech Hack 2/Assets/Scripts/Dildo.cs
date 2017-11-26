using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dildo : MonoBehaviour {

    public GameObject tip;
    public GameObject come;
    float destroyTime;
    public float fuseLength = 2000f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - destroyTime > fuseLength)
        {
            Destroy(this);
        }
	}

    public void Come()
    {
        come.active= true;
        destroyTime = Time.time;
    }
}
