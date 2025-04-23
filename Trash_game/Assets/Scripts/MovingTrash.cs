using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class MovingTrash : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float deadzone = 20f;

    public bool canMove = true;

    // Update is called once per frame
    private void Start()
    {
    }

    void Update()
    {
        if (canMove == true)
        {
            transform.position = transform.position + Vector3.right * (moveSpeed * Time.deltaTime);

            if (transform.position.x > deadzone)
            {
                Destroy(gameObject);
            }
        }
    }
}