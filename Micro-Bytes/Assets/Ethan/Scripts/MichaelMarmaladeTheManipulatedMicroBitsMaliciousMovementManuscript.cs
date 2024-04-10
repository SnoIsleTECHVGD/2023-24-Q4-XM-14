using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MichaelMarmaladeTheManipulatedMicroBitsMaliciousMovementManuscript : MonoBehaviour
{
    //The speed the object is moving at.
    public float speed = 1.0f;

    //The thing our object is moving to.
    public GameObject @byte;
    public Transform targets;
    public GameObject blacklights;
    void Start()
    {
        //Gets our object's transform.
        @byte = GameObject.FindWithTag("player");
        targets = @byte.transform;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Blacklight"))
        {
            transform.position = Vector2.MoveTowards(transform.position, blacklights.transform.position, speed);
            transform.position = Vector2.MoveTowards(transform.position, @byte.transform.position, 0);
            this.GetComponent<pointTowards>().enabled = true;
        }
        else 
        {
            transform.position = Vector2.MoveTowards(transform.position, blacklights.transform.position, 0);
            transform.position = Vector2.MoveTowards(transform.position, @byte.transform.position, speed);
            this.GetComponent<pointTowards>().enabled = false;
        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Blacklight"))
        {
            transform.position = Vector2.MoveTowards(transform.position, blacklights.transform.position, 0);
            transform.position = Vector2.MoveTowards(transform.position, @byte.transform.position, 0);
            this.GetComponent<pointTowards>().enabled = false;
        }
    }
}
