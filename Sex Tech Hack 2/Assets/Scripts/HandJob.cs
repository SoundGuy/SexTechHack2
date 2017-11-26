using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class HandJob : MonoBehaviour {

    public int score = 0;

    public int targetStrokes = 10;


    public enum direction
    {
        none,
        down,
        up,
        
    } ;


    public Dildo[] dildos;
    public  direction[] currentDirections;
    public  int[] currentStrokes;

    public TextMesh[] strokeTexts;


    public TextMesh scoreText;
    public TextMesh recordTimeText;

    // Use this for initialization
    void Start() {
        for (int i=0; i < currentDirections.Length; i++)
        {
            currentDirections[i] = direction.none;
        }
        for (int i = 0; i < currentStrokes.Length; i++)
        {
            currentStrokes[i] = 0;
        }


    }

    // Update is called once per frame
    void Update () {
		
	}

    public void colliding(direction dildoDir, int dildoNUmber) {
        Debug.Log("colliing " + dildoNUmber + " dir =" + dildoDir);
        if (currentDirections[dildoNUmber] != dildoDir)
        {
            currentDirections[dildoNUmber] = dildoDir;
            
            if (currentStrokes[dildoNUmber]++ > targetStrokes)
            {
                winDildo(dildoNUmber);
                return;
            }
            strokeTexts[dildoNUmber].text = currentStrokes[dildoNUmber].ToString() ;
        }
    }

    void winDildo(int dildoNUmber)
    {
        currentStrokes[dildoNUmber] = -99999;
        score++;
        scoreText.text = score.ToString();
        dildos[dildoNUmber].Come();

        if (score >= dildos.Length)
        {
            recordTimeText.text = "Time : " + Time.time;
        }
    }
}
