using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp2 : MonoBehaviour
{
    public GameObject ourWindow;
    public ScoreSystem scoreSystem;

    private void Start()
    {

    }

    private void Update()
    {
        if (scoreSystem.score >= 1200 && scoreSystem.score <= 1250)
        {
            OpenWindow();
        }
    }

    public void OpenWindow()
    {
        ourWindow.SetActive(true);
    }

    public void CloseWindow()
    {
        ourWindow.SetActive(false);
    }
}
