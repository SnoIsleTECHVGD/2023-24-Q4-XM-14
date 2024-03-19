using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseMove : MonoBehaviour
{
    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;
    public Light normLight;
    public CircleCollider2D circleCollider;
    

    // Use this for initialization
    void Start()
    {
        normLight = GetComponentInChildren<Light>();
        circleCollider = GetComponentInChildren<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
            
        if(Input.GetMouseButtonDown(0) && normLight.enabled == false)
        {
            normLight.enabled = true;
            circleCollider.enabled = true;

        }
        else if(Input.GetMouseButtonDown(0) && normLight.enabled == true) 
        {
            normLight.enabled = false;
            circleCollider.enabled = false;
        }

    }
}
