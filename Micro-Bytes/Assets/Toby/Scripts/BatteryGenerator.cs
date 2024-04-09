using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BatteryGenerator : MonoBehaviour
{
    public UnityEvent GeneratorOn;
    public UnityEvent OneBattery;
    public UnityEvent TwoBattery;
    public UnityEvent ThreeBattery;
    public int BatteriesIn;
    int BatteryCount;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        BatteryCount = FindObjectOfType<BatteryCollection>().BatteryCount;
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") && BatteryCount > 0)
        {
            BatteriesIn += BatteryCount;
            BatteryCount = 0;
            FindObjectOfType<BatteryCollection>().BatteryCount = 0;
        }
        if (other.gameObject.CompareTag("Player") && BatteriesIn == 1)
        {
            OneBattery.Invoke();
        }
        if (other.gameObject.CompareTag("Player") && BatteriesIn == 2)
        {
            TwoBattery.Invoke();
        }
        if (other.gameObject.CompareTag("Player") && BatteriesIn == 3)
        {
            GeneratorOn.Invoke();
            ThreeBattery.Invoke();
        }
    }
}
