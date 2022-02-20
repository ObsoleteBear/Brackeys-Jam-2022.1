using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabController : MonoBehaviour
{
    public Transform grabDetect;
    public Transform boxHolder;
    public bool holding;
    public float rayDist; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D grabCheck = Physics2D.Raycast(grabDetect.position, Vector2.right * transform.localScale, rayDist);
        
        if (grabCheck.collider != null && grabCheck.collider.tag == "Box")
        {
            if (Input.GetKeyDown(KeyCode.E) && holding == false)
            {
                holding = true;
                grabCheck.collider.gameObject.transform.parent = boxHolder;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
            }
            else if (Input.GetKeyDown(KeyCode.E) && holding == true)
            {
                holding = false;
                grabCheck.collider.gameObject.transform.parent = null;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
            }
            if (holding == true) 
            {
                grabCheck.collider.gameObject.transform.position = boxHolder.position;
            }
        }
    }
}
