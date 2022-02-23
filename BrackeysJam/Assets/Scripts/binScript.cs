using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class binScript : MonoBehaviour
{
    public string countryStamp;
    public string shape;

    public MailObject mailObject;
    public MailSpawn mailSpawn;

    public GameObject sign;

    public bool square;
    public bool circle;
    public bool triangle;
    
    public bool black;
    public bool blue;
    public bool red;
    public bool white;

    public bool usaStamp;
    public bool britainStamp;
    public bool mexicoStamp;
    public bool canadaStamp;
    public bool euStamp;
    public bool chinaStamp;
    public bool noStamp;

    private void Update()
    {

    }

    public void MailTouched(string color, string country, string shape, MailObject mail)
    {
        bool mailTrue = true;
        //check if its the right color
        switch (color)
        {
            case "Red":
                if (red)
                {
                    mailTrue = true;
                }
                else
                {
                    mailTrue = false;
                }
                break;
            case "Black":
                if (black)
                {
                    mailTrue = true;
                }
                else
                {
                    mailTrue = false;
                }
                break;
            case "Blue":
                if (blue)
                {
                    mailTrue = true;
                }
                else
                {
                    mailTrue = false;
                }
                break;
            case "White":
                if (white)
                {
                    mailTrue = true;
                }
                else
                {
                    mailTrue = false;
                }
                break;
        }

        //check if mail should fail
        if (!mailTrue)
        {
            mail.binFail();
        }

    }
}