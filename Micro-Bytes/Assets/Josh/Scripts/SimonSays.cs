using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class SimonSays : MonoBehaviour
{
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public GameObject Button4;
    public Sprite ButtonChange;
    // Update is called once per frame
    void Update()
    {
        GameObject[] Buttons = {Button1, Button2, Button3, Button4};
        int i = 0;
        if (Button1)
        {

        }
        /* 
          if (Buttons[0].GetComponent<SpriteRenderer>().sprite == ButtonChange)
        {
            if (Buttons[1].GetComponent<SpriteRenderer>().sprite == ButtonChange)
            {
                if (Buttons[2].GetComponent<SpriteRenderer>().sprite == ButtonChange)
                {
                    if (Buttons[3].GetComponent<SpriteRenderer>().sprite == ButtonChange)
                    {
                        this.gameObject.SetActive(false);
                    }

                }
            }
        } 
       */
    }
}
