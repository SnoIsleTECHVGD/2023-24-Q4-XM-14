using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogueText;
    public UnityEvent triggerOnCollision;
    public UnityEvent triggerOnCollide;
    public UnityEvent onSceneEnter;

    public bool dialogueStarted;

    public void Update()
    {
    }
    public void Wake()
    {
        onSceneEnter.Invoke();
    }
    public void OnTriggerEnter2D(Collider2D collider)
    {
        triggerOnCollide.Invoke();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        triggerOnCollision.Invoke();    
    }
    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogueText);
    }
}
