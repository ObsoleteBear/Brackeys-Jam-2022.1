using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class letterScript : MonoBehaviour
{
    //Put this on the bin thiing
    public bool blackBin;
    private GameObject letterThing;
    public int Score;
    private GameObject thing;
    


    private void Awake()
    {
        letterThing = GameObject.FindGameObjectWithTag("Letter");
        
    }
    private void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (blackBin == true && letterThing.name == "blackLetter") 
        {
            GameObject.Destroy(thing);
            print("dez");
            Score += 1;
            
        }
    }
}
