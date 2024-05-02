using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoader : MonoBehaviour
{
    public string sceneName;
    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Scene()
    {
        SceneManager.LoadScene(sceneName);
    }
}