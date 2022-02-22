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

    public GameObject sign;

    public SpriteRenderer stamp;
    public Sprite usaStamp;
    public Sprite britainStamp;
    public Sprite mexicoStamp;
    public Sprite canadaStamp;
    public Sprite euStamp;
    public Sprite chinaStamp;
    public Sprite noStamp;


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
                sign.GetComponent<SpriteRenderer>().sprite = squareSprite;
                break;
            case "Triangle":
                sign.GetComponent<SpriteRenderer>().sprite = triangleSprite;
                break;
            case "Circle":
                sign.GetComponent<SpriteRenderer>().sprite = circleSprite;
                break;
            default:
                shape = "Square";
                sign.GetComponent<SpriteRenderer>().sprite = squareSprite;
                break;
        }

        switch (countryStamp)
        {
            case "United States":
                stamp.sprite = usaStamp;
                break;
            case "Britain":
                stamp.sprite = britainStamp;
                break;
            case "Mexico":
                stamp.sprite = mexicoStamp;
                break;
            case "Canada":
                stamp.sprite = canadaStamp;
                break;
            case "European Union":
                stamp.sprite = euStamp;
                break;
            case "China":
                stamp.sprite = chinaStamp;
                break;
            default:
                stamp.sprite = noStamp;
                break;
        }
    }

}   
