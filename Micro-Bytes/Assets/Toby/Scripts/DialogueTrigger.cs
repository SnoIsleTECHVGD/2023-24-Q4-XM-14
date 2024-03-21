using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogueText;
    public KeyCode dialogueContinue;
    public UnityEvent triggerOnButtonPress;
    public UnityEvent triggerOnCollision;
    public UnityEvent triggerOnCollide;

    public void Update()
    {
        if (Input.GetKeyDown(dialogueContinue) == true)
        {
            triggerOnButtonPress.Invoke();
        }
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
