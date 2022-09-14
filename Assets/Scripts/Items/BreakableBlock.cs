using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableBlock : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    [SerializeField] private float destroyTime;
    void OnTriggerEnter2D(Collider2D coll){
        anim.Play("BreakableBlockHit");
        Destroy(this.gameObject, destroyTime);
    }
}
