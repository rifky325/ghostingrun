using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreSystem : MonoBehaviour
{
    public Text scoreText;
    public float score = 0;
    public float pointsPerSecond;
    public bool scoreIncreasing;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(scoreIncreasing == true)
        {
            score += pointsPerSecond * Time.deltaTime;
            scoreText.text = "" + Mathf.RoundToInt(score);
        }
        else
        {
            scoreIncreasing = false;
        }
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().isGameOver)
            scoreIncreasing = false;
        {
            if (PlayerPrefs.GetInt("HighScore") < score)
            {
                PlayerPrefs.SetInt("HighScore", Mathf.RoundToInt(score));
                Debug.Log("New High Score is " + Mathf.Round(score));
            }
        }
    }

    /* private void OnTriggerEnter2D(Collider2D collision)
     {
         if (collision.gameObject.CompareTag("Obstacle"))
         {
             score = score + 1;
             scoreText.text = "" + score;
         }
     } 
     */

    public void AddScoreCoin(int pointsToAddFromCoin)
    {
        score += pointsToAddFromCoin;
        scoreText.text = "" + score;
    }

    public void AddScoreEnemy(int pointsToAddFromEnemy)
    {
        score += pointsToAddFromEnemy;
        scoreText.text = "" + score;
    }
}
