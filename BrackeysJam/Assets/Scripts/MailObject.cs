using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailObject : MonoBehaviour
{
    public string color;
    public string countryStamp;
    public string shape;

    public float despawnTimer;
    public float despawnMin;
    public float despawnMax;
    public bool inBin;
    public int mailCost;

    public Sprite squareSprite;
    public Sprite circleSprite;
    public Sprite triangleSprite;

    public SpriteRenderer stamp;
    public Sprite usaStamp;
    public Sprite britainStamp;
    public Sprite mexicoStamp;
    public Sprite canadaStamp;
    public Sprite euStamp;
    public Sprite chinaStamp;
    public Sprite noStamp;

    public MailSpawn mailSpawn;
    public binScript binScript;

    public void Awake()
    {
        inBin = false;
        despawnTimer = GameObject.FindGameObjectWithTag("MailSpawner").GetComponent<MailSpawn>().mailDespawn;
        mailSpawn = GameObject.FindGameObjectWithTag("MailSpawner").GetComponent<MailSpawn>();
        binScript = GameObject.FindGameObjectWithTag("Bin").GetComponent<binScript>();
    }
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

        if (inBin == false)
        {
            despawnTimer -= Time.deltaTime;
        }
        if(inBin == true)
        {
            
            Destroy(gameObject);
        }

        if (despawnTimer <= 0)
        {
            GameObject.FindGameObjectWithTag("MailSpawner").GetComponent<MailSpawn>().LosePoints(mailCost);
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bin" && inBin == false)
        {
            collision.GetComponent<binScript>().MailTouched(color, countryStamp, shape, this);
        }
    }

    public void TouchedBin()
    {
        inBin = true;
        mailSpawn.playerScore += mailCost;
    }

    public void binFail()
    {
        inBin = true;
        mailSpawn.playerScore -= mailCost;
    }
}