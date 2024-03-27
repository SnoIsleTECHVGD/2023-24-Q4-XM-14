using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ByteAnimationManager : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public GameObject Byte;
    public bool inLight;
    public bool isHiding;
    public float timeInLight;
    public float timeOutLight;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeOutLight != 0)
        {
            Hide();
        }
        if (inLight == true)
        {
            if (isHiding == true)
            {
                UnHide();
            }
            timeInLight += Time.deltaTime;
            timeOutLight = 0;
        }
        else
        {
            timeOutLight += Time.deltaTime;
            timeInLight = 0;
        }
        if (timeOutLight >= 20)
        {
            DimDeath();
        }
        /* Enables walking animation
        if ()
        {
            GetComponent<Animator>().SetInteger("Animation Decide", 1);
        }
        */
    }
    //enables idle
    public void OnTriggerEnter2D(Collider2D other)
    {
        inLight = true;
        if (timeInLight > 0)
        {
            Idle();
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        inLight = false;
    }
    public void Idle()
    {
        GetComponent<Animator>().SetInteger("Animation Decide", 0);
    }
    public void Walk()
    {
        GetComponent<Animator>().SetInteger("Animation Decide", 1);
    }
    public void Hide()
    {
        GetComponent<Animator>().SetInteger("Animation Decide", 2);
        isHiding = true;
    }
    public void UnHide()
    {
        GetComponent<Animator>().SetInteger("Animation Decide", 3);
        isHiding = false;
    }
    public void BurnDeath()
    {
        GetComponent<Animator>().SetInteger("Animation Decide", 4);
    }
    public void DimDeath()
    {
        GetComponent<Animator>().SetInteger("Animation Decide", 5);   
    }
}
