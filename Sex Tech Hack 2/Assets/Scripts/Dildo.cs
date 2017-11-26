using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dildo : MonoBehaviour {

    public GameObject tip;
    public GameObject come;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Come()
    {
        come.active= true;
    }
}
