﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uppgift3 : MonoBehaviour 
{
    public int valA = 10;
    public int valB = 15;

    // is a method 
    int Method()
    {
        return valA + valB;
        
     
    }
    

    
	// Use this for initialization
	void Start () {
        Debug.Log(valA + valB);
        // print valAs + valBs value
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
