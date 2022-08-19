using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public Text HighScoreText;

    // Start is called before the first frame update
    void Start()
    {
        HighScoreText.text = "High Score : " + PlayerPrefs.GetInt("HighScore").ToString();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("Assets/Scenes/Gameplay.unity");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void SelectMap()
    {
        SceneManager.LoadScene("Assets/Scenes/SwipeMenu.unity");
    }

    public void Option()
    {
        SceneManager.LoadScene("Assets/Scenes/Option.unity");
    }

    public void Instructions()
    {
        SceneManager.LoadScene("Assets/Scenes/Instructions.unity");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Assets/Scenes/Credits.unity");
    }
}
