using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BatteryCollection : MonoBehaviour
{
    public int BatteryCount;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Battery"))
        {
            BatteryCount++;
            other.gameObject.SetActive(false);
        }
    }
}
