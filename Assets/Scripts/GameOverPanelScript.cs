using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPanelScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Assets/Scenes/MainMenuScene.unity");
    }
    
    public void LoadSampleMenu1()
    {
        SceneManager.LoadScene("Assets/Scenes/Gameplay.unity");
    }
    public void LoadSampleMenu2()
    {
        SceneManager.LoadScene("Assets/Scenes/Gameplay 2.unity");
    }
    public void LoadSampleMenu3()
    {
        SceneManager.LoadScene("Assets/Scenes/Gameplay 3.unity");
    }
}
