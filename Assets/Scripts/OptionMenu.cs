using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class OptionMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    // Start is called before the first frame update
    
    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
    
    public void Back()
    {
        SceneManager.LoadScene("Assets/Scenes/MainMenuScene.unity");
    }
}
