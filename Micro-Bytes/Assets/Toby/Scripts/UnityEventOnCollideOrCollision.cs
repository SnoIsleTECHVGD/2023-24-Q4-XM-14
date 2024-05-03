using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class UnityEventOnCollideOrCollision : MonoBehaviour
{
    
    public UnityEvent collide;
    public UnityEvent onCollision;
    public bool MichaelBox;
    public GameObject Box;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            collide.Invoke();
        }
        if (other.CompareTag("Broken"))
        {
            other.tag = "Player";
        }
        if (this.CompareTag("Red Box") && other.CompareTag("Player") && MichaelBox == true)
        {
            Box.GetComponent<Rigidbody2D>().mass = 1000;
        }
        if (this.CompareTag("Red Box") && other.CompareTag("Michael") && MichaelBox == true)
        {
            Box.GetComponent<Rigidbody2D>().mass = 10;
        }

    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        
            onCollision.Invoke();
        
    }
}
