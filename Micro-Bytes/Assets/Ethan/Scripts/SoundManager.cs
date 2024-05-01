using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    public GameObject Camera;
    public float volume;
    // Start is called before the first frame update
    void Start()
    {
        volume = Camera.GetComponent<AudioSource>().volume;
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
        else 
        { 
            Load();
        }
    }
    private void Update()
    {
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }
    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }
    public void CutSound()
    {
        Camera.GetComponent<AudioSource>().volume = 0;
    }
    public void BringSoundBack()
    {
        Camera.GetComponent<AudioSource>().volume = volume;
    }
}
