using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ByteButton : MonoBehaviour
{
    public UnityEvent onButtonPress;
    public UnityEvent onButtonRelease;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            onButtonPress.Invoke();
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            onButtonRelease.Invoke();
        }
    }
}

