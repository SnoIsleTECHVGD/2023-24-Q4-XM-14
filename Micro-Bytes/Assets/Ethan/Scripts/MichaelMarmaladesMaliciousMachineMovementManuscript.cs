using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MichaelMarmaladesMaliciousMachineMovementManuscript : MonoBehaviour
{
    public GameObject player;
    public float speed;
    private float distance;

    //Rotation offset
    public float rotationSpeed = 100f; // Speed of rotation
    public Vector3 rotationOffset; // The offset in degrees
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
        transform.rotation = Quaternion.Euler(Vector3.forward * angle);

        // Rotate the object around its local Z axis at 1 degree per second
        transform.Rotate(Vector3.forward, Time.deltaTime * rotationSpeed);

        // Apply the rotation offset
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + rotationOffset);
    }
}
