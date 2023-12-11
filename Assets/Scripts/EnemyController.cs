using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody2D physic;
    public Transform player;
    public float speed;
    public float agroDistance;
    public Transform leftPoint; // левая крайняя точка
    public Transform rightPoint; // правая крайняя точка
    
    private bool movingRight = true; // флаг направления движения

    void Start()
    {
        physic = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        float distToPlayer = Vector2.Distance(transform.position, player.position);

        if (distToPlayer < agroDistance)
        {
            StartHunting();
        }
        else
        {
            StopHunting();
        }
        
        if (movingRight)
        {
            if (transform.position.x >= rightPoint.position.x)
            {
                movingRight = false;
            }
        }
        else
        {
            if (transform.position.x <= leftPoint.position.x)
            {
                movingRight = true;
            }
        }
    }

    void StartHunting()
    {
        if (player.position.x < transform.position.x) // идет влево
        {
            physic.velocity = new Vector2(-speed, 0);
            transform.localScale = new Vector2(0.5f, 0.5f);
        }
        else if (player.position.x > transform.position.x)
        {
            physic.velocity = new Vector2(speed, 0);
            transform.localScale = new Vector2(-0.5f, 0.5f);
        }
    }

    void StopHunting()
    {
        physic.velocity = new Vector2(0, 0);
    }
}