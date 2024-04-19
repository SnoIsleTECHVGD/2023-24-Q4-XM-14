using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public Vector3 smoothPosition;
    private Vector2 mousePast;
    private Vector2 mouseNow;
    [Range(0, 10)]
    public float movingSmoothFactor;
    [Range(0, 10)]
    public float stopSmoothFactor;
    private float currentLerpFactor;
    public float lerpSpeed;

    private void Start()
    {
        mouseNow = Input.mousePosition;
        mousePast = mouseNow;
    }
    private void FixedUpdate()
    {
        Follow();
    }

    void Follow()
    {
        Vector3 targetPosition = target.position + offset;
        mouseNow = Input.mousePosition;
        if (mouseNow != mousePast)
        {
            smoothPosition = targetPosition;
            currentLerpFactor = Mathf.Lerp(currentLerpFactor, movingSmoothFactor, Time.fixedDeltaTime * lerpSpeed);
        }
        else
        {
            currentLerpFactor = Mathf.Lerp(currentLerpFactor, stopSmoothFactor, Time.fixedDeltaTime * lerpSpeed);
        }
        transform.position = Vector3.Lerp(transform.position, smoothPosition, currentLerpFactor * Time.fixedDeltaTime);
        mousePast = mouseNow;
    }
}
