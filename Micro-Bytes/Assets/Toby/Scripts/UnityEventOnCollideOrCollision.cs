using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class UnityEventOnCollideOrCollision : MonoBehaviour
{
    public UnityEvent collide;
    public UnityEvent onCollision;
    public void OnTriggerEnter2D(Collider2D collider)
    {
        collide.Invoke();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        onCollision.Invoke();
    }
}
