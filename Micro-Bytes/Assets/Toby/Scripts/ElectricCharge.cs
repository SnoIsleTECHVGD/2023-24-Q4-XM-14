using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ElectricCharge : MonoBehaviour
{
    public static bool isCharged;
    public UnityEvent onBoxPress;

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (this.gameObject.CompareTag("Exposed Wire") && other.gameObject.CompareTag("Player") && isCharged == false)
        {
            isCharged = true;
            // Add particle effects
            // Add charged sound effect
        }
        else if (this.gameObject.CompareTag("Circuit Box") && other.gameObject.CompareTag("Player") && isCharged == true)
        {
            onBoxPress.Invoke();
            isCharged = false;
            // Remove particle effects
            // light up wires
            // Change animation of the invoked object: Doors close and lights turn off
            // Turn off any scripts needed to turn off or switch animations or art needed to be switched
            // sound effects
        }
    }
}
