using UnityEngine;

public class PopUp : MonoBehaviour
{
    public GameObject ourWindow;
    public ScoreSystem scoreSystem;
    
    private void Start()
    {
        
    }
    
    private void Update()
    {
        if (scoreSystem.score >= 750 && scoreSystem.score <= 800)
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