using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    private ScoreSystem theScoreSystem;
    public int EnemyScoreToGive;
    public int maxHealth = 100;
    int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        theScoreSystem = FindObjectOfType<ScoreSystem>();
    }

 
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Debug.Log("Enemy died!");
        theScoreSystem.AddScoreEnemy(EnemyScoreToGive);
        animator.SetBool("isDead", true);
        GetComponent<BoxCollider2D>().enabled = false;
    }
}
