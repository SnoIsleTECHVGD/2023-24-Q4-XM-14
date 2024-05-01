using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MichaelMoving : MonoBehaviour
{
    public GameObject Battery1;
    public GameObject Battery2;
    public GameObject Battery3;
    public GameObject Michael;
    public GameObject Michael2;
    public GameObject Michael3;
    public GameObject Michael4;
    void Update()
    {
        if (Battery1?.activeInHierarchy == false)
        {
            Michael.SetActive(false);
            Michael2.SetActive(true);
        }
        else if (Battery2?.activeInHierarchy == false) 
        {
            Michael2.SetActive(false);
            Michael3.SetActive(true);
        }
        else if (Battery3?.activeInHierarchy == false)
        {
            Michael3.SetActive(false);

        }
    }
}
