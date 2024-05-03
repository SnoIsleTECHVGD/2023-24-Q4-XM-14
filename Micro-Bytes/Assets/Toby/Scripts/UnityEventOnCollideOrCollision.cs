using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class UnityEventOnCollideOrCollision : MonoBehaviour
{
    
    public UnityEvent collide;
    public UnityEvent onCollision;
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
        
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        
            onCollision.Invoke();
        
    }
}
