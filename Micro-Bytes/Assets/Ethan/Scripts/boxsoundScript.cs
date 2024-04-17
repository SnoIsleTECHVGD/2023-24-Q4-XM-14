using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxsoundScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GetComponent<AudioSource>().enabled = true;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GetComponent<AudioSource>().enabled = false;
        }
    }
}
