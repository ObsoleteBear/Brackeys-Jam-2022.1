 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class binScript : MonoBehaviour
{
    public string binColor;
    public string countryStamp;
    public string shape;

    public MailObject mailObject;
    public MailSpawn mailSpawn;

    public Sprite squareSprite;
    public Sprite circleSprite;
    public Sprite triangleSprite;

    private void Update()
    {
        switch (binColor)
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
                binColor = "White";
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
    }

}   
