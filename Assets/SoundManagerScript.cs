using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static SoundManagerScript instance;
    public static AudioClip jumpSound, attackSound, deathSound, collectcoinSound, gameoverSound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        jumpSound = Resources.Load<AudioClip> ("jump");
        attackSound = Resources.Load<AudioClip>("attack");
        deathSound = Resources.Load<AudioClip>("death");
        collectcoinSound = Resources.Load<AudioClip>("collectCoin");
        gameoverSound = Resources.Load<AudioClip>("gameOver");

        audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "jump":
                audioSrc.PlayOneShot(jumpSound);
                break;
            case "attack":
                audioSrc.PlayOneShot(attackSound);
                break;
            case "death":
                audioSrc.PlayOneShot(deathSound);
                break;
            case "collectCoin":
                audioSrc.PlayOneShot(collectcoinSound);
                break;
            case "gameOver":
                audioSrc.PlayOneShot(gameoverSound);
                break;
        }
    }

    void Awake()
    {
        if (instance != null)
            Destroy(gameObject);

        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
