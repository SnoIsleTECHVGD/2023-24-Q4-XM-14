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
    public Sprite ButtonChanger;
    // Update is called once per frame
    void Update()
    {
        
        /* int i = 0;
         if (Button1)
         {

         }*/


       List<GameObject> Buttoner = new List<GameObject>() {Button1, Button2, Button3, Button4};


        foreach (GameObject Button in Buttoner)
        {
            if (Button1.GetComponent<SpriteRenderer>().sprite == ButtonChange)
            {
            
                if (Button2.GetComponent<SpriteRenderer>().sprite == ButtonChange)
                {
                  
                    if (Button3.GetComponent<SpriteRenderer>().sprite == ButtonChange)
                    {
                       
                        if (Button4.GetComponent<SpriteRenderer>().sprite == ButtonChange)
                        {
                            this.gameObject.SetActive(false);

                        }

                    }
                }
            }
        }

    }




}
