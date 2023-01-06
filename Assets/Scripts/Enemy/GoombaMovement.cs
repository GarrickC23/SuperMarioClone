using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaMovement : Enemy
{
    public GameObject flatGoomba; 
    public float destroyTime;

    // Update is called once per frame
    void Update()
    {
        EnemyMovement(); 
        //rb.velocity = new Vector3(moveSpeed, 0, 0) * Time.deltaTime;
    }

    protected override void EnemyMovement()
    {
        transform.Translate (new Vector3(moveSpeed * direction, 0, 0) * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        var temp = Instantiate(flatGoomba, transform.position, transform.rotation);
        Destroy(this.gameObject, destroyTime);
        Destroy(temp, 0.25f);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //gameObject.transform.Rotate(0, 180, 0, Space.World);
        //transform.RotateAround(gameObject.transform.position, Vector3.up, 180);
        if ( collision.gameObject.tag != "Ground" && collision.gameObject.tag != "Blocks" )
        {
            TurnAround(); 
        }
    }
}
