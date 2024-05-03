using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMini : MonoBehaviour
{
    public KeyCode MiniMapToggle;
    //public GameObject MiniMap;
    public Camera MiniMapCam;


    public void Update()
    {



        if (Input.GetKeyDown(MiniMapToggle) && MiniMapCam.enabled == false)
        {

            //MiniMapCam.gameObject.SetActive(true);
            MiniMapCam.enabled = true;

                


        }

        else if (Input.GetKeyDown(MiniMapToggle) && MiniMapCam.enabled == true)
        {
                    MiniMapCam.enabled = false;





        }




    }


}
