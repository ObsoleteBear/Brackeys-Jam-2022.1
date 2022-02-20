using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    Vector2 movement;
    private float deez;
    private float nuts;
    private SpriteRenderer sprite;
    public Transform thing;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if(deez > 0)
        {
            transform.Rotate(-1, 0, 0);
            
        } 
        if(deez < 0)
        {
            transform.localScale = new Vector3(transform.localScale.x * 1, transform.localScale.y, transform.localScale.z);

        }
        if(nuts > 0)
        {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y * -1, transform.localScale.z);
        }
        if (nuts < 0)
        {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y * 1, transform.localScale.z);
        }

    }
    

    private void FixedUpdate()
    {
        deez = Input.GetAxis("Horizontal");
        nuts = Input.GetAxis("Vertical");
        movement.Normalize();
        rb.velocity = new Vector2(movement.x * speed * Time.deltaTime, movement.y * speed * Time.deltaTime);
        
    }

    
}
