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
       
        /* int i = 0;
         if (Button1)
         {

         }*/


       List<GameObject> Buttoner = new List<GameObject>() {Button1, Button2, Button3, Button4};
       

        foreach (GameObject Button in Buttoner) 
          {
            
            if (Buttoner.TrueForAll(GetComponent<SpriteRenderer>().sprite == ButtonChange)) 
            {
                this.gameObject.SetActive(false);
            }
            else if (Button.GetComponent<SpriteRenderer>().sprite != ButtonChange)
            {
                this.gameObject.SetActive(true);
            }
          }   
        
          
    }
         
       
    
}
