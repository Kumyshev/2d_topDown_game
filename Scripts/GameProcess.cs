using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProcess : MonoBehaviour
{
    public float Radius = 10;
    public GameObject enemyPrefs;
    public Transform player;
    private float timeLeft;


    // Start is called before the first frame update
    void Start()
    {
        timeLeft = 3f;
        PlayerPrefs.SetInt("EnemyState", 1);

    }


    public void EnemyRevive()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            Vector3 position = Random.insideUnitSphere * Radius + player.position;
            Instantiate(enemyPrefs, position, Quaternion.identity);
            Start();
        }
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("EnemyState", 0) == 0)
        {
            EnemyRevive();
        }

    }
}
