 using UnityEngine;
using System.Collections;

public class Uppgift5 : MonoBehaviour
{
    public int valA = 10;
    public int valB = 5;
    private int valC;
    public float valD = 10;
    public float valE = 0;

    //Is a method
    int Method(int a, int b)
    {
        return a + b;

    }
    // Use this for initialization
    void Start()
    {
        //if valC is bigger than valD and smaller than valE print "between D and E"
        valC = Method(valA, valB);
        if (valC < valE && valC > valD)
        {
            Debug.Log("between D and E");
        }
        //if valC is bigger than valE or smaller than valD print "larger or smaller than it should be"
        else
        {
            Debug.Log("larger or smaller than it should be");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

}

