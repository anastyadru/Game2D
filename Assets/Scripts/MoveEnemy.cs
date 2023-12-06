using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{

    public float speed;
    public Vector2 dir;
    
    void Update()
    {
        transform.Translate(dir * speed, Space.World);
        if (gameObject.transform.position.x < -15)
        {
            Destroy(gameObject);
        }
    }
}
