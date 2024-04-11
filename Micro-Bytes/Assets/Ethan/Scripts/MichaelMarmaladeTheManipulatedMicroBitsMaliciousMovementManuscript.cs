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

    //public GameObject current;


    void Start()
    {
        //Gets our object's transform.
        blacklights = GameObject.FindWithTag("Blacklight");
        targets = blacklights.transform;
    }


    private void OnTriggerStay2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Blacklight"))
        {

            transform.position = Vector2.MoveTowards(transform.position, blacklights.transform.position, speed);
            this.GetComponent<pointTowards>().enabled = true;
            this.GetComponent<MichaelMarmaladesMaliciousMachineMovementManuscript>().enabled = false;
        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Blacklight"))
        {
            transform.position = Vector2.MoveTowards(transform.position, blacklights.transform.position, 0);
            this.GetComponent<pointTowards>().enabled = false;
            this.GetComponent<MichaelMarmaladesMaliciousMachineMovementManuscript>().enabled = true;
        }

    }
}

