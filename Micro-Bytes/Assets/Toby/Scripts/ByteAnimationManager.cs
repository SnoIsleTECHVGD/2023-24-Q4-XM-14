using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ByteAnimationManager : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public GameObject Byte;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /* Enables walking animation
        if ()
        {
            GetComponent<Animator>().SetInteger("Animation Decide", 1);
        }
        */
    }
    //enables idle
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("lights"))
        {
            GetComponent<Animator>().SetInteger("Animation Decide", 0);
        }
    }
    public void Hide()
    {
        GetComponent<Animator>().SetInteger("Animation Decide", 2);
    }
}
