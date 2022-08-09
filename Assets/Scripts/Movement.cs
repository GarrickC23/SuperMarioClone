using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 0; 
    private bool isJumping = false;
    private bool isRunning = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Jump Button
        if ( Input.GetButtonDown("Jump") && !isJumping )
        {
            Debug.Log("Capsule Jump");
            Debug.Log(isJumping);
            rb.velocity = new Vector2(0, 10);
            isJumping = true;
        }

        //Left, Right
        float x = Input.GetAxis("Horizontal");
        transform.position += new Vector3(x, 0, 0) * speed * Time.deltaTime; 

        //Running
        if ( !isRunning )
        {
            speed *= 1; 
        }
        if ( Input.GetKeyDown(KeyCode.LeftShift) && !isRunning )
        {
            speed *= 5;
            isRunning = true;
        }

        //Crouch
        if ( Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S) )
        {
            Debug.Log("crouched");
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if ( collision.gameObject.tag == "Ground" )
        {
            isJumping = false;
        }
    }
}
