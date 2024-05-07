using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class MichaelSpawner : MonoBehaviour
{
    public float teleportTime;
    public UnityEvent spawnMichael;
    public UnityEvent teleport;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            teleport.Invoke();
            Invoke("SpawnMichael", teleportTime);
        }

    }
    public void Teleport()
    {
        teleport.Invoke();
        Invoke("SpawnMichael", teleportTime);
    }
    public void SpawnMichael()
    {
        spawnMichael.Invoke();
    }

    
}