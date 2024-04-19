using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimationManager : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Open()
    {
        animator.SetBool("isOpen", true);
    }

    public void Close()
    {
        animator.SetBool("isOpen", false);
        animator.SetBool("isClosing", true);
        Invoke("Idle", 2f);
    }

    public void Idle()
    {
        animator.SetBool("isClosing", false);
        animator.SetBool("isClosed", true);
    }
}
