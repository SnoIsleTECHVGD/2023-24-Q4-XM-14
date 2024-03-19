using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class moveTowards : MonoBehaviour
{
    //STOLE THIS FROM JOSH, GONNA TWEAK IT A BIT TOO

    //The speed the object is moving at.
    public float speed = 1.0f;

    //The thing our object is moving to.
    public Transform target;

    void Start()
    {
        //Gets our object's transform.
        target = target.GetComponent<Transform>();
    }

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        speed = 1.0f;
        if (other.gameObject.CompareTag("lights"))
        {
            var move = speed;
        transform.position = Vector2.MoveTowards(transform.position, target.position, 3);
        }
        
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        speed = 0;
        if (other.gameObject.CompareTag("lights"))
        {
            var stop = speed;
            transform.position = Vector2.MoveTowards(transform.position, target.position, 3);
        }
        
    }
}
