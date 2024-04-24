using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class PauseParticle : MonoBehaviour
{
    public UnityEvent zappy;
   
    void Start()
    {
     ParticleSystem particleSystem = GetComponent<ParticleSystem>();
        particleSystem.Stop();
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.tag.Equals("Generator"))
        {
            ParticleSystem particleSystem = GetComponent<ParticleSystem>();
            particleSystem.Play();
            zappy.Invoke();
        }

        if (collision.gameObject.tag.Equals("Circuit Box"))
        {
            ParticleSystem particleSystem = GetComponent<ParticleSystem>();
            particleSystem.Stop();
            }
        }

    }
    /* private void OnCollisionExit2D(Collision2D collision)
     {
         if (collision.gameObject.tag.Equals(""))
         {
             ParticleSystem particleSystem = GetComponent<ParticleSystem>();
             particleSystem.Stop();
         }

     }*/

