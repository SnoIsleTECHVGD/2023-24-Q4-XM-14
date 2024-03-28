using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class ByteAnimationManager : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public UnityEvent flashlightOff;
    public Animator animator;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<speedometer>().speed != 0)
        {
            Walk();
        }
        if (FindObjectOfType<speedometer>().speed == 0)
        {
            Idle();
        }
    }
    //enables idle
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("lights"))
        {
            animator.SetBool("inLight", true);
        }
        if (other.gameObject.CompareTag("Blacklight Bulb"))
        {
            animator.SetInteger("Death", 1);
            flashlightOff.Invoke();
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("lights"))
        {
            animator.SetBool("inLight", false);
        }
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Michael"))
        {
            animator.SetInteger("Death", 1);
            flashlightOff.Invoke();
        }
    }
    public void Idle()
    {
        animator.SetBool("isMoving", false);
        animator.SetBool("isStill", true);
    }
    public void Walk()
    {
        animator.SetBool("isStill", false);
        animator.SetBool("isMoving", true);
    }
    public void DimDeath()
    {
        animator.SetInteger("Death", 2);
    }
}
