using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coin1, coin2, coin3;
    [HideInInspector]
    public float coinSpawnInterval = 3f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnCoins");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnCoin()
    {
        int random = Random.Range(1, 4);

        if (random == 1)
        {
            Instantiate(coin1, new Vector3(transform.position.x + 1, -0.5f, 0), Quaternion.identity);
        }
        if (random == 2)
        {
            Instantiate(coin2, new Vector3(transform.position.x + 2, -0.5f, 0), Quaternion.identity);
        }
        if (random ==3)
        {
            Instantiate(coin3, new Vector3(transform.position.x + 3, -0.5f, 0), Quaternion.identity);
        }
    }

    IEnumerator SpawnCoins()
    {
        while (true)
        {
            SpawnCoin();
            yield return new WaitForSeconds(coinSpawnInterval);
        }
    }
}
