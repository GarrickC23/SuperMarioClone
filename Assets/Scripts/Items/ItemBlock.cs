using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBlock : MonoBehaviour
{
    public GameObject emptyBox;
    public GameObject mushroom;
    public float distance;

    [SerializeField] private float destroyTime;
    void OnTriggerEnter2D(Collider2D coll){
        Instantiate(emptyBox, transform.position, transform.rotation);
        Instantiate(mushroom, transform.position + (transform.up * distance), transform.rotation);
        Destroy(this.gameObject, destroyTime);
    }
}
