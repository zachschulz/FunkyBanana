using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uppgift1 : MonoBehaviour 
{
   
    public int valA = 10;
    public int valB = 5;
    private int valC = 0;
    private int valD = 0;

	// Use this for initialization
	void Start () {

        Debug.Log(valA); 

        Debug.Log(valB);

        // swapped valA and valBs value to valC and valD to save them
        valC = valA;
        valD = valB;

        // swapped their values 
        valB = valC;
        valA = valD;

        // print it
        Debug.Log(valA);

        Debug.Log(valB);

        

        }

        
	    
	// Update is called once per frame
	void Update () {
		
	}
}