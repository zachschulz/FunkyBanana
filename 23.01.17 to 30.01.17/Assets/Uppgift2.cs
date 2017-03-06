using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uppgift2 : MonoBehaviour {
    public float valA = 5;
    public float valB = 10;
	// Use this for initialization

	void Start () {


        if (valA > valB)
        {
            Debug.Log(valA);

            //if valA is bigger than valB print it 
        }
        else
        {
            Debug.Log(valB);

            //If valB is bigger than valA print it 
        }
        //if their Values are equal print same value 
            if (valA == valB)
            {
                Debug.Log("Same Value");
            }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
