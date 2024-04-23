using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    public TMPro.TMP_Text dialogueText;
    public TMPro.TMP_Text name;
    public Image icon;
    public KeyCode dialogueContinue;
    public int dialogueAmount;

    public UnityEvent switchCharacterXenon;
    public UnityEvent switchCharacterPolaris;
    public UnityEvent switchCharacterJermy;

    //public Animator dialogueAnimator;

    private Queue<string> sentences;
    private Queue<Sprite> icons;
   
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
        Time.timeScale = 0;
        name.text = dialogue.name;
        icons = new Queue<Sprite>();
        sentences = new Queue<string>();

        foreach (DialoguePiece in dialogue.conversation)
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
        dialogueAmount -= 1;
        Time.timeScale = 1;
        if (dialogueAmount > 0)
        {
            
        }
    }
}
