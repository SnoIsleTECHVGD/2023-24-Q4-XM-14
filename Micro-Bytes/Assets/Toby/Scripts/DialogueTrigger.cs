using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogueText;
    public KeyCode dialogueContinue;
    public UnityEvent triggerOnButtonPressOnce;
    public UnityEvent triggerOnButtonPressAgain;
    public UnityEvent triggerOnCollision;
    public UnityEvent triggerOnCollide;

    public bool dialogueStarted;

    public void Update()
    {
        if (Input.GetKeyDown(dialogueContinue) == true && dialogueStarted == false)
        {
            triggerOnButtonPressOnce.Invoke();
            dialogueStarted = true;
        }
        else if (Input.GetKeyDown(dialogueContinue) == true && dialogueStarted == true)
        {
            triggerOnButtonPressAgain.Invoke();
            // if you are out of sentences quit the dialogue           
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
