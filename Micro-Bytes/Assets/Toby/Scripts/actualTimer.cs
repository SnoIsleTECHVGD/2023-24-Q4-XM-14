using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class actualTimer : MonoBehaviour
{
    public float timer;
    public float maxTime;
    public simpleTimer timed;
    // Start is called before the first frame update
    void Start()
    {
        timer = maxTime;
        timed.SetMaxTime(maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 0)
        {
            timer -= Time.deltaTime;
            timed.SetTimer(timer);
            print(timer);

        }
    }
}
