using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dildo : MonoBehaviour {

    public GameObject tip;
    public GameObject come;
    float destroyTime;
    public float fuseLength = 3f;
    // Use this for initialization
    void Start () {
        destroyTime = 0f;

    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Destroy Time = " + destroyTime +  "curen" + Time.time);

        if (destroyTime != 0f && Time.time - destroyTime > fuseLength)
        {
            Destroy(this.gameObject);
        }
	}

    public void Come()
    {
        come.active= true;
        destroyTime = Time.time;
        Debug.Log("Destroy Time = " + destroyTime );
    }
}
