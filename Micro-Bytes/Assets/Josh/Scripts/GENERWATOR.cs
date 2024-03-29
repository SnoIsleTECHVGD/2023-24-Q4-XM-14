using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GENERWATOR : MonoBehaviour
{
    void Start()
    {
        ParticleSystem particleSystem = GetComponent<ParticleSystem>();
        particleSystem.Stop();

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
         
        
            if (collision.gameObject.CompareTag("Player"))
            {   
                ParticleSystem particleSystem = GetComponent<ParticleSystem>();
                particleSystem?.Play();
            }
        
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
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


