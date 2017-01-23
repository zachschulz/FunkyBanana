using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uppgift2 : MonoBehaviour {
    public float ValA = 5;
    public float ValB = 10;
	// Use this for initialization
	void Start () {
        //Om ValA är större än ValB så printar den ValA's värde i konsollen
        if (ValA > ValB)
        {
            Debug.Log(ValA);

        }
            //Om ValB är större än Val A så printar den ValB's värde i konsollen
        else
        {
            Debug.Log(ValB);
        }
        //Om ValA är lika stort som ValB så printar den Same Value i konsollen
            if (ValA == ValB)
            {
                Debug.Log("Same Value");
            }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
