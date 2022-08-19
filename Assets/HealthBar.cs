using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public int playerHealth;
    [SerializeField] private Image[] hearts;

    // Start is called before the first frame update
    void Start()
    {
        Update();
    }

    // Update is called once per frame
    public void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < playerHealth)
            {
                hearts[i].color = Color.red;
            }
            else
            {
                hearts[i].color = Color.black;
            }
        }
    
    }
}
