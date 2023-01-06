using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator anim;
    private float speed;
    public float walkSpeed = 3; 
    public float sprintSpeed = 5; 
    public float sprintMultiplier = 5;
    private bool isJumping = false;

    public GameObject fireball;
    private FireFlower power; 
    public float launchVelocity = 700f; 

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
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
        
        //Running
        speed = walkSpeed;
        if ( Input.GetKey(KeyCode.LeftShift) )
        {
            speed *= sprintMultiplier;
        }

        //Left, Right
        float x = Input.GetAxis("Horizontal");
        if ( x > 0 )
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.position += new Vector3(x, 0, 0) * speed * Time.deltaTime; 
            anim.Play("MarioRun");
        }
        else if (x < 0 ) 
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            transform.position += new Vector3(x, 0, 0) * speed * Time.deltaTime; 
            anim.Play("MarioRun");
        }

        //Running
        //if ( !Input.GetKeyDown(KeyCode.LeftShift) )
        //{
        //}
        // if ( Input.GetKey(KeyCode.LeftShift) )
        // {
        //     Debug.Log("sprint");
        //     speed = sprintSpeed;
        // 

        //Crouch
        if ( Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S) )
        {
            Debug.Log("crouched");
        }

        if ( Input.GetButtonDown("Fire1") )
        {
            //Debug.Log(power.firePower);
            GameObject ball = Instantiate(fireball, transform.position + (transform.right * 1), transform.rotation);
            ball.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector3(launchVelocity, 0, 0));
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if ( collision.gameObject.tag == "Blocks" )
        {
            isJumping = false;
        }
    }
}
