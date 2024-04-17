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
    public float Distance;
    public float AttackDistance;
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
        if (Distance <= AttackDistance)
        {
            attackOn.Invoke();
            Attack();
        }
        else
        {
            attackOff.Invoke();
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
        Invoke("EnableCollider", 2);
    }
    public void Stun()
    {

    }

    public void Die()
    {

    }

    public void EnableCollider()
    {

    }
}

