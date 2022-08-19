using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SwipeMenu : MonoBehaviour
{
    public GameObject selectMapUI;
    public GameObject scrollbar;
    float scroll_pos = 0;
    float[] pos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pos = new float[transform.childCount];
        float distance = 1f / (pos.Length - 1f);
        for (int i = 0; i < pos.Length; i++)
        {
            pos[i] = distance * i;
        }
        if (Input.GetMouseButton(0))
        {
            scroll_pos = scrollbar.GetComponent<Scrollbar>().value;
        }
        else
        {
            for (int i = 0; i < pos.Length; i++)
            {
                if (scroll_pos < pos[i] + (distance / 2) && scroll_pos > pos[i] - (distance / 2))
                {
                    scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, pos[i], 1f);
                }
            }
        }

        for (int i = 0; i < pos.Length; i++)
        {
            if (scroll_pos < pos[i] + (distance / 2) && scroll_pos > pos[i] - (distance / 2))
            {
                transform.GetChild(i).localScale = Vector2.Lerp(transform.GetChild(i).localScale, new Vector2(1f, 1f), 0.1f);
                for (int a = 0; a < pos.Length; a++)
                {
                    if (a != i)
                    {
                        transform.GetChild(a).localScale = Vector2.Lerp(transform.GetChild(a).localScale, new Vector2(1f, 1f), 0.1f);
                    }
                }
            }
        }
    }

    public void Map1()
    {
        SceneManager.LoadScene("Assets/Scenes/Gameplay.unity");
    }
    public void Map2()
    {
        SceneManager.LoadScene("Assets/Scenes/Gameplay 2.unity");
    }
    public void Map3()
    {
        SceneManager.LoadScene("Assets/Scenes/Gameplay 3.unity");
    }
    public void Back()
    {
        SceneManager.LoadScene("Assets/Scenes/MainMenuScene.unity");
    }
    public void BackFromInformasi()
    {
        SceneManager.LoadScene("Assets/Scenes/SwipeMenu.unity");
    }
    public void Information1()
    {
        SceneManager.LoadScene("Assets/Scenes/Informasi 1.unity");
    }
    public void Information2()
    {
        SceneManager.LoadScene("Assets/Scenes/Informasi 2.unity");
    }
    public void Information3()
    {
        SceneManager.LoadScene("Assets/Scenes/Informasi 3.unity");
    }
}
