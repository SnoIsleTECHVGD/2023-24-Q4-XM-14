using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class SafeZones : MonoBehaviour
{
   
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (this.gameObject.CompareTag("lighter"))
        {
            if(collision.gameObject.CompareTag("Player"))
            {
                FindObjectOfType<actualTimer>().inLight = true;
            }
        }
    }
    
}

