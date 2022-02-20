using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailObject : MonoBehaviour
{
    public string color;
    public bool hasStamp;
    public string shape;

    public Sprite squareSprite;
    public Sprite circleSprite;
    public Sprite triangleSprite;

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
                color = "White";
                gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                break;
        }

        switch (shape) 
        {
            case "Square":
                gameObject.GetComponent<SpriteRenderer>().sprite = squareSprite;
                break;
            case "Triangle":
                gameObject.GetComponent<SpriteRenderer>().sprite = triangleSprite;
                break;
            case "Circle":
                gameObject.GetComponent<SpriteRenderer>().sprite = circleSprite;
                break;
            default:
                shape = "Square";
                gameObject.GetComponent<SpriteRenderer>().sprite = squareSprite;
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
