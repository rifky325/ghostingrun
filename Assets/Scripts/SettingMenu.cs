using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingMenu : MonoBehaviour
{
    public AudioMixer volMixer;
    public Slider volSlider;
    public Dropdown graphicDropdown;
    public Toggle fullScreenToggle;
    private int screenInt;
    Resolution[] resolution;
    private bool isFullScreen = false;
    const string prefName = "optionvalue";
    const string graName = "graphicoption";

    private void Awake()
    {
        screenInt = PlayerPrefs.GetInt("togglestate");
        if(screenInt == 1)
        {
            isFullScreen = true;
            fullScreenToggle.isOn = true;
        }
        else
        {
            fullScreenToggle.isOn = false;
        }
        graphicDropdown.onValueChanged.AddListener(new UnityAction<int>(index =>
        {
            PlayerPrefs.SetInt(graName, graphicDropdown.value);
            PlayerPrefs.Save();
        }));
    }
    // Start is called before the first frame update
    void Start()
    {
        volSlider.value = PlayerPrefs.GetFloat("MVolume", 1f);
        volMixer.SetFloat("volume", PlayerPrefs.GetFloat("MVolume"));

        graphicDropdown.value = PlayerPrefs.GetInt(graName, 3);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
