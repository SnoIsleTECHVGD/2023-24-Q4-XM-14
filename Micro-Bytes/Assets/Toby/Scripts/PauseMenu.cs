using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject Timer;
    public GameObject BatteryCount;
    public GameObject Dialogue;
    public KeyCode pause;
    // Update is called once per frame
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
        Dialogue.SetActive(false);
    }
    public void Continue()
    {
        PausePanel.SetActive(false);
        Timer.SetActive(true);
        BatteryCount.SetActive(true);
        if (FindObjectOfType<DialogueManager>().dialogueOver != true)
        {
            Dialogue.SetActive(true);
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

}
