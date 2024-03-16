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

    
    void Update()
    {
        var move = speed * Time.deltaTime; // calculate distance to move
        //Moves the object.
        transform.position = Vector3.MoveTowards(transform.position, target.position, move);

    }
}
