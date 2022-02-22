using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailSpawn : MonoBehaviour
{
    public GameObject mailPrefab;

    public float mailDespawn;
    public float timer;
    public int playerScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            GameObject mailPiece = Instantiate(mailPrefab, transform.position, Quaternion.identity);
            mailPiece.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-90, 90), -Random.Range(50, 90)));
            timer = Random.Range(4, 9);
        }
    }

    public void LosePoints (int pointsLost)
    {
        if (playerScore - pointsLost >= 0)
        {
            playerScore -= pointsLost;
        }
        else
        {
            playerScore = 0;
        }
    }
}
