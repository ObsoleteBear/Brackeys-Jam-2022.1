using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    Vector2 movement;
    private float deez;
    private SpriteRenderer sprite;

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
        } 
        if(deez < 0)
        {
            sprite.flipX = true;
        }
            
    }
    

    private void FixedUpdate()
    {
        deez = Input.GetAxis("Horizontal");
        movement.Normalize();
        rb.velocity = new Vector2(movement.x * speed * Time.deltaTime, movement.y * speed * Time.deltaTime);
        print(deez);
    }

    
}
