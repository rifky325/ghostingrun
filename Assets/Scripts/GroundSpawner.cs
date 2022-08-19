using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject Air1, Air2, Ground1, Ground2, Ground3, Ground4, Ground5, Ground6, Ground7;
    bool hasGround = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasGround)
        {
            SpawnGround();
            hasGround = true;
        }
    }

    public void SpawnGround()
    {
        int randomNum = Random.Range(1,10);
        if(randomNum == 1)
        {
            Instantiate(Ground1, new Vector3(transform.position.x + 6, -4.37f, 0), Quaternion.identity);
        }

        if(randomNum == 2)
        {
            Instantiate(Ground2, new Vector3(transform.position.x + 7, -4.37f, 0), Quaternion.identity);
        }

        if(randomNum == 3)
        {
            Instantiate(Ground3, new Vector3(transform.position.x + 6, -4.37f, 0), Quaternion.identity);
        }

        if (randomNum == 4)
        {
            Instantiate(Ground4, new Vector3(transform.position.x + 8, -4.37f, 0), Quaternion.identity);
        }

        if (randomNum == 5)
        {
            Instantiate(Ground5, new Vector3(transform.position.x + 6, -4.37f, 0), Quaternion.identity);
        }

        if (randomNum == 6)
        {
            Instantiate(Ground6, new Vector3(transform.position.x + 7, -4.37f, 0), Quaternion.identity);
        }

        if (randomNum == 7)
        {
            Instantiate(Ground7, new Vector3(transform.position.x + 6, -4.37f, 0), Quaternion.identity);
        }

        if (randomNum == 8)
        {
            Instantiate(Air1, new Vector3(transform.position.x + 6, -2.95f, 0), Quaternion.identity);
        }

        if (randomNum == 9)
        {
            Instantiate(Air2, new Vector3(transform.position.x + 7, -1.04f, 0), Quaternion.identity);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            hasGround = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            hasGround = false;
        }
    }
}
