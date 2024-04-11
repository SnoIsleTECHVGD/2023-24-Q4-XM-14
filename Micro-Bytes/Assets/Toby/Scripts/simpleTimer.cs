using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class simpleTimer : MonoBehaviour
{ 
    public Slider slider;
    
    // Start is called before the first frame update

    //SIMPLE HEALTHBAR

    public void SetMaxTime(float timer)
    {
        slider.maxValue = timer;
        slider.value = timer;
    }
    public void SetTimer(float timer)
    {
        slider.value = timer;
    }

        
}
