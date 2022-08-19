using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject[] levelButtons;

    private void Awake()
    {
        if (PlayerPrefs.GetInt("levelUnlocked") == 1)
        {
            PlayerPrefs.SetInt("levelUnlocked", 5);
        }
        //PlayerPrefs.DeleteAll();
    }

    void Start()
    {
        for (int i = 5; i < levelButtons.Length; i++)
        {
            levelButtons[i].GetComponent<Button>().interactable = false;
        }

        for (int i = 5; i <= PlayerPrefs.GetInt("levelUnlocked"); i++)
        {
            levelButtons[i - 5].GetComponent<Button>().interactable = true;
        }
    }

    public void loadscene(int index)
    {
        SceneManager.LoadScene(index);
    }   
}