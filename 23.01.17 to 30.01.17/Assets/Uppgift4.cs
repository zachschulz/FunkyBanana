using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uppgift4 : MonoBehaviour {
    public float ValA;
    public float ValB;
    public float ValC;

	// Use this for initialization
	void Start () {

		if(ValC < ValB || ValC < ValA)
        {

            Debug.Log("in the middle");
            //if their value is between A and B print "in the middle"
        }
        else
        {
            Debug.Log("not in the middle");
            //if it's not print "not in the middle" 
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
