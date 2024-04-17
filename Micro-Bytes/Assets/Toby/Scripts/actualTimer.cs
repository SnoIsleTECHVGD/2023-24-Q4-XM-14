using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class actualTimer : MonoBehaviour
{
    public float timer;
    public float maxTime;
    public simpleTimer timed;
    public bool inLight;
    // Start is called before the first frame update
    void Start()
    {
        timer = maxTime;
        timed.SetMaxTime(maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 0 && inLight == false)
        {
            timer -= Time.deltaTime;
            timed.SetTimer(timer);
            print(timer);

        }
        else if (timer <= maxTime && inLight == true)
        {
            timer += Time.deltaTime;
            timed.SetTimer(timer);
            print(timer);
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("lights"))
        {
            inLight = true;
        }
       else if (other.gameObject.CompareTag("lighter"))
        {
            inLight = true;
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("lights"))
        {
            inLight = false;
        }
       else if (other.gameObject.CompareTag("lighter"))
        {
            inLight = false;
        }
    }
}
