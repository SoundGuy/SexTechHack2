using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DildoCollider : MonoBehaviour {

    public HandJob handjob;
    public HandJob.direction myDirection;
    public  int dildoNumber;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }



    void OnCollisionEnter(Collision collision)
    {
        handjob.colliding(myDirection, dildoNumber);
    }

    void OnTriggerEnter(Collider other)
    {
        handjob.colliding(myDirection,dildoNumber);
    }
}
