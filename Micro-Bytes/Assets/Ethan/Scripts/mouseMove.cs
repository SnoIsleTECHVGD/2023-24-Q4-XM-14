using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering.Universal;

public class mouseMove : MonoBehaviour
{
    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;
    public UnityEvent normlightSwitchOn;
    public UnityEvent normlightSwitchOff;
    public UnityEvent blacklightSwitchOn;
    public UnityEvent blacklightSwitchOff;

    public Light2D flashLight;
    public CircleCollider2D flashLightCollider;

    public Light2D blacklight;
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
        
        // Turns on the normal light and turns off black light   
        if(Input.GetMouseButtonDown(0) && flashLight.enabled == false)
        {
            normlightSwitchOn.Invoke();
            flashLight.enabled = true;
            flashLightCollider.enabled = true;
            blacklight.enabled = false;
            blacklightCollider.enabled = false;
        }
        // turns off the normal light
        else if(Input.GetMouseButtonDown(0) && flashLight.enabled == true) 
        {
            normlightSwitchOff.Invoke();
            flashLight.enabled = false;
            flashLightCollider.enabled = false;
        }
        // turns on black light and turns off normal light
        if(Input.GetMouseButtonDown(1) && blacklight.enabled == false)
        {
            blacklightSwitchOn.Invoke();
            blacklight.enabled = true;
            blacklightCollider.enabled = true;
            flashLight.enabled = false;
            flashLightCollider.enabled = false;
        }
        // turns off blacklight
        else if (Input.GetMouseButtonDown(1) && blacklightCollider.enabled == true)
        {
            blacklightSwitchOff.Invoke();
            blacklight.enabled = false;
            blacklightCollider.enabled = false;
        }

    }
}
