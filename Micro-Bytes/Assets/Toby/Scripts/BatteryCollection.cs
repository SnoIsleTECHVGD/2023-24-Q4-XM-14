using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class BatteryCollection : MonoBehaviour
{
    public int batteryCount;
    public UnityEvent hasBattery;
    public UnityEvent noBattery;
    public UnityEvent oneBattery;
    public UnityEvent twoBattery;
    public UnityEvent threeBattery;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (batteryCount == 1)
        {
            hasBattery.Invoke();
            oneBattery.Invoke();
        }
        else if (batteryCount == 2)
        { 
            twoBattery.Invoke();
        }
        else if (batteryCount >= 3)
        {
            threeBattery.Invoke();
        }
        else
        {
            noBattery.Invoke();
        }
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Battery"))
        {
            Destroy(other.gameObject);
            batteryCount += 1;
        }
    }
}
