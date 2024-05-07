using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ElectricCharge : MonoBehaviour
{
    public static bool isCharged;
    public UnityEvent onBoxPress;
    public GameObject timerGenerator;
    public bool immune;
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (this.gameObject.CompareTag("Generator") && other.gameObject.CompareTag("Player") && isCharged == false)
        {
            isCharged = true;
            //immune = true;
        }
        else if (this.gameObject.CompareTag("Generator") && other.gameObject.CompareTag("Michael") && isCharged == false)
        {
            isCharged = true;
        }
        if (this.gameObject.CompareTag("Timed Box") && other.gameObject.CompareTag("Michael") && isCharged == true)
        {
            isCharged = false;
            timerGenerator.GetComponent<MichaelSpawner>().Teleport();
            timerGenerator.GetComponent<TimedGenerator>().isOn = true;
            timerGenerator.GetComponent<TimedGenerator>().PowerOn();
        }
        else if (this.gameObject.CompareTag("Timed Box") && other.gameObject.CompareTag("Player") && isCharged == true)
        {
            isCharged = false;
            timerGenerator.GetComponent<TimedGenerator>().isOn = true;
            timerGenerator.GetComponent<TimedGenerator>().PowerOn();
            timerGenerator.GetComponent<MichaelSpawner>().Teleport();
        }
        else if (this.gameObject.CompareTag("Circuit Box") && other.gameObject.CompareTag("Player") && isCharged == true)
        {
            onBoxPress.Invoke();
            isCharged = false;
            //immune = false;
        }
        else if (this.gameObject.CompareTag("Circuit Box") && other.gameObject.CompareTag("Michael") && isCharged == true)
        {
            onBoxPress.Invoke();
            isCharged = false;
            //immune = false;
        }

    }
} 
