using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<
    }

    void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * speed * Time.deltaTime;
        
        if (Input.GetKeyDown(KeyCode.Space))
    }
}