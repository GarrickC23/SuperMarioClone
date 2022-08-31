using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb; 
    // Start is called before the first frame update
    void Start()
    {
        localScale.x = 1; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = localScale;
        rb.velocity = new Vector2(localScale.x * speed, rb.velocity.y);
    }
}
