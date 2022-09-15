using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBlock : MonoBehaviour
{
    public GameObject emptyBox;
    [SerializeField] private float destroyTime;
    void OnTriggerEnter2D(Collider2D coll){
        Instantiate(emptyBox, transform.position, transform.rotation);
        Destroy(this.gameObject, destroyTime);
    }
}
