using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 0; 
    private bool isJumping = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetButtonDown("Jump") && !isJumping )
        {
            Debug.Log("Capsule Jump");
            Debug.Log(isJumping);
            rb.velocity = new Vector2(0, 10);
            isJumping = true;
        }
        float x = Input.GetAxis("Horizontal");
        transform.position += new Vector3(x, 0, 0) * speed * Time.deltaTime; 
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if ( collision.gameObject.tag == "Ground" )
        {
            isJumping = false;
        }
    }
}
