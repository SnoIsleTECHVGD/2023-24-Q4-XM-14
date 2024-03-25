using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleTimer : MonoBehaviour
{
    public float timer;
    // Start is called before the first frame update

    //SIMPLE HEALTHBAR


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while (timer >= 0)
        {
            timer -= Time.deltaTime;
        
            print(timer);

        }
    }
}
