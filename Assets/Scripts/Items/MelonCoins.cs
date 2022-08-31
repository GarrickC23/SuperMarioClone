using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MelonCoins : MonoBehaviour
{
    private Animator anim; 
    public float destroyTime; 
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        anim.Play("CoinCollected");
        Destroy(this.gameObject, destroyTime);
    }
}
