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
    public Sprite deeztop;
    public Sprite deezbottom;
    public Sprite urmom;

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
            sprite.flipX = false;
            gameObject.GetComponent<SpriteRenderer>().sprite = urmom;
        } 
        if(deez < 0)
        {
            sprite.flipX = true;
            gameObject.GetComponent<SpriteRenderer>().sprite = urmom;
        }
        if(nuts > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = deeztop;
        }
        if (nuts < 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = deezbottom;
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
