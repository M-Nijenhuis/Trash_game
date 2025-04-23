using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawner : MonoBehaviour
{
  public GameObject trash;
  public float spawnInterval = 2f;
  private float timer = 0f;

  // Start is called before the first frame update
  void Start()
  {
    SpawnTrashObject();
  }

  // Update is called once per frame
  void Update()
  {
    if (timer < spawnInterval)
    {
      timer = timer + Time.deltaTime;
    }
    else
    {
      SpawnTrashObject();
      timer = 0;
    }
  }

  private void SpawnTrashObject()
  {
    Instantiate(trash, new Vector2(transform.position.x, 0), transform.rotation);
  }
}
