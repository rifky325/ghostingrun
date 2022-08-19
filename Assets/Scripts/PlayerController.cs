using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float runSpeed;
    private int jumpCount = 0;
    private bool canJump = true;
    Animator anim;
    public bool isGameOver = false;
    public GameObject GameOverPanel, scoreText;
    public Text FinalScoreText, HighScoreText;
    [SerializeField] private HealthBar _healthBar;
    public int life = 3;
    //private ScoreSystem theScoreSystem;

    // Start is called before the first frame update
    public void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        StartCoroutine("IncreaseGameSpeed");
        //theScoreSystem = FindObjectOfType<ScoreSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver)
        {
            transform.position = Vector3.right * runSpeed * Time.deltaTime + transform.position;
        }

        if (jumpCount == 2)
        {
            canJump = false;
        }

        if (Input.GetKeyDown("space") && canJump && !isGameOver)
        {
            SoundManagerScript.PlaySound("jump");
            rb2d.velocity = Vector3.up * 7.5f;
            anim.SetTrigger("jump");
            jumpCount += 1;
        }
    }

    public void GameOver()
    {
        SoundManagerScript.PlaySound("gameOver");
        isGameOver = true;
        anim.SetTrigger("death");
        StopCoroutine("IncreaseGameSpeed");

        StartCoroutine("ShowGameOverPanel");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            jumpCount = 0;
            canJump = true;
        }
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            if (life > 1)
            {
                life--;
            }
            else
            {
                GameOver();
            }
            _healthBar.playerHealth = _healthBar.playerHealth - 1;
            _healthBar.Update();

        }
        if (collision.gameObject.CompareTag("BottomDetector"))
        {
            life = 0;
            GameOver();
            _healthBar.playerHealth = 0;
            _healthBar.Update();
        }
        
        if (collision.gameObject.CompareTag("Enemy"))
        {
            life = 0;
            GameOver();
            _healthBar.playerHealth = 0;
            _healthBar.Update();
        }
    }
    IEnumerator IncreaseGameSpeed()
    {
        while (true)
        {
            yield return new WaitForSeconds(8);

            if (runSpeed < 10)
            {
                runSpeed += 0.3f;
            }
            if (GameObject.Find("GroundSpawner").GetComponent<ObstacleSpawner>().obstacleSpawnInterval > 1)
            {
                GameObject.Find("GroundSpawner").GetComponent<ObstacleSpawner>().obstacleSpawnInterval -= 0.1f;
            }
        }
    }

    IEnumerator ShowGameOverPanel()
    {
        //theScoreSystem.scoreIncreasing = false;
        yield return new WaitForSeconds(0.5f);
        GameOverPanel.SetActive(true);
        scoreText.SetActive(false);

        FinalScoreText.text = "" + Mathf.RoundToInt(GameObject.Find("ScoreDetector").GetComponent<ScoreSystem>().score);
        HighScoreText.text = "" + Mathf.RoundToInt(PlayerPrefs.GetInt("HighScore"));

        //theScoreSystem.score = 0;
        //theScoreSystem.scoreIncreasing = true;
    }
}
