using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailObject : MonoBehaviour
{
    public string color;
    public bool hasStamp;
    public string shape;
    
    

    public SpriteRenderer stamp;

    public void Update()
    {
        switch (color)
        {
            case "Blue":
                gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
                break;
            case "Red":
                gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                break;
            case "Black":
                gameObject.GetComponent<SpriteRenderer>().color = Color.black;
                
                break;
            default:
                break;
        }

        if (hasStamp)
        {
            stamp.enabled = true;
        }
        else
        {
            stamp.enabled = false;
        }

        

    }
}
