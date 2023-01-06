using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public float moveSpeed;
    public float direction; 
    public int health; 
    private Rigidbody2D rb; 
    // Start is called before the first frame update

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>(); 
    }

    //public abstract void EnemyDie();

    //public abstract void TakeDamage(float damageTaken);

    protected abstract void EnemyMovement(); 

    protected void TurnAround()
    {
        if ( direction < 0 )
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 180, 0); 
        }
        direction = -direction; 
    }
}
