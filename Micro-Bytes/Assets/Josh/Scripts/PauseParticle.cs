using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseParticle : MonoBehaviour
{

   
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

