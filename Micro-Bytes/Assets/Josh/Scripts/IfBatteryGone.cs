using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfBatteryGone : MonoBehaviour
{
    public GameObject Battery;
    public GameObject Byte;

    void Update()
    {
        if (Battery.CompareTag("Broken"))
        {
            this.gameObject.SetActive(false);
            Byte.SetActive(true);
        }
    }
}
