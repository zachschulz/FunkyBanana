using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uppgift1 : MonoBehaviour {
    public int ValA = 10;
    public int ValB = 5;
    private int ValC = 0;
    private int ValD = 0;
	// Use this for initialization
	void Start () {

        Debug.Log(ValA); 

        Debug.Log(ValB);

        ValC = ValA;
        ValD = ValB;
        ValB = ValC;
        ValA = ValD;
            
        Debug.Log(ValA);

        Debug.Log(ValB);
        }

        
	    
	// Update is called once per frame
	void Update () {
		
	}
}