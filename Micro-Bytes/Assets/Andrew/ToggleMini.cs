using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class ToggleMini : MonoBehaviour
{
    public KeyCode MiniMapToggle;
    //public GameObject MiniMap;
    public Camera MiniMapCam;
    public KeyCode WiggleBuggingCheatCode;
    public bool WiggleBuggingOn;
    public CapsuleCollider2D ByteCapsule;
    public PolygonCollider2D BytePolygon;
    public KeyCode BrightnessUp;
    public KeyCode BrightnessDown;
    public Light2D global;
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

        if (Input.GetKeyDown(WiggleBuggingCheatCode) && WiggleBuggingOn == false)
        {
            ByteCapsule.enabled = false;
            BytePolygon.enabled = true;
            WiggleBuggingOn = true;
        }

        else if (Input.GetKeyDown(WiggleBuggingCheatCode) && WiggleBuggingOn == true)
        {
            ByteCapsule.enabled = true;
            BytePolygon.enabled = false;
            WiggleBuggingOn = false;
        }

        if (Input.GetKeyDown(BrightnessUp))
        {
            global.intensity += 0.5f;
        }
        else if (Input.GetKeyDown(BrightnessDown))
        {
            global.intensity -= 0.5f;
        }
    }

}
