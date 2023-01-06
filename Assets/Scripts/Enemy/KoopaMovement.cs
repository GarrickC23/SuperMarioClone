using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KoopaMovement : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMovement();
    }

    protected override void EnemyMovement()
    {
        transform.Translate (new Vector3(moveSpeed * direction, 0, 0) * Time.deltaTime);
    }
}
