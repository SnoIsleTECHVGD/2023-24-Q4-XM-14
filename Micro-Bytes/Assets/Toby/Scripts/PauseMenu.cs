using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject Timer;
    public GameObject BatteryCount;
    public GameObject Icon;
    public GameObject blacklight;
    public KeyCode pause;
    static public List<GameObject> dialogueBoxes;
    public bool blacklightGone;
    // Update is called once per frame

    public void Start()
    {
        dialogueBoxes = new List<GameObject>(GameObject.FindGameObjectsWithTag("Dialogue"));
    }
    
    
    void Update()
    {
        if (Input.GetKeyDown(pause))
        {
            Pause();
        }
       
    }
    public void Pause()
    {
        Time.timeScale = 0;
        PausePanel.SetActive(true);
        Timer.SetActive(false);
        BatteryCount.SetActive(false);
        blacklight.SetActive(false);
        foreach (GameObject dia in dialogueBoxes)
        {
            dia.SetActive(false);
        }
        Icon.SetActive(false);
    }
    public void Continue()
    {
        PausePanel.SetActive(false);
        Timer.SetActive(true);
        BatteryCount.SetActive(true);
        if (blacklightGone == true)
        {
            blacklight.SetActive(true);
        }
        if (FindObjectsOfType<DialogueManager>().Any(item => item.dialogueOpen == true))
        {
            Icon.SetActive(true);
            foreach (GameObject dialogue in dialogueBoxes)
            {
                dialogue.SetActive(true);
            }
        }
        else 
        { 
            Time.timeScale = 1;
        }
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Title Screen");
    }
    public void Restart(string scene)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(scene);
    }

    public void Blacklight()
    {
        blacklightGone = true;
    }

}
