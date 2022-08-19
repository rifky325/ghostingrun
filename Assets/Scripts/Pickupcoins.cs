using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupcoins : MonoBehaviour
{
    public Animator animator;
    public int CoinScoreToGive;
    private ScoreSystem theScoreSystem;

    // Start is called before the first frame update
    void Start()
    {
        theScoreSystem = FindObjectOfType<ScoreSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            SoundManagerScript.PlaySound("collectCoin");
            theScoreSystem.AddScoreCoin(CoinScoreToGive);
            gameObject.SetActive(false);
        }
    }
}
