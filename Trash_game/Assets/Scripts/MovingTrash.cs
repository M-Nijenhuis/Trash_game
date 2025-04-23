using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTrash : MonoBehaviour
{

  public float moveSpeed = 5f;
  public float deadzone = 20f;

  // Update is called once per frame
  void Update()
  {
    transform.position = transform.position + Vector3.right * (moveSpeed * Time.deltaTime);

    if (transform.position.x > deadzone)
    {
      Destroy(gameObject);
    }
  }
}
