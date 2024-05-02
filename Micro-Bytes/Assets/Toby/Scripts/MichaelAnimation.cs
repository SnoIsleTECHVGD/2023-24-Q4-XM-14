using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

public class MichaelAnimation : MonoBehaviour
{
    public Animator animator;
    public UnityEvent attackOn;
    public UnityEvent attackOff;
    public GameObject Byte;
    public BoxCollider2D AttackCollider;
    public UnityEvent MichaelDeath;
    public UnityEvent MichaelWalkOff;
    public float Distance;
    public float AttackDistance;
    
    public bool isStunned;
    public bool isDead;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Distance = Vector2.Distance(transform.position, Byte.transform.position);
        if (FindObjectOfType<speedometer>().speed != 0)
        {
           Walk();
        }
        if (FindObjectOfType<MichaelMarmaladeTheManipulatedMicroBitsMaliciousMovementManuscript>().lightOn == false && isDead == false)
        {
            if (Distance <= AttackDistance)
            {
                attackOn.Invoke();
                Attack();
            }
            else
            {
                attackOff.Invoke();
                DisableCollider();
            }
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Michael Killer"))
        {
            isDead = true;
            MichaelWalkOff.Invoke();
            DieAnimation();
        }
    }
    public void Walk()
    {
        animator.SetBool("isMoving", true);
        animator.SetBool("isStunned", false);
        animator.SetBool("isAttack", false);
    }
    public void Attack()
    {
        animator.SetBool("isAttack", true);
        animator.SetBool("isMoving", false);
        animator.SetBool("isStunned", false);
        Invoke("EnableCollider", 0.5f);
        
    }
    /*public void Stun()
    {
        isStunned = true;
        DisableCollider();
        attackOn.Invoke();
        animator.SetBool("isStunned", true);
        animator.SetBool("isAttack", false);
        animator.SetBool("isMoving", false);
    }
    */
    public void DieAnimation()
    {
        animator.SetBool("Death", true);
        Invoke("Die", 2f);
    }

    public void EnableCollider()
    {
        AttackCollider.enabled = true;
    }

    public void DisableCollider()
    {
        AttackCollider.enabled = false;
    }

    public void Die()
    {
        MichaelDeath.Invoke();
    }
}

