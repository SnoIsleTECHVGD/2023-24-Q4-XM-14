using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.UIElements;
using UnityEngine;

public class moveTowards : MonoBehaviour
{
    //STOLE THIS FROM JOSH, GONNA TWEAK IT A BIT TOO

    //The speed the object is moving at.
    public float speed = 1.0f;

    //The thing our object is moving to.
    public GameObject lights;
    public Transform targets;

    public GameObject current;
    

    void Start()
    {
        //Gets our object's transform.
        lights = GameObject.FindWithTag("lights");
        targets = lights.transform;
    }

    
    private void OnTriggerStay2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("lights"))
        {
            
            transform.position = Vector2.MoveTowards(transform.position, lights.transform.position, speed);
            
        }
        
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("lights"))
        {
            transform.position = Vector2.MoveTowards(transform.position, lights.transform.position, 0);
            
        }
        
    }
}
