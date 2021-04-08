using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    
    //public Transform player;
    public float speed = 2f;

    private Transform player;


    private void Start()
    {
        player = GameObject.FindWithTag("me").transform;
    }


    private void Update()
    {
        
        if (Vector3.Distance(transform.position, player.position) > 1f)
        {
            MoveTowards(player.position);
            RotateTowards(player.position);
        }
    }

    private void MoveTowards(Vector2 target)
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }

    private void RotateTowards(Vector2 target)
    {
        Vector2 ternTo = target - (Vector2)transform.position;
        ternTo.Normalize();
        float angle = Mathf.Atan2(ternTo.y, ternTo.x) * Mathf.Rad2Deg - 90f;
        transform.rotation = Quaternion.Euler(Vector3.forward * angle);
    }
}
