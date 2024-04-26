using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.Events;

public class TimedGenerator : MonoBehaviour
{
    public float timeOn;
    public bool isOn;
    public UnityEvent poweredOn;
    public UnityEvent charge1;
    public UnityEvent charge2;
    public UnityEvent chargeOff;
    // Start is called before the first frame update
    void Start()
    {
        timeOn = 12;
    }

    // Update is called once per frame
    void Update()
    {
        if (isOn == true)
        {
            timeOn -= Time.deltaTime;
        }
        if (timeOn <= 0)
        {
            chargeOff.Invoke();
            isOn = false;
        }
        else if (timeOn <= 6)
        {
            charge2.Invoke();
        }
        else if (timeOn <= 9)
        {
            charge1.Invoke();
        }

    }
    public void PowerOn()
    {
        timeOn = 12;
        poweredOn.Invoke();
        isOn = true;
    }
}
