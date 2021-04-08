using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 20;
    private int AllPoints;


    private void Start()
    {
        PlayerPrefs.SetInt("EnemyState", 1);

        AllPoints = PlayerPrefs.GetInt("Points", 0);

    }

    void Die()
    {
        PlayerPrefs.SetInt("AllPoints", ++AllPoints);


        Destroy(gameObject);
        PlayerPrefs.SetInt("EnemyState", 0);
        
        
    }

    public void Damage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }

    }
}
