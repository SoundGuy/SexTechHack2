using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour {

    public AudioSource audioSource;
    public AudioClip[] audioClips;
    public int currentClip;
    // Use this for initialization
    void Start () {
        currentClip = 0;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void chooseNext()
    {
        currentClip++;
        if (currentClip >= audioClips.Length)
            currentClip = 0;
        audioSource.clip = audioClips[currentClip];
    }
}
