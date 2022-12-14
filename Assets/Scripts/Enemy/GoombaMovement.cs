using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaMovement : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate (new Vector3(moveSpeed, 0, 0) * Time.deltaTime);
        //rb.velocity = new Vector3(moveSpeed, 0, 0) * Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.transform.Rotate(0, 180, 0, Space.World);
        //transform.RotateAround(gameObject.transform.position, Vector3.up, 180);
    }
}
