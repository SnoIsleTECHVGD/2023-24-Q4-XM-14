using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseMove : MonoBehaviour
{
    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;


    public Light normLight;
    public CircleCollider2D normCollider;

    public Light blacklight;
    public CircleCollider2D blacklightCollider;

    

    // Use this for initialization
    void Start()
    {
        /*normLight = GetComponentInChildren<Light>();
        normCollider = GetComponentInChildren<CircleCollider2D>();
        blacklight = GetComponentInChildren<Light>();
       // blacklightCollider = GetComponentInChildren<CircleCollider2D>();*/
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
            normCollider.enabled = true;
            blacklight.enabled = false;
            blacklightCollider.enabled = false;
        }
        else if(Input.GetMouseButtonDown(0) && normLight.enabled == true) 
        {
            normLight.enabled = false;
            normCollider.enabled = false;
        }

        if(Input.GetMouseButtonDown(1) && blacklight.enabled == false)
        {
            blacklight.enabled = true;
            blacklightCollider.enabled = true;
            normLight.enabled = false;
            normCollider.enabled = false;
        }
        else if (Input.GetMouseButtonDown(1) && blacklightCollider.enabled == true)
        {
            blacklight.enabled = false;
            blacklightCollider.enabled = false;
        }

    }
}
