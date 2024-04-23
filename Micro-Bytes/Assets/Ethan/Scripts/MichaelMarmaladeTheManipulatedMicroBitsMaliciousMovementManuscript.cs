using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class MichaelMarmaladeTheManipulatedMicroBitsMaliciousMovementManuscript : MonoBehaviour
{
    //STOLE THIS FROM JOSH, GONNA TWEAK IT A BIT TOO

    //The speed the object is moving at.
    public float speed = 1.0f;

    //The thing our object is moving to.
    public GameObject blacklights;
    public Transform targets;

    public bool lightOn;
    //public GameObject current;

    


    void Start()
    {
        //Gets our object's transform.
        blacklights = GameObject.FindWithTag("Blacklight");
        targets = blacklights.transform;
    }

    private void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Blacklight"))
        {
            lightOn = true;
            this.GetComponent<MichaelMarmaladesMaliciousMachineMovementManuscript>().enabled = false;
            this.GetComponent<pointTowards>().enabled = true;
            //should move MMTMMB towards the mouse while in collision with Blacklight collider
            transform.position = Vector2.MoveTowards(transform.position, blacklights.transform.position, speed);
        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Blacklight"))
        {
            lightOn = false;
            transform.position = Vector2.MoveTowards(transform.position, blacklights.transform.position, 0);
            //this.GetComponent<pointTowards>().enabled = false;
            this.GetComponent<MichaelMarmaladesMaliciousMachineMovementManuscript>().enabled = true;
            this.GetComponent<pointTowards>().enabled = false;
        }

    }
}

