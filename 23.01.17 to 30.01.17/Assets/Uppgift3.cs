using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uppgift3 : MonoBehaviour {
    public int ValA = 10;
    public int ValB = 15;

    int Method()
    {
        return ValA + ValB;
        
    }
    

    
	// Use this for initialization
	void Start () {
        Debug.Log(ValA + ValB);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
