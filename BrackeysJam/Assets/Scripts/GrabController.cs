using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class GrabController : MonoBehaviour
{
    public Transform grabDetect;
    public Transform boxHolder;
    public GameObject mailHeld;
    public float holdForce;
    //public bool holding;
    public float rayDist; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D grabCheck = Physics2D.Raycast(boxHolder.position, grabDetect.localPosition, rayDist);
        
        if (grabCheck.collider != null && grabCheck.collider.tag == "Letter")
        {
            if (Input.GetKeyDown(KeyCode.E) && mailHeld == null && grabCheck != mailHeld)
            {
                //grabCheck.collider.gameObject.transform.parent = boxHolder;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
                mailHeld = grabCheck.collider.gameObject;
            }
            else if (Input.GetKeyDown(KeyCode.E) && mailHeld != null)
            {
                //grabCheck.collider.gameObject.transform.parent = null;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
                mailHeld = null;
            }
        }
        if (mailHeld != null)
        {
            mailHeld.transform.position = boxHolder.position;

            //Vector2 holdPos = boxHolder.transform.position - mailHeld.transform.position;
            //mailHeld.GetComponent<Rigidbody2D>().AddForce(holdPos * holdForce);
        }
    }
}
