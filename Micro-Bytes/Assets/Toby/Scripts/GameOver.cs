using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public string whichGameOver;
    public void Over()
    {
        SceneManager.LoadScene(whichGameOver);
    }
}
