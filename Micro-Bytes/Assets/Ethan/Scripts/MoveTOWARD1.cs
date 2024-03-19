using System.Collections;
using System.Collections.Generic;
//using Unity.Android.Types;
using UnityEngine;

public class MoveTOWARD1 : MonoBehaviour
{
    //The speed the object is moving at.
    public float speed = 1.0f;

    //The thing our object is moving to.
    public Transform target;
    
    void Start()
    {
        //Gets our object's transform.
        target = target.GetComponent<Transform>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        var move = speed * Time.deltaTime; // calculate distance to move
                                           //Moves the object.
        var slow = speed - Time.deltaTime;

        var stop = speed / Time.deltaTime;

            transform.position = Vector3.MoveTowards(transform.position, target.position, slow);

        
            transform.position = Vector3.MoveTowards(transform.position, target.position, move);
        if (target.tag.Equals("Light"))
        {

        }
    }


}
