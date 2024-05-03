using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ColoredButtons : MonoBehaviour
{
    public UnityEvent onButtonPress;
    public UnityEvent onButtonRelease;
    public string color;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(color))
        {
            onButtonPress.Invoke();
        }

    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(color))
        {
            onButtonRelease.Invoke();
        }

    }
}
