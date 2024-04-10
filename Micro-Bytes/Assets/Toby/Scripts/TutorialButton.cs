using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TutorialButton : MonoBehaviour
{
    public bool isClicked;
    public Button tutorialButton;
    public UnityEvent tutorialPageOn;
    public UnityEvent tutorialPageOff;

    public void Click()
    {
        isClicked = !isClicked;
        if (isClicked == true)
        {
            tutorialPageOn.Invoke();
        }
        else
        {
            tutorialPageOff.Invoke();
        }
    }
}
