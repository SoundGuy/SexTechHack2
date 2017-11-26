using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EroticZone : MonoBehaviour {

    public AudioSource Mouth;
    public SoundPlayer MouthSoundPlayers;
    //public AudioClip[] audioClips;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

	}



    void OnCollisionEnter(Collision collision)
    {
        PlaySound();
    }

    void OnTriggerEnter(Collider other)
    {
        PlaySound();
    }

    void PlaySound()
    {

        //choose sound
        Mouth.Play();
    }
}


