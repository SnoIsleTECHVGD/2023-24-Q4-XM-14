using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundOnMove : MonoBehaviour
{
    public void Update()
    {
        if (GetComponent<speedometer>().speed != 0)
        {
            GetComponent<AudioSource>().enabled = true;
        }
        else
        {
            GetComponent<AudioSource>().enabled = false;
        }
    }
}

