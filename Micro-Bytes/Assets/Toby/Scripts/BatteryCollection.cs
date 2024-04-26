using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class BatteryCollection : MonoBehaviour
{
    public int BatteryCount;
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
        if (BatteryCount == 1)
        {
            hasBattery.Invoke();
            oneBattery.Invoke();
        }
        else if (BatteryCount == 2)
        { 
            twoBattery.Invoke();
        }
        else if (BatteryCount == 3)
        {
            threeBattery.Invoke();
        }
        else
        {
            noBattery.Invoke();
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Battery"))
        {
            BatteryCount++;
            Destroy(other.gameObject);
        }
    }
}
