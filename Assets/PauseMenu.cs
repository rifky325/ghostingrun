using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Assets/Scenes/MainMenuScene.unity");
    }
    public void RetryMenu1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Assets/Scenes/Gameplay.unity");
    }
    public void RetryMenu2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Assets/Scenes/Gameplay 2.unity");
    }
    public void RetryMenu3()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Assets/Scenes/Gameplay 3.unity");
    }
}
