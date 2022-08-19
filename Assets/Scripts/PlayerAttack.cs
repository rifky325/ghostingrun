using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Animator animator;

    public Transform attackPoint;
    public LayerMask enemyLayers;

    public float attackRange = 0.5f;
    public int attackDamage = 100;

    public float attackRate = 1f;
    float nextAttackTime = 0f;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextAttackTime)
        { 
        if (Input.GetMouseButtonDown(0))
        {
                SoundManagerScript.PlaySound("attack");
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
        }
        }
    }

    void Attack()
    {
        animator.SetTrigger("attack");
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
        }
    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
