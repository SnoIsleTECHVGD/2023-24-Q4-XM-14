using UnityEngine;
using System.Collections;

public class MouseMove2D : MonoBehaviour
{

    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;
    public Light normlight;

    void Start()
    {
        normlight = this.GetComponentInChildren<Light>();
    }
    // Update is called once per frame
    void Update()
    {
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
        if (Input.GetMouseButtonDown(1) && normlight.enabled == true)
        {
            normlight.enabled = false;

        }
        
        else if (Input.GetMouseButtonDown(1) && normlight.enabled == false) 
        { 
            normlight.enabled = true;
            
        }
    }
}
