using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailObject : MonoBehaviour
{
    public string color;
    public string countryStamp;
    public string shape;

    public float despawnTimer;
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
        mailSpawn = GameObject.FindGameObjectWithTag("MailSpawner").GetComponent<MailSpawn>();
        binScript = GameObject.FindGameObjectWithTag("Bin").GetComponent<binScript>();
        despawnTimer = Random.Range(mailSpawn.mailDespawnMin, mailSpawn.mailDespawnMax);
        //color randomizer
        switch (Random.Range(1, 4)) 
        {
            case 1:
                color = "Blue";
                break;
            case 2:
                color = "Red";
                break;
            case 3:
                color = "Black";
                break;
            case 4:
                color = "White";
                break;
        }
        //shape randomizer
        switch (Random.Range(1, 3)) 
        {
            case 1:
                shape = "Square";
                break;
            case 2:
                shape = "Triangle";
                break;
            case 3:
                shape = "Circle";
                break;
        }
        //country randomizer
        switch (Random.Range(1, 7)) 
        {
            case 1:
                countryStamp = "United States";
                break;
            case 2:
                countryStamp = "Britain";
                break;
            case 3:
                countryStamp = "Mexico";
                break;
            case 4:
                countryStamp = "Canada";
                break;
            case 5:
                countryStamp = "European Union";
                break;
            case 6:
                countryStamp = "China";
                break;
            case 7:
                countryStamp = "None";
                break;
        }
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