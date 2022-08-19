using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy1;
    [HideInInspector]
    public float enemySpawnInterval = 5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnEnemys");
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().isGameOver)
        {
            StopCoroutine("SpawnEnemys");
        }
    }

    private void SpawnEnemy()
    {
        int random = Random.Range(1, 2);

        if (random == 1)
        {
            Instantiate(enemy1, new Vector3(transform.position.x + 1, -0.5f, 0), Quaternion.identity);
        }

    }

    IEnumerator SpawnEnemys()
    {
        while (true)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(enemySpawnInterval);
        }
    }
}
