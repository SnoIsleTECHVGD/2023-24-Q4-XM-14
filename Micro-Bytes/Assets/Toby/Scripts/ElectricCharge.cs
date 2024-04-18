using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ElectricCharge : MonoBehaviour
{
    public static bool isCharged;
    public UnityEvent onBoxPress;
    public bool immune;
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (this.gameObject.CompareTag("Generator") && other.gameObject.CompareTag("Player") && isCharged == false)
        {
            isCharged = true;
            //immune = true;
        }
        else if (this.gameObject.CompareTag("Circuit Box") && other.gameObject.CompareTag("Player") && isCharged == true)
        {
            onBoxPress.Invoke();
            isCharged = false;
            //immune = false;
        }
    }
}
