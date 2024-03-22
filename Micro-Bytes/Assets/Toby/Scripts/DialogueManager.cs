using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    public TMPro.TMP_Text dialogueText;
    public TMPro.TMP_Text name;
    public KeyCode dialogueContinue;

    public UnityEvent switchCharacter;

    //public Animator dialogueAnimator;

    private Queue<string> sentences;
   
    void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(dialogueContinue) == true)
        {
            DisplayNextSentence();
        }
    }
    public void StartDialogue(Dialogue dialogue)
    {
        //dialogueAnimator.SetBool("IsOpen", true);

        sentences = new Queue<string>();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence ()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    public void EndDialogue()
    {
        switchCharacter.Invoke();
        //dialogueAnimator.SetBool("IsOpen", false);
    }

}
