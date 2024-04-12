using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject Timer;
    public GameObject BatteryCount;
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
    }
    public void Continue()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
        Timer.SetActive(true);
        BatteryCount.SetActive(true);
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
