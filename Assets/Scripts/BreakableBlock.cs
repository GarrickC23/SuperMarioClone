using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableBlock : MonoBehaviour
{
    [SerializeField] private float destroyTime;
    void OnTriggerEnter2D(Collider2D coll){
        Destroy(this.gameObject, destroyTime);
    }
}
